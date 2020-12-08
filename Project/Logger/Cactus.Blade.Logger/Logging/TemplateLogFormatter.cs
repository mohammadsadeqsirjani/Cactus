﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Logging
{
    public class TemplateLogFormatter : ILogFormatter
    {
        private static readonly Dictionary<string, Func<ILogEntry, string>> _simpleTokenHandlers = new Dictionary<string, Func<ILogEntry, string>>();
        private static readonly Dictionary<string, Func<ILogEntry, DateTime>> _dateTimeTokenHandlers = new Dictionary<string, Func<ILogEntry, DateTime>>();

        private static readonly Regex _simpleTokenRegex = new Regex(@"{(?<token>[a-zA-Z_][a-zA-Z0-9_]*?)}", RegexOptions.Compiled);
        private static readonly Regex _parentheticalTokenRegex = new Regex(@"{(?<token>[a-zA-Z_][a-zA-Z0-9_]*?)(?:\((?<format>.*?)\))?}", RegexOptions.Compiled);

        private static readonly Regex _extendedPropertiesRegex =
            new Regex(@"
        {                                       # Opening curly brace
            extendedProperties                  # extendedProperties
                \(                              # Opening parenthesis
                    (?<before>(?:[^{]|{{)*)     # Text after the opening curly brace and parenthesis and before '{key}'
                    {(?<key>key|[^}]+)}         # The exact string, '{key}', or '{key_name}' where 'key_name' is the name of an extended property
                    (?<omitKey>\?)?             # The optional '?' after '{key}' (if present, omit the key name)
                    (?<between>(?:[^{]|{{)*)    # Text after '{key}' and before '{value}'
                    {value}                     # The exact string, '{value}'
                    (?<after>.*?)               # Text after '{value}' and before the closing parenthesis and curly brace
                \)                              # Closing parenthesis
        }                                       # Closing curly brace",
                RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline | RegexOptions.Compiled);

        private static readonly Regex _containsHtmlTagsRegex = new Regex("&lt;.+?&gt;", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

        private static readonly CultureInfo _culture = new CultureInfo("en-US");

        private readonly bool _isHtmlEncoded;
        private readonly string _template;

        static TemplateLogFormatter()
        {
            AddSimpleTokenHandler("newLine", logEntry => Environment.NewLine);
            AddSimpleTokenHandler("tab", logEntry => "\t");

            AddSimpleTokenHandler("message", logEntry => logEntry.Message);
            AddSimpleTokenHandler("applicationId", logEntry => logEntry.ApplicationId);
            AddSimpleTokenHandler("applicationUserId", logEntry => logEntry.ApplicationUserId);
            AddSimpleTokenHandler("environment", logEntry => logEntry.Environment);
            AddSimpleTokenHandler("machineName", logEntry => logEntry.MachineName);
            AddSimpleTokenHandler("level", logEntry => logEntry.Level.ToString());
            AddSimpleTokenHandler("exception", logEntry => logEntry.ExceptionDetails);
            AddSimpleTokenHandler("exceptionContext", logEntry => logEntry.ExceptionContext);
            AddSimpleTokenHandler("exceptionType", logEntry => logEntry.ExceptionType);
            AddSimpleTokenHandler("uniqueId", logEntry => logEntry.UniqueId);

            AddSimpleTokenHandler("callerInfo", logEntry => FormatSpecificExtendedProperty(logEntry, "CallerInfo"));
            AddSimpleTokenHandler("stepReport", logEntry => FormatSpecificExtendedProperty(logEntry, "StepReport"));

            AddDateTimeTokenHandler("createTime", logEntry => logEntry.CreateTime);
        }

        public TemplateLogFormatter(string template)
        {
            _template = WebUtility.HtmlDecode(template);

            _isHtmlEncoded =
                template != null
                && _containsHtmlTagsRegex.IsMatch(template);
        }

        public static void AddSimpleTokenHandler(string key, Func<ILogEntry, string> getValue)
        {
            _simpleTokenHandlers[key] = getValue;
        }

        public static void AddSimpleTokenHandler<TLogEntry>(string key, Func<TLogEntry, string> getTokenReplacement)
            where TLogEntry : ILogEntry
        {
            _simpleTokenHandlers[key] =
                logEntry =>
                {
                    if (logEntry is TLogEntry)
                    {
                        var tLogEntry = (TLogEntry)logEntry;
                        return getTokenReplacement(tLogEntry);
                    }

                    return null;
                };
        }

        public static void AddDateTimeTokenHandler(string key, Func<ILogEntry, DateTime> getDateTime)
        {
            _dateTimeTokenHandlers[key] = getDateTime;
        }

        public static void AddDateTimeTokenHandler<TLogEntry>(string key, Func<TLogEntry, DateTime> getDateTime)
            where TLogEntry : ILogEntry
        {
            _dateTimeTokenHandlers[key] =
                logEntry =>
                {
                    if (logEntry is TLogEntry)
                    {
                        var tLogEntry = (TLogEntry)logEntry;
                        return getDateTime(tLogEntry);
                    }

                    return default(DateTime);
                };
        }

        private static string FormatSpecificExtendedProperty(ILogEntry logEntry, string extendedProperty)
        {
            return
                logEntry.ExtendedProperties.ContainsKey(extendedProperty)
                    ? logEntry.ExtendedProperties[extendedProperty]
                    : "N/A";
        }

        public string Format(ILogEntry logEntry)
        {
            var formattedLogEntry = _simpleTokenRegex.Replace(
                _template,
                match =>
                {
                    Func<ILogEntry, string> getValue;

                    return
                        HtmlEncodeIfNecessary(
                            _simpleTokenHandlers.TryGetValue(match.Groups["token"].Value, out getValue)
                                ? getValue(logEntry)
                                : match.Value);
                });

            formattedLogEntry = _parentheticalTokenRegex.Replace(
                formattedLogEntry,
                match =>
                {
                    Func<ILogEntry, DateTime> getValue;

                    if (!_dateTimeTokenHandlers.TryGetValue(match.Groups["token"].Value, out getValue))
                    {
                        return match.Value;
                    }

                    var value = getValue(logEntry);

                    return
                        HtmlEncodeIfNecessary(
                            match.Groups["format"].Success
                                ? value.ToString(match.Groups["format"].Value, _culture)
                                : value.ToString("f", _culture));
                });

            formattedLogEntry =
                _extendedPropertiesRegex.Replace(
                    formattedLogEntry,
                    match =>
                    {
                        var before = match.Groups["before"].Value;
                        var between = match.Groups["between"].Value;
                        var after = match.Groups["after"].Value;

                        var key = match.Groups["key"].Value;
                        var omitKey = match.Groups["omitKey"].Success;

                        if (key == "key")
                        {
                            return
                                logEntry.ExtendedProperties
                                    .Aggregate(
                                        new StringBuilder(),
                                        (sb, kvp) => sb.Append(before).Append(omitKey ? null : kvp.Key).Append(between).Append(HtmlEncodeIfNecessary(kvp.Value)).AppendLine(after))
                                    .ToString();
                        }

                        string value;

                        if (!logEntry.ExtendedProperties.TryGetValue(key, out value))
                        {
                            value = "N/A";
                        }

                        return HtmlEncodeIfNecessary(before + (omitKey ? null : key) + between + HtmlEncodeIfNecessary(value) + after);
                    });

            return formattedLogEntry;
        }

        private string HtmlEncodeIfNecessary(string value)
        {
            return _isHtmlEncoded ? WebUtility.HtmlEncode(value) : value;
        }
    }
}

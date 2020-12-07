//using System;
//using System.IO;
//using Cactus.Blade.Logger;

//namespace Logger.Test
//{
//    public class ClassLogger
//    {
//        private static readonly ILogger Logger = global::Logger.CreateLogger<ClassLogger>();

//        public ClassLogger(ITestOutputHelper output)
//        {
//            var writer = new DelegateLogWriter(d => output.WriteLine(d.ToString()));
//            global::Logger.RegisterWriter(writer);
//        }

//        [Fact]
//        public void LogMessage()
//        {
//            const int k = 42;
//            const int l = 100;

//            Logger.Trace().Message("Sample trace message, k={0}, l={1}", k, l).Write();
//            Logger.Debug().Message("Sample debug message, k={0}, l={1}", k, l).Write();
//            Logger.Info().Message("Sample informational message, k={0}, l={1}", k, l).Write();
//            Logger.Warn().Message("Sample warning message, k={0}, l={1}", k, l).Write();
//            Logger.Error().Message("Sample error message, k={0}, l={1}", k, l).Write();
//            Logger.Fatal().Message("Sample fatal error message, k={0}, l={1}", k, l).Write();
//            Logger.Log(LogLevel.Info).Message("Sample fatal error message, k={0}, l={1}", k, l).Write();
//            Logger.Log(() => LogLevel.Info).Message("Sample fatal error message, k={0}, l={1}", k, l).Write();
//        }

//        [Fact]
//        public void LogInfoProperty()
//        {
//            var k = 42;
//            var l = 100;

//            Logger.Info()
//                .Message("Sample informational message, k={0}, l={1}", k, l)
//                .Property("Test", "Tesing properties")
//                .Write();
//        }

//        [Fact]
//        public void LogInterpolation()
//        {
//            var k = 42;
//            var l = 100;

//            // delay string interpolation formating till actual write of message
//            Logger.Info()
//                .Message(() => $"Sample informational message, k={k}, l={l}")
//                .Property("Test", "Tesing properties")
//                .Write();
//        }
//        [Fact]
//        public void LogExtension()
//        {
//            var k = 42;
//            var l = 100;

//            // delay string interpolation formating till actual write of message
//            Logger.Info(() => $"Sample informational message, k={k}, l={l}");
//        }

//        [Fact]
//        public void LogError()
//        {
//            var path = "blah.txt";
//            try
//            {
//                var text = File.ReadAllText(path);
//            }
//            catch (Exception ex)
//            {
//                Logger.Error()
//                    .Message("Error reading file '{0}'.", path)
//                    .Exception(ex)
//                    .Property("Test", "ErrorWrite")
//                    .Write();
//            }
//        }

//        [Fact]
//        public void CorrectLoggerName()
//        {
//            var k = 42;
//            var l = 100;

//            var builder = Logger.Info()
//                .Message("Sample informational message, k={0}, l={1}", k, l)
//                .Property("Test", "Tesing properties");


//            builder.LogData.Logger.Should().Be("FluentLogger.Tests.ClassLogger");
//        }
//    }
//}

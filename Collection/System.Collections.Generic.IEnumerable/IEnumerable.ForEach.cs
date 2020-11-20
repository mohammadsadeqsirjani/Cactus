﻿using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     Enumerates for each in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    /// <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
    {
        var list = @this.ToList();

        foreach (var item in list) action(item);

        return list;
    }

    /// <summary>Enumerates for each in this collection.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    /// <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
    {
        var list = @this.ToList();

        for (var i = 0; i < list.Count; i++) action(list[i], i);

        return list;
    }
}
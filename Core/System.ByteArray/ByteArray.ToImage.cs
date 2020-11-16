﻿using System.Drawing;
using System.IO;

public static partial class Extension
{
    /// <summary>
    ///     A byte[] extension method that converts the @this to an image.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an Image.</returns>
    public static Image ToImage(this byte[] @this)
    {
        using var stream = new MemoryStream(@this);

        return Image.FromStream(stream);
    }
}

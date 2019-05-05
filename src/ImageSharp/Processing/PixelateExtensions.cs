// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Processing.Processors.Effects;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds pixelation effect extensions to the <see cref="Image"/> type.
    /// </summary>
    public static class PixelateExtensions
    {
        /// <summary>
        /// Pixelates an image with the given pixel size.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext Pixelate(this IImageProcessingContext source) => Pixelate(source, 4);

        /// <summary>
        /// Pixelates an image with the given pixel size.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="size">The size of the pixels.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext Pixelate(this IImageProcessingContext source, int size) =>
            source.ApplyProcessor(new PixelateProcessor(size));

        /// <summary>
        /// Pixelates an image with the given pixel size.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="size">The size of the pixels.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext Pixelate(
            this IImageProcessingContext source,
            int size,
            Rectangle rectangle) =>
            source.ApplyProcessor(new PixelateProcessor(size), rectangle);
    }
}
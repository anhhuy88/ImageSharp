﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Processing.Processors.Effects;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds oil painting effect extensions to the <see cref="Image"/> type.
    /// </summary>
    public static class OilPaintExtensions
    {
        /// <summary>
        /// Alters the colors of the image recreating an oil painting effect with levels and brushSize
        /// set to <value>10</value> and <value>15</value> respectively.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext OilPaint(this IImageProcessingContext source) => OilPaint(source, 10, 15);

        /// <summary>
        /// Alters the colors of the image recreating an oil painting effect  with levels and brushSize
        /// set to <value>10</value> and <value>15</value> respectively.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext OilPaint(this IImageProcessingContext source, Rectangle rectangle) =>
            OilPaint(source, 10, 15, rectangle);

        /// <summary>
        /// Alters the colors of the image recreating an oil painting effect.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="levels">The number of intensity levels. Higher values result in a broader range of color intensities forming part of the result image.</param>
        /// <param name="brushSize">The number of neighboring pixels used in calculating each individual pixel value.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext
            OilPaint(this IImageProcessingContext source, int levels, int brushSize) =>
            source.ApplyProcessor(new OilPaintingProcessor(levels, brushSize));

        /// <summary>
        /// Alters the colors of the image recreating an oil painting effect.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="levels">The number of intensity levels. Higher values result in a broader range of color intensities forming part of the result image.</param>
        /// <param name="brushSize">The number of neighboring pixels used in calculating each individual pixel value.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext OilPaint(
            this IImageProcessingContext source,
            int levels,
            int brushSize,
            Rectangle rectangle) =>
            source.ApplyProcessor(new OilPaintingProcessor(levels, brushSize), rectangle);
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToRotationalSpeed
{
    public static class NumberToRotationalSpeedExtensions
    {
        #region CentiradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed CentiradiansPerSecond(this int value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? CentiradiansPerSecond(this int? value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed CentiradiansPerSecond(this long value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? CentiradiansPerSecond(this long? value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed CentiradiansPerSecond(this double value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? CentiradiansPerSecond(this double? value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed CentiradiansPerSecond(this float value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? CentiradiansPerSecond(this float? value) => RotationalSpeed.FromCentiradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed CentiradiansPerSecond(this decimal value) => RotationalSpeed.FromCentiradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? CentiradiansPerSecond(this decimal? value) => RotationalSpeed.FromCentiradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DeciradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DeciradiansPerSecond(this int value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DeciradiansPerSecond(this int? value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DeciradiansPerSecond(this long value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DeciradiansPerSecond(this long? value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DeciradiansPerSecond(this double value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DeciradiansPerSecond(this double? value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DeciradiansPerSecond(this float value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DeciradiansPerSecond(this float? value) => RotationalSpeed.FromDeciradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DeciradiansPerSecond(this decimal value) => RotationalSpeed.FromDeciradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DeciradiansPerSecond(this decimal? value) => RotationalSpeed.FromDeciradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreePerMinute

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerMinute(this int value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerMinute(this int? value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerMinute(this long value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerMinute(this long? value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerMinute(this double value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerMinute(this double? value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerMinute(this float value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerMinute(this float? value) => RotationalSpeed.FromDegreesPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerMinute(this decimal value) => RotationalSpeed.FromDegreesPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerMinute(this decimal? value) => RotationalSpeed.FromDegreesPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerSecond(this int value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerSecond(this int? value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerSecond(this long value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerSecond(this long? value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerSecond(this double value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerSecond(this double? value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerSecond(this float value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerSecond(this float? value) => RotationalSpeed.FromDegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerSecond(this decimal value) => RotationalSpeed.FromDegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerSecond(this decimal? value) => RotationalSpeed.FromDegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrodegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicrodegreesPerSecond(this int value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicrodegreesPerSecond(this int? value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicrodegreesPerSecond(this long value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicrodegreesPerSecond(this long? value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicrodegreesPerSecond(this double value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicrodegreesPerSecond(this double? value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicrodegreesPerSecond(this float value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicrodegreesPerSecond(this float? value) => RotationalSpeed.FromMicrodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicrodegreesPerSecond(this decimal value) => RotationalSpeed.FromMicrodegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicrodegreesPerSecond(this decimal? value) => RotationalSpeed.FromMicrodegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicroradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicroradiansPerSecond(this int value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicroradiansPerSecond(this int? value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicroradiansPerSecond(this long value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicroradiansPerSecond(this long? value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicroradiansPerSecond(this double value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicroradiansPerSecond(this double? value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicroradiansPerSecond(this float value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicroradiansPerSecond(this float? value) => RotationalSpeed.FromMicroradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicroradiansPerSecond(this decimal value) => RotationalSpeed.FromMicroradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicroradiansPerSecond(this decimal? value) => RotationalSpeed.FromMicroradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillidegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MillidegreesPerSecond(this int value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MillidegreesPerSecond(this int? value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MillidegreesPerSecond(this long value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MillidegreesPerSecond(this long? value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MillidegreesPerSecond(this double value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MillidegreesPerSecond(this double? value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MillidegreesPerSecond(this float value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MillidegreesPerSecond(this float? value) => RotationalSpeed.FromMillidegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MillidegreesPerSecond(this decimal value) => RotationalSpeed.FromMillidegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MillidegreesPerSecond(this decimal? value) => RotationalSpeed.FromMillidegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilliradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MilliradiansPerSecond(this int value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MilliradiansPerSecond(this int? value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MilliradiansPerSecond(this long value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MilliradiansPerSecond(this long? value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MilliradiansPerSecond(this double value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MilliradiansPerSecond(this double? value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MilliradiansPerSecond(this float value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MilliradiansPerSecond(this float? value) => RotationalSpeed.FromMilliradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MilliradiansPerSecond(this decimal value) => RotationalSpeed.FromMilliradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MilliradiansPerSecond(this decimal? value) => RotationalSpeed.FromMilliradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanodegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanodegreesPerSecond(this int value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanodegreesPerSecond(this int? value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanodegreesPerSecond(this long value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanodegreesPerSecond(this long? value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanodegreesPerSecond(this double value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanodegreesPerSecond(this double? value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanodegreesPerSecond(this float value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanodegreesPerSecond(this float? value) => RotationalSpeed.FromNanodegreesPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanodegreesPerSecond(this decimal value) => RotationalSpeed.FromNanodegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanodegreesPerSecond(this decimal? value) => RotationalSpeed.FromNanodegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanoradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanoradiansPerSecond(this int value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanoradiansPerSecond(this int? value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanoradiansPerSecond(this long value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanoradiansPerSecond(this long? value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanoradiansPerSecond(this double value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanoradiansPerSecond(this double? value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanoradiansPerSecond(this float value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanoradiansPerSecond(this float? value) => RotationalSpeed.FromNanoradiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanoradiansPerSecond(this decimal value) => RotationalSpeed.FromNanoradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanoradiansPerSecond(this decimal? value) => RotationalSpeed.FromNanoradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RadianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RadiansPerSecond(this int value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RadiansPerSecond(this int? value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RadiansPerSecond(this long value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RadiansPerSecond(this long? value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RadiansPerSecond(this double value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RadiansPerSecond(this double? value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RadiansPerSecond(this float value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RadiansPerSecond(this float? value) => RotationalSpeed.FromRadiansPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RadiansPerSecond(this decimal value) => RotationalSpeed.FromRadiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RadiansPerSecond(this decimal? value) => RotationalSpeed.FromRadiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RevolutionPerMinute

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerMinute(this int value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerMinute(this int? value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerMinute(this long value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerMinute(this long? value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerMinute(this double value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerMinute(this double? value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerMinute(this float value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerMinute(this float? value) => RotationalSpeed.FromRevolutionsPerMinute(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerMinute(this decimal value) => RotationalSpeed.FromRevolutionsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerMinute(this decimal? value) => RotationalSpeed.FromRevolutionsPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RevolutionPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerSecond(this int value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerSecond(this int? value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerSecond(this long value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerSecond(this long? value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerSecond(this double value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerSecond(this double? value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerSecond(this float value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerSecond(this float? value) => RotationalSpeed.FromRevolutionsPerSecond(value);

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerSecond(this decimal value) => RotationalSpeed.FromRevolutionsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerSecond(this decimal? value) => RotationalSpeed.FromRevolutionsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif

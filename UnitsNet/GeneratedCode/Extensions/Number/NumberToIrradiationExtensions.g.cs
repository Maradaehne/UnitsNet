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
namespace UnitsNet.Extensions.NumberToIrradiation
{
    public static class NumberToIrradiationExtensions
    {
        #region JoulePerSquareCentimeter

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareCentimeter(this int value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareCentimeter(this int? value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareCentimeter(this long value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareCentimeter(this long? value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareCentimeter(this double value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareCentimeter(this double? value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareCentimeter(this float value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareCentimeter(this float? value) => Irradiation.FromJoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareCentimeter(this decimal value) => Irradiation.FromJoulesPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareCentimeter(this decimal? value) => Irradiation.FromJoulesPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerSquareMeter

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMeter(this int value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMeter(this int? value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMeter(this long value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMeter(this long? value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMeter(this double value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMeter(this double? value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMeter(this float value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMeter(this float? value) => Irradiation.FromJoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMeter(this decimal value) => Irradiation.FromJoulesPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMeter(this decimal? value) => Irradiation.FromJoulesPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerSquareMillimeter

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMillimeter(this int value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMillimeter(this int? value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMillimeter(this long value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMillimeter(this long? value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMillimeter(this double value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMillimeter(this double? value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMillimeter(this float value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMillimeter(this float? value) => Irradiation.FromJoulesPerSquareMillimeter(value);

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation JoulesPerSquareMillimeter(this decimal value) => Irradiation.FromJoulesPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromJoulesPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? JoulesPerSquareMillimeter(this decimal? value) => Irradiation.FromJoulesPerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerSquareMeter

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilojoulesPerSquareMeter(this int value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilojoulesPerSquareMeter(this int? value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilojoulesPerSquareMeter(this long value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilojoulesPerSquareMeter(this long? value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilojoulesPerSquareMeter(this double value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilojoulesPerSquareMeter(this double? value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilojoulesPerSquareMeter(this float value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilojoulesPerSquareMeter(this float? value) => Irradiation.FromKilojoulesPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilojoulesPerSquareMeter(this decimal value) => Irradiation.FromKilojoulesPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromKilojoulesPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilojoulesPerSquareMeter(this decimal? value) => Irradiation.FromKilojoulesPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilowattHourPerSquareMeter

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilowattHoursPerSquareMeter(this int value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilowattHoursPerSquareMeter(this int? value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilowattHoursPerSquareMeter(this long value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilowattHoursPerSquareMeter(this long? value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilowattHoursPerSquareMeter(this double value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilowattHoursPerSquareMeter(this double? value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilowattHoursPerSquareMeter(this float value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilowattHoursPerSquareMeter(this float? value) => Irradiation.FromKilowattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation KilowattHoursPerSquareMeter(this decimal value) => Irradiation.FromKilowattHoursPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromKilowattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? KilowattHoursPerSquareMeter(this decimal? value) => Irradiation.FromKilowattHoursPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillijoulePerSquareCentimeter

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation MillijoulesPerSquareCentimeter(this int value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? MillijoulesPerSquareCentimeter(this int? value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation MillijoulesPerSquareCentimeter(this long value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? MillijoulesPerSquareCentimeter(this long? value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation MillijoulesPerSquareCentimeter(this double value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? MillijoulesPerSquareCentimeter(this double? value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation MillijoulesPerSquareCentimeter(this float value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? MillijoulesPerSquareCentimeter(this float? value) => Irradiation.FromMillijoulesPerSquareCentimeter(value);

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation MillijoulesPerSquareCentimeter(this decimal value) => Irradiation.FromMillijoulesPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromMillijoulesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Irradiation? MillijoulesPerSquareCentimeter(this decimal? value) => Irradiation.FromMillijoulesPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region WattHourPerSquareMeter

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation WattHoursPerSquareMeter(this int value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? WattHoursPerSquareMeter(this int? value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation WattHoursPerSquareMeter(this long value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? WattHoursPerSquareMeter(this long? value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation WattHoursPerSquareMeter(this double value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? WattHoursPerSquareMeter(this double? value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation WattHoursPerSquareMeter(this float value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? WattHoursPerSquareMeter(this float? value) => Irradiation.FromWattHoursPerSquareMeter(value);

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation WattHoursPerSquareMeter(this decimal value) => Irradiation.FromWattHoursPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Irradiation.FromWattHoursPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Irradiation? WattHoursPerSquareMeter(this decimal? value) => Irradiation.FromWattHoursPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif

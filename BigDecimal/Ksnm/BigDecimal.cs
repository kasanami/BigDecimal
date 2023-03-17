using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace Ksnm
{
    public struct BigDecimal : INumber<BigDecimal>, IEquatable<BigDecimal>
    {
        public static BigDecimal One => throw new NotImplementedException();

        public static int Radix => throw new NotImplementedException();

        public static BigDecimal Zero => throw new NotImplementedException();

        public static BigDecimal AdditiveIdentity => throw new NotImplementedException();

        public static BigDecimal MultiplicativeIdentity => throw new NotImplementedException();

        static BigDecimal INumberBase<BigDecimal>.One => throw new NotImplementedException();

        static int INumberBase<BigDecimal>.Radix => throw new NotImplementedException();

        static BigDecimal INumberBase<BigDecimal>.Zero => throw new NotImplementedException();

        static BigDecimal IAdditiveIdentity<BigDecimal, BigDecimal>.AdditiveIdentity => throw new NotImplementedException();

        static BigDecimal IMultiplicativeIdentity<BigDecimal, BigDecimal>.MultiplicativeIdentity => throw new NotImplementedException();

        public static BigDecimal Abs(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsCanonical(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsEvenInteger(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsFinite(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsImaginaryNumber(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInfinity(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInteger(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNaN(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegative(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegativeInfinity(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNormal(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositive(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositiveInfinity(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsRealNumber(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsSubnormal(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal MaxMagnitude(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal MaxMagnitudeNumber(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal MinMagnitude(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal MinMagnitudeNumber(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.Abs(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsCanonical(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsComplexNumber(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsEvenInteger(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsFinite(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsImaginaryNumber(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsInfinity(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsInteger(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsNaN(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsNegative(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsNegativeInfinity(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsNormal(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsOddInteger(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsPositive(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsPositiveInfinity(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsRealNumber(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsSubnormal(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.IsZero(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.MaxMagnitude(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.MaxMagnitudeNumber(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.MinMagnitude(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.MinMagnitudeNumber(BigDecimal x, BigDecimal y)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static BigDecimal INumberBase<BigDecimal>.Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static BigDecimal ISpanParsable<BigDecimal>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IParsable<BigDecimal>.Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryConvertFromChecked<TOther>(TOther value, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryConvertFromSaturating<TOther>(TOther value, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryConvertFromTruncating<TOther>(TOther value, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryConvertToChecked<TOther>(BigDecimal value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryConvertToSaturating<TOther>(BigDecimal value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryConvertToTruncating<TOther>(BigDecimal value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<BigDecimal>.TryParse(string? s, NumberStyles style, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static bool ISpanParsable<BigDecimal>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        static bool IParsable<BigDecimal>.TryParse(string? s, IFormatProvider? provider, out BigDecimal result)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(BigDecimal other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(BigDecimal other)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        int IComparable.CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        int IComparable<BigDecimal>.CompareTo(BigDecimal other)
        {
            throw new NotImplementedException();
        }

        bool IEquatable<BigDecimal>.Equals(BigDecimal other)
        {
            throw new NotImplementedException();
        }

        string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator +(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IUnaryPlusOperators<BigDecimal, BigDecimal>.operator +(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator +(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IAdditionOperators<BigDecimal, BigDecimal, BigDecimal>.operator +(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator -(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IUnaryNegationOperators<BigDecimal, BigDecimal>.operator -(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator -(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static BigDecimal ISubtractionOperators<BigDecimal, BigDecimal, BigDecimal>.operator -(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator ++(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IIncrementOperators<BigDecimal>.operator ++(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator --(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IDecrementOperators<BigDecimal>.operator --(BigDecimal value)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator *(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IMultiplyOperators<BigDecimal, BigDecimal, BigDecimal>.operator *(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator /(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IDivisionOperators<BigDecimal, BigDecimal, BigDecimal>.operator /(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static BigDecimal operator %(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static BigDecimal IModulusOperators<BigDecimal, BigDecimal, BigDecimal>.operator %(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static bool IEqualityOperators<BigDecimal, BigDecimal, bool>.operator ==(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static bool IEqualityOperators<BigDecimal, BigDecimal, bool>.operator !=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<BigDecimal, BigDecimal, bool>.operator <(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<BigDecimal, BigDecimal, bool>.operator >(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<BigDecimal, BigDecimal, bool>.operator <=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<BigDecimal, BigDecimal, bool>.operator >=(BigDecimal left, BigDecimal right)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
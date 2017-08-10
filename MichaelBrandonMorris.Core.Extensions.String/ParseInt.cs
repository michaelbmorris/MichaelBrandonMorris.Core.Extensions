using System;
using System.Globalization;

namespace MichaelBrandonMorris.Core.Extensions.String
{
    public static partial class StringExtensions
    {
        public static int ParseInt(this string s)
        {
            return int.Parse(s);
        }

        public static int ParseInt(this string s, NumberStyles style)
        {
            return int.Parse(s, style);
        }

        public static int ParseInt(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return int.Parse(s, style, provider);
        }

        public static int ParseInt(this string s, IFormatProvider provider)
        {
            return int.Parse(s, provider);
        }
    }
}
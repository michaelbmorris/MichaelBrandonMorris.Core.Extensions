using System;
using System.Globalization;

namespace MichaelBrandonMorris.Core.Extensions.String
{
    public static partial class StringExtensions
    {
        public static bool TryParseInt(this string s, out int result)
        {
            return int.TryParse(s, out result);
        }

        public static bool TryParseInt(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out int result)
        {
            return int.TryParse(s, style, provider, out result);
        }
    }
}
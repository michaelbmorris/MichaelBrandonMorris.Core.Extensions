namespace MichaelBrandonMorris.Core.Extensions.String
{
    public static partial class StringExtensions
    {
        public static string NullOrWhiteSpaceConditional(this string s)
        {
            return s.IsNullOrWhiteSpace() ? null : s;
        }
    }
}
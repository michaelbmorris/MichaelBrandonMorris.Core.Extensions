namespace MichaelBrandonMorris.Core.Extensions.String
{
    public static partial class StringExtensions
    {
        public static string NullOrEmptyConditional(this string s)
        {
            return s.IsNullOrEmpty() ? null : s;
        }
    }
}
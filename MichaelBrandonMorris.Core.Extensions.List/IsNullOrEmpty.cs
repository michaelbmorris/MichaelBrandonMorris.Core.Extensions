using System.Collections.Generic;

namespace MichaelBrandonMorris.Core.Extensions.List
{
    public static partial class ListExtensions
    {
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }
    }
}

using System.Collections.Generic;

namespace MichaelBrandonMorris.Core.Extensions.List
{
    public static partial class ListExtensions
    {
        public static bool IsEmpty<T>(this IList<T> list)
        {
            return list.Count == 0;
        }
    }
}

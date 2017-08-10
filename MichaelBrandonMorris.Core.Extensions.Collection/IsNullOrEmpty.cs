using System.Collections.Generic;

namespace MichaelBrandonMorris.Core.Extensions.Collection
{
    public static partial class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}

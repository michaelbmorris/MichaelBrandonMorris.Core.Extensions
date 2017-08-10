using System;
using System.Collections.Generic;
using System.Linq;

namespace MichaelBrandonMorris.Core.Extensions.List
{
    public static partial class ListExtensions
    {
        public static IList<TSource> OrderBy<TSource, TKey>(
            this IList<TSource> list,
            Func<TSource, TKey> keySelector)
        {
            return list.AsEnumerable().OrderBy(keySelector).ToList();
        }

        public static IList<TSource> OrderBy<TSource, TKey>(
            this IList<TSource> list,
            Func<TSource, TKey> keySelector,
            IComparer<TKey> comparer)
        {
            return list.AsEnumerable().OrderBy(keySelector, comparer).ToList();
        }

        public static IList<TSource> OrderBy<TSource, T1, T2>(
            this IList<TSource> list,
            Func<TSource, T1> keySelector1,
            Func<TSource, T2> keySelector2)
        {
            return list
                .AsEnumerable()
                .OrderBy(keySelector1)
                .ThenBy(keySelector2)
                .ToList();
        }

        public static IList<TSource> OrderBy<TSource, T1, T2, T3>(
            this IList<TSource> list,
            Func<TSource, T1> keySelector1,
            Func<TSource, T2> keySelector2,
            Func<TSource, T3> keySelector3)
        {
            return list
                .AsEnumerable()
                .OrderBy(keySelector1)
                .ThenBy(keySelector2)
                .ThenBy(keySelector3)
                .ToList();
        }

        public static IList<TSource> OrderBy<TSource, T1, T2, T3, T4>(
            this IList<TSource> list,
            Func<TSource, T1> keySelector1,
            Func<TSource, T2> keySelector2,
            Func<TSource, T3> keySelector3,
            Func<TSource, T4> keySelector4)
        {
            return list
                .AsEnumerable()
                .OrderBy(keySelector1)
                .ThenBy(keySelector2)
                .ThenBy(keySelector3)
                .ThenBy(keySelector4)
                .ToList();
        }
    }
}

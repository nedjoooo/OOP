using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(item => !predicate(item));
        }
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var list = collection.ToList();
            for (int i = 0; i < count; i++)
            {
                list.AddRange(collection);
            }
            return list;
        }
        public static IEnumerable<string> WhereEndsWith
            (this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var resultCollection = new List<string>();

            foreach (var suffix in suffixes)
            {
                resultCollection.AddRange(collection.Where(item => item.EndsWith(suffix)));
            }

            return resultCollection as IEnumerable<string>;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2_Custom_Linq_Extension_Methods
{
    public static class Extensions
    {
        // public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) { … } – works just like Where(predicate) but filters the non-matching items from the collection.
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            IEnumerable<T> where = collection.Where(predicate);
            IEnumerable<T> output = collection.Except(where);
            return output;
        }

        // public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) { … } – repeats the collection count times.
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            IEnumerable<T> output = collection;
            for (int i = 0; i < count; i++)
            {
                output = output.Concat(collection);
            }
            return output;
        }

         // public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes) { … } – filters all items from the collection that ends with some of the specified suffixes.
        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            IEnumerable<string> output = null;
            IList<string> temp = new List<string>();
            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.LastIndexOf(suffix) == item.Length - suffix.Length&&item.LastIndexOf(suffix)!=-1)
                    {
                        temp.Add(item);
                        break;
                    }
                }
            }
            
            output = temp;
            return output;
        }

    }
}

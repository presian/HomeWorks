//Create your own LINQ extension methods:
//•	public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) { … } – works just like Where(predicate) but filters the non-matching items from the collection.
//•	public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) { … } – repeats the collection count times.
//•	public static IEnumerable<string> WhereEndsWith<string>(this IEnumerable<string> collection, this IEnumerable<string> suffixes) { … } – filters all items from the collection that ends with some of the specified suffixes.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Custom_Linq_Extension_Methods
{
    class CustomLinqExtensionMethods
    {
        static void Main(string[] args)
        {
            // The collection
            int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // First method
            var predicate = new Func<int, bool>(x => x < 6);
            var collection = arr.WhereNot(predicate);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            // Second methods
            var collection1 = arr.Repeat(2);
            foreach (var item1 in collection1)
            {
                Console.WriteLine(item1); 
            }

            // Third methods
            string[] strCollection = new string[] { "Pesho", "Gosho", "i", "Tosho", "otivat", "na", "riba", "zaedno", "s", "Alibaba" };
            string [] suffixes = new string[]{"sho", "ba"};
            var collection2 = strCollection.WhereEndsWith(suffixes);
            foreach (var item2 in collection2)
            {
                Console.WriteLine(item2);
            }
        }
    }
}

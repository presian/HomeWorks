//Implement the following extension methods for the class StringBuilder:
//•	Substring(int startIndex, int length) – returns a new String object, containing the elements in the given range. Throw an exception when the range is invalid.
//•	RemoveText(string text) – removes all occurrences of the specified text (case-insensitive) from the StringBuilder. The method should not create a new StringBuilder, but should modify the existing one and return it as a result.
//•	AppendAll(IEnumerable<T> items) – appends the string representations of all items from the specified collection. Use ToString() to convert from T to string.
//Write a program to demonstrate that your new extension methods work correctly.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_StringBuilder_Extensions
{
    public class StringBuilderExtensionsProgram
    {
        static void Main(string[] args)
        {
            // Substring()
            StringBuilder builder = new StringBuilder("Pesho, Gosho i Tosho otivat na riba");
            Console.WriteLine(builder.Substring(2,3));
            
            // RemoveText()
            StringBuilder builder1 = new StringBuilder("Pesho, Gosho i Tosho otivat na riba");
            Console.WriteLine(builder.RemoveText(", gosho"));
            
            // AppendAll()
            StringBuilder builder2 = new StringBuilder("Pesho, Gosho i Tosho otivat na riba v ");
            string[] list = new[] {"Ponedelnik", ", Votrnik", " ili Srqda."};
            Console.WriteLine(builder2.AppendAll(list));
        }
    }
}

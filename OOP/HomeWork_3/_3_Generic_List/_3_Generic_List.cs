using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Generic_List
{
    class GenericList
    {
        static void Main(string[] args)
        {
            GenericList<int> a = new GenericList<int>();
            a.Add(1);
            a.Add(2);
            a.Add(55);
            a.Add(133);
            a.Add(155);

            Console.WriteLine(a[4]);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //GenericList<string> b = new GenericList<string>();
            //b.Add("1");
            //b.Add("2");
            //b.Add("55");
            //b.Add("133");

            var allAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("Version: " + allAttributes[0]);

        }
    }
}

namespace _2_String_Disperser
{
    using System;

    class MainClass
    {
        static void Main()
        {
            StringDisperser firstTestObject = new StringDisperser("a", "b", "c");
            StringDisperser secondTestObject = new StringDisperser("d", "e", "f");

            Console.WriteLine(firstTestObject.Equals(secondTestObject));
            Console.WriteLine(firstTestObject);
            Console.WriteLine(firstTestObject != secondTestObject);
            StringDisperser thirdTestObject = (StringDisperser)firstTestObject.Clone();

            Console.WriteLine(firstTestObject);
            Console.WriteLine(thirdTestObject);

            Console.WriteLine("=====================");
            thirdTestObject.LastString = "a";
            Console.WriteLine(thirdTestObject);
            Console.WriteLine(firstTestObject);

            Console.WriteLine("====================");
            Console.WriteLine(firstTestObject.CompareTo(thirdTestObject));

            Console.WriteLine("====================");
            StringDisperser stringDisperser = new StringDisperser("pesho", "gosho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}

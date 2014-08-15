using System;

class StringsAndObjects
{
    static void Main()
    {
        string h = "Hello";
        string w = "World";
        object o = h + " " + w;
        string hw = (string)o;
        Console.WriteLine(hw);
    }
}


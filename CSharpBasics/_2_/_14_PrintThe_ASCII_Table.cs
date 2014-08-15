using System;
using System.Text;

class PrintThe_ASCII_Table
{
    static void Main()
    {
        int i = 0;
        for (char symbol = '\x0000'; symbol <= 0xFF; symbol++)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine( i + " - " + symbol);
            i++;             
        }
    }
}


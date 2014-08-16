using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Please enter a integer: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                string txt = Console.ReadLine();
                Console.WriteLine(txt + "*");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}

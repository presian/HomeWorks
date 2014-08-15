using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First name:");
        string firstName = Console.ReadLine();
        Console.Write("Last name:");
        string lastName = Console.ReadLine();
        Console.Write("Age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gender (m/f):");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Personal ID number:");
        long personalID = long.Parse(Console.ReadLine());
        Console.Write("Unique employee number (27560000…27569999):");
        int uniqueNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEmployee personal info: \n{0} \n{1} \n{2} \n{3} \n{4} \n{5}\n",firstName,lastName,age,gender,personalID,uniqueNumber);
    }
}

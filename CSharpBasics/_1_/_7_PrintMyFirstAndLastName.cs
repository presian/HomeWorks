using System;

    class PrintMyFirstAndLastName
    {
        static void Main()
        {
            Console.Write("Please Enter Your First Name: ");
            string firstname = Console.ReadLine();
            Console.Write("Please Enter Your Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("{0} \n{1}", firstname, lastname);
            
        }
    }

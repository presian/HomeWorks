using _1_Customer.SupportClasses;

namespace _1_Customer
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            Customer firstCustomer = new Customer("Atanas", "Petrov", "Ivanov", 9805162795, new PermanentAddress("Bulgaria", "Sofia", "Slavianska", 5), "0899050505", "gogo@abv.bg", new List<Payments>() { new Payments("Nintendo", 125.5m) }, CustomerType.OneTime);
            Customer secondCustomer = new Customer("Georgi", "Petrov", "Ivanov", 8905162795, new PermanentAddress("Bulgaria", "Sofia", "Slavianska", 5), "0899050505", "gogo@abv.bg", new List<Payments>() { new Payments("Nintendo", 125.5m), new Payments("Nintendo", 125.5m) }, CustomerType.OneTime);

            Customer testClone = (Customer)secondCustomer.Clone();

            testClone.Payments.Add(new Payments("Sega", 134.55m));
            testClone.Payments[1].Price = 138;
            testClone.Address.Street = "Popa";

            Console.WriteLine(secondCustomer);

            Console.WriteLine(testClone);

            Console.WriteLine(firstCustomer.CompareTo(secondCustomer));
        }
    }
}

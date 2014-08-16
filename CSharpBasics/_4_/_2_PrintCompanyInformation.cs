using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please enter company address: ");
        string companyAdres = Console.ReadLine();
        Console.Write("Please enter company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Please enter company fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Please enter company web site: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Please enter company manager (first name): ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter company manager (last name): ");
        string lastName = Console.ReadLine();
        Console.Write("Please enter company manager (age): ");
        string age = Console.ReadLine();
        Console.Write("Please enter company manager (phone number): ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("Company name: {0}\nAdress: {1}\nPhone number: {2}\nFax number: {3}\nWeb site: {4}\n", companyName, companyAdres, companyPhone, companyFax, companyWebsite);
        Console.WriteLine("Manager: {0} {1}\nAge: {2}\nPhone number: {3}", firstName, lastName, age, managerPhone);
    }
}

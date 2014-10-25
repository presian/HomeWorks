//Problem 2.	Human, Student and Worker
//Define an abstract class Human holding a first name and a last name.
//•	Define a class Student derived from Human that has a field faulty number (5-10 digits / letters).
//•	Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns the payment earned by hour by the worker. 
//•	Define the proper constructors and properties for the classes in your class hierarchy.
//•	Initialize a list of 10 students and sort them by faculty number in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by payment per hour in descending order.
//•	Merge the lists and then sort them by first name and last name.



using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Human_Students_Worker
{
    class MainClass
    {
        static void Main()
        {
            const string FacultyNumber = "0514000";
            const int MinSalary = 1000;
            const int MaxSalary = 2000;

            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            string[] firstNames = new string[] { "Ivan", "Georgi", "Todor", "Atanas", "Petar", "Nikola" };
            string[] lastNames = new string[] { "Ivanov", "Georgiev", "Todorov", "Atanasov", "Petrov", "Nikolov" };

            Random randomGenerator = new Random();
            int firstRandom = firstNames.Count();
            int lastRandom = lastNames.Count();

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(firstNames[randomGenerator.Next(firstRandom)], 
                    lastNames[randomGenerator.Next(lastRandom)], 
                    FacultyNumber + i));
                workers.Add(new Worker(firstNames[randomGenerator.Next(lastRandom)],
                    lastNames[randomGenerator.Next(lastRandom)],
                    (decimal)randomGenerator.Next(MinSalary, MaxSalary), 8));
            }

            students = students
                .OrderBy(student => student.FacultyNumber)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName
                    + "\nFaculty number: " + student.FacultyNumber);
            }
            workers = workers
                .OrderByDescending(worker => worker.MoneyPerHour())
                .ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName
                    + "\n Salary:" + worker.WeekSalery
                    + "\nWorking hours per day: " + worker.WorkHoursPerDay
                    + "\nMoney per hour: " + worker.MoneyPerHour());
            }

            // version 1
            List<Human> all = new List<Human>();
            all.AddRange(students);
            all.AddRange(workers);
            all = all.OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToList();

            foreach (var human in all)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }

            // version 2
            Console.WriteLine("\n\n\n");
            IList<Human> allHumans = students.Cast<Human>()
                .Union(workers.Cast<Human>())
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToList();
            foreach (var human in allHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            } 
        }
    }
}

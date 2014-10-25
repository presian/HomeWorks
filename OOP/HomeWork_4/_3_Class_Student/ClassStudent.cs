// 3.Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_Student
{
    class ClassStudent
    {
        static void Main(string[] args)
        {
            // List
            IList<Student> softUni = new List<Student>();

            // Students
            softUni.Add(new Student("Asen", "Asenov", 19, "001014", "029741515", "asen_001@softUni.bg", 2, new List<int>() { 3, 3, 3, 2, 3, 2, 3 }));
            softUni.Add(new Student("Boris", "Borisov", 25, "002015", "0888000001", "boris_002@softUni.bg", 1, new List<int>() { 3, 3, 3, 3, 3, 3, 4 }));
            softUni.Add(new Student("Vasil", "Vasilev", 20, "003", "0888000011", "vasil_003@softUni.bg", 1, new List<int>() { 2, 3, 3, 2, 3, 4, 4 }));
            softUni.Add(new Student("Martin", "Georgiev", 19, "004", "+35929661468", "georgi_003@softUni.bg", 2, new List<int>() { 4, 3, 3, 4, 4, 4, 4 }));
            softUni.Add(new Student("Damyan", "Damyanov", 32, "005", "0888001000", "dido_005@softUni.bg", 1, new List<int>() { 5, 3, 3, 3, 3, 3, 3 }));
            softUni.Add(new Student("Emil", "Aleksov", 28, "006014", "0888100000", "emil_006@abv.bg", 2, new List<int>() { 3, 3, 6, 3, 3, 3, 3 }));
            softUni.Add(new Student("Rumen", "Jivkov", 21, "007", "+359 29743625", "rumen_007@softUni.bg", 2, new List<int>() { 3, 3, 3, 3, 3, 3, 6 }));
            softUni.Add(new Student("Zdravko", "Kirilov", 33, "008", "0888000000", "zdravko_008@softUni.bg", 2, new List<int>() { 3, 3, 3, 5, 3, 3, 3 }));
            softUni.Add(new Student("Martin", "Asparuhov", 30, "009014", "0899100000", "martin_009@softUni.bg", 1, new List<int>() { 3, 3, 4, 3, 6, 3, 3 }));
            softUni.Add(new Student("Milen", "Marinchev", 18, "010", "0888000999", "milen_010@abv.bg", 2, new List<int>() { 3, 6, 3, 5, 3, 3, 4 }));

            // 4.Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("4.Print all students from group number 2. Use a LINQ query. Order the students by FirstName.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var secondGroup = from student in softUni
                              where student.GroupNumber == 2
                              orderby student.FirstName
                              select student;
            foreach (var student in secondGroup)
            {
                Console.WriteLine(student);
            }

            // 5.Print all students whose first name is before their last name alphabetically. Use a LINQ query.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("5.Print all students whose first name is before their last name alphabetically. Use a LINQ query.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var firstNameFirst = from student in softUni
                                 where string.Compare(student.FirstName, student.LastName) == -1
                                 select student;
            foreach (var student in firstNameFirst)
            {
                Console.WriteLine(student);
            }

            // 6.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("6.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var between18_24 = from student in softUni
                               where student.Age >= 18 && student.Age <= 24
                               select new { Name = student.FirstName + " " + student.LastName, Age = student.Age };
            foreach (var student in between18_24)
            {
                Console.WriteLine(student.Name + " - " + student.Age);
            }

            // 7. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("7. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("         /a. With lambda expressions");
            Console.WriteLine("***********************************************************************");

            // a. With lambda expressions
            var order = softUni.OrderByDescending(a => a.FirstName).ThenByDescending(a => a.LastName);
            foreach (var student in order)
            {
                Console.WriteLine(student);
            }

            // b. With LINQ query
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("         /b. With LINQ query");
            Console.WriteLine("***********************************************************************");
            var order1 = from student in softUni
                         orderby student.LastName descending
                         orderby student.FirstName descending
                         select student;
            foreach (var student in order1)
            {
                Console.WriteLine(student);
            }

            // 8. Print all students that have email @abv.bg. Use LINQ.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("8. Print all students that have email @abv.bg. Use LINQ.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var emailFilter = from student in softUni
                              where student.Email.Contains("@abv.bg")
                              select student;
            foreach (var student in emailFilter)
            {
                Console.WriteLine(student);
            }

            // 9. Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("9. Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var phoneFiter = from student in softUni
                             where (student.Phone.StartsWith("02") ||
                                 student.Phone.StartsWith("+3592") ||
                                 student.Phone.StartsWith("+359 2"))
                             select student;
            foreach (var student in phoneFiter)
            {
                Console.WriteLine(student);
            }

            // 10. Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("10. Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var excellentStudents = from student in softUni
                                    where student.Marks.Contains(6)
                                    select new { Name = student.FirstName + " " + student.LastName, Marks = student.Marks };
            foreach (var excellentStudent in excellentStudents)
            {
                Console.WriteLine("Name: " + excellentStudent.Name + "\nMarks: " + string.Join(", ", excellentStudent.Marks));
            }

            // 11. Write a similar program to the previous one to extract the students with exactly two marks '2'. Use extension methods.
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("11. Write a similar program to the previous one to extract the students with exactly two marks '2'. Use extension methods.");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var weekStudents = from student in softUni
                               where student.Marks.Count(a => a == 2) > 1
                               select student;
            foreach (var weekStudent in weekStudents)
            {
                Console.WriteLine(weekStudent);
            }

            // 12. Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            Console.WriteLine("\n\n//////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("12. Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
            var students2014 = from student in softUni
                               where student.FacultyNumber.Length >= 6
                               where student.FacultyNumber.Substring(4, 2).Equals("14")
                               select student;
            foreach (var student in students2014)
            {
                Console.WriteLine(student);
            }
        }
    }
}

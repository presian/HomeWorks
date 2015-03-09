namespace StudentSystem.Client.SystemClasses
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using Data;
    using Models;

    public class CommandExecutor
    {
        private const string Format = "dd/MM/yyyy";
        private StudentSystemContext db;

        public CommandExecutor(StudentSystemContext db)
        {
            this.db = db;
        }

        public StudentSystemContext Db
        {
            get { return this.db; }
            set { this.db = value; }
        }

        private void ExecuteAddStudent()
        {
            while (true)
            {
                try
                {
                    var student = this.GetUserInputForNewStudent();
                    this.Db.Students.Add(student);
                    this.Db.SaveChanges();
                    this.PrintSuccesMessage();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Somthing is wrong! Plese try again later!");
                }
            } 
        }

        private void ExecuteAddResource()
        {
            var resource = this.GetUserInputForNewResource();
            if (resource != null)
            {
                try
                {
                    this.db.Resources.Add(resource);
                    this.db.SaveChanges();
                    this.PrintSuccesMessage();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something is wrong! Plese try again later!");
                }
            }
            
        }

        private void ExecuteAddCourse()
        {
            while (true)
            {
                try
                {
                    var newCourse = this.GetUserInputForNewCourse();
                    newCourse.Resources = this.AddResourcesToNewCource();
                    this.Db.Courses.Add(newCourse);
                    this.db.SaveChanges();
                    this.PrintSuccesMessage();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Some of date is bad please try again!");
                }
            }
        }

        public void ExecuteCommand(CommandType type)
        {
            switch (type)
            {
                case CommandType.ListStudentsInfo:
                    this.ExecuteStudentInfo();
                    break;
                case CommandType.ListCoursesInfo:
                    this.ExecuteListCoursesInfo();
                    break;
                case CommandType.AddCourse:
                    this.ExecuteAddCourse();
                    break;
                case CommandType.AddStudent:
                    this.ExecuteAddStudent();
                    break;
                case CommandType.AddResource:
                    this.ExecuteAddResource();
                    break;
            }
        }

        private void ExecuteListCoursesInfo()
        {
            var courses = this.Db.Courses.Select(c => new
            {
                c.Name,
                c.Resources
            }).ToList();

            foreach (var course in courses)
            {
                Console.WriteLine("======================");
                Console.WriteLine("{0, -5} {1} {0, 5}", "*", course.Name);
                Console.WriteLine("======================");
                foreach (var resource in course.Resources.Select(r => new
                {
                    r.Link,
                    r.Name,
                    r.ResourceType
                }))
                {
                    Console.WriteLine("* " + resource.Name);
                    Console.WriteLine("  " + resource.Link);
                    Console.WriteLine("  " + resource.ResourceType);
                }

                Console.WriteLine("___________________________");
            }
        }

        private void ExecuteStudentInfo()
        {
            var data = this.db.Students.Select(s => new
            {
                s.Name,
                s.Submissions
            }).ToList();

            foreach (var s in data)
            {
                Console.WriteLine("======================");
                Console.WriteLine("{0, -5} {1} {0, 5}", "*", s.Name);
                Console.WriteLine("======================");
                foreach (var sm in s.Submissions.Select(sub => new
                {
                    sub.Homework.Content,
                    sub.Homework.HomeworkContentType,
                    sub.Homework.DateTime
                }))
                {
                    Console.WriteLine("* " + sm.Content);
                    Console.WriteLine("  " + sm.HomeworkContentType);
                    Console.WriteLine("  " + sm.DateTime);
                }

                Console.WriteLine("___________________________");
            }
        }

        private HashSet<Resource> AddResourcesToNewCource()
        {
            var resourses = new HashSet<Resource>();
            var noExit = true;
            while (noExit)
            {
                if (!this.GetYesOrNoAnswer("resource"))
                {
                    return resourses;
                }

                Console.WriteLine("====================");
                Console.WriteLine("* Add new resource *");
                Console.WriteLine("====================");
                var resource = this.GetUserInputForNewResource();
                if (resource != null)
                {
                    resourses.Add(resource);
                    noExit = this.GetYesOrNoAnswer("again");
                }
                else
                {
                    noExit = false;
                }
            }

            return resourses;
        }

        private ResourceType GetResourceType()
        {
            Console.WriteLine("* Enter a resource type (1-4)[and press Enter] *");
            Console.WriteLine("1. Video");
            Console.WriteLine("2. Presentation");
            Console.WriteLine("3. Document");
            Console.WriteLine("4. Other");
            Console.Write("What you choose: ");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return ResourceType.Video;
                    case "2":
                        return ResourceType.Presentation;
                    case "3":
                        return ResourceType.Document;
                    case "4":
                        return ResourceType.Other;
                    default:
                        Console.WriteLine("Please enter valid one ;)");
                        continue;
                }
            }
        }

        private bool GetYesOrNoAnswer(string action)
        {
            while (true)
            {
                Console.Write("** Are you want enter {0} [y/n]: ", action);

                switch (Console.ReadLine())
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("===================================");
                        Console.WriteLine("Please enter again yes[y] or no[n]!");
                        Console.WriteLine("===================================");
                        continue;
                }
            }
        }

        private Course GetUserInputForNewCourse()
        {
            while (true)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("* Enter a course :) *");
                Console.WriteLine("=====================");
                Console.Write("Enter a name [and press Enter]: ");
                var name = Console.ReadLine();
                Console.Write("Enter a description [and press Enter]: ");
                var description = Console.ReadLine();
                Console.Write("Enter a start date in format (dd/MM/yyyy) [and press Enter]: ");
                var startDate = this.DatePareser();
                Console.Write("Enter a end date in format (dd/MM/yyyy) [and press Enter]: ");
                var endDate = this.DatePareser();
                Console.Write("Enter a price [and press Enter]: ");
                var price = Console.ReadLine();
                if (this.IsValidStringInput(name))
                {
                    try
                    {
                        var newCourse = new Course
                        {
                            Name = name,
                            Description = description,
                            StartDate = startDate,
                            EndDate = endDate,
                            Price = decimal.Parse(price)
                        };

                        return newCourse;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You insert some bad data! Please try again!");
                    } 
                }
            }
        }

        private Resource GetUserInputForNewResource()
        {
            var noExit = true;
            while (noExit)
            {
                Console.Write("Enter a name (minimum 5 symbols) [and press Enter]: ");
                var name = Console.ReadLine();
                var type = this.GetResourceType();
                Console.Write("Enter a link (minimum 5 symbols) [and press Enter]: ");
                var link = Console.ReadLine();
                if (this.IsValidStringInput(name) && this.IsValidStringInput(link))
                {
                    return new Resource
                    {
                        Link = link,
                        Name = name,
                        ResourceType = type
                    }; 
                }
                else
                {
                    Console.WriteLine("Your data is bad! This resourse can not be created.");
                    noExit = this.GetYesOrNoAnswer("again");
                }
            }

            return null;
        }

        private Student GetUserInputForNewStudent()
        {
            while (true)
            {
                Console.Write("Enter a name (more than 5 symbols) [and press Enter]*: ");
                var name = Console.ReadLine();
                Console.Write("Enter a phone number (more than 5 symbols) [and press Enter]*: ");
                var phone = Console.ReadLine();
                Console.Write("Enter a birthday in format (dd/MM/yyyy)[and press Enter]: ");
                var birthday = this.DatePareser();

                if (this.IsValidStringInput(name) && this.IsValidStringInput(phone))
                {
                    try
                    {
                        return new Student
                        {
                            Name = name,
                            BirthDay = birthday,
                            PhoneNumber = phone,
                            RegistrationDate = DateTime.Now
                        };
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Some of your data is bad! We can not add this data to Database!\n*   Please, try again!  *");
                    }
                }
                else
                {
                    Console.WriteLine("* The name or phone is shorter than 5 symbols *");
                    Console.WriteLine("         *    Plese try again     *          ");
                }
            } 
        }

        private bool IsValidStringInput(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 5)
            {
                return false;
            }
            return true;
        }

        private void PrintSuccesMessage()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Your data is added to database!");
            Console.WriteLine("*******************************");
        }

        private DateTime DatePareser()
        {
            while (true)
            {
                var date = Console.ReadLine();
                try
                {
                    var result = DateTime.ParseExact(date, Format, CultureInfo.InvariantCulture);
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("The date is in wrong format! Please try again!");
                }
            }
        }
    }
}
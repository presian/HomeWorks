namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemContext context)
        {
            AddResources(context);
            AddHomeworks(context);
            AddStudents(context);
            AddCourses(context);
            AddHomeworkSubmissions(context);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private void AddHomeworkSubmissions(StudentSystemContext db)
        {
            if (db.HomeworkSubmissions.Any())
            {
                return;
            }
            db.HomeworkSubmissions.AddRange(new HashSet<HomeworkSubmission>()
            {
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "C# Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "C# Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "C# Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "C# Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Peter Petrov"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Peter Petrov")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "Java Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "Java Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "Java Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "Java Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Peter Petrov"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Peter Petrov")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "JavaScript Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "JavaScript Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "JavaScript Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "JavaScript Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Peter Petrov"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Peter Petrov")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "C# Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "C# Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "C# Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "C# Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Todor Todorov"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Todor Todorov")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "Java Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "Java Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "Java Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "Java Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Todor Todorov"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Todor Todorov")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "JavaScript Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "JavaScript Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "JavaScript Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "JavaScript Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Todor Todorov"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Todor Todorov")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "C# Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "C# Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "C# Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "C# Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Alex Toshev"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Alex Toshev")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "Java Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "Java Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "Java Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "Java Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Alex Toshev"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Alex Toshev")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                },
                new HomeworkSubmission
                {
                    Course = db.Courses.FirstOrDefault(c => c.Name == "JavaScript Basics"),
                    CourseId = db.Courses
                        .Where(c => c.Name == "JavaScript Basics")
                        .Select(c => c.Id)
                        .FirstOrDefault(),
                    Homework = db.Homeworks
                        .FirstOrDefault(h => h.Content == "JavaScript Basics"),
                    HomeworkId = db.Homeworks
                        .Where(h => h.Content == "JavaScript Basics")
                        .Select(h => h.Id)
                        .FirstOrDefault(),
                    Student = db.Students.FirstOrDefault(s => s.Name == "Alex Toshev"),
                    StudentId = db.Students
                        .Where(s => s.Name == "Alex Toshev")
                        .Select(s => s.Id)
                        .FirstOrDefault()
                }
            });
            db.SaveChanges();
        }

        private void AddCourses(StudentSystemContext db)
        {
            if (db.Courses.Any())
            {
                return;
            }

            db.Courses.AddRange(new HashSet<Course>()
            {
                new Course
                {
                    Description = "C# for begginers",
                    EndDate = new DateTime(2015, 7, 12),
                    Name = "C# Basics",
                    Price = 150m,
                    Resources = new HashSet<Resource>()
                    {
                        db.Resources.Single(r=>r.Name == "SoftUni")
                    },
                    StartDate = new DateTime(2015, 4, 12),
                    Students = db.Students.ToList(),
                    Submissions = db.HomeworkSubmissions
                        .Where(h => h.Course.Name == "C# Basics").ToList()
                },
                new Course
                {
                    Description = "Java for begginers",
                    EndDate = new DateTime(2015, 12, 1),
                    Name = "Java Basics",
                    Price = 150m,
                    Resources = new HashSet<Resource>()
                    {
                        db.Resources.Single(r=>r.Name == "CodeAcademy")
                    },
                    StartDate = new DateTime(2015, 8, 3),
                    Students = db.Students.ToList(),
                    Submissions = db.HomeworkSubmissions
                        .Where(h => h.Course.Name == "Java Basics").ToList()
                },
                new Course
                {
                    Description = "JavaScript for begginers",
                    EndDate = new DateTime(2016, 3, 8),
                    Name = "JavaScript Basics",
                    Price = 150m,
                    Resources = db.Resources.Where(r=>r.Name != "SoftUni" && r.Name != "CodeAcademy").ToList(),
                    StartDate = new DateTime(2015, 12, 20),
                    Students = db.Students.ToList(),
                    Submissions = db.HomeworkSubmissions
                        .Where(h => h.Course.Name == "JavaScript Basics").ToList()
                }
            });

            db.SaveChanges();
        }

        private void AddStudents(StudentSystemContext db)
        {
            if (db.Students.Any())
            {
                return;
            }

            db.Students.AddRange(new HashSet<Student>()
            {
                new Student
                {
                    BirthDay = new DateTime(1986, 4, 12),
                    Courses = db.Courses.ToList(),
                    Name = "Peter Petrov",
                    PhoneNumber = "+359 888 888 888",
                    RegistrationDate = new DateTime(2014, 1, 3)
                },
                new Student
                {
                    BirthDay = new DateTime(1988, 7, 23),
                    Courses = db.Courses.ToList(),
                    Name = "Todor Todorov",
                    PhoneNumber = "+359 999 999 999",
                    RegistrationDate = new DateTime(2014, 2, 1)
                },
                new Student
                {
                    BirthDay = new DateTime(2000, 4, 8),
                    Courses = db.Courses.ToList(),
                    Name = "Alex Toshev",
                    PhoneNumber = "+359 777 777 777",
                    RegistrationDate = new DateTime(2014, 4, 8)
                }
            });

            db.SaveChanges();
        }

        private void AddHomeworks(StudentSystemContext db)
        {
            if (db.Homeworks.Any())
            {
                return;
            }

            db.Homeworks.AddRange(new HashSet<Homework>()
            {
                new Homework
                {
                    Content = "C# Basics",
                    DateTime = new DateTime(2015, 2, 15),
                    HomeworkContentType = HomeworkContentType.ApplicationPDF
                },
                new Homework
                {
                    Content = "Java Basics",
                    DateTime = new DateTime(2015, 2, 18),
                    HomeworkContentType = HomeworkContentType.ApplicatinZIP
                },
                new Homework
                {
                    Content = "JavaScript Basics",
                    DateTime = new DateTime(2015, 3, 1),
                    HomeworkContentType = HomeworkContentType.ApplicatinZIP
                }
            });

            db.SaveChanges();
        }

        private void AddResources(StudentSystemContext db)
        {
            if (db.Resources.Any())
            {
                return;
            }

            db.Resources.AddRange(new HashSet<Resource>()
            {
                new Resource
                {
                    Link = "www.google.com",
                    Name = "Google",
                    ResourceType = ResourceType.Other
                },
                new Resource
                {
                    Link = "www.softuni.bg",
                    Name = "SoftUni",
                    ResourceType = ResourceType.Other
                },
                new Resource
                {
                    Link = "www.YouTube.com",
                    Name = "YouTube",
                    ResourceType = ResourceType.Video
                },
                new Resource
                {
                    Name = "Telerik",
                    Link = "http://telerikacademy.com/",
                    ResourceType = ResourceType.Other
                },
                new Resource
                {
                    Name = "CodeAcademy",
                    Link = "http://www.codecademy.com/",
                    ResourceType = ResourceType.Other
                }
            });

            db.SaveChanges();
        }
    }
}
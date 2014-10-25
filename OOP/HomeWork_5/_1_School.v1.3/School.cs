//Problem 1.	School
//We are given a school. In the school, there are classes of students. 
//•	Each class has a set of teachers. 
//•	Each teacher teaches a set of disciplines. 
//•	Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and students. Both teachers and students are people. Students, classes, teachers and disciplines have details (optional field).
//Your task is to identify the classes (in terms of OOP) and their members, encapsulate their fields, define the class hierarchy (inherit shared data and functionality) and create a class diagram with Visual Studio.


using System.Collections.Generic;

namespace _1_School.v1._3
{
    class School
    {
        private IList<Class> classes;

        public School(List<Class> classes)
        {
            this.classes = classes;
        }

        public IList<Class> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }
        static void Main()
        {
            //Student danailov = new Student("Presian Danailov");
            //Student georgiev = new Student("Georgi Georgiev");
            //Teacher nakov = new Teacher("Svetlin Nakov");
            //Teacher karamfilov = new Teacher("Vladi Karamfilov");
            //Discipline oop = new Discipline("OOP", 35);
            //Discipline javaBasics = new Discipline("Java Basics", 35);
            //Discipline cSharpBasics = new Discipline("C# Basics", 35);
            //Class a1 = new Class("Level2 - Evening");
            //a1.TeacherOfThisClass.Add(nakov);
            //a1.TeacherOfThisClass.Add(karamfilov);
            //a1.StudentsOfThisClass.Add(danailov);
            //a1.StudentsOfThisClass.Add(georgiev);
            //danailov.StudentNumber = 151;
            //georgiev.StudentNumber = 253;
            //nakov.TeacherDisciplines.Add(oop);
        }

    }
}

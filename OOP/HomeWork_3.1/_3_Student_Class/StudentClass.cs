using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Student_Class
{
    class StudentClass
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pesho", 28);
            student.Name = "Gosho";
            student.Age = 30;
        }
    }
}

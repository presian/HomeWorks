using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Student_Class
{
    public delegate void MyEventHandler(object sender, PropertyChangedEventArgs e);
    class Student
    {
        private string name;
        private int age;
        public event MyEventHandler ChangeProperty;

        public string Name
        {
            get { return name; }
            set
            {
                var ev = new PropertyChangedEventArgs { OldName = name, Name = value, ChangeProperty = "Name" };
                this.name = value;
                this.OnChange(this, ev);
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                var ev = new PropertyChangedEventArgs { OldAge = this.age, Age = value, ChangeProperty = "Age" };
                age = value;
                this.OnChange(this, ev);
            }
        }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.ChangeProperty += OutPut;
        }

        protected void OnChange(object sender, PropertyChangedEventArgs e)
        {
            if (ChangeProperty != null)
            {
                ChangeProperty(sender, e);
            }
        }

        public void OutPut(object sender, PropertyChangedEventArgs e)
        {
            switch (e.ChangeProperty)
            {
                case "Name": Console.WriteLine("Property changed: {0} (from {1} to {2})", e.ChangeProperty, e.OldName, e.Name); break;
                case "Age": Console.WriteLine("Property changed: {0} (from {1} to {2})", e.ChangeProperty, e.OldAge, e.Age); break;
            }
        }
    }
}

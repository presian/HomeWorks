using System;
using System.Collections.Generic;

namespace _4_Company_Hierarchy
{
    class CompanyHierarchyMainClass
    {
        static void Main()
        {
            IList<Employee> theFirm = new List<Employee>();
            SalesEmployee pesho = new SalesEmployee("Pesho", "Goshev", 8806041256, 2500m, Department.Sales,
                new List<Sale>()
                {
                    new Sale("ReSharper", new DateTime(2014, 2, 2), 150), 
                    new Sale("StyleCop", new DateTime(2011, 2, 2), 15),
                    new Sale("Aptana", new DateTime(2008,8,2), 50 )
                });
            SalesEmployee nasko = new SalesEmployee("Atanas", "Todorov", 9009041256, 2500m, Department.Sales,
                new List<Sale>()
                {
                    new Sale("ReSharper", new DateTime(2014, 2, 2), 150),
                    new Sale("StyleCop", new DateTime(2011, 2, 2), 15),
                    new Sale("Aptana", new DateTime(2008, 8, 2), 50)
                });
            DeveloperEmployee toshko = new DeveloperEmployee("Todor", "Todorov", 9009041256, 2500m, Department.Production,
                    new List<Project>()
                    {
                        new Project("ReSharper",new DateTime(2012, 2, 2),ProjectState.Open,"Mega Cool"),
                        new Project("StyleCop", new DateTime(2010, 1, 2),ProjectState.Open,"Mega Cool"),
                        new Project("Aptana", new DateTime(2006,8,2),ProjectState.Close,"So-so")
                    });
            DeveloperEmployee gencho = new DeveloperEmployee("Evgenis", "Vasilev", 8501041256, 2500m, Department.Production,
                    new List<Project>()
                    {
                        new Project("ReSharper",new DateTime(2012, 2, 2),ProjectState.Open,"Mega Cool"),
                        new Project("StyleCop", new DateTime(2010, 1, 2),ProjectState.Open,"Mega Cool"),
                        new Project("Aptana", new DateTime(2006,8,2),ProjectState.Close,"So-so")
                    });
            Manager ceco = new Manager("Cvetan", "Gogov", 8008041257, 4000m, Department.Marketing,
                new List<Employee>() { gencho, toshko, nasko, pesho });
            theFirm.Add(pesho);
            theFirm.Add(nasko);
            theFirm.Add(toshko);
            theFirm.Add(gencho);
            theFirm.Add(ceco);
            foreach (var employee in theFirm)
            {
                Console.WriteLine(employee);
            }


            //Employee a = new Employee("Pesho", "Goshev", 8806041256, 2500m, Department.Accounting);
            //Manager b = new Manager("Pesho", "Goshev", 8806041256, 2500m, Department.Accounting, new List<Employee>() { a, a });
            //DeveloperEmployee az = new DeveloperEmployee("Pesho", "Goshev", 8806041256, 2500m, Department.Accounting, new List<Project>() { new Project("a", new DateTime(2008, 12, 25), ProjectState.Open, "N/A"), new Project("b", new DateTime(2008, 12, 25), ProjectState.Open, "N/A") });
            //Console.WriteLine(az);
        }
    }
}

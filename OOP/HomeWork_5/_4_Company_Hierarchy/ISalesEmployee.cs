using System.Collections.Generic;

namespace _4_Company_Hierarchy
{
    internal interface ISalesEmployee
    {
        IList<Sale> SalesOfEmployee { get; set; }
        decimal Salary { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        long Id { get; set; }
        string ToString();
    }
}
using System;

namespace _4_Company_Hierarchy
{
    internal interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
        string ToString();
    }
}
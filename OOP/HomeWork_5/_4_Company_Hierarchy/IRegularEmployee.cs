namespace _4_Company_Hierarchy
{
    internal interface IRegularEmployee
    {
        string ToString();
        decimal Salary { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        long Id { get; set; }
    }
}
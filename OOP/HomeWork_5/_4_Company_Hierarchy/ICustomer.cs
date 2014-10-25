namespace _4_Company_Hierarchy
{
    internal interface ICustomer
    {
        decimal CustomerAmount { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        long Id { get; set; }
        string ToString();
    }
}
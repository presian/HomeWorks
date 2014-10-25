namespace _4_Company_Hierarchy
{
    internal interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        long Id { get; set; }
        string ToString();
    }
}
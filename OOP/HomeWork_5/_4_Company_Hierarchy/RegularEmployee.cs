namespace _4_Company_Hierarchy
{
    class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string firstName, string lastName, long id, decimal salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

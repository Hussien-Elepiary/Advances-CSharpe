namespace Session_01.Employee
{
    public struct EmployeeStruct:IComparable<EmployeeStruct>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(EmployeeStruct other)
        {
            return Salary.CompareTo(other.Salary);
        }

        public override string ToString()
        {
            return $"{ID} :::: {Name} :::: {Salary:c}";
        }
    }
}
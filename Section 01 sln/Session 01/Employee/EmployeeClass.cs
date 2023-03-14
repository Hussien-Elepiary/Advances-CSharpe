namespace Session_01.Employee
{
    public class EmployeeClass : IComparable<EmployeeClass>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{ID} :::: {Name} :::: {Salary:c}";
        }
        public override bool Equals(object? obj)
        {
            // EmployeeClass other = (EmployeeClass) obj; // Not Safe

            // is conditional operator 
            /// 1 obj is point // can be handled
            /// 2 obj is an object from another class inheriting form Point // can`t be handled
            /// 3 obj is null // can be handled
            /// 4 it`s a conditon if true it converts if else retures false // can`t be handled if false is not needed in this case

            // as Casting Operator
            
            EmployeeClass other = obj as EmployeeClass; //Casting will succed if Obj is EmployeeClass

            if (other == null) return false;
            return ID == other.ID && Name == other.Name && Salary == other.Salary;
        }

        public int CompareTo(EmployeeClass? other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
        }
    }
}

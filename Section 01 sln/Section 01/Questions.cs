using Session_01.Employee;
using Session_01.Point;
using Session_01;
using Ginaric_and_Non_Ginaric_Collections;

namespace Section_01
{
    internal class Questions
    {
        public static void NonGinaricSwapExamples()
        {

            int x = 1; int y = 2;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            Helper.SWAP(ref x, ref y);
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            Console.WriteLine();
            double k = 2; double v = 3;
            Console.WriteLine($"k = {k}");
            Console.WriteLine($"v = {v}");
            Helper.SWAP(ref k, ref v);
            Console.WriteLine($"k = {k}");
            Console.WriteLine($"v = {v}");
            Console.WriteLine();
            Point2D P1 = new Point2D(1, 1);
            Point2D P2 = new Point2D(2, 2);
            Console.WriteLine($"P1 = {P1}");
            Console.WriteLine($"P2 = {P2}");
            Helper.SWAP(ref P1, ref P2);
            Console.WriteLine($"P1 = {P1}");
            Console.WriteLine($"P2 = {P2}");
            Console.WriteLine();
        }

        public static void GinaricSwapExamples()
        {
            int x = 1; int y = 2;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            HelperGenaric<int>.SWAP(ref x, ref y);
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            Console.WriteLine();
            double k = 2; double v = 3;
            Console.WriteLine($"k = {k}");
            Console.WriteLine($"v = {v}");
            HelperGenaric<double>.SWAP(ref k, ref v);
            Console.WriteLine($"k = {k}");
            Console.WriteLine($"v = {v}");
            Console.WriteLine();
            Point2D P1 = new Point2D(1, 1);
            Point2D P2 = new Point2D(2, 2);
            Console.WriteLine($"P1 = {P1}");
            Console.WriteLine($"P2 = {P2}");
            HelperGenaric<Point2D>.SWAP(ref P1, ref P2);
            Console.WriteLine($"P1 = {P1}");
            Console.WriteLine($"P2 = {P2}");
            Console.WriteLine();
        }

        public static void Equality()
        {
            // in class .Equals Works on the refranece not the values in the object it self 
            Console.WriteLine("in class .Equals Works on the refranece not the values in the object it self\n");
            Point2D P1 = new Point2D(1, 1);
            Point2D P2 = new Point2D(1, 1);
            Console.WriteLine($"Class .Equlas: {P1.Equals(P2)}");
            //in stract it works on the values
            Console.WriteLine("\nin stract it works on the values\n");
            EmployeeStruct Emp3 = new EmployeeStruct() { ID = 10, Name = "Ahmed", Salary = 7_000 };
            EmployeeStruct Emp4 = new EmployeeStruct() { ID = 10, Name = "Ahmed", Salary = 7_000 };
            Console.WriteLine($"Struct .Equlas: {Emp3.Equals(Emp4)}");

            // Cus of that we can override the .Equals method in the class to make the equlity in the values
            ///public override bool Equals(object? obj)
            ///{
            ///    EmployeeClass other = obj as EmployeeClass;
            ///    return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;
            ///}
        }

        public static void Search()
        {
            EmployeeStruct Emp1 = new EmployeeStruct() { ID = 10, Name = "Ahmed", Salary = 7_000 };
            EmployeeStruct Emp2 = new EmployeeStruct() { ID = 20, Name = "Ahmed", Salary = 20_000 };
            EmployeeStruct Emp3 = new EmployeeStruct() { ID = 30, Name = "Ahmed", Salary = 30_000 };

            EmployeeStruct[] employees = new EmployeeStruct[] { Emp1, Emp2 };

            Console.WriteLine(HelperGenaric<EmployeeStruct>.SearchArray(employees, Emp3));

            EmployeeStruct[] employees2 = new EmployeeStruct[] { Emp1, Emp2, Emp3 };

            Console.WriteLine(HelperGenaric<EmployeeStruct>.SearchArray(employees2, Emp3));
        }

        public static void Sorting()
        {
            EmployeeStruct Emp1 = new EmployeeStruct() { ID = 20, Name = "Ahmed", Salary = 20_000 };
            EmployeeStruct Emp2 = new EmployeeStruct() { ID = 10, Name = "Ahmed", Salary = 7_000 };
            EmployeeStruct Emp3 = new EmployeeStruct() { ID = 30, Name = "Ahmed", Salary = 30_000 };
            EmployeeStruct Emp4 = new EmployeeStruct() { ID = 20, Name = "Ahmed", Salary = 20_000 };

            EmployeeStruct[] employees2 = new EmployeeStruct[] { Emp1, Emp2, Emp3, Emp4 };

            foreach (EmployeeStruct emp in employees2)
            {
                Console.WriteLine(emp);
            }

            HelperGenaric<EmployeeStruct>.BubbleSort(employees2);

            Console.WriteLine("\nAfter Sorting\n");
            foreach (EmployeeStruct emp in employees2)
            {
                Console.WriteLine(emp);
            }
        }

        public static void NonGenericCollections()
        {
            int Qnumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose A Question From The Folowing:\n1. ArrayList. \n2. SortedList \n3. Stack \n4. Queue \n5. Hashtable");
                Console.Write("Enter a number : ");
            } while (!int.TryParse(Console.ReadLine(), out Qnumber));

            Console.Clear();
            switch (Qnumber)
            {
                case 1:
                    Non_Ginaric_Collections.ArrayListExample();
                    break;
                case 2:
                    Non_Ginaric_Collections.SortedListExample();    
                    break;
                case 3:
                    Non_Ginaric_Collections.StackExample();
                    break;
                case 4:
                    Non_Ginaric_Collections.QueueExample();
                    break;
                case 5:
                    Non_Ginaric_Collections.HashtableExample();
                    break;
            }
        }

        public static void GenericCollections()
        {
            int Qnumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose A Question From The Folowing:\n1. List. \n2. Dictionary. \n3. SortedList. \n4. Queue \n5. Stack.\n6. SortedDictionary");
                Console.Write("Enter a number : ");
            } while (!int.TryParse(Console.ReadLine(), out Qnumber));

            Console.Clear();
            switch (Qnumber)
            {
                case 1:
                    Ginaric_Collections.ListExample();
                    break;
                case 2:
                    Ginaric_Collections.DictionaryExample();
                    break;
                case 3:
                    Ginaric_Collections.SortedListExample();
                    break;
                case 4:
                    Ginaric_Collections.QueueExample();
                    break;
                case 5:
                    Ginaric_Collections.StackExample();
                    break;
                case 6:
                    Ginaric_Collections.SortedDictionaryExample();
                    break;
            }
        }
    }
}


using Ginaric_and_Non_Ginaric_Collections;
using Session_01;
using Session_01.Employee;
using Session_01.Point;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Section_01
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Press 'E' to Exit Press 'S' to Start: ");
            DontStop(Console.ReadLine());
        }
        public static void DontStop(string x)
        {

            if (x.ToUpper() == "E")
            {
                Environment.Exit(0);
            }
            else if (x.ToUpper() == "S")
            {
                StartPoint();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("please Type E or S");
                Main();
            }
        }
        public static void StartPoint()
        {
            int Qnumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose A Question From The Folowing:\n1. SWAP With Out Ginarics. \n2. SWAP With Ginarics \n3. Equality \n4. Search \n5. Bubble-Sorting \n6. Non Generic Collections\n7. Generic Collections");
                Console.Write("Enter a number : ");
            } while (!int.TryParse(Console.ReadLine(), out Qnumber));


            Console.Clear();
            switch (Qnumber)
            {
                case 1:
                    Console.WriteLine("This is a simple example for Swaping.\nby making overriding for the same method;\nbut this is bad way cus its making the same thing repeating the code.\n");
                    Questions.NonGinaricSwapExamples();
                    Console.WriteLine("\npublic static void SWAP (ref int X , ref int Y){}\npublic static void SWAP (ref double X, ref double Y){}\npublic static void SWAP (ref Point2D X, ref Point2D Y){}\n Thanks");
                    break;
                case 2:
                    Console.WriteLine("This is a simple example for Swaping.\nby using ginarics implmented in 2005 C#2;\n");
                    Questions.GinaricSwapExamples();
                    Console.WriteLine("\npublic static void SWAP<T> (ref <T> X , ref <T> Y){}\n Thanks");
                    break;
                case 3:
                    Questions.Equality();
                    break;
                case 4:
                    Questions.Search();
                    break;
                case 5:
                    Questions.Sorting();
                    break;
                case 6:
                    Questions.NonGenericCollections();
                    break;
                case 7:
                    Questions.GenericCollections();
                    break;
            }

            Console.ReadLine();
            Console.Clear() ;
            Main();
        }
    }
}
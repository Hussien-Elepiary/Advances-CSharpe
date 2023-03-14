using System.Collections;

namespace Ginaric_and_Non_Ginaric_Collections
{

    /// <summary>
    /// Non Ginaric Colloections are data types that can contain any value or (Key, value) of any type in the same Collection 
    /// like ArrayList | SortedList | Stack | Queue | Hashtable
    /// 
    /// there are good uses for it if you want a container that containe any data of any datatype and handling it later but you have to becareful 
    /// while useing it cus it can make a lot of errors in the runtime so you have to handle every posible problem coming from it if you are calculating somthing or making a query of some other data... 
    /// </summary>
    public class Non_Ginaric_Collections
    {
        /// ArrayList
        /// SortedList
        /// Stack
        /// Queue
        /// Hashtable

        ///<summary>
        ///ArrayList stores objects of any type like an array. 
        ///However, there is no need to specify the size of the ArrayList like with an array as it grows automatically.
        ///</summary>

        public static void ArrayListExample()
        {
            Console.WriteLine("ArrayList is a data type that makes a dynamic array that can hold any type of data in it \nthat mean it can hold \n1. string\n2. int\n3. bool\nin the same list with no restrictions\n");

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hamada");
            list.Add(1.5);
            list.Add(1.5m);
            list.Add(1.5f);
            list.Add(true);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\nthe Way of it handling the dynaimc size it makes a new array with the same old data \nand multiplying the size or the cap it self if the cap was 4 it makes it 8 and if 8 makes it 16 etc...");
        }

        ///<summary>
        ///SortedList stores (key and value) pairs. 
        ///It automatically arranges elements in ascending order of key by default. C# includes both, 
        ///generic and non-generic SortedList collection.
        ///</summary>

        public static void SortedListExample() 
        {
            SortedList list = new SortedList(); // it can hold any data type in it like the array list but in pairs (key, value) and i automaticly sorts it asce by the key,
            list.Add(1,"1");
            /*list.Add("aly", 2);*/ // throws an exiption of sorting the elemnt in the run time
            /*list.Add('A', 3);*/     // throws an exiption of sorting the elemnt in the run time
            list.Add(4, "4");
            list.Add(2, "2");
            list.Add(3, "3");
            list.Add(5, "5");
            for (int i = 0; i <= list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        ///<summary>
        ///Stack stores the values in LIFO style (Last In First Out).
        ///It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values. 
        ///C# includes both, generic and non-generic Stack.
        ///</summary>

        public static void StackExample()
        {
            Stack list = new Stack();
            list.Push("A");
            list.Push('B');
            list.Push(1);
            list.Push(1.5);
            list.Push(1.5m);
            list.Push(1.5f);

            foreach (var item in list)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine("as you can see stack way of arranging the data is Last In First Out");
        }

        ///<summary>
        ///Queue stores the values in FIFO style (First In First Out). It keeps the order in which the values were added.
        ///It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection.
        ///C# includes generic and non-generic Queue.
        ///</summary>
        
        public static void QueueExample() 
        {
            Queue list = new Queue();
            list.Enqueue("A");
            list.Enqueue('B');
            list.Enqueue(1);
            list.Enqueue(1.5);
            list.Enqueue(1.5m);
            list.Enqueue(1.5f);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("as you can see stack way of arranging the data is First In First Out");
        }

        ///<summary>
        ///Hashtable stores key and value pairs. It retrieves the values by comparing the hash value of the keys.
        ///</summary>

        public static void HashtableExample()
        {
            Hashtable list = new Hashtable();
            list.Add(1, "A");
            list.Add("A", 2);
            list.Add('B', 1.5);

            /// in the following hashtable you cannot make a for loop 
            ///  to get all the data in the list it self but you can get it by calling it with the key asigned to it`s value 
            Console.WriteLine(list[1]); 
            Console.WriteLine(list["A"]);
            Console.WriteLine(list['B']);
        }

    }
}

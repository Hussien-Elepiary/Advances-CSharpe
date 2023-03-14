using System.Collections;
using System.Collections.Generic;

namespace Ginaric_and_Non_Ginaric_Collections
{
    public class Ginaric_Collections
    {
        /// <summary>
        /// Generic List<T> contains elements of specified type. It grows automatically as you add elements in it.
        /// </summary>
        public static void ListExample()
        {
            Console.WriteLine("List is a data type that makes a dynamic array that can hold any type of data in it but with a ginaric data type like\n i can put strings only or int only it makes a dynamic array of int or a dynamic array of string etc...\n");

            List<int> list = new List<int>(); // this list can hold ony int32 
            list.Add(1);
            list.AddRange(new int[]{ 2, 3, 4, 5 });

            /*list.Add("Hamada");*/ // not valid
            /*list.Add(1.5);     */ // not valid
            /*list.Add(1.5m);    */ // not valid
            /*list.Add(1.5f);    */ // not valid
            /*list.Add(true);    */ // not valid

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("the Way of it handling the dynaimc size it makes a new list with the same old data \nand multiplying the size or the cap it self if the cap was 4 it makes it 8 and if 8 makes it 16 etc...\n");
        }

        /// <summary>
        /// Dictionary<TKey,TValue> contains key-value pairs.
        /// </summary>
        public static void DictionaryExample()
        { 
            //the Dictionary is like HashTable but has rules on the Key Data Type And Value DataType 
            //The Rules (You can set the Data Type) that you Want For it 
            Dictionary<int,string> dict = new Dictionary<int,string>();

            dict.Add(1, "A");
            /*dict.Add("A", 2);  */ // Not Valid
            /*dict.Add('B', 1.5);*/ // Not Valid
            dict.Add(2, "B");
            dict.Add(3, "C");
            dict.Add(4, "D");

            Dictionary<string,int> dict2 = new Dictionary<string,int>();
            dict2.Add("A", 1);
            dict2.Add("B", 2);
            dict2.Add("C", 3);
            dict2.Add("D", 4);

            Console.WriteLine("Hint IN ForEach You Can loop on the Dic And Get (Key ,Value) Because Of the Way ForEach is Handleing the List or the Dict in this Case:\nForEache is taking the object it self in the Dict\n");

            Console.WriteLine("Dict<int,string>");
            foreach (var item in dict)
            {
                Console.WriteLine($"Key: {item.Key} || Value: {item.Value}" );
            }
            Console.WriteLine("\nDict2<stirng,int>");
            foreach (var item in dict2)
            {
                Console.WriteLine($"Key: {item.Key} || Value: {item.Value}");
            }
            Console.WriteLine("\nUnlike For: For is calling the Value by the Key but that only works if the Key Was (INT) or any data type that you can make an itration out of like (int,double,etc...)\n");
            for (int i = 1; i <= dict.Count; i++)
            {
                Console.WriteLine($"Value: {dict[i]}");
            }
            //for (int i = 1; i <= dict2.Count; i++)
            //{
            /*    Console.WriteLine($"Value: {dict2[i]}");*/// as you can see not valid cus the Key is string..
            //}
            Console.WriteLine("As you can see in the last Example that the Dictionary is like the HashTable in the nonGeneric Collections..");
        }

        /// <summary>
        /// SortedList stores key and value pairs. It automatically adds the elements in ascending order of key by default.
        /// </summary>
        public static void SortedListExample() 
        {
            Console.WriteLine("To Cut it Short Sorted List is like Dictionary but Sorted Automaticly By KeyValue");
            SortedList<int,string> sortedList = new SortedList<int, string>();

            /*dict.Add("A", 2);  */ // Not Valid
            /*dict.Add('B', 1.5);*/ // Not Valid
            sortedList.Add(4, "D");
            sortedList.Add(3, "C");
            sortedList.Add(2, "B");
            sortedList.Add(1, "A");

            SortedList<char, string> sortedList2 = new SortedList<char, string>();

            sortedList2.Add('C', "C");
            sortedList2.Add('B', "B");
            sortedList2.Add('D', "D");
            sortedList2.Add('A', "A");

            Console.WriteLine("SortedList<int,string> sortedList = new SortedList<int, string>();\nKey is int ");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key} || Value: {item.Value}");
            }
            Console.WriteLine("\nSortedList<char, string> sortedList2 = new SortedList<char, string>();\nKey is char ");
            foreach (var item in sortedList2)
            {
                Console.WriteLine($"Key: {item.Key} || Value: {item.Value}");
            }
        }

        ///<summary>
        /// Queue<T> stores the values in FIFO style (First In First Out). 
        /// It keeps the order in which the values were added.
        /// It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection.
        ///</summary>
        public static void QueueExample() 
        {
            // this line means a Queue Of only ints
            Console.WriteLine("Queue<T> Works Just like Queue But more DataType Closed like i can make sure that the DataType that i need in it is only ints or Strings not Any(object?)...");
            Queue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            list.Enqueue(4);
            /*list.Enqueue("A"); */ // not valid
            /*list.Enqueue('B'); */ // not valid
            /*list.Enqueue(1.5); */ // not valid
            /*list.Enqueue(1.5m);*/ // not valid
            /*list.Enqueue(1.5f);*/ // not valid

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("as you can see stack way of arranging the data is First In First Out");
        }

        ///<summary>
        /// Stack<T> stores the values as LIFO (Last In First Out). 
        /// It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values.
        ///</summary>
        public static void StackExample() 
        {

            Console.WriteLine("Stack<T> is the same as stack LIFO (but have DataType Control Point)");

            Stack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            /*list.Push("A"); */ //not Valid
            /*list.Push('B'); */ //not Valid
            /*list.Push(1.5); */ //not Valid
            /*list.Push(1.5m);*/ //not Valid
            /*list.Push(1.5f);*/ //not Valid

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("as you can see stack way of arranging the data is Last In First Out");
        }

        ///<summary>
        ///The SortedDictionary<TKey, TValue> generic class is a binary search tree with O(log n) retrieval, 
        ///where n is the number of elements in the dictionary. In this, it is similar to the SortedList<TKey, TValue> 
        ///generic class. The two classes have similar object models, and both have O(log n) retrieval. 
        ///Where the two classes differ is in memory use and speed of insertion and removal:
        ///
        ///SortedList<TKey, TValue> uses less memory than SortedDictionary<TKey,TValue>.
        ///
        ///SortedDictionary<TKey, TValue> has faster insertion and removal operations for unsorted data,
        ///O(log n) as opposed to O(n) for SortedList<TKey, TValue>.
        ///
        ///If the list is populated all at once from sorted data, SortedList<TKey,TValue> 
        ///is faster than SortedDictionary<TKey, TValue>.
        ///</summary>
        public static void SortedDictionaryExample() 
        {
            

            SortedDictionary<int, string> sortedList = new SortedDictionary<int, string>();

            /*dict.Add("A", 2);  */ // Not Valid
            /*dict.Add('B', 1.5);*/ // Not Valid
            sortedList.Add(4, "D");
            sortedList.Add(3, "C");
            sortedList.Add(2, "B");
            sortedList.Add(1, "A");

            SortedDictionary<char, string> sortedList2 = new SortedDictionary<char, string>();

            sortedList2.Add('C', "C");
            sortedList2.Add('B', "B");
            sortedList2.Add('D', "D");
            sortedList2.Add('A', "A");

            Console.WriteLine("SortedDictionary<int,string> sortedList = new SortedDictionary<int, string>();\nKey is int ");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key} || Value: {item.Value}");
            }
            Console.WriteLine("\nSortedDictionary<char, string> sortedList2 = new SortedDictionary<char, string>();\nKey is char ");
            foreach (var item in sortedList2)
            {
                Console.WriteLine($"Key: {item.Key} || Value: {item.Value}");
            }
        }
    }
}

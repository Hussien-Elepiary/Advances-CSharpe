using Library;
using Library.Helpers;

namespace Section_02
{
    internal class Program
    {
        
        static void Main()
        {
            
            int Number;

            do
            {
                Console.Write("Enter The Book Number You Want to Enter: ");
            } while (!int.TryParse(Console.ReadLine(),out Number));

            InPuts(Number);
        }

        public static void InPuts(int Count)
        {
            Func<Book, string> GetISBN = delegate (Book book) { return book.ISBN; };


            List<Book> books = new List<Book>();
            for (int i = 0; i < Count; i++)
            {
                Console.Clear();
                string ISBN, Title, Author;
                DateTime PubDate;
                decimal Price;
                do
                {
                    Console.Write("Enter Book ISBN: ");
                    ISBN = Console.ReadLine()??"";
                } while (ISBN == "");
                
                do
                {
                    Console.Write("Enter Book Title: ");
                    Title = Console.ReadLine() ?? "";
                } while (Title == "");

                do
                {
                    Console.Write("Enter Book Authors Split Between Each Author With ',': ");
                    Author = Console.ReadLine() ?? "";
                } while (Author == "");

                do
                {
                    Console.Write("Enter Book Publish Date With Your PC Date Format: ");
                } while (!DateTime.TryParse(Console.ReadLine(), out PubDate));

                do
                {
                    Console.Write("Enter Book Price: ");
                } while (!decimal.TryParse(Console.ReadLine(),out Price));

                books.Add(BooksBuilder(ISBN, Title, StringToArray(Author), PubDate, Price));
            }

            foreach (Book book in books)
            {
                LibraryEngine.ProcessBooks(books, (book) => string.Join(',', book.PublicationDate));
                LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
                LibraryEngine.ProcessBooks(books, GetISBN);
            }
        }


        private static Book BooksBuilder(string ISBN, string Title, string[] Authors, DateTime PublicationDate, decimal Price)
        {
            return new Book(ISBN, Title, Authors, PublicationDate, Price);
        }

        public static string[] StringToArray(string OutPut)
        {
            string[] X;
            X = OutPut.Split(',');
            return X;
        }
    }
}
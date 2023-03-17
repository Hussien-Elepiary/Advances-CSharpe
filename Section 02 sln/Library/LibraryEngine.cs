namespace Library
{
    public delegate string FuncBooks(Book book);
    public static class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, Func<Book,string> funcBook)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(funcBook(book));
            }
        }
    }
}

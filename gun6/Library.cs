namespace gun6
{
    internal class Library
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string title) 
        {
            foreach (Book book in books) 
            {
                if (book.Title == title)
                {
                    books.Remove(book);
                    return;
                }
            }
        }
        public Book? FindBook(string title) 
        {
            foreach (Book book in books) 
            {
                if (book.Title == title)
                    return book;
            }
            return null;
        }
        public void ShowBook() 
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void BorrowBook(string title, User user) 
        {
            Book? book = FindBook(title);
            if (book != null)
            {
                book.Borrow(user);  
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        public void ReturnBook(string title) 
        {
            Book? book = FindBook(title);
            if (book != null)
            {
                book.Return();
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}

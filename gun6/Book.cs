using gun6.Interfaces;

namespace gun6
{
    public class Book : IBorrowable, IReservable
    {
        public string Title;
        public string Author;
        public int Year;
        public bool IsBorrowed;

        public User? BorrowedBy { get; private set; } 
        public Book(string title, string author, int year, bool ısBorrowed)
        {
            Title = title;
            Author = author;
            Year = year;
            IsBorrowed=ısBorrowed;
        }
        public override string ToString()
        {
            return $"{Title} - {Author} ({Year})";
        } 

        public void Borrow(User user)
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                BorrowedBy = user;
                Console.WriteLine($"The book '{Title}' has been borrowed by {user.Name}.");
            }
            else
            {
                Console.WriteLine($"The book '{Title}' is already borrowed by {BorrowedBy?.Name}.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"{BorrowedBy?.Name} returned the book.");
                BorrowedBy = null;
            }
            else
            {
                Console.WriteLine($"The book '{Title}' was not borrowed.");
            }
        }

        public void Reserve()
        {
            Console.WriteLine($"The book '{Title}' has been reserved by {BorrowedBy?.Name}.");
        }
    }
}

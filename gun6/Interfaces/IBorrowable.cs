namespace gun6.Interfaces
{
    internal interface IBorrowable
    {
        void Borrow(User user);
        void Return();
    }
}

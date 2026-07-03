
namespace gun4
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount hesap1 = new BankAccount("123456", "ali", 1000);
            Console.WriteLine(hesap1);
            hesap1.ParaYatir(500);
            hesap1.ParaCek(300);

            BankAccount hesap2 = new BankAccount("654321", "veli", 2000);
            Console.WriteLine(hesap2);
            hesap2.ParaYatir(1000);
            hesap2.ParaCek(5000);

            hesap1.ParaTransferi(hesap2,200);
        }
    }
}
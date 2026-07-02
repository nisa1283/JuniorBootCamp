using System;

class gun2
{
    static void Main(string[] args)
    {
        bool devamMı = true;
        while (devamMı)
        {
            Console.WriteLine("Ne yapmak istersiniz?" +
                "\n a-Hesap Makinesi " +
                "\n b-Sayı Tek mi Çift mi Kontrolü " +
                "\n c-Faktöriyel hesaplama " +
                "\n d-Fibonacci Sayısı bulma " +
                "\n e-Asal sayı kontrolü");
            char secim = char.Parse(Console.ReadLine());
            
            switch (secim)
            {
                case 'a':
                    HesapMakinesi();
                    break;
                case 'b':
                    SayiTekCiftKontrol();
                    break;
                case 'c':
                    FaktoriyelHesaplama();
                    break;
                case 'd':
                    FibonacciSayisiBulma();
                    break;
                case 'e':
                    int sayi = SayiOku("Bir sayı giriniz: ");

                    bool sonuc = AsalMi(sayi);

                    if (sonuc)
                        Console.WriteLine("Asaldır.");
                    else
                        Console.WriteLine("Asal değildir.");
                    break;

            }

            Console.WriteLine("Başka bir işlem yapmak ister misiniz? (E/H)");
            string cevap = Console.ReadLine();
            if (cevap.ToUpper() != "E")
            {
                Console.WriteLine("Hesap makinesinden çıkılıyor. İyi günler!");
                devamMı = false;
            }

        }
    }
    static void HesapMakinesi()
    {

        Console.WriteLine("Hesap Makinesine hoşgeldiniz!");
        Console.WriteLine("Lütfen iki sayı giriniz:");
        int sayi1 = SayiOku("1. sayıyı giriniz:");
        int sayi2 = SayiOku("2. sayıyı giriniz:");
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: 1. Toplama 2. Çıkarma 3. Çarpma 4. Bölme");
        int secim = SayiOku("İşlem:");

        switch (secim)
        {
            case 1:
                Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                break;
            case 2:
                Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                break;
            case 3:
                Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                break;
            case 4:
                if (sayi2 != 0)
                {
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz.");
                }
                break;

            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }

    }
    static void SayiTekCiftKontrol()
    {
        Console.WriteLine("Sayı tek mi çift mi kontrolüne hoşgeldiniz!");
        int sayi = SayiOku("Lütfen sayı giriniz:");

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı tektir.");
        }
    }

    static void FaktoriyelHesaplama()
    {
        Console.WriteLine("Faktöriyel hesaplamaya hoşgeldiniz!");
        int sayi = SayiOku("Lütfen sayı giriniz:");
        
            int faktoriyel = 1;
            for (int j = 1; j <= sayi; j++)
            {
                faktoriyel *= j; 
            }
            Console.WriteLine($"{sayi}! = {faktoriyel}");
        

    }

    static void FibonacciSayisiBulma()
    {
        Console.WriteLine("Fibonacci sayısı bulmaya hoşgeldiniz!");
        int sayi = SayiOku("Lütfen sayı giriniz:");
        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci dizisi:");
        for (int i = 0; i < sayi; i++)
        {
            if (i <= 1)
                c = i;
            else
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.Write(c + " ");
        }
    }

    static bool AsalMi(int sayi)
    {
        if (sayi <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }

        return true;
    }
    static int SayiOku(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);

            string giris = Console.ReadLine();

            if (int.TryParse(giris, out int sayi))
            {
                return sayi;
            }

            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        }
    }

}      



bool devamMı = true;
while (devamMı)
{
    Console.WriteLine("Ne yapmak istersiniz? a-Hesap Makinesi b-Sayı Tek mi Çift mi Kontrolü c-Faktöriyel hesaplama d-Fibonacci Sayısı bulma" +
    "e-Asal sayı kontrolü");
    char secim = char.Parse(Console.ReadLine());

    switch (secim)
    {
        case 'a':

            Console.WriteLine("Hesap Makinesine hoşgeldiniz!");
            Console.WriteLine("Lütfen iki sayı giriniz:");
            int sayı1 = int.Parse(Console.ReadLine());
            int sayı2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: 1. Toplama 2. Çıkarma 3. Çarpma 4. Bölme");
            int secim1 = int.Parse(Console.ReadLine());

            switch (secim1)
            {
                case 1:
                    Console.WriteLine("Sonuç: " + (sayı1 + sayı2));
                    break;
                case 2:
                    Console.WriteLine("Sonuç: " + (sayı1 - sayı2));
                    break;
                case 3:
                    Console.WriteLine("Sonuç: " + (sayı1 * sayı2));
                    break;
                case 4:
                    if (sayı2 != 0)
                    {
                        Console.WriteLine("Sonuç: " + (sayı1 / sayı2));
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }break;

        case 'b':
            Console.WriteLine("Sayı tek mi çift mi kontrolüne hoşgeldiniz!");
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            break;

        case 'c':
            Console.WriteLine("Faktöriyel hesaplamaya hoşgeldiniz!");
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayiFaktoriyel = int.Parse(Console.ReadLine());

            for (int i = 1; i<= sayiFaktoriyel; i++)
            {
                int faktoriyel = 1;
                for (int j = 1; j <= i; j++)
                {
                    faktoriyel *= j;
                }
                Console.WriteLine($"{i}! = {faktoriyel}");
            }
            break;

        case 'd':
            Console.WriteLine("Fibonacci sayısı bulmaya hoşgeldiniz!");
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayiFibonacci = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacci dizisi:");
            for (int i = 0; i < sayiFibonacci; i++)
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
            break;
        case 'e':
            Console.WriteLine("Asal sayı kontrolüne hoşgeldiniz!");
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayiAsal = int.Parse(Console.ReadLine());
            bool asalMi = true;
            if (sayiAsal <= 1)
            {
                asalMi = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(sayiAsal); i++)
                {
                    if (sayiAsal % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
            }
            if (asalMi)
            {
                Console.WriteLine($"{sayiAsal} bir asal sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayiAsal} bir asal sayı değildir.");
            }
            break;

        default:
            Console.WriteLine("Geçersiz seçim.");
            break;
    }
    Console.WriteLine("Başka bir işlem yapmak ister misiniz? (E/H)");
    string cevap = Console.ReadLine();
    if (cevap.ToUpper() != "E")
    {
        Console.WriteLine("Hesap makinesinden çıkılıyor. İyi günler!");
        devamMı = false;
    }
    int Enbüyüksayı(int sayi1, int sayi2)
    {
       if (sayi1 > sayi2)
        return sayi1;
       else
        return sayi2;
    }
}
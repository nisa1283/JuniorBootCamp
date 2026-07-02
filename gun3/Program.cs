using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)

    {
        
        #region Dizi 
        int[] sayilar = { 12, 5, 8, 23, 41, 7 };

        int toplam = 0;

        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }

        Console.WriteLine(toplam);
        Console.WriteLine(toplam/sayilar.Length);

        int enBuyuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
        }
        Console.WriteLine(enBuyuk);

        int enKucuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi < enKucuk)
            {
                enKucuk = sayi;
            }
        }
        Console.WriteLine(enKucuk);

        #endregion

        #region List
        List<int> sayilarListesi = new List<int>(sayilar);
        Console.WriteLine("Lütfen listeye eklemek istediğiniz sayıları girin. Çıkmak için '-1' yazın.");

        // 2. Döngü ile kullanıcıdan veri isteyin
        while (true)
        {
            Console.Write("sayı girin: ");
            int girilenDeger = int.Parse(Console.ReadLine());

            // 3. Çıkış şartını kontrol edin
            if (girilenDeger == -1)
            {
                break;
            }

            // 4. Veriyi listeye ekleyin
            sayilarListesi.Add(girilenDeger);
        }

        // 5. Listeyi ekrana yazdırın
        Console.WriteLine("\n--- Girdiğiniz Sayılar ---");
        foreach (int sayi in sayilarListesi)
        {
            Console.WriteLine(sayi);
        }

        int elemanSayisi = sayilarListesi.Count;

        // Ekrana yazdırdık (Çıktı: 3 olacaktır)
        Console.WriteLine("Listedeki eleman sayısı: " + elemanSayisi);

        int enKucuk1 = sayilarListesi.Min();
        Console.WriteLine("En küçük değer: " + enKucuk1);

        int enBuyuk1 = sayilarListesi.Max();
        Console.WriteLine("En büyük değer: " + enBuyuk1);

        double ortalama = sayilarListesi.Average();
        Console.WriteLine("Ortalama: " + ortalama);
        #endregion
        

        #region Kelime Sayacı
        Dictionary<string, int> kelimeler = new Dictionary<string, int>();

        string metin = "Bugün hava çok güzel bugün gerçekten hava çok güzel";

        string[] dizi = metin.ToLower().Split(' ');

        foreach (string kelime in dizi)
        {

            if (kelimeler.ContainsKey(kelime))
            {
                kelimeler[kelime]++;
            }
            else
            {
                kelimeler[kelime] = 1;
            }
        }

        foreach (var item in kelimeler)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        #endregion

        #region HashSet ile Tekrar Eden Öğeleri Bulma
        int[] sayilar1 = { 5, 8, 2, 5, 9, 2, 7 };

        HashSet<int> benzersizler = new HashSet<int>();
        HashSet<int> tekrarEdenler = new HashSet<int>();

        foreach (int sayi in sayilar1)
        {
            // Eğer ekleme işlemi false dönerse, bu öğe daha önce eklenmiştir (tekrar ediyor)
            if (!benzersizler.Add(sayi))
            {
                tekrarEdenler.Add(sayi);
            }
        }

        // 2. Sonucu Ekrana Yazdır
        Console.WriteLine("Tekrar eden öğeler:");
        foreach (int tekrar in tekrarEdenler)
        {
            Console.WriteLine(tekrar);
        }
        #endregion
    }
}

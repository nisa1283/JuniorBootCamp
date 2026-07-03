namespace gun4
{
    internal class BankAccount
    {
        private string hesapNo;
        private string sahipAdi;
        private decimal bakiye;

        public BankAccount(string hesapNo, string sahipAdi, decimal bakiye)
        {
            this.hesapNo = hesapNo;
            this.sahipAdi = sahipAdi;
            if (bakiye < 0)
            {
                this.bakiye = 0;
            }
            else
            {
                this.bakiye = bakiye;
            }
        }
        public void HesapBilgileriniGoster()
        {
            Console.WriteLine("Hesap No: " + hesapNo);
            Console.WriteLine("Sahip Adı: " + sahipAdi);
            Console.WriteLine("Bakiye: " + bakiye);
        }
        public override string ToString()
        {
            // Geriye nesnenin bilgilerini içeren anlamlı bir metin döndürüyoruz.
            return "Hesap No: " + hesapNo + ", Sahip Adı: " + sahipAdi + ", Bakiye: " + bakiye;
        }

        public void ParaYatir(decimal miktar)
        {
            if (miktar <= 0)
            {
                Console.WriteLine("Yatırılacak miktar sıfır veya negatif olamaz.");
                return;
            }
            else
            {
                bakiye += miktar;
                Console.WriteLine(miktar + " TL yatırıldı. Yeni bakiye: " + bakiye);
            }    
        }

        public void ParaCek(decimal miktar)
        {
            if (miktar > 0)
            {
                if (miktar <= bakiye)
                {
                    bakiye -= miktar;
                    Console.WriteLine(miktar + " TL çekildi. Yeni bakiye: " + bakiye);
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye. İşlem gerçekleştirilemedi.");
                }
            }
            else
            {
                 Console.WriteLine("Çekilecek miktar sıfır veya negatif olamaz.");
            }

        }

        public void ParaTransferi(BankAccount hedefHesap, decimal miktar)
        {
            if (miktar > 0)
            {
                if (miktar <= bakiye)
                {
                    bakiye -= miktar;
                    hedefHesap.ParaYatir(miktar);
                    Console.WriteLine(miktar + " TL " + hedefHesap + " hesabına transfer edildi. Yeni bakiye: " + bakiye);

                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye. İşlem gerçekleştirilemedi.");
                }
            }
            else 
            {
                Console.WriteLine("Transfer edilecek miktar sıfır veya negatif olamaz.");
            }

        }
    }
}

using System;

namespace OdevUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Rastgele 10 adet sayı üretme
            Random randomsayi = new Random();
            int[] sayilar = new int[10];

            Console.WriteLine("--- Rastgele Üretilen Sayılar ---");
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = randomsayi.Next(1, 101);
                Console.WriteLine((i + 1) + ". Sayı: " + sayilar[i].ToString());
            }

            // 2. En büyük ve en küçük sayıyı, sırasını bulma
            int enb = sayilar[0];
            int enk = sayilar[0];
            int enbSira = 1;
            int enkSira = 1;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enb)
                {
                    enb = sayilar[i];
                    enbSira = i + 1;
                }

                if (sayilar[i] < enk)
                {
                    enk = sayilar[i];
                    enkSira = i + 1;
                }
            }

            Console.WriteLine("\n--- En Büyük ve En Küçük Değerler ---");
            Console.WriteLine("En büyük sayı: " + enb.ToString() + " (" + enbSira.ToString() + ". sırada)");
            Console.WriteLine("En küçük sayı: " + enk.ToString() + " (" + enkSira.ToString() + ". sırada)");

            // 3. Tek ve çift sayı adetleri
            int ciftAdet = 0;
            int tekAdet = 0;

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    ciftAdet++;
                }
                else
                {
                    tekAdet++;
                }
            }

            Console.WriteLine("\n--- Tek / Çift Adetleri ---");
            Console.WriteLine("Çift sayı adedi: " + ciftAdet.ToString());
            Console.WriteLine("Tek sayı adedi: " + tekAdet.ToString());

            // 4. Kullanıcıdan sayı alma ve filtreleme
            Console.Write("\nBir sayı giriniz: ");
            int kullaniciSayisi;

            while (!int.TryParse(Console.ReadLine(), out kullaniciSayisi))
            {
                Console.WriteLine("Lütfen sadece rakamla sayı girin.");
                Console.Write("Tekrar bir sayı giriniz: ");
            }

            Console.WriteLine("\nGirdiğiniz sayıdan (" + kullaniciSayisi.ToString() + ") büyük olan rastgele sayılar:");
            bool buyukVarMi = false;

            foreach (int sayi in sayilar)
            {
                if (sayi > kullaniciSayisi)
                {
                    Console.WriteLine(sayi.ToString());
                    buyukVarMi = true;
                }
            }

            if (!buyukVarMi)
            {
                Console.WriteLine("Girdiğiniz sayıdan daha büyük bir rastgele sayı üretilmemiş.");
            }
        }
    }
}

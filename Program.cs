        Random randomsayi = new Random();
        int[] sayilar = new int[10];

        Console.WriteLine("Üretilen 10 Sayı:");
        for (int i = 0; i < 10; i++)

        {
            sayilar[i] = randomsayi.Next(1, 101);
            Console.WriteLine(i + 1 + ". Sayı = " + sayilar[i]);
        }
        int enbuyuksayi = sayilar[0];
        int enkucuksayi = sayilar[0];
        int enbuyuksayisira = 1;
        int enkucuksayisira = 1;

        int ciftAdet = 0;
        int tekAdet = 0;

        for (int i = 0; i < 10; i++)
        {
            if (sayilar[i] > enbuyuksayi)
            {
                enbuyuksayi = sayilar[i];
                enbuyuksayisira = i + 1;
            }
            if (sayilar[i] < enkucuksayi)
            {
                enkucuksayi = sayilar[i];
                enkucuksayisira = i + 1;
            }
            if (sayilar[i] % 2 == 0)
            {
                ciftAdet++;
            }
            else
            {
                tekAdet++;
            }
        }
        Console.WriteLine("en büyük sayı: " + enbuyuksayi + " (" + enbuyuksayisira + ". sırada)");
        Console.WriteLine("en küçük sayı: " + enkucuksayi + " (" + enkucuksayisira + ". sırada)");
        Console.WriteLine("çift sayı adedi: " + ciftAdet);
        Console.WriteLine("tek sayı adedi: " + tekAdet);
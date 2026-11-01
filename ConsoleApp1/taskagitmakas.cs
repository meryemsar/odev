String[] objeler = new string[3] { "tas", "kagit", "makas" };
Boolean ObjeSectiMi = false;
int tur = 0;
string girilen = "";
int bilgisayarKazanmaAdeti = 0;
int kullaniciKazanmaAdeti = 0;
List<string> turSonucları = new List<string>();
while (true) {
    ObjeSectiMi = false;
    
    do {
        Console.Write("Taş, kağıt, makastan birini seçiniz. Oyun siz bitti yazana kadar devam edecektir. Hangisini seçiyorsunuz? : ");
        girilen = Console.ReadLine();
        
        if (girilen.ToLower() == "bitti") {
            break;
        }
        for (int i = 0; i < objeler.Length; i++)
        {
            if (girilen.ToLower() == objeler[i].ToLower()) {
                ObjeSectiMi = true;
                break;
            }
        }
        if (ObjeSectiMi == false)
        {
            Console.WriteLine("Lütfen taş, kağıt, makastan birini yazın.");
        }
    } while (ObjeSectiMi == false);
    if (ObjeSectiMi == false)
    {
        break;
    }
    tur += 1;

    int rastgeleSayi = Random.Shared.Next(0, 3);
    Console.WriteLine("Bilgisayarın seçimi : " + objeler[rastgeleSayi]);
    if (objeler[rastgeleSayi].ToLower() == girilen.ToLower()) {
        Console.WriteLine("Berabere");
        turSonucları.Add(tur.ToString() + ".tur :" + "berabere");
    }

    else if (objeler[rastgeleSayi].ToLower() == "tas" && girilen.ToLower() == "makas" || objeler[rastgeleSayi].ToLower() == "makas" && girilen.ToLower() == "kagit" || objeler[rastgeleSayi].ToLower() == "kagit" && girilen.ToLower() == "tas")
    {
        Console.WriteLine("Bilgisayar kazandı");
        bilgisayarKazanmaAdeti++;
        turSonucları.Add(tur.ToString() + ".tur :" + "bilgisayar kazandı");
    }

    else 
    {
        Console.WriteLine("Kullanici kazandı");
        kullaniciKazanmaAdeti++;
        turSonucları.Add(tur.ToString() + ".tur :" + "kullanici kazandı");
    }
}

Console.WriteLine("Oyun kaç kere oynandı: " + tur.ToString());
Console.WriteLine("Oyuncu kazanma sayısı: " + kullaniciKazanmaAdeti.ToString());
Console.WriteLine("Bilgisayar kazanma sayısı: " + bilgisayarKazanmaAdeti.ToString());
Console.WriteLine("Tur Sonuçları: ");

foreach (string sonuc in turSonucları)
{
    Console.WriteLine(sonuc);
}

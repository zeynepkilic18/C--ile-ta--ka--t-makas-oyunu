using System;

/*public class Proje1
{
    public static void Main(string[] args)
    {
        string kisi = "" ,kisi1 = "", kisi2 = "";
        Console.WriteLine("Lütfen oyunu nasıl oynamak istediğinizi seçiniz:");
        Console.WriteLine("İki kişi oynamak istiyorsanız 1'i bilgisayara karşı oynamak istiyorsanız 2'yi tuşlayınız");
        int secim = Int32.Parse(Console.ReadLine());
        string devam;

        switch (secim)
        {
            case 1: Console.WriteLine("Oyuncuların adını giriniz: ");
                kisi1 = Console.ReadLine();
                kisi2 = Console.ReadLine();
                TasKagitMakas2();
                Console.ReadLine();
                Console.WriteLine("Oyunu tekrar oynamak ister misiniz? (Evet için 'e', Hayır için 'h' tuşlayın)");
                devam = Console.ReadLine();

                if (devam.ToLower() == "e")
                {
                    Console.Clear(); // Konsolu temizler ve ikinci bir oyun başlatır.
                    Main(null); // Main metoduyla programı yeniden başlatır.
                }
                else if (devam.ToLower() == "h")
                {
                    Environment.Exit(0); // Programı sonlandırır.
                }
                else
                {
                    Console.WriteLine("Geçersiz seçenek. Lütfen 'e' veya 'h' tuşlayın.");
                }

                break;

            case 2: Console.WriteLine("Oyuncunun adını giriniz: ");
                kisi = Console.ReadLine();
                TasKagitMakas1();
                Console.ReadLine();
                Console.WriteLine("Oyunu tekrar oynamak ister misiniz? (Evet için 'e', Hayır için 'h' tuşlayın)");
                devam = Console.ReadLine();

                if (devam.ToLower() == "e")
                {
                    Console.Clear(); // Konsolu temizler ve ikinci bir oyun başlatır.
                    Main(null); // Main metoduyla programı yeniden başlatır.
                }
                else if (devam.ToLower() == "h")
                {
                    Environment.Exit(0); // Programı sonlandırır.
                }
                else
                {
                    Console.WriteLine("Geçersiz seçenek. Lütfen 'e' veya 'h' tuşlayın.");
                }

                break;


        }
        
        
    }


    private static void TasKagitMakas1()
    {
        int kisipuanı = 0;
        int bilgisayarpuanı = 0;
        string kullanicisecimi;
        do
        {
            Console.WriteLine("Lütfen taş kağıt ya da makas seçimi yapınız.(Taş,Kağıt,Makas olarak)");
            kullanicisecimi = Console.ReadLine();
            Console.WriteLine("Kişi seçimi: " + kullanicisecimi);
            string[] secenek = { "Taş", "Kağıt", "Makas" };
            Random pc = new Random();
            int a = pc.Next(3);
            Console.WriteLine("Bilgisayar seçimi: " + secenek[a]);
            if (kullanicisecimi == "Taş" && secenek[a] == "Kağıt" || kullanicisecimi == "Makas" && secenek[a] == "Taş" || kullanicisecimi == "Kağıt" && secenek[a] == "Makas")
            {
                bilgisayarpuanı++;
            }

            if (kullanicisecimi == "Taş" && secenek[a] == "Makas" || kullanicisecimi == "Makas" && secenek[a] == "Kağıt" || kullanicisecimi == "Kağıt" && secenek[a] == "Taş")
            {
                kisipuanı++;
            }

            


        } while (bilgisayarpuanı < 10 || kisipuanı < 10);
        Console.WriteLine("Kullanıcı pc'yi" + kisipuanı + " kadar yener");
        Console.WriteLine("Kullanıcı pc'ye" + bilgisayarpuanı + " kadar yenilir");


    }

    private static void TasKagitMakas2()
    {
        int kisi1puanı = 0;
        int kisi2puanı = 0;
        string kullanici1secimi;
        string kullanici2secimi;
        do
        {
            Console.WriteLine("Lütfen taş kağıt ya da makas seçimi yapınız.(Taş,Kağıt,Makas olarak)");
            kullanici1secimi = Console.ReadLine();
            Console.WriteLine("1.Kişi seçimi: " + kullanici1secimi);
            Console.WriteLine("Lütfen taş kağıt ya da makas seçimi yapınız.(Taş,Kağıt,Makas olarak)");
            kullanici2secimi = Console.ReadLine();
            Console.WriteLine("2.Kişi seçimi: " + kullanici2secimi);

            if (kullanici1secimi == "Taş" && kullanici2secimi == "Kağıt" || kullanici1secimi == "Makas" && kullanici2secimi == "Taş" || kullanici1secimi == "Kağıt" && kullanici2secimi == "Makas")
            {
                kisi2puanı++;
            }

            if (kullanici2secimi == "Taş" && kullanici1secimi == "Makas" || kullanici2secimi == "Makas" && kullanici1secimi == "Kağıt" || kullanici2secimi == "Kağıt" && kullanici1secimi == "Taş")
            {
                kisi1puanı++;
            }

            if (kisi1puanı >= 10 || kisi2puanı >= 10)
            {
                break; // Her iki oyuncu da 10 puanı geçtiğinde döngüden çık
            }
        } while (true);

        if (kisi1puanı == 10)
        {
            Console.WriteLine("Kazanan 1.kişi");
            Console.WriteLine("Skor: 1.kişi " + kisi1puanı + " 2.kişi " + kisi2puanı);
        }
        else if (kisi2puanı == 10)
        {
            Console.WriteLine("Kazanan 2.kişi");
            Console.WriteLine("Skor: 1.kişi " + kisi1puanı + " 2.kişi " + kisi2puanı);
        }

        
    }
}*/

using System;
using System.Collections.Generic;

public class Proje1
{
    public static void Main(string[] args)
    {
        List<string> kazananlar = new List<string>(); // Kazananların listesi
        string kisi = "", kisi1 = "", kisi2 = "";
        Console.WriteLine("Lütfen oyunu nasıl oynamak istediğinizi seçiniz:");
        Console.WriteLine("İki kişi oynamak istiyorsanız 1'i bilgisayara karşı oynamak istiyorsanız 2'yi tuşlayınız");
        int secim = Int32.Parse(Console.ReadLine());
        string devam;

        switch (secim)
        {
            case 1:
                Console.WriteLine("Oyuncuların adını giriniz: ");
                kisi1 = Console.ReadLine();
                kisi2 = Console.ReadLine();
                TasKagitMakas2(kisi1, kisi2, kazananlar);
                break;

            case 2:
                Console.WriteLine("Oyuncunun adını giriniz: ");
                kisi = Console.ReadLine();
                TasKagitMakas1(kisi, kazananlar);
                break;
        }

        Console.WriteLine("Oyunu tekrar oynamak ister misiniz? (Evet için 'e', Hayır için 'h' tuşlayın)");
        devam = Console.ReadLine();

        if (devam.ToLower() == "e")
        {
            Console.Clear();
            Main(null);
        }
        else if (devam.ToLower() == "h")
        {
            Console.WriteLine("Oyunları kazananlar:");
            foreach (var kazanan in kazananlar)
            {
                Console.WriteLine(kazanan);
            }
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Geçersiz seçenek. Lütfen 'e' veya 'h' tuşlayın.");
        }
    }

    private static void TasKagitMakas1(string oyuncuAdi, List<string> kazananlar)
    {
        int kisipuanı = 0;
        int bilgisayarpuanı = 0;
        string kullanicisecimi;
        do
        {
            Console.WriteLine("Lütfen taş kağıt ya da makas seçimi yapınız.(Taş,Kağıt,Makas olarak)");
            kullanicisecimi = Console.ReadLine();
            Console.WriteLine("Kişi seçimi: " + kullanicisecimi);
            string[] secenek = { "Taş", "Kağıt", "Makas" };
            Random pc = new Random();
            int a = pc.Next(3);
            Console.WriteLine("Bilgisayar seçimi: " + secenek[a]);
            if (kullanicisecimi == "Taş" && secenek[a] == "Kağıt" || kullanicisecimi == "Makas" && secenek[a] == "Taş" || kullanicisecimi == "Kağıt" && secenek[a] == "Makas")
            {
                bilgisayarpuanı++;
            }

            if (kullanicisecimi == "Taş" && secenek[a] == "Makas" || kullanicisecimi == "Makas" && secenek[a] == "Kağıt" || kullanicisecimi == "Kağıt" && secenek[a] == "Taş")
            {
                kisipuanı++;
            }

            if (kisipuanı >= 10 || bilgisayarpuanı >= 10)
            {
                if (kisipuanı > bilgisayarpuanı)
                {
                    kazananlar.Add(oyuncuAdi);
                }
                break;
            }
        } while (true);

        Console.WriteLine(oyuncuAdi + " bilgisayarı " + kisipuanı + " - " + bilgisayarpuanı + " yener");
    }

    private static void TasKagitMakas2(string oyuncu1Adi, string oyuncu2Adi, List<string> kazananlar)
    {
        int kisi1puanı = 0;
        int kisi2puanı = 0;
        string kullanici1secimi;
        string kullanici2secimi;
        do
        {
            Console.WriteLine("Lütfen taş kağıt ya da makas seçimi yapınız.(Taş,Kağıt,Makas olarak)");
            kullanici1secimi = Console.ReadLine();
            Console.WriteLine(oyuncu1Adi + " seçimi: " + kullanici1secimi);
            Console.WriteLine("Lütfen taş kağıt ya da makas seçimi yapınız.(Taş,Kağıt,Makas olarak)");
            kullanici2secimi = Console.ReadLine();
            Console.WriteLine(oyuncu2Adi + " seçimi: " + kullanici2secimi);

            if (kullanici1secimi == "Taş" && kullanici2secimi == "Kağıt" || kullanici1secimi == "Makas" && kullanici2secimi == "Taş" || kullanici1secimi == "Kağıt" && kullanici2secimi == "Makas")
            {
                kisi2puanı++;
            }

             if (kullanici1secimi == "Taş" && kullanici2secimi == "Makas" || kullanici1secimi == "Makas" && kullanici2secimi == "Kağıt" || kullanici1secimi == "Kağıt" && kullanici2secimi == "Taş")
            {
                kisi1puanı++;
            }

            if (kisi1puanı >= 10 || kisi2puanı >= 10)
            {
                if (kisi1puanı > kisi2puanı)
                {
                    kazananlar.Add(oyuncu1Adi);
                }
                else if (kisi2puanı > kisi1puanı)
                {
                    kazananlar.Add(oyuncu2Adi);
                }
                break;
            }
        } while (true);

        if (kisi1puanı > kisi2puanı)
        {
            Console.WriteLine(oyuncu1Adi + " " + oyuncu2Adi + "i " + kisi1puanı + " - " + kisi2puanı + " yener");
        }
        else if (kisi2puanı > kisi1puanı)
        {
            Console.WriteLine(oyuncu2Adi + " " + oyuncu1Adi + "i " + kisi2puanı + " - " + kisi1puanı + " yener");
        }
        else
        {
            Console.WriteLine("Berabere!");
        }
    }
}

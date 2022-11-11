using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1=new Musteri();
            musteri1.Id = 1;
            musteri1.Meslek = "Memur";
            musteri1.Ad = "Ahmet";
            musteri1.SoyAd = "Arslan";

            Musteri musteri2=new Musteri();
            musteri2.Id = 2;
            musteri2.Meslek = "Esnaf";
            musteri2.Ad = "Naci";
            musteri2.SoyAd = "Demir";

            Musteri musteri3=new Musteri();
            musteri3.Id = 3;
            musteri3.Meslek = "Garson";
            musteri3.Ad = "Hülya";
            musteri3.SoyAd = "Yaşar";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("\n");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}

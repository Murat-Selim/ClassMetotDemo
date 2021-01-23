using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yilmaz";
            musteri1.Id = 1;
            musteri1.yasi = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Gokturk";
            musteri2.Id = 2;
            musteri2.yasi = 29;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ayse";
            musteri3.Soyadi = "Korkmaz";
            musteri3.Id = 3;
            musteri3.yasi = 35;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriListeleme(musteri2);
            musteriManager.MusteriListeleme(musteri3);
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);


        }
    }
}

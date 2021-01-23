using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri listelendi : " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}

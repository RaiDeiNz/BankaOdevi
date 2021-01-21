using System;
using System.Collections.Generic;
using System.Text;

namespace Banka
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) { Console.WriteLine(musteri.MusteriAdi + " Listeye eklendi"); }
        public void MusteriSil(Musteri musteri) { Console.WriteLine(musteri.MusteriId + " Numaralı müşteri listeden kaldırıldı!"); }
        public void MusterileriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("\nMüşteri Id : " + musteri.MusteriId + "\nMüşteri Adı : " + musteri.MusteriAdi + "\nMüşteri Soyadı : " + musteri.MusteriSoyadi + "\n");
            }
        }
    }
}

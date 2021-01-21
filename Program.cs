using System;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamMusteri = 1;
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriSoyadi = "Veli";
            musteri1.MusteriId = toplamMusteri++;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Alis";
            musteri2.MusteriSoyadi = "Velis";
            musteri2.MusteriId = toplamMusteri++;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.MusterileriListele(musteriler);

            musteriManager.MusteriSil(musteri2);

        }
    }
}

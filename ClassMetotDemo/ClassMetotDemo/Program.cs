using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "ayşenur";
            musteri1.Soyad = "memiş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "ahmet";
            musteri2.Soyad = "saki";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "merve";
            musteri3.Soyad = "kaya";

            Console.WriteLine("Müşteri listesi :");

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};
            foreach (var kisi in musteriler)
            {
                Console.WriteLine(kisi.Id + ". " + kisi.Ad + " " + kisi.Soyad);
            }

            Console.WriteLine("---------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Sil(musteri1);



        }
    }
}

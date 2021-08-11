using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " numaralı " + musteri.Ad + " " + musteri.Soyad + " eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " numaralı " + musteri.Ad + " " + musteri.Soyad + " silindi.");
        }



    }
}

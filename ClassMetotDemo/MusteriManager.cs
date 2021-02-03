using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "sisteme eklendi.");

            Console.WriteLine("Ekleme işlemi bitti.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "sistemden silindi.");

            Console.WriteLine("Silme işlemi bitti.");
        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Güncelleme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "sistemde güncellendi.");

            Console.WriteLine("Güncelleme işlemi bitti.");
        }
        public void Düzenle(Musteri musteri)
        {
            Console.WriteLine("Düzenleme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "sistemde düzenlendi.");

            Console.WriteLine("Düzenleme işlemi bitti.");
        }

    }
}

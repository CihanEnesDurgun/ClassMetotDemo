using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Cihan Enes";
            musteri1.Soyad = "Durgun";
            musteri1.Id = 1;
            musteri1.HesaptakiPara = 500;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Derya Ceren";
            musteri2.Soyad = "Durgun";
            musteri2.Id = 2;
            musteri2.HesaptakiPara = 400;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Durgun";
            musteri3.Id = 3;
            musteri3.HesaptakiPara = 6000;

            Console.WriteLine("--------------------------------------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("--------------------------------------------");

            musteriManager.Güncelle(musteri1);
            Console.WriteLine("--------------------------------------------");

            musteriManager.Sil(musteri3);
            Console.WriteLine("--------------------------------------------");

            musteriManager.Düzenle(musteri2);
            Console.WriteLine("--------------------------------------------");

        }
    }
}

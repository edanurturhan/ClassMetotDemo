using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.id = 1;
            musteri1.ad = "Edanur";
            musteri1.soyad = "Turhan";
            musteri1.yas = 23;
            musteri1.meslek = "Bilgisayar Mühendisi";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.ad = "Esma Ebru";
            musteri2.soyad = "Altun";
            musteri2.yas = 36;
            musteri2.meslek = "Doktor";

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.ad = "Muhammed Emre";
            musteri3.soyad = "Turhan";
            musteri3.yas = 33;
            musteri3.meslek = "Bilgisayar Mühendisi";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.ad);
                Console.WriteLine(musteri.soyad);
                Console.WriteLine(musteri.id);
                Console.WriteLine(musteri.yas);
                Console.WriteLine(musteri.meslek);
                Console.WriteLine("-------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

        }
    }
}

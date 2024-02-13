using System;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            //ort hesaplama
            int sinav1, sinav2, proje, ort;
            Console.WriteLine("1. Sınav Notunu Giriniz: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sınav Notunu Giriniz: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Proje Notunu Giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine());

            ort = (sinav1 + sinav2 + proje) / 3;
            Console.WriteLine("Ortalama: " + ort);



            if (ort < 0 || ort > 100)
            {
                Console.WriteLine("Hatalı Giriş!");
            }
            else if (ort > 30 && ort < 50)
            {
                Console.WriteLine("İdare eder...");
            }
            else if (ort >= 50 && ort < 75)
            {
                Console.WriteLine("Güzel...");
            }
            else if (ort >= 75 && ort <= 100)
            {
                Console.WriteLine("Çok iyi...");
            }
            else if (ort <= 30 && ort >= 0)
            {
                Console.WriteLine("Çok kötü...");
            }

            Console.Read();

            ///////////////
            

            int sayi;
            Console.WriteLine("Lütfen bir sayı giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Çift Sayı...");
            }
            else if (sayi % 2 == 1)
            {
                Console.WriteLine("Tek Sayı...");
            }

            Console.Read();

            ///////////////

            //mevsim örneği
            string mevsim;
            Console.WriteLine("Lütfen bir mevsim adı giriniz : ");
            mevsim = Console.ReadLine();

            if (mevsim == "kis")
            {
                Console.WriteLine("Kış ayları :  Aralık, Ocak , Şubat ");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("İlkbahar ayları : Mart ,Nisan , Mayıs ");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine("Yaz ayları : Haziran , Temmuz , Ağustos");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("Sonbahar ayları : Eylül , Ekim , Kasım ");
            }
            else
            {
                Console.WriteLine("HATALI MEVSİM GİRİŞİ... ");
            }

            Console.Read();

            ///////////////
            

            Console.WriteLine("***** Ayşe Teyze'nin Kitap Dükkanı *****");

            double a, indirim, odenecek;
            Console.Write("ürün fiyatını giriniz : ");
            a = Convert.ToDouble(Console.ReadLine());

            if (a < 100)
            {
                indirim = a * 10 / 100;
                odenecek = a - indirim;
                Console.WriteLine("İndirim miktarı :  " + indirim);
                Console.WriteLine("Ödenecek miktar : " + odenecek);
            }
            if (a >= 100 && a < 150)
            {
                indirim = a * 15 / 100;
                odenecek = a - indirim;
                Console.WriteLine("İndirim miktarı :  " + indirim);
                Console.WriteLine("Ödenecek miktar : " + odenecek);
            }
            if (a >= 150 && a < 200)
            {
                indirim = a * 20 / 100;
                odenecek = a - indirim;
                Console.WriteLine("İndirim miktarı :  " + indirim);
                Console.WriteLine("Ödenecek miktar : " + odenecek);
            }

        }
    }
}
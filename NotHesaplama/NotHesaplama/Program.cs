using System;

namespace NotHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Hesaplama");

            double sinav1, sinav2, sinav3, proje, ort;
            string ad, soyad, numara;

            Console.WriteLine();

            Console.WriteLine("***** Öğrenci Kimlik Bilgileri *****");

            Console.WriteLine();

            Console.WriteLine("Adınız: ");
            ad = Console.ReadLine();

            Console.WriteLine("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.WriteLine("Numaranız: ");
            numara = Console.ReadLine();


            Console.WriteLine("***** Öğrenci Sınav Bilgileri *****");
            Console.WriteLine();

            Console.WriteLine("Birinci sınav : ");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sınav : ");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Üçüncü sınav : ");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Proje Notunuz : ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***** Ortalama Değeri *****");
            Console.WriteLine();

            ort = (sinav1 + sinav2 + sinav3 + proje) / 4;

            Console.WriteLine("Ad Soyad ->  "+ ad  +" "+  soyad);
            Console.WriteLine("Ortalama = "+ort);

            Console.ReadLine();
        }
    } 
}

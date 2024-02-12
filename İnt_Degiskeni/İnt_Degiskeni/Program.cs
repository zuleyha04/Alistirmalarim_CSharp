using System;

namespace İnt_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {
            //"int tanımlama"
            //int a, b, c;
            //a = 8;
            //b = 7;
            //c = a * b;
            //Console.WriteLine("a*b = {0}",c);

            //Console.ReadLine();


            //int deger1, deger2, bolum;
            //deger1 = 12;
            //deger2 = 22;
            //bolum = (deger1 + deger2) / 2;
            //Console.WriteLine(bolum);

            string ad, soyad, numara;
            int sınav1, sınav2, sınav3, proje, ortalama;

            Console.WriteLine("**** Öğrenci Bilgi ****");
            Console.WriteLine();

            ad = "Züleyha";
            soyad = "Akbaş";
            numara = "12345678910";

            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(numara);

            Console.WriteLine();
            Console.WriteLine("**** Not Bilgisi ****");
            Console.WriteLine();
            sınav1 = 60;
            sınav2 = 70;
            sınav3 = 100;
            proje = 90;

            Console.WriteLine("Sınav1= " + sınav1);
            Console.WriteLine("Sınav2= " + sınav2);
            Console.WriteLine("Sınav3= " + sınav3);
            Console.WriteLine("Proje Notu = " + proje);

            Console.WriteLine();
            Console.WriteLine("**** Ortalama ****");
            Console.WriteLine();

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            Console.WriteLine("Ortalama = "+ ortalama);
            Console.Read();







        }
    }
}
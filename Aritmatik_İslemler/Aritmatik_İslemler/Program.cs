
using System;

namespace Aritmatik_İslemler
{
    class Aritmatik_İslemler
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam ,fark , carpma,bolme;

            Console.WriteLine("**** Aritmatik Dört İşlem **** ");

            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            fark = sayi1 - sayi2;
            Console.WriteLine("Fark : " + fark);

            carpma = sayi1 * sayi2;
            Console.WriteLine("Çarpma : " + carpma);

            bolme = sayi1 / sayi2;
            Console.WriteLine("Bölme : " + bolme);


            Console.ReadLine();


            int kenar, karealan, karecevre;
            int dikenar1,dikenar2, dikalan, dikcevre;

            Console.WriteLine("***** Karenin Alan ve Çevresini Bulma *****");
            Console.WriteLine("Karenin kenar uzunluğunu giriniz : ");
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = kenar * 4;

            Console.WriteLine("Kare Alan : "+ karealan);
            Console.WriteLine("Kare Çevre : "+karecevre);

            Console.WriteLine();
            Console.WriteLine("***** Dikdörtgenin Alan ve Çevresini Bulma *****");
            Console.WriteLine("Dikdörtgenin 1. kenar uzunluğunu giriniz : ");
            dikenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin 2. kenar uzunluğunu giriniz : ");
            dikenar2 = Convert.ToInt32(Console.ReadLine());
            dikalan = dikenar1 * dikenar2;
            dikcevre = dikenar1 * 2 + dikenar2 * 2;

            Console.WriteLine("Dikdörtgen Alan : "+ dikalan);
            Console.WriteLine("Dikdörtgen Çevre : " + dikcevre);

            Console.ReadLine();


        }
    }

}
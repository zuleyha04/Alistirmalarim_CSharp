using System;

namespace Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string[] sehirler = { "Ankara", "İstanbul", "Düzce", "Sakarya", "Bursa", "Samsun", "Bayburt" };

            foreach (string i in sehirler)
            {
                Console.WriteLine(i);
            }


            //foreach ile sayıların toplanması
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            int toplam = 0;

            foreach (int i in sayilar)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Toplam: " + toplam);


            //2ye bölüneneleri yazdırma
            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            foreach (int j in rakamlar)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
            }

            //foreach ile faktoriyel

            int[] sayi = { 1, 2, 3, 4, 5, 6 };
            int carpim = 1;

            foreach (int i in sayi)
            {
                carpim = carpim * i;
            }
            Console.WriteLine("6'nın faktoriyeli: " + carpim);

            Console.Read();

        }
    }
}
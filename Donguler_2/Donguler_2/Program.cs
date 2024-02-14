using System;

namespace Donguler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //0dan 100e kadar 9un katlarını yazdırma
            for (int i = 0; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            //120nin bölenlerini yazdırma
            int sayi = 120;
            for(int i = 1; i <= 120; i++)
            {
                if (sayi%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            //fibonacci

            int a=1, b = 1,c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for ( int i = 1; i <= 8; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }

        }
    }
}
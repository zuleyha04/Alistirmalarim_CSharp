using System;

namespace Donguler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den 10a yazdırma
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //1den 10a kadar sayıların toplamı
            int toplam = 0;

            for (int i = 0; i <= 10; i++)
            {
                toplam = toplam + i;
                Console.WriteLine(toplam);
            }
            Console.ReadLine();


            //çift sayıların toplamı 
            int topl = 0;

            for (int i = 0; i <= 10; i+=2)
            {
                topl = topl + i;
                Console.WriteLine("Toplam : "+ topl);

            }
            Console.ReadLine();
        }
    }
}
using System;

namespace Donguler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("i'nin döngüden çıkış değeri : " + i);





            //faktoriyel
            int say,faktoriyel = 1;
            Console.Write("***** Faktoriyeli alınacak sayıyı giriniz :  ");
            say = Convert.ToInt32(Console.ReadLine());
            

            while (say>0)
            {
                faktoriyel = faktoriyel * say;
                say--;
               
            }
            Console.WriteLine("Faktoriyel : "+faktoriyel);
            Console.ReadLine();
        }
        
    }

}


using System;

namespace Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[3];//dizinin boyutu 

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Şehir : ");
                sehirler[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            Console.ReadLine();




            //dizideki en büyük sayıyı bulma
            int sayi;
            int[] sayilar = new int[5];
            Console.WriteLine("Lütfen 5 tane sayı giriniz : ");

            for (int i = 0; i < 5; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }


            int enBuyuk = sayilar[0];
            for (int i = 1; i < 5; i++)
            {
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }
            }
            Console.WriteLine("En Büyük Sayı : " + enBuyuk);

            Console.ReadLine();



            //sırasıyla dizileri yazdırma

            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.WriteLine(i+1 +" . Öğrencinin Adı : ");
                isim[i] = Console.ReadLine();

                Console.WriteLine(i + 1 + " Sınav 1 : ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(i + 1 + " Sınav 2 : ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2;

            }

            Console.WriteLine();
            Console.WriteLine("Öğrenci | Sınav1 | Sınav2 | Ortalama");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" "+ isim[i]+"        " + s1[i]+"    " + s2[i]+"   " + ort[i]);
            }

            Console.ReadLine();

        }

    }
}
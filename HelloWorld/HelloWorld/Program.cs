using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //"hello world yazdır"
            //Console.WriteLine("Hello World");

            //"string tanımlayıp, yazdır"
            //string isim;
            //isim = "Zuleyha";
            //Console.WriteLine(isim);
            //Console.ReadLine();


            //string İsim;
            //Console.WriteLine("Lütfen isminizi giriniz = ");
            //isim = Console.ReadLine();
            //Console.WriteLine("Hoşgeldin "+isim);
            //Console.ReadLine();


            //"tanımlanan stringleri + ile yazdır"
            //string ad, soyad, yas, meslek, sehir;

            //Console.WriteLine("Lütfen sırasıyla ad,soyad , yaş , meslek ve şehir bilgilerinizi giriniz...");

            //ad = Console.ReadLine();
            //soyad = Console.ReadLine();
            //yas = Console.ReadLine();
            //meslek = Console.ReadLine();
            //sehir = Console.ReadLine();

            //Console.WriteLine("Adınız : " + ad);
            //Console.WriteLine("Soyadınız : "+ soyad);
            //Console.WriteLine("Yaşınız : "+ yas);
            //Console.WriteLine("Mesleğiniz : "+ meslek);
            //Console.WriteLine("Şehriniz : "+ sehir);

            //Console.ReadLine();


            //"tanımlanan stringleri {} ile yazdır"
            //string isim;
            //Console.WriteLine("Lütfen isminizi giriniz :");
            //isim = Console.ReadLine();
            //Console.WriteLine("merhaba {0}",isim);
            //Console.ReadLine();

            string ad, soyad, sehir;

            Console.WriteLine("Adınız :");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız :");
            soyad = Console.ReadLine();
            Console.WriteLine("Şehriniz :");
            sehir = Console.ReadLine();

            Console.WriteLine("Ad:{0} , Soyad:{1} , Şehir:{2}",ad,soyad,sehir);
            Console.Read();



        }
            
    }
}

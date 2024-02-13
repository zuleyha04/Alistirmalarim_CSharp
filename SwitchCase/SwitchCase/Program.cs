
using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.WriteLine("Lütfen mevsimi küçük harflerle yazınız : ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz":Console.WriteLine("Yaz mevsimi ayları : Haziran Temmuz Ağustos ");
                    break;
                case "ilkbahar":Console.WriteLine("İlkbahar mevsimi ayları : Mart Nisan Mayıs ");
                    break;
                case "sonbahar":Console.WriteLine("Sonbahar mevsimi ayları : Eylül Ekim Kasım");
                    break;
                case "kis":Console.WriteLine("Kış mevsimi ayları : Aralık Ocak Şubat ");
                    break;
                default:Console.WriteLine("Hatalı mevsim girişi...");
                    break;
            }
            Console.Read();
        }
    }
}
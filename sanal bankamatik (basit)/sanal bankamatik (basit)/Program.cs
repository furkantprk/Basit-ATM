using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sanal_bankamatik__basit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi İşlemi Yapmak İstersiniz?");
            Console.WriteLine("1-PARA ÇEKME");
            Console.WriteLine("2-PARA YATIRMA");
            Console.WriteLine("3-BAKİYE GÖRÜNTÜLEME");
            Console.WriteLine("4-ÇIKIŞ");
            string secim=Console.ReadLine();

            double bakiye = 1247.37;

            if (secim == "1")
            {
                Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ TUTARI GİRİNİZ:");
                double cekilecekTutar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("PARAYI ÇEKTİKTEN SONRA KALAN TUTAR: " + (bakiye - cekilecekTutar));
                Console.ReadLine();
            }

            else if (secim == "2")
            {
                Console.WriteLine("YATIRILACAK TUTARI GİRİNİZ:");
                double yatirilanTutar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("PARAYI YATIRDIKTAN SONRA TOPLAM TUTAR: " + (bakiye + yatirilanTutar));
                Console.ReadLine();
            }
            else if (secim == "3")
            {
                Console.WriteLine("TOPLAM BAKİYENİZ: " + bakiye);
                Console.ReadLine();
            }
            else if (secim == "4")
            {
                Console.WriteLine("ATM'DEN ÇIKIŞ YAPTINIZ. TEKRAR BEKLERİZ.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("YANLIŞ TUŞLAMA YAPTINIZ. TEKRAR DENEYİNİZ.");
                Console.ReadLine();

            }

        }
    }
}

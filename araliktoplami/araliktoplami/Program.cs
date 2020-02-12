using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araliktoplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine("kaçtan kaça kadar olan sayıları toplamak istiyorsunuz");
            Console.WriteLine("alt sınırı giriniz");
            int alt_sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("üst sınırı giriniz");
            int ust_sayi = int.Parse(Console.ReadLine());
            int a = ust_sayi;
            while (ust_sayi >= alt_sayi)
            {
                toplam += ust_sayi;
                ust_sayi--;
            }
            Console.WriteLine("{0} (dahil) ile {1} (dahil) arasındaki sayıların toplamı{2}dir", alt_sayi,a, toplam);
            Console.Read();
        }
    }
}

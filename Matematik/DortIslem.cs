using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2) //parametre kısmı methodun ihtiyacı olan değişkenler gibidir aslında
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+ toplam);
        }
        //topla metodunu kullnabilmen için iki sayı vermemiz lazım (parametre)
    }
}

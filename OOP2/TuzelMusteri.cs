using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{   //Coorporate
    //Miras : Inheritance -- asıl olayı Müşteride olan tüm özellikler artık geçrekte de tüzelde de vardır.
    //TüzelMusteri miras alır Musteriden şeklinde ifade edilir. Aynı zamanda onların referansını da tutabiliyor.
    internal class TuzelMusteri : Musteri //Tüzel müşteri bir müşteridir demek.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

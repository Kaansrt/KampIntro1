using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Class lar - içerisinde özellikler ve operasyon tutar.

namespace OOP2
{
    internal class Musteri
    {
        // Eğer ki bir nesnede bir değeri kullanmak zorunda gibi durmuyorsak, orada soyutlama hatası yapıyoruzdur.
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        // Tc no ve vergi no vb sayılardan oluşur, bir veri üzerinden matematiksel işlem yapmıyorsak bunlar metinsel olarak planlanmalıdır.
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {   //naming convention -- syntax
        public void Ekle(Urun urun) // (Urun urun) --> parametre, Urun değişkeninde urun isminde bir parametre
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi);
            //bu metod şeklini kullanmak yerine class kullanma sebebimiz, yeni bi parametre eklendiğinde maindeki tüm ekle2 ye de parametre girmek zorunda kaldık.
            //encapsulation denir. Ayrı ayrı düzensiz olan yapıyı kapsülün içine sokarak çalışırız.
        }
    }
}
//bir classın içerisinde birden fazla metot olabilir.
//methodun imzası
//bi yerde nomral parantez görürsek orada method çalışıyor demektir.
//bir operasyon tutuyor, yani method kullanıyor

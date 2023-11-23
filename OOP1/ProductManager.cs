using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product) // Product classında product isimli bir parametre
        {
            Console.WriteLine(product.ProductName + " Eklendi!");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }
        /*public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)//void içinde return çalışmaz
        {
            Console.WriteLine(sayi1 + sayi2);
        } */
    }
}
// void anahtar kelimesi : İşlem sonucunun ne olduğuyla ilgili bir bilgiye gerek yoksa void olarak tanımlanır.
// void Diğer tarafa sonucu göndermez sonuc ya o class içerisinde kalır ya da ekrana yazdırılabilir.
// Return :  Bir işlem sonucunda elde edilen değeri kullanıldığı fonksiyona dönderen ifadedir. Bu ifade döndürülecek
// ifadenin türüne göre tanımlanan fonksiyondaki işlem sonucunu değer olarak geri gönderir.
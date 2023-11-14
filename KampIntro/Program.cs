using System;

namespace KampIntro
{
    internal class Program
    {   //program.cs deki cs dosya uzantısıdır yani c sharp
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori"; //metinsel ifadeler.
            int ogrenciSayisi = 32000; // tamsayılar için integer
            double faizOrani = 1.45; // ondalıklı sayılar için double
            bool sistemeGirisYapmisMi = true; // true false tur.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giiş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            //Random zar = new Random();
            //int at = zar.Next(1, 7);
            //int at2 = zar.Next(1, 7);

            //Console.WriteLine(at);
            //if (at == 1)
            //{
            //    Console.WriteLine("Zarınınz 1 geldi.");
            //}
            //else if (at == 2)
            //{
            //    Console.WriteLine("Zarınınz 2 geldi.");
            //}
            //else if (at == 3)
            //{
            //    Console.WriteLine("Zarınınz 3 geldi.");
            //}
            //else if (at == 4)
            //{
            //    Console.WriteLine("Zarınınz 4 geldi.");
            //}
            //else if (at == 5)
            //{
            //    Console.WriteLine("Zarınınz 5 geldi.");
            //}
            //else if (at == 6)
            //{
            //    Console.WriteLine("Zarınınz 6 geldi.");
            //}



            Console.ReadKey();

        }
    }
}

// console kod yazarken en yoğun kullandığımız araçlardan bir tanesidir.
// değişkenler verileri tutmak içindir.
// Type-safety -- tür güvenliği 
// bir satırı bitirince noktalı virgül konulamlıdır.
// değer tutucu - alias , bir nevi kısayol atamamızı sağlar
// kodlar yukarıdan aşağıya doğru çalışır
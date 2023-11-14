using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";      //bu şekilde aynı tip listelenen verileri dizilerde tanımlarız. array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme", "Programlamaya başlangıç","Java" };
            
            for (int i = 0; i < kurslar.Length; i++) // ilk kısım başlangıç değeri, ikinci kısım şart, üçüncü kısım ise artış şekli = i++, i yi birer birer arttır demek. i +=1;
            {   //lenght eleman sayısı içindir. 
                // kursların uzunluğu kadar döngü dönsün, kursların[i.elemanını] göster dediğimiz için her döngüde bi sonraki elemanı gösterir.
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti.");
            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dönmeye yarar. in kurslar = kursları dolaş, kurs takma isimdir  
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu -- Footer");
        }
    }
}
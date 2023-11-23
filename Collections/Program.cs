namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Kaan", "Murat", "Kerem", "Halil" };
            //// arrayler ilk başta yukarıda oluşturduğumuz sınırlarda takılır. aşağıda gelip de arraye eleman ekleyemeyiz
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker"; // teoride işe yarar ama new dediğimiz için yeni bir referans adresi tanımladığımız için diğer elemanları kaybederiz. Yukardakini koplayalar
            //Console.WriteLine(isimler[4]); // sadece 4. elemanı girdik diğer elemanları girmedik diye 5 elemanlı,4.indexi ilker olan bir dizi oluyor yani yukarıdaki diziyi tamamen değiştirmiş olduk
            //Console.WriteLine(isimler[0]); // İçerisi boştur, ilkerden sonra bir şey yazmaz

            //List çalışma mantığı olarak diziler ile nerdeyse aynıdır. Sonradan eleman ekleyebiliriz.
            //List bir sınıftır. yanına gelen < > bu ifade ise generic yapıdır
            List<string> isimler2 = new List<string> { "Kaan","Murat","Kerem","Halil" };
            //isimler2.Add("Engin"); böyle de eleman ekleyebiliriz.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker"); 
            Console.WriteLine(isimler2[4]);

        }
    }
}
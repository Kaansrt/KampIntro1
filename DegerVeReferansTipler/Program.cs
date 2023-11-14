namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi1 artik 30 (sayi2 ile eşit değere sahip ) oldu
            sayi2 = 65;

            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999; //sayialar[0] da 999 olur. Yukarıdakinden farklıdır.

            foreach (var item in sayilar1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

// bu konu oldukça önemli
// int, decimal, double, float , bool (0,1) = değer tipler
// array, class, interface = referans tipler
// bellekte stack ve heap isimli 2 alan vardır, değer tipi olanlar stackte gerçekleşir.
// değer tipi şöyle okuruz = sayi1 in değeri eşittir 10, sayi1 in değeri = sayi2 nin değeri yani 20.Sadece değeri aktarırız, sayi2 ile olan irtibat kopar. Sadece değeri kopyalar ve işi biter

// new komutu heapte yeni bir adres oluşturmaya yarar, oraya örneği aktarır.
// int[] sayilar1 dendiğinde stackte sayilar1 diye ref adresi tanımlarız, new dediğimiz anda sayilar1 için heap ta alan oluştur değerleri oraya yaz deriz
/* bağlantı şöyle kurulur, heapte adresi vardır. adres değeri tutulur. diyelim ki sayilar1 in adresi 101[10,20,30], sayilar2 nin adresine de 102. sayilar1 = sayilar2 
   okunurken sayilar1 in ref numarası sayilar2 nin referans numarasına eşittir. Yani sayilar 1 in ref numarası 102 olur o yüzden sayilar1 sayilar2 dizesinin içindekileri alır. adreslerin içindekiler  
   kopyalandıktan sonra sayilar2 nin 0. elemanı 999 yaptığımızda, sayilar1 ile adresi aynı olduğu için sayilar 1 in de 0.elemanı 999 olur. Pointer ismiyle karşımıza çıkar.
   101 adresini tutan kalmadığı için .NET te garbage collector dediiğmiz şey 101. adresteki [10,20,30] u bellekter atar. */ 
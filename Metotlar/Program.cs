namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ayrac = new string('-', 10);
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            //Urun classını değişken tipi gibi düşün, urun1 de değişken adı gibi.
            Urun urun1 = new Urun(); //klasın örneğini tanımlıyoruz. İnstance - class örneği oluşturmak
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            //type safe oldugu için Urun veri tipini yazdık. var da yazabilirdik.
            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //Urun classı (veri tipi) içindeki urunler isimdeki dizide urun takma adıyla dön, tek tek ekrana bastır.
            {
                Console.WriteLine(ayrac);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);

            }
            Console.WriteLine(ayrac+"METOTLAR"+ayrac);

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            sepetManager.Ekle2("Elma","Yeşil Elma",12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",12,8);

            Console.ReadKey();
        }
    }
}

//tekrar tekrar kullanılabilirliği sağlar.Don't repeat yourself. DRY - Celan code  - Best Practice
//classları 2 ye ayırdık özellik tutan ve operasyon (method) tutan


/*  new için : İlk olarak bilgisayarın belleğinde random classına dayanan yeni nesneyi depolamaya yetecek büyüklükte bir adres ister .
	Yeni nesneyi oluşturur ve bellek adresinde depolar.
	dice değişkeninde kaydedilebilmesi için bellek adresini döndürür.
	Bu noktadan sonra dice değişkenine başvurulduğunda .NET runtime arka planda bir arama gerçekleştirerek doğrudan nesnenin kendisiyle çalıştığımız yanılsamasını yaratır.
 */
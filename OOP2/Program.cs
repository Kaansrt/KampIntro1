namespace OOP2
{
    // Olaya her zaman nesne gözü ile bakılır. Soyutlama
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kaan Sert - bireysel
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kaan";
            musteri1.Soyadi = "Sert";
            musteri1.TcNo = "12345678910";

            //Kodlama.io - Şirket
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            // Gerçek Müşteri - Tüzel Müşteri Bunlar farklı müşteri tipleri, birbirleri yerine kullanılamaz.
            // Bu kullanım yanlış oldugu için tüzel ve gerçek müşteri isimli iki adet class oluşturduk.

            Musteri musteri3 = new GercekMusteri();//Musteri classı hem gerçekMusterinin classını hemde TuzelMusterinin classının Referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1); // Gerçek müsteri ve tüzelMusteri musteriden miras aldıgı için parametre olarak ikisini de gönderebiliyoruz
            musteriManager.Add(musteri2); // musteri3 ü de 4 ü e yollayabiliriz.


            
            //SOLID
        }
    }
}

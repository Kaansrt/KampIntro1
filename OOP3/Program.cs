namespace OOP3
{   //interface giris
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();// IKrediManager deseydik ne aynı sonucu alırdık.
            TasitKrediManager tasitKrediManager = new TasitKrediManager();      // İnterfaceler de o interface i implemente eden class ın referansını tutabiliyor cünkü
            IKrediManager konutKrediManager = new KonutKrediManager();          // İnterface onu implemente eden class ın referansını tutabilir kısaca
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,new SmsLoggerService()); //new DatabaseLogger yerine 11. satırdaki databaseLogger da yazabilirdik ikisi aynı şey
            // yukarıda yaptıgımız yazılımda sürdürülebilirliği sağlar.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager } ;
            krediler.Add(konutKrediManager);

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); // yukarıdaki List şeklinde gönderilen parametre.

            Console.ReadKey();
        }
    }
}

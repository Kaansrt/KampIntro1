namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kaan";
            int yas = 22;

            Kurs kurs1 = new Kurs(); //Kurs isimli değişkeni böyle tanımladık + 11.satırdan 13.satıra kadar olan kurs1 isimli değişkenin propertiyleridir.
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Kaan Sert";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Esma Sert";
            kurs2.IzlenmeOrani = 64;
            
            Kurs kurs3 = new Kurs(); 
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Emirhan Bayır";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi+" : " +kurs1.Egitmen); 
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 }; //içinde kurs veri tipini (nesnesini) barındıran bir array tanımladık.

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani  { get; set; }
    }
}
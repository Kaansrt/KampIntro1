namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kaan");
            isimler.Add("Murat");
            


            Console.ReadKey();
        }
    }
}
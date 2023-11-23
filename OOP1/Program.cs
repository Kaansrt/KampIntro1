namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // kategori Id 2 mobilyaya denk geliyor.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //yukarıda oluşturduğumz yapıyı aşağıdaki gibi de oluşturabiliriz.
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };
            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager(); // instance creation -- örnek oluşturma
            productManager.Add(product1);//product 1 i alır ProductManager classının içindeki Add methoduna gönderir. Product1 i product parametresi içinde tutar.
            Console.WriteLine(product1.ProductName);


            /*productManager.Topla2(3,6);
            int toplamSonuc = productManager.Topla(3,6); // eşitliğin sağ tarafı aslında return den gelen değerdir.
            Console.WriteLine(toplamSonuc*2); // böyle işlemleri yapabilmek için return etmemiz gerekmektedir. */


            Console.ReadKey();
        }
    }
//int double bool... sayısal veriler değer tip atamalar değer üzerinden olur bağlantı kopar sonra.
//diziler , class, abstract class, interface .. referans tip atamalar referansın numrası ile yapılır
}
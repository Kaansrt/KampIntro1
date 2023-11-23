using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro // Kendi list imizi yapıyoruz
{
    internal class MyList<T> // Generic class - T = type
    {
        T[] items; // MyList Classının bütün metodalrının erişebilmesi için metodların dışına yazdık.
        public MyList() // buna constructor denir - ctor
        {
            items = new T[0];
        }
        // item yerine istediğimiz bir şeyi yazabilirdik, genel olarak item kullanıldıgı için item yazdık.
        public void Add(T item) // arka planda T program.cs nin içindeki < > in içerisine yazdığımız şey olur, var gibi çalışır 
        {
            //bu add i kullanarak yukarıdaki T[] items arrayine eklemek istiyorsuz ama arraylar heapte oldugu için başladıpında 0 elemanlı olarak newliyoruz.
            //bunun için constructor yapısından yararlanıyoruz.
            //bir lass newlendiğinde çalışan bloğa constructor denir.
            T[] tempArray = items;         //geciciDizinin referansı items ın referansı, önceki verileri newlediğimize kaybeceğimizden onları korumak için böyle tutarız
            items = new T[items.Length + 1]; // dinamik hale getirdik, her eleman eklendiğinde 1 artacak şekilde.
            //new referans numarası alınca önceki elemanlar kaybolur, bu olmasın diye o referans numarasını tempArray e tutturuyoruz
            //aşağıda emanet olarak verdiğimiz itemleri geri alıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; // index oldugu için, lenght 1 den başlar index 0 dan. son elemanına item ı ekle diyoruz
        }
        public int Uzunluk
        {
            get
            { return items.Length; }
        }
    }
}

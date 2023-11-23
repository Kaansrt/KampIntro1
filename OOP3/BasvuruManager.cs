using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {   //METHOD INJECTION
        public void BasvuruYap(IKrediManager krediManager,ILoggerService logger) //hepsinin referansını tuttugu icin IKrediManager yaptık, Soyut halleri
        {                                                                        // Geçrek hayatta birden fazla logger birden yapılır, onun için list<ILoggerService> yaparız
            // Başvuranın bilgilerini değerlendirme                              -- logger' ı birden fazla yaparsak Foreach ile yparız
            // Bunun içerisinde bir de kredi hesaplayalım, program cs de parametre olarak hangi krediyi girersek, aşağıdaki hesapla onun hesaplası olur.
            krediManager.Hesapla();
            logger.Log();
            //Somut halleri
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {   // List teki her bir kredinin hesabını yap.
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }

    } // aynı veri türünde (IKrediManager) belli sayıda, o sayıda belirsizse o bir veri grubu oluşturmak için ne kullanırız?
}

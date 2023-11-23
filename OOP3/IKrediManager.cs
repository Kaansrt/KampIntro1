using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla(); // imzanın aynı oldugu ama içerisinin farklı oldugu durumlarda base de olusturdugumuz class ı class olarak değil de interfacce olarak oluştururuz

        void BiSeyYap();

    }//interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız, Kredi türlerinin hepsinde hesaplama vardır ama kodlar farklıdır, faizoranı vb gibi seyler
    
}
//interface - biri bu interface i kullanırsa, o bu metodu ya da metotları kullanmak zorunda
//Genellikle operasyonel metotlarda kullanırız interfaceleri. İnteface referans tutucudur.


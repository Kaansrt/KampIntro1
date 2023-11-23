using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface ILoggerService
    {   // interface oldugu için sadece erişim belirteci koymadık, default belirtcei publictir
        void Log();// interface içinde sadece imza metotlar olur, içi dolu olamaz.
    }
}
//loglama - kim ne zaman hangi operasyonu cağırdı, olan hareketleri döktüğümüz döküm, mail gönderilmesi, sms gönderilmesi, veri tabanına yazılması vb.

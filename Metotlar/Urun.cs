using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {   //property - özellik
        public int Id { get; set; }     //Id bir datayı ayırt etmek için eşsiz olan nesnedir, tc gibi
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
//nesneyi tanımlayan özellikleri barındıran yapıyı class ile yaparız
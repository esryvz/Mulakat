using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.Model
{
    public class Komponent : BaseEntity
    {
        public int KomponentID { get; set; }
        public string BilesenAdi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public string Birim { get; set; }
    }
}

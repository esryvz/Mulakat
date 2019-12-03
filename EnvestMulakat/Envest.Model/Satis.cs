using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.Model
{
    public class Satis :BaseEntity
    {
        public int SatisID { get; set; }
        public string Musteri { get; set; }
        public int PanoID { get; set; }
        public Pano Pano { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public int IndirimOrani { get; set; }
        public decimal ToplamTutar { get; set; }
        public decimal ToplamSatisTutari { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.Model
{
    public class PanoKomponent : BaseEntity
    {
        public int PanoKomponentID { get; set; }
        public int PanoID { get; set; }
        public Pano Pano { get; set; }
        public int KomponentID { get; set; }
        public Komponent Komponent { get; set; }
        public int Adet { get; set; }
     

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.Model
{
    public class Pano :BaseEntity
    { 
        public int PanoID { get; set; }
        public string PanoAdi { get; set; }
        public int Kar { get; set; }
        public decimal Maliyet { get; set; }
    }
}

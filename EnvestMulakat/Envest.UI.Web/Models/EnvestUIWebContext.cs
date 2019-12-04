using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Envest.UI.Web.Models
{
    public class EnvestUIWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EnvestUIWebContext() : base("name=EnvestUIWebContext")
        {
        }

        public System.Data.Entity.DbSet<Envest.Model.Pano> Panoes { get; set; }

        public System.Data.Entity.DbSet<Envest.Model.PanoKomponent> PanoKomponents { get; set; }

        public System.Data.Entity.DbSet<Envest.Model.Komponent> Komponents { get; set; }

        public System.Data.Entity.DbSet<Envest.Model.Satis> Satis { get; set; }
    }
}

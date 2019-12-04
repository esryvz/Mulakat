using Envest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.DAL
{
    class EnvestDbContext :DbContext
    {
        public EnvestDbContext()
            :base("EnvestDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Komponent> Komponent { get; set; }
        public DbSet<Pano> Pano { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<PanoKomponent> PanoKomponent { get; set; }
        public DbSet<Kur> Kur { get; set; }

    }
}

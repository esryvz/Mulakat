using Envest.DAL;
using Envest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Envest.BLL
{
    public class SatisManager
    {
        Repository<Satis> repoSatis = new Repository<Satis>();

        public List<Satis> GetAll()
        {
            return repoSatis.ListQueryable().Include("Pano").ToList();
        }

        public int Create(Satis data)
        {
            var result = repoSatis.Insert(new Satis()
            {
                Musteri = data.Musteri,
                PanoID = data.PanoID,
                Adet = data.Adet,
                BirimFiyat = data.BirimFiyat,
                IndirimOrani = data.IndirimOrani,
                ToplamTutar = data.ToplamTutar,
                ToplamSatisTutari =data.ToplamSatisTutari

            });
            return result;
        }
    }
}

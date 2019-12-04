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
        Repository<Komponent> repoKomp = new Repository<Komponent>();
        Repository<PanoKomponent> repoPanoKomp = new Repository<PanoKomponent>();
        KomponentManager komponentManager = new KomponentManager();

        public List<Satis> GetAll()
        {
            return repoSatis.ListQueryable().Include("Pano").ToList();
        }

        public int Create(Satis data)
        {
            var komponentler = repoPanoKomp.ListQueryable().Include("Komponent").Where(x => x.PanoID == data.PanoID).ToList();         
            foreach (var item in komponentler)
            {
                if (item.Komponent.Stok == 0 || item.Komponent.Stok < data.Adet)
                {                    
                    return 0;
                }
                else
                {
                    item.Komponent.Stok -= data.Adet;
                    
                }                
            }
            foreach (var item in komponentler)
            {
                komponentManager.UpdateComponent(item.Komponent);
            }
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

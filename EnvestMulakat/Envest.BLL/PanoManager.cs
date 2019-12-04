using Envest.DAL;
using Envest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.BLL
{
    public class PanoManager
    {
        Repository<Pano> repoPano = new Repository<Pano>();
        Repository<PanoKomponent> repoPanoKomp = new Repository<PanoKomponent>();
        Repository<Kur> repoKur = new Repository<Kur>();
        public List<Pano> GetAll()
        {
            var panoList = repoPano.List();
            Pano pano = new Pano();
            foreach (var item in panoList)
            {
                pano.Maliyet = MaliyetHesapla(item.PanoID);
                pano.PanoID = item.PanoID;
                pano.PanoAdi = item.PanoAdi;
                pano.Kar = item.Kar;
                UpdatePano(pano);
            }
            return repoPano.List();
        }

        public Pano FindByID(int ID)
        {
            return repoPano.Find(x => x.PanoID == ID);
        }

        public int CreatePano(Pano data)
        {
            var result = repoPano.Insert(new Pano()
            {
                PanoAdi = data.PanoAdi,
                Kar = data.Kar
               
            });
            return result;
        }

        public int UpdatePano(Pano data)
        {
            Pano pano = repoPano.Find(x => x.PanoID == data.PanoID);
            if (pano !=null)
            {
                pano.PanoAdi = data.PanoAdi;
                pano.Kar = data.Kar;
                pano.Maliyet = data.Maliyet;

                return repoPano.Update(pano);
            }
            else
            {
                return 0;
            }
        }

        public int DeletePano(int ID)
        {
            Pano pano = repoPano.Find(x => x.PanoID == ID);
            if (pano != null)
            {
                return repoPano.Delete(pano);
            }
            else
            {
                return 0;
            }
        }

        public decimal MaliyetHesapla(int panoID)
        {
            var komponentler = repoPanoKomp.ListQueryable().Include("Komponent").Where(x => x.PanoID == panoID).ToList();
            decimal maliyet = 0;

            foreach (var item in komponentler)
            {
                var paraBirimi = item.Komponent.Birim;
                var kur = repoKur.ListQ(x => x.Birim == paraBirimi).FirstOrDefault().Deger;
                maliyet += Convert.ToDecimal(item.Komponent.Fiyat * kur);
            }
            return maliyet;
        }
    }
}

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
    public class PanoKomponentManager
    {
        Repository<PanoKomponent> repo = new Repository<PanoKomponent>();

        public List<PanoKomponent> GetAll(int ID)
        {
            return repo.ListQueryable().Include("Komponent").Where(x=> x.PanoID == ID).ToList();
        }

        public int Create(PanoKomponent data)
        {
            var result= repo.Insert(new PanoKomponent()
            {
                PanoID = data.PanoID,
                KomponentID = data.KomponentID,
                Adet = data.Adet
            });
            return result;
        }

        public int Delete(int ID)
        {
            PanoKomponent panoKom = repo.Find(x => x.PanoKomponentID == ID);
            if (panoKom != null)
            {
                return repo.Delete(panoKom);

            }
            else
            {
                return 0;
            }
        }
    }
}

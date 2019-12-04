using Envest.DAL;
using Envest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envest.BLL
{
    public class KomponentManager
    {
        Repository<Komponent> repoKomponent = new Repository<Komponent>();

        public List<Komponent> GetAll()
        {
            return repoKomponent.List();
        }

        public Komponent FindByID(int ID)
        {
            return repoKomponent.Find(x => x.KomponentID == ID);
        }

        public int CreateComponent(Komponent data)
        {
             var result = repoKomponent.Insert(new Komponent()
                {
                    BilesenAdi = data.BilesenAdi,
                    Stok = data.Stok,
                    Fiyat = data.Fiyat,
                    Birim = data.Birim
                });

                return result;
            
        }

        public int UpdateComponent(Komponent data)
        {
            Komponent kom = repoKomponent.Find(x => x.KomponentID == data.KomponentID);
            if (kom !=null)
            {
                kom.BilesenAdi = data.BilesenAdi;
                kom.Stok = data.Stok;
                kom.Fiyat = data.Fiyat;
                kom.Birim = data.Birim;

                return repoKomponent.Update(kom);
            }
            else
            {
                return 0;
            }
            
        }

        public int DeleteComponent(int ID)
        {
            Komponent kom = repoKomponent.Find(x => x.KomponentID == ID);
            if (kom !=null)
            {
                return repoKomponent.Delete(kom);

            }
            else
            {
                return 0;
            }
        }
    }
}

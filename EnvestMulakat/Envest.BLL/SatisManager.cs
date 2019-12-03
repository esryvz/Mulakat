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
    }
}

using Envest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Envest.DAL
{
    public class Repository<T> where T : class
    {
        private EnvestDbContext db;
        private DbSet<T> _objSet;

        public Repository()
        {
            db = new EnvestDbContext();
            _objSet = db.Set<T>();
        }

        public List<T> List()
        {
            return _objSet.ToList();
        }
        public IQueryable<T> ListQ(Expression<Func<T, bool>> where)
        {
            return _objSet.Where(where);
        }
        public IQueryable<T> ListQueryable()
        {
            return _objSet.AsQueryable<T>();
        }
        public int Save()
        {
            return db.SaveChanges();
        }

        public int Insert(T obj)
        {
            
            _objSet.Add(obj);
            BaseEntity baseEntity = obj as BaseEntity;
            baseEntity.CreatedDate = DateTime.Now;

            return Save();
        }

        public int Update(T obj)
        {
            BaseEntity baseEntity = obj as BaseEntity;
            baseEntity.UpdatedDate = DateTime.Now;
            return Save();
        }

        public int Delete(T obj)
        {
            _objSet.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objSet.FirstOrDefault(where);
        }
    }
}

using FanusYazilim.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.DataAccessLayer.EntityFramework
{
    public class GenericRepository<T>:RepositoryBase , IRepository<T>  where T:class
    {
        
        private DbSet<T> _objectSet;

        public GenericRepository()
        {
            _objectSet = db.Set<T>();
        }
        public List<T> AllDataList()
        {
            return _objectSet.ToList();
        }
        public List<T> QueryDataList(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }
        public int Update(T obj)
        {
            return Save();
        }
        public int Save()
        {
            return db.SaveChanges();
        }



    }
}

using FanusYazilim.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.BusinessLayer.Abstract
{
    public abstract class GenericManager<T> where T : class
    {
        protected GenericRepository<T> _repo = new GenericRepository<T>();

        public int Insert(T obj)
        {
            return _repo.Insert(obj);
        }

        public int Delete(T obj)
        {
            return _repo.Delete(obj);
        }
        public int Update(T obj)
        {
            return _repo.Update(obj);
        }
        public List<T> AllList()
        {
            return _repo.AllDataList();
        }
        public List<T> QueryDataList(Expression<Func<T, bool>> where)
        {
            return _repo.QueryDataList(where);
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return _repo.Find(where);
        }


    }
}

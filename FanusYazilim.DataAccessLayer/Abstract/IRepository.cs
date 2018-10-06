using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> AllDataList();
        List<T> QueryDataList(Expression<Func<T, bool>> where);
        T Find(Expression<Func<T, bool>> where);
        int Insert(T obj);
        int Delete(T obj);
        int Update(T obj);
        int Save();
    }
}

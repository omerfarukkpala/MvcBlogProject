using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDAL<T>
    {
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        T GetByID(int id);

        List<T> List(Expression<Func<T, bool>> filter);

        T Find(Expression<Func<T, bool>> where);
    }
}

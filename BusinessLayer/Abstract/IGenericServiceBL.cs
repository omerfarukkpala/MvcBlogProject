using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericServiceBL<T>
    {
        List<T> GetList();
        void TAdd(T t);
        T GetByID(int id);
        void TDelete(T t);
        void TUpdate(T t);
    }
}

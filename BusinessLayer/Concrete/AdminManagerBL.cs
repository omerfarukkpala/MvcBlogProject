using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManagerBL : IAdminServiceBL
    {
        IAdminDAL _adminDal;

        public AdminManagerBL(IAdminDAL adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetByID(int id)
        {
            return _adminDal.GetByID(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }

        public void TAdd(Admin t)
        {
            _adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
        }
    }
}

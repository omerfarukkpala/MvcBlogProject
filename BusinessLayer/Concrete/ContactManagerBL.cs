using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManagerBL : IContactServiceBL
    {
        RepositoryDAL<Contact> repocontact = new RepositoryDAL<Contact>();

        IContactDAL _contactDal;

        public ContactManagerBL(IContactDAL contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByID(int id)
        {
            return _contactDal.Find(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}

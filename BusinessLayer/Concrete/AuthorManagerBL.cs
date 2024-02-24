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
    public class AuthorManagerBL : IAuthorServiceBL
    {
        IAuthorDAL _authorDal;

        public AuthorManagerBL(IAuthorDAL authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public Author GetByID(int id)
        {
            return _authorDal.GetByID(id);
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Author t)
        {
            _authorDal.Insert(t);
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            _authorDal.Update(t);
        }
    }
}

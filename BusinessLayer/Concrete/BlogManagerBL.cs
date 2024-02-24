using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManagerBL : IBlogServiceBL
    {
        IBlogDAL _blogDal;

        public BlogManagerBL(IBlogDAL blogDal)
        {
            _blogDal = blogDal;
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.List(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.List(x => x.AuthorID == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return _blogDal.List(x => x.CategoryID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}

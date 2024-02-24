using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogServiceBL : IGenericServiceBL<Blog>
    {
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogByAuthor(int id);
    }
}

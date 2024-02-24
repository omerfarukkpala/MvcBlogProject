using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManagerBL
    {
        RepositoryDAL<Author> repouser = new RepositoryDAL<Author>();
        RepositoryDAL<Blog> repouserblog = new RepositoryDAL<Blog>();

        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.AuthorMail == p);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repouserblog.List(x=>x.AuthorID == id);
        }
        public void EditAuthor(Author p)
        {
            Author author = repouser.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorAboutShort = p.AuthorAboutShort;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorMail = p.AuthorMail;
            author.AuthorPassword = p.AuthorPassword;
            author.AuthorPhoneNumber = p.AuthorPhoneNumber;
            repouser.Update(author);
        }
    }
}

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
    public class CommentManagerBL : ICommentServiceBL
    {
        RepositoryDAL<Comment> repocomment = new RepositoryDAL<Comment>();

        ICommentDAL _commentDal;

        public CommentManagerBL(ICommentDAL commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return _commentDal.List(x => x.BlogID == id);
        }
        public List<Comment> CommentByStatusTrue()
        {
            return _commentDal.List(x => x.CommentStatus == true);
        }
        public List<Comment> CommentByStatusFalse()
        {
            return _commentDal.List(x => x.CommentStatus == false);
        }
        public void CommentStatusChangeToFalse(int id)
        {
            Comment comment = _commentDal.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            _commentDal.Update(comment);
        }
        public void CommentStatusChangeToTrue(int id)
        {
            Comment comment = _commentDal.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            _commentDal.Update(comment);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void CommentDelete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}

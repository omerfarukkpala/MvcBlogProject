using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManagerBL cm = new CommentManagerBL(new EFCommentDal());
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var commentcount = cm.CommentList().Where(x=>x.BlogID == id).Count();
            ViewBag.count = commentcount;

            var commentlist = cm.CommentByBlog(id);
            return PartialView(commentlist);
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            c.CommentStatus = true;
            cm.TAdd(c);
            return PartialView();
        }
        public ActionResult AdminCommentListTrue()
        {
            var commentlist = cm.CommentByStatusTrue();
            return View(commentlist);
        }
        public ActionResult AdminCommentListFalse()
        {
            var commentlist = cm.CommentByStatusFalse();
            return View(commentlist);
        }
        public ActionResult StatusChangeToFalse(int id)
        {
            cm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult StatusChangeToTrue(int id)
        {
            cm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}
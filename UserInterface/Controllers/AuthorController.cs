using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManagerBL bm = new BlogManagerBL(new EFBlogDal());
        AuthorManagerBL aum = new AuthorManagerBL(new EFAuthorDal());
        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetails = bm.GetBlogByID(id);
            return PartialView(authordetails);
        }
        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = bm.GetList().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();

            var authorblogs = bm.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }
        public ActionResult AuthorList()
        {
            var authorlists = aum.GetList();
            return View(authorlists);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results = authorValidator.Validate(p);

            if (results.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string fileName = Path.GetFileName(Request.Files[0].FileName);
                    string extension = Path.GetExtension(Request.Files[0].FileName);
                    string path = "~/Image/" + fileName + extension;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    p.AuthorImage = "/Image/" + fileName + extension;
                }

                aum.TAdd(p);
                return RedirectToAction("AuthorList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = aum.GetByID(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results = authorValidator.Validate(p);

            if (results.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string fileName = Path.GetFileName(Request.Files[0].FileName);
                    string extension = Path.GetExtension(Request.Files[0].FileName);
                    string path = "~/Image/" + fileName + extension;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    p.AuthorImage = "/Image/" + fileName + extension;
                }

                aum.TUpdate(p);
                return RedirectToAction("AuthorList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UserInterface.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            Context c = new Context();
            var userinfo = c.Authors.FirstOrDefault(x=>x.AuthorMail == p.AuthorMail && x.AuthorPassword == p.AuthorPassword);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.AuthorMail, false);
                Session["AuthorMail"] = userinfo.AuthorMail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context c = new Context();
            var admininfo = c.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.Username, false);
                Session["Username"] = admininfo.Username.ToString();
                return RedirectToAction("AdminBlogList2", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }
    }
}
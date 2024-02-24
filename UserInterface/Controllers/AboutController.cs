using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: About
        AboutManagerBL abm = new AboutManagerBL(new EFAboutDal());
        AuthorManagerBL aum = new AuthorManagerBL(new EFAuthorDal());
        public ActionResult Index()
        {
            var aboutcontent = abm.GetList();
            return View(aboutcontent);
        }
        public PartialViewResult Footer()
        {
            var aboutcontentlist = abm.GetList();
            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            var authorlist = aum.GetList();
            return PartialView(authorlist);
        }
        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutlist = abm.GetList();
            return View(aboutlist);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                p.AboutImage1 = "/Image/" + fileName + extension;
                p.AboutImage2 = "/Image/" + fileName + extension;
            }

            abm.TUpdate(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}
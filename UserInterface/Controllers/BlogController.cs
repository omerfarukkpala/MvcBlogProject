using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.IO;

namespace UserInterface.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManagerBL bm = new BlogManagerBL(new EFBlogDal());
        CommentManagerBL cm = new CommentManagerBL(new EFCommentDal());
        Context c = new Context();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogList(int page = 1)
        {
            var bloglist = bm.GetList().ToPagedList(page, 6);
            return PartialView(bloglist);
        }
        [AllowAnonymous]
        public PartialViewResult FeaturedPosts()
        {
            //1. Post
            var posttitle1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.pt1 = posttitle1;
            ViewBag.pi1 = postimage1;
            ViewBag.bd1 = blogdate1;
            ViewBag.bpid1 = blogpostid1;

            //2. Post
            var posttitle2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.pt2 = posttitle2;
            ViewBag.pi2 = postimage2;
            ViewBag.bd2 = blogdate2;
            ViewBag.bpid2 = blogpostid2;

            //3. Post
            var posttitle3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.pt3 = posttitle3;
            ViewBag.pi3 = postimage3;
            ViewBag.bd3 = blogdate3;
            ViewBag.bpid3 = blogpostid3;

            //4. Post
            var posttitle4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.pt4 = posttitle4;
            ViewBag.pi4 = postimage4;
            ViewBag.bd4 = blogdate4;
            ViewBag.bpid4 = blogpostid4;

            //5. Post
            var posttitle5 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate5 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid5 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.pt5 = posttitle5;
            ViewBag.pi5 = postimage5;
            ViewBag.bd5 = blogdate5;
            ViewBag.bpid5 = blogpostid5;

            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public ActionResult BlogDetails()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogCover(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        [AllowAnonymous]
        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        [AllowAnonymous]
        public ActionResult BlogByCategory(int id)
        {
            var BlogListByCategory = bm.GetBlogByCategory(id);
            var CategoryName = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryName).FirstOrDefault();
            ViewBag.cn = CategoryName;

            var CategoryDescription = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.cd = CategoryDescription;

            return View(BlogListByCategory);
        }
        public ActionResult AdminBlogList()
        {
            var bloglist = bm.GetList();
            return View(bloglist);
        }
        public ActionResult AdminBlogList2()
        {
            var bloglist = bm.GetList();
            return View(bloglist);
        }
        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult AddNewBlog()
        {         
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();

            ViewBag.val = values;
            ViewBag.val2 = values2;

            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog b)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                b.BlogImage = "/Image/" + fileName + extension;
                b.BlogImage2 = "/Image/" + fileName + extension;
                b.BlogImage3 = "/Image/" + fileName + extension;
            }

            bm.TAdd(b);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult DeleteBlog(int id)
        {
            Blog blog = bm.GetByID(id);
            bm.TDelete(blog);
            return RedirectToAction("AdminBlogList");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = bm.GetByID(id);

            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();

            ViewBag.val = values;
            ViewBag.val2 = values2;
            
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                p.BlogImage = "/Image/" + fileName + extension;
                p.BlogImage2 = "/Image/" + fileName + extension;
                p.BlogImage3 = "/Image/" + fileName + extension;
            }

            bm.TUpdate(p);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult GetCommentByBlog(int id)
        {           
            var commentlist = cm.CommentByBlog(id);
            return View(commentlist);
        }
        public ActionResult AuthorBlogList(int id)
        {
            var blogs = bm.GetBlogByAuthor(id);
            return View(blogs);
        }
    }
}
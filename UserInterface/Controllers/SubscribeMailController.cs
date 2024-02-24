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
    [AllowAnonymous]
    public class SubscribeMailController : Controller
    {
        // GET: SubscribeMail
        SubscribeMailManagerBL sm = new SubscribeMailManagerBL(new EFSubscribeMailDal());
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {          
            sm.TAdd(p);
            return PartialView();
        }
    }
}
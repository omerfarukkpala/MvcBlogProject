using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManagerBL adminmanager = new AdminManagerBL(new EFAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminmanager.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            List<SelectListItem> valueAdminRole = new List<SelectListItem>();
            valueAdminRole.Add(new SelectListItem
            {
                Text = "A",
                Value = "A"

            });
            valueAdminRole.Add(new SelectListItem
            {
                Text = "B",
                Value = "B"

            });
            ViewBag.vlc = valueAdminRole;

            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            AdminValidator adminvalidator = new AdminValidator();
            ValidationResult results = adminvalidator.Validate(p);

            if (results.IsValid)
            {
                adminmanager.TAdd(p);
                return RedirectToAction("Index");
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
        public ActionResult EditAdmin(int id)
        {
            List<SelectListItem> valueAdminRole = new List<SelectListItem>();
            valueAdminRole.Add(new SelectListItem
            {
                Text = "A",
                Value = "A"

            });
            valueAdminRole.Add(new SelectListItem
            {
                Text = "B",
                Value = "B"

            });
            ViewBag.vlc = valueAdminRole;

            var adminValue = adminmanager.GetByID(id);
            return View(adminValue);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            AdminValidator adminvalidator = new AdminValidator();
            ValidationResult results = adminvalidator.Validate(p);

            if (results.IsValid)
            {
                adminmanager.TUpdate(p);
                return RedirectToAction("Index");
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
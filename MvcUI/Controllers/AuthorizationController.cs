using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Controllers
{
    public class AuthorizationController : Controller
    {

        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminManager.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin admin)
        {
            adminManager.AdminAddBl(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = adminManager.GetById(id);
            return View(adminvalue);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin admin)
        {
            adminManager.AdminUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}
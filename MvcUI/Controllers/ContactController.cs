using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator validationRules = new ContactValidator();
        // GET: Category
        public ActionResult Index()
        {
            TempData["ContactCount"] = contactManager.GetList().Count();
            var contactvalues = contactManager.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = contactManager.GetById(id);
            return View(contactvalues);
        }
        
       public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}

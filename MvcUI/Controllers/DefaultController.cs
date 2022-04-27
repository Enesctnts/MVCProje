using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Controllers
{
    public class DefaultController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        public ActionResult Headings()
        {
            var headinglist = headingManager.GetList();
            return View(headinglist);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
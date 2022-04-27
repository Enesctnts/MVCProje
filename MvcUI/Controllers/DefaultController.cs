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
        ContentManager contentManager = new ContentManager(new EfContentDal());   
        public ActionResult Headings()
        {
            var headinglist = headingManager.GetList();
            return View(headinglist);
        }
        public PartialViewResult Index()
        {
            var contentlist = contentManager.GetList();
            return PartialView(contentlist);
        }
    }
}
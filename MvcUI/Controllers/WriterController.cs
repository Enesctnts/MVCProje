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
    public class WriterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult GetWriterList()
        {
            var writervalues = writerManager.GetList();
            return View(writervalues);
        }


        [HttpGet]// sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]// butona tıklandıgında alttaki metod çalışacak
        public ActionResult AddWriter(Writer writer)
        {
            writerManager.WriterAddBl(writer);
            return RedirectToAction("GetWriterList");
        }
    }
}
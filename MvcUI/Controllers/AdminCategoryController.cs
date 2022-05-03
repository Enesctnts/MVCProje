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

namespace MvcUI.Controllers
{
    [Authorize(Roles = "A")]
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory

        [Authorize(Roles="A")]//Sadece A rolüne sahip kişiler görüntüleyebilir 
        public ActionResult Index()
        {
            var categoryvalues = categoryManager.GetList();
            return View(categoryvalues);
        }
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public ActionResult GetCategoryList()
        {
            var categoryvalues = categoryManager.GetList();
            return View(categoryvalues);
        }


        [HttpGet]// sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]// butona tıklandıgında alttaki metod çalışacak
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)//Geçerli ise
            {
                categoryManager.CategoryAddBl(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
        }
        public ActionResult DeleteCategory(int id)
        {
            var result = categoryManager.GetById(id);
            categoryManager.CategoryDelete(result);
            return RedirectToAction("GetCategoryList");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var result = categoryManager.GetById(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            categoryManager.CategoryUpdate(category);
            return RedirectToAction("GetCategoryList");
        }

    }
}
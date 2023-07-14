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

namespace MvcProjeKamp.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        //EfCategoryDal: farklı bir bileşene geçtiğimde bu bileşene daha az bağımlı olması için böyle bir şey yaptım.
        // GET: AdminCategory
        public ActionResult Index()
        {
            //listeleme
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult results = categoryvalidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAddBL(p);
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

        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetById(id); 
            //silecegimiz degerin id'sini GetById ile buluyoruz 
            cm.CategoryRemoveBL(categoryvalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = cm.GetById(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category ctg)
        {
            cm.CategoryUpdateBL(ctg);
            return RedirectToAction("Index");
        }
    }
}
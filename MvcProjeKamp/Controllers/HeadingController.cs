using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var headingvalues = headingManager.Getlist();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            //kategori dropdownlist için: önce categorymanagerdan nesne üret
            List<SelectListItem> valuecategory = (from value in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = value.CategoryName,
                                                      Value = value.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.categoryvalues = valuecategory;

            //yazar dropdownlist için: önce writermanagerdan nesne üret
            List<SelectListItem> valuewriter = (from val in writerManager.Getlist()
                                                select new SelectListItem
                                                {
                                                    Text = val.WriterName + " " + val.WriterSurname,
                                                    Value = val.WriterId.ToString()
                                                }).ToList();
            ViewBag.writervalues = valuewriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //ekleme işleminde bugünün kısa tarihini aldım.
            //viewda bunu görünmeyecek. sql'e tabloya bugunun tarihiyle kaydolacak.
            headingManager.HeadingAddBL(p);
            return RedirectToAction("Index");

        }
        ////başlığa göre içerik getirme 
        //public ActionResult ContentByHeading()
        //{
        //    return View();
        //}
    }
}
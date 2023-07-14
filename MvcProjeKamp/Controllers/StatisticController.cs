using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class StatisticController : Controller
        
    {
        // GET: istatistik

        Context _context = new Context();
        public ActionResult Index()
        {
            


            //Toplam kategori sayısı
            var totalCategory = _context.Categories.Count(); 
            ViewBag.totalNumberOfCategories = totalCategory;

            //Yazılım kategorisine ait başlık sayısı
            var totalSoftwareTitle = _context.Categories.Where(x => x.CategoryName == "Yazılım").Count();
            ViewBag.softwareCategoryTitleNumber = totalSoftwareTitle;

            //Yazar adında 'a' harfi geçen yazar sayısı
            var writerNameSortByA = _context.Writers.Count(x => x.WriterName.Contains("a")); 
            ViewBag.writerNameSortByA = writerNameSortByA;

            //En fazla başlığa sahip kategori adı
            var mostTitles = _context.Headings.Max(x => x.Category.CategoryName); 
            ViewBag.categoryNameWithTheMostTitles = mostTitles;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark (aktif kategorileri getir)
            var categoryStatusTrue = _context.Categories.Where(x => x.CategoryStatus == true).Count(); 
            ViewBag.activeCategories = categoryStatusTrue;

           
            return View();
        }
    }
}

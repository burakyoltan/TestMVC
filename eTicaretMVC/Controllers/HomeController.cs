using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eTicaretMVC.Models;

namespace eTicaretMVC.Controllers
{
    public class HomeController : Controller
    {
        readonly DataContext _context=new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.Where(i=>i.IsHome==true).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.FirstOrDefault(i => i.Id == id));

        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Products.Where(i=>i.IsApproved).AsQueryable();

            if (id != null)
            {
                urunler=urunler.Where(i => i.CategoryId == id);
            }
           
            return View(urunler.ToList());

        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eTicaretMVC.Models;

namespace eTicaretMVC.Controllers
{
    public class CardController : Controller
    {
        private  DataContext db=new DataContext();


        public ActionResult Index()
        {
            return View(GetCard());
        }

        // GET: Card
        public ActionResult AddToCard(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id==Id);

            if (product !=null)
            {
                GetCard().AddProduct(product,1);
            }

            return RedirectToAction("Index");
        }
        public ActionResult RemovoFromCard(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCard().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }


        public Card GetCard()
        {

            var card = (Card) Session["Card"];
            if (card == null)
            {
                card=new Card();
                Session["Card"] = card;
            }

            return card;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCard());
        }

    }
}
using InsertMultplePrpduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsertMultplePrpduct.Controllers
{
    public class HomeController : Controller
    {

        private Database1Entities db = new Database1Entities();
        // GET: Home
        public ActionResult Index()
        {
            //var db = new Model1();
            var listCategory = db.Categories.ToList();
            return View(listCategory);
        }
        [HttpPost]
        public ActionResult AddProduct(List<Product> ListProduct)
        {
            //var db = new Model1();
            db.Products.AddRange(ListProduct);
            db.SaveChangesAsync();
            var result = new { message = ListProduct.Count + " product(s) save successfully." };
            return Json(result);
        }
    }
}
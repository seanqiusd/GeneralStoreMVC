using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        // Add the application Db Context (link to the datebase)
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Product/Index
        public ActionResult Index()
        {
            // See below (modifying ApplicationDbContext class)
            return View(_db.Products.ToList());
        }

        


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}
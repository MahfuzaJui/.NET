using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Products.Models;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Productlist> products = new List<Productlist>();
            for(int i=0; i<10; i++)
            {
                var p = new Productlist
                {
                    ID = i + 1,
                    Name = "Product" + (i + 1),
                    
                };
                products.Add(p);
            }
            return View(products);
        }
    }
}
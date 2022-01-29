using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop.Controllers
{
    public class ShoesController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        // GET: Shoes
        public ActionResult GetAllShoes(string theButton)
        {
            switch (theButton)
            {
                case "showSales":
                    return View(dataContext.Shoes.Where(theShoe => theShoe.inSale == true).ToList());
                case "sort":
                    return View(dataContext.Shoes.OrderBy(theShoe => theShoe.price).ToList());
                default:
                    break;
            }
            return View(dataContext.Shoes.ToList());
        }
    }
}
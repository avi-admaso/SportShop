using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop.Controllers
{
    public class MangerController : Controller
    {
        // GET: Manger
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        public ActionResult ManagerPage(string theButton)
        {
            switch (theButton)
            {
                case "mangerShirts":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "shirt").ToList());
                case "mangerPants":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "pants").ToList());
                default:
                    break;
            }
            return View();
        }
        public ActionResult ManagerPageEquipments(string theButton)
        {
            switch (theButton)
            {
                case "mangerEquipments":
                    return View(dataContext.Equipments.ToList());

                default:
                    break;
            }
            return View();
        }
        public ActionResult ManagerPageShoes(string theButton)
        {
            switch (theButton)
            {

                case "mangerShoes":
                    return View(dataContext.Shoes.ToList());
                default:
                    break;
            }
            return View();
        }
    }
}
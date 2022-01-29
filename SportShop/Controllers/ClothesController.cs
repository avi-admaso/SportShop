using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop.Controllers
{
    public class ClothesController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        // GET: Clothes
        public ActionResult GetAllShirts(string theButton)

        {
            switch (theButton)
            {

                case "theShorts":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "shirt" & clothe.isShort == true).ToList());
                case "long":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "shirt" & clothe.isShort == false).ToList());
                case "drifit":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "shirt" & clothe.isDrifit == true).ToList());
                case "sort":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "shirt").OrderBy(item => item.price).ToList());
                default:
                    break;
            }
            return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "shirt").ToList());
        }

        public ActionResult GetAllPants(string theButton)
        {
            switch (theButton)
            {
                case "theShorts":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "pants" & clothe.isShort == true).ToList());
                case "long":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "pants" & clothe.isShort == false).ToList());
                case "drifit":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "pants" & clothe.isDrifit == true).ToList());
                case "sort":
                    return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "pants").OrderBy(item => item.price).ToList());
                default:
                    break;
            }
            return View(dataContext.Clothes.Where(clothe => clothe.clothesType == "pants").ToList());
        }
    public ActionResult MangerShirtsView()
    {
        return View();
    }
    public ActionResult MangerPantsView()
    {
        return View();
    }
    }
}
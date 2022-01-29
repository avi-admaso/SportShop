using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop.Controllers
{
    public class EquipmentsController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        // GET: Equipment
        public ActionResult GetAllEquipments(string theButton)
        {

            switch (theButton)
            {

                case "soccer":
                    return View(dataContext.Equipments.Where(equip => equip.sportType == "soccer").ToList());
                case "basketBall":
                    return View(dataContext.Equipments.Where(equip => equip.sportType == "basketball").ToList());
                case "sort":
                    return View(dataContext.Equipments.OrderBy(item => item.price).ToList());
                default:
                    break;
            }
            return View(dataContext.Equipments.ToList());
        }

    }
}

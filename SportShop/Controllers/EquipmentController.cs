using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop.Controllers
{
    public class EquipmentController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        // GET: Equipment
        public ActionResult GetAllEquipmentts()
        {
            return View(dataContext.Equipments.ToList());
        }
    }
}
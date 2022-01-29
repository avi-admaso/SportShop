using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportShop.Controllers.api
{
    public class EquipmentsController : ApiController
    {
        // GET: api/Equipments
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        public IHttpActionResult Get()
        {

            return Ok(dataContext.Equipments.ToList());
        }

        // GET: api/Equipments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Equipments
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Equipments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Equipments/5
        public void Delete(int id)
        {
        }
    }
}

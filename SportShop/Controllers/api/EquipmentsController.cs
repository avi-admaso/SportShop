using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {

                List<Equipment> getTheEquipment = dataContext.Equipments.ToList();
                return Ok(getTheEquipment);
            }
            catch (SqlException)
            {
                return BadRequest("Error");

            }
            catch (Exception)
            {
                return BadRequest("Error");

            }
        }

        // GET: api/Equipments/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                List<Equipment> getById = dataContext.Equipments.Where(item => item.Id == id).ToList();
                return Ok(getById);
            }
            catch (SqlException)
            {
                return BadRequest("Error");

            }
            catch (Exception)
            {
                return BadRequest("Error");

            }
        }

        // POST: api/Equipments
        public IHttpActionResult Post([FromBody] Equipment value)
        {
            try
            {


                dataContext.Equipments.InsertOnSubmit(value);
                dataContext.SubmitChanges();
                return Ok("good Job");
            }
            catch (SqlException)
            {
                return BadRequest("Error");

            }
            catch (Exception)
            {
                return BadRequest("Error");

            }
        }

        // PUT: api/Equipments/5
        public IHttpActionResult Put(int id, [FromBody] Equipment value)
        {
            try
            {
                Equipment theEquipments = dataContext.Equipments.First(item => item.Id == id);
                theEquipments.sportType = value.sportType;
                theEquipments.equipmentName = value.equipmentName;
                theEquipments.company = value.company;
                theEquipments.price = value.price;
                theEquipments.quantity = value.quantity;
                theEquipments.inSupplay = value.inSupplay;
                theEquipments.photo = value.photo;
                dataContext.SubmitChanges();
                return Ok("good job");
            }
            catch (SqlException)
            {
                return BadRequest("Error");

            }
            catch (Exception)
            {
                return BadRequest("Error");

            }
        }

        // DELETE: api/Equipments/5
        public IHttpActionResult Delete(int id)
        {

            try
            {
                Equipment getById = dataContext.Equipments.First(item => item.Id == id);
                dataContext.Equipments.DeleteOnSubmit(getById);
                dataContext.SubmitChanges();
                return Ok("the item delete");

            }
            catch (SqlException)
            {
                return BadRequest("Error");

            }
            catch (Exception)
            {
                return BadRequest("Error");

            }
        }
    }
}

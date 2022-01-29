using SportShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportShop.Controllers.Api
{
    public class ClothesController : ApiController
    {
        // GET: api/Clothes
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        public IHttpActionResult Get()
        {
            try
            {

                List<Clothe> getTheClothes = dataContext.Clothes.ToList();
                return Ok(getTheClothes);
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

        // GET: api/Clothes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                List<Clothe> getById = dataContext.Clothes.Where(item => item.Id == id).ToList();
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

        // POST: api/Clothes
        public IHttpActionResult Post([FromBody] Clothe value)
        {
            try
            {


                dataContext.Clothes.InsertOnSubmit(value);
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

        // PUT: api/Clothes/5
        public IHttpActionResult Put(int id, [FromBody] Clothe value)
        {
            try
            {
            Clothe theClothes = dataContext.Clothes.First(item => item.Id == id);
            theClothes.clothesType = value.clothesType;
            theClothes.gender = value.gender;
            theClothes.company = value.company;
            theClothes.model = value.model;
            theClothes.price = value.price;
            theClothes.quantity = value.quantity;
            theClothes.isShort = value.isShort;
            theClothes.isDrifit = value.isDrifit;
            theClothes.photo = value.photo;
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

        // DELETE: api/Clothes/5
        public IHttpActionResult Delete(int id)
        {

            try
            {
            Clothe getById = dataContext.Clothes.First(item => item.Id == id);
            dataContext.Clothes.DeleteOnSubmit(getById);
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

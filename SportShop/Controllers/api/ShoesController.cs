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
    public class ShoesController : ApiController
    {
        static string stringConnection = "Data Source=.;Initial Catalog=SportShop;Integrated Security=True;Pooling=False";
        SportShopDataContext dataContext = new SportShopDataContext();
        public IHttpActionResult Get()
        {
            try
            {

                List<Shoe> getTheShoes = dataContext.Shoes.ToList();
                return Ok(getTheShoes);
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

        // GET: api/Shoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                List<Shoe> getById = dataContext.Shoes.Where(item => item.Id == id).ToList();
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

        // POST: api/Shoes
        public IHttpActionResult Post([FromBody] Shoe value)
        {
            try
            {


                dataContext.Shoes.InsertOnSubmit(value);
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

        // PUT: api/Shoes/5
        public IHttpActionResult Put(int id, [FromBody] Shoe value)
        {
            try
            {
                Shoe theShoes = dataContext.Shoes.First(item => item.Id == id);
                theShoes.shoeType = value.shoeType;
                theShoes.model = value.model;
                theShoes.price = value.price;
                theShoes.quantity = value.quantity;
                theShoes.inSale = value.inSale;
                theShoes.photo = value.photo;
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

        // DELETE: api/Shoes/5
        public IHttpActionResult Delete(int id)
        {

            try
            {
                Shoe getById = dataContext.Shoes.First(item => item.Id == id);
                dataContext.Shoes.DeleteOnSubmit(getById);
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

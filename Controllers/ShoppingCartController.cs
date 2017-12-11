using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstREST.Lib_Primavera.Model;

namespace FirstREST.Controllers
{
    public class ShoppingCartController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Lib_Primavera.Model.ShoppingCart> Get()
        {
            System.Diagnostics.Debug.WriteLine("HEREEEE");
            return Lib_Primavera.PriIntegration.getShoppingCartItems();
            System.Diagnostics.Debug.WriteLine("FINISHED");
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
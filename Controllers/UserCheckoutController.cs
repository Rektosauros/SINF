using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstREST.Lib_Primavera.Model;

namespace FirstREST.Controllers
{
    public class UserCheckoutController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public void Get(string id)
        {
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(string name)
        {

            //string name = formData["UserName"];
            System.Diagnostics.Debug.WriteLine("OLAAAAA "+name);
            System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PRIDEMOSINF"].ConnectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader reader;

            /*cmd.CommandText = "DELETE FROM dbo.ShoppingCart WHERE CartItemId LIKE '1'";*/
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConn;
            sqlConn.Open();
            reader = cmd.ExecuteReader();
            sqlConn.Close();
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
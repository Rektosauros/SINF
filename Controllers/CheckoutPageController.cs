using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.Controllers
{
    public class CheckoutPageController : Controller
    {
        //
        // GET: /CheckoutPage/

        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Checkout(string Name, string Email, string CellNumber, string Address, string PostalCode)
        {
            System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PRIDEMOSINF"].ConnectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader reader;

            cmd.CommandText = "INSERT INTO dbo.UserCheckOut(UserName, Address, PostalCode, Email, CellNumber) VALUES('"+Name+"', '"+Address+"', '"+PostalCode+"', '"+Email+"', '"+CellNumber+"')";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConn;
            sqlConn.Open();
            reader = cmd.ExecuteReader();
            sqlConn.Close();

            cmd.CommandText = "DELETE FROM ShoppingCart";
            sqlConn.Open();
            reader = cmd.ExecuteReader();
            sqlConn.Close();

            System.Diagnostics.Debug.WriteLine("OLAAAAA " + Name);
            return View();
        }

    }
}

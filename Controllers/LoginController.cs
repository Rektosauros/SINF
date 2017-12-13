using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstREST.Lib_Primavera.Model;
using Interop.StdBE900;
using FirstREST.Lib_Primavera;

namespace FirstREST.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserCheckOut objUser)
        {
            //StdBELista objList = PriEngine.Engine.Consulta("SELECT Descricao from FAMILIAS WHERE Familia LIKE 'COMP'");
            StdBELista objList = PriEngine.Engine.Consulta("SELECT UserId from USERPROFILE WHERE UserName LIKE 'Jaquim' AND Password LIKE 'teste'");
            System.Diagnostics.Debug.WriteLine("1 "+ objList.Valor("UserId"));
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("2 "+ objList.Valor("UserId"));


               
               // System.Diagnostics.Debug.WriteLine("USER ID das " + objList.Valor("Descricao"));
                
               // System.Diagnostics.Debug.WriteLine("USER ID "+objList.Valor("UserId"));
                if (objList.Valor("UserId") != null)
                {
                    /*UserCheckOut tempUser = Lib_Primavera.PriIntegration.GetUserProf(objUser.UserCod);
                    Session["UserID"] = tempUser.UserCod.ToString();
                    Session["UserName"] = tempUser.UserName.ToString();
                    return RedirectToAction("UserDashBoard");*/
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
       
    }
}

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
        public ActionResult Login(UserProfile objUser)
        {
            if (ModelState.IsValid)
            {
                StdBELista objList = PriEngine.Engine.Consulta("SELECT UserId from UserProfile WHERE UserName LIKE '"+objUser.UserName+" AND Password LIKE '"+objUser.Password+"'");
                if (objList.Valor("UserId") != null)
                {
                    UserProfile tempUser = Lib_Primavera.PriIntegration.GetUserProf(objUser.UserCod);
                    Session["UserID"] = tempUser.UserCod.ToString();
                    Session["UserName"] = tempUser.UserName.ToString();
                    return RedirectToAction("UserDashBoard");
                }
            }
            return View(objUser);
        }
       
    }
}

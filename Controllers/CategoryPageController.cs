using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstREST.Lib_Primavera.Model;

namespace FirstREST.Controllers
{
    public class CategoryPageController : Controller
    {
        //
        // GET: /CategoryPage/

        public ActionResult Category(string id)
        {
            Familias fam = new Familias { Familia = id };
            return View(fam);
        }

    }
}

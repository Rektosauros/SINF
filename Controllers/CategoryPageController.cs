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
    public class CategoryPageController : Controller
    {
        //
        // GET: /CategoryPage/

        public ActionResult Category(string id)
        {
            StdBELista objList = PriEngine.Engine.Consulta("SELECT Descricao from FAMILIAS WHERE Familia LIKE '"+id+"'");
            Familias fam = new Familias { Familia = id, Descricao = objList.Valor("Descricao") };
            return View(fam);
        }

    }
}

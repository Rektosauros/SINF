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
    public class ItemPageController : Controller
    {
        // GET api/<controller>
        public ActionResult Index(string id)
        {
            StdBELista objList = PriEngine.Engine.Consulta("SELECT Descricao, STKActual, PCMEDIO, Familia FROM ARTIGO WHERE Artigo LIKE '" + id + "'");
            Artigo art = new Artigo { CodArtigo = id, DescArtigo = objList.Valor("Descricao"), STKAtual = objList.Valor("STKActual"), Familia = objList.Valor("Familia"), Price = objList.Valor("PCMEDIO") };
            return View(art);
        }

        
    }
}
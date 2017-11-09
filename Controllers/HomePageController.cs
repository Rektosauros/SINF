using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HomePage/Welcome

        public String Welcome()
        {
            return "This is my welcome action method";
        }

    }
}

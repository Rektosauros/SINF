﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.Controllers
{
    public class ShoppingCartPageController : Controller
    {
        //
        // GET: /ShoppingCartPage/

        public ActionResult ShoppingCart()
        {
            return View();
        }

    }
}

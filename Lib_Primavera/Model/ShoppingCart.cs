using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class ShoppingCart
    {
        public int CartItemID { get; set; }

        public string ArtigoID { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class UserCheckOut
    {     
        public string UserCod
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }


        public string Address { get; set; }

        public string PostalCode { get; set; }

        /*public string NumContribuinte
        {
            get;
            set;
        }*/

        public string Email
        {
            get;
            set;
        }

        public string CellNumber { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLANES.Controllers
{
    public class PbaController : Controller
    {
        // 
        // GET: /Pba/

        public string Index()
        {
            return ">>>>>>>>>>>>>>>>>>>>>>>>>>>This is my default action..FROM Pba.";
            return ">>>>>>>>>>>>>>>>>>>>>>>>>>>This is my default action..FROM Pba.";
        }

        // 
        // GET: /Pba/Welcome/ 

        public string Welcome( )
        {
            return "**********************************This is the Welcome action method..FROM Pba/Welcome/.";
            return "**********************************This is the Welcome action method..FROM Pba/Welcome/.";
        }
    }
}

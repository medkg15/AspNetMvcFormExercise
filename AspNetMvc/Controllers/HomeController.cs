using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcData.Callouts;

namespace AspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalloutQuery _query;

        public HomeController(ICalloutQuery query)
        {
            _query = query;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
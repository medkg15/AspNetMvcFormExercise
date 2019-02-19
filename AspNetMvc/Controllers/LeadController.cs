using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcData.Leads;

namespace AspNetMvc.Controllers
{
    public class LeadController : Controller
    {
        private readonly ILeadHandler _leadHandler;

        public LeadController(ILeadHandler leadHandler)
        {
            _leadHandler = leadHandler;
        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
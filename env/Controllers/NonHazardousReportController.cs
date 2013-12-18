using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers
{
    public class NonHazardousReportController : Controller
    {
        //
        // GET: /NonHazardousReport/

        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult WasteReport()
        {
            return PartialView();
        }

    }
}

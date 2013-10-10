using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers
{
    public class HazardousMonthReportController : Controller
    {
        //
        // GET: /HazardousMonthReport/

        public ActionResult Index()
        {
            return PartialView();
        }

    }
}

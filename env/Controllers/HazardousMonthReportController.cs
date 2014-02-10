using env.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers
{
    [AuthorizeUser("")]
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

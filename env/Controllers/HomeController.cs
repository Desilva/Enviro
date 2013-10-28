using env.Models;
using env.Models.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers
{
    public class HomeController : Controller
    {
        public star_energy_enviroEntities db = new star_energy_enviroEntities();
        public List<GraphicTypeWrapper> lgt = new List<GraphicTypeWrapper>();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            lgt = (from type in db.graphic_type
                   select new GraphicTypeWrapper
                   {
                       id = type.id,
                       name = type.name,
                       peraturan = type.peraturan
                   }).ToList();
            ViewBag.lgt = lgt;
            return View();
        }

    }
}

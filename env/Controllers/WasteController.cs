using env.Models;
using env.Models.Wrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers
{
    public class WasteController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /Waste/

        public ActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult Binding()
        {
            List<WasteWrapper> list = db.waste_hazardous.Select(p => new WasteWrapper { id = p.id, name = p.name, waste_code = p.waste_code }).OrderByDescending(p => p.id).ToList();
            return Json(list);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<waste_hazardous> models)
        {
            List<WasteWrapper> ss = new List<WasteWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new waste_hazardous
                {
                    name = source.name,
                    waste_code = source.waste_code
                };

                db.waste_hazardous.Add(s);
                db.SaveChanges();
                // store the product in the result
                ss.Add(new WasteWrapper { id = s.id, name = s.name, waste_code = s.waste_code });
            }
            return Json(ss.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<waste_hazardous> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                waste_hazardous s = db.waste_hazardous.Find(source.id);
                s.name = source.name;
                s.waste_code = source.waste_code;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        [HttpPost]
        public ActionResult Delete(IEnumerable<waste_hazardous> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                waste_hazardous s = db.waste_hazardous.Find(source.id);
                db.waste_hazardous.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

    }
}

using env.Models;
using env.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers
{
    [AuthorizeUser("")]
    public class GraphicsUnitController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /GraphicsUnit/

        public ActionResult Index()
        {
            return PartialView();
        }

        //
        // POST: /GraphicsUnit/Binding

        [HttpPost]
        public JsonResult Binding()
        {
            List<graphics_unit> list = db.graphics_unit.OrderByDescending(p => p.id).ToList();
            return Json(list);
        }

        //
        // POST: /GraphicsUnit/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<graphics_unit> models)
        {
            List<graphics_unit> ss = new List<graphics_unit>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new graphics_unit
                {
                    unit = source.unit
                };

                db.graphics_unit.Add(s);
                db.SaveChanges();
                // store the product in the result
                ss.Add(new graphics_unit { id = s.id, unit = s.unit });
            }
            return Json(ss.ToList());
        }

        //
        // POST: /GraphicsUnit/Edit

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<graphics_unit> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                graphics_unit s = db.graphics_unit.Find(source.id);
                s.unit = source.unit;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        //
        // POST: /GraphicsUnit/Delete

        [HttpPost]
        public ActionResult Delete(IEnumerable<graphics_unit> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                graphics_unit s = db.graphics_unit.Find(source.id);
                db.graphics_unit.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

    }
}

using env.Models;
using env.Models.Wrapper;
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
    public class WasteUnitController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /WasteUnit/

        public ActionResult Index()
        {
            return PartialView();
        }

        //
        // POST: /WasteUnit/Binding

        [HttpPost]
        public JsonResult Binding()
        {
            List<WasteUnitWrapper> list = db.satuan_unit.Select(p => new WasteUnitWrapper { id = p.id, satuan = p.satuan, unit_conversion = p.unit_conversion }).OrderByDescending(p => p.id).ToList();
            return Json(list);
        }

        //
        // POST: /WasteUnit/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<satuan_unit> models)
        {
            List<WasteUnitWrapper> ss = new List<WasteUnitWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new satuan_unit
                {
                    satuan = source.satuan,
                    unit_conversion = source.unit_conversion
                };

                db.satuan_unit.Add(s);
                db.SaveChanges();
                // store the product in the result
                ss.Add(new WasteUnitWrapper { id = s.id, satuan = s.satuan, unit_conversion = s.unit_conversion });
            }
            return Json(ss.ToList());
        }

        //
        // POST: /WasteUnit/Edit

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<satuan_unit> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                satuan_unit s = db.satuan_unit.Find(source.id);
                s.satuan = source.satuan;
                s.unit_conversion = source.unit_conversion;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        //
        // POST: /WasteUnit/Delete

        [HttpPost]
        public ActionResult Delete(IEnumerable<satuan_unit> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                satuan_unit s = db.satuan_unit.Find(source.id);
                db.satuan_unit.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

    }
}

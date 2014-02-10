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
    public class SourceWasteController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /SourceWaste/

        public ActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult Binding()
        {
            List<SourceWasteWrapper> list = db.source_of_waste.Select(p => new SourceWasteWrapper{ id = p.id, source = p.source}).OrderByDescending(p => p.id).ToList();
            return Json(list);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<source_of_waste> models)
        {
            List<SourceWasteWrapper> ss = new List<SourceWasteWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new source_of_waste
                {
                    source = source.source
                };

                db.source_of_waste.Add(s);
                db.SaveChanges();
                // store the product in the result
                ss.Add(new SourceWasteWrapper { id = s.id, source = s.source});
            }
            return Json(ss.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<source_of_waste> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                source_of_waste s = db.source_of_waste.Find(source.id);
                s.source = source.source;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        [HttpPost]
        public ActionResult Delete(IEnumerable<source_of_waste> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                source_of_waste s = db.source_of_waste.Find(source.id);
                db.source_of_waste.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

    }
}

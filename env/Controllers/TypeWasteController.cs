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
    public class TypeWasteController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /TypeWaste/

        public ActionResult Index()
        {
            return PartialView();
        }

        //
        // POST: /TypeWaste/Binding

        [HttpPost]
        public JsonResult Binding()
        {
            List<TypeWasteWrapper> list = db.type_of_waste.Select(p => new TypeWasteWrapper { id = p.id, name = p.name }).OrderByDescending(p => p.id).ToList();
            return Json(list);
        }

        //
        // POST: /TypeWaste/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<type_of_waste> models)
        {
            List<TypeWasteWrapper> ss = new List<TypeWasteWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new type_of_waste
                {
                    name = source.name
                };

                db.type_of_waste.Add(s);
                db.SaveChanges();
                // store the product in the result
                ss.Add(new TypeWasteWrapper { id = s.id, name = s.name });
            }
            return Json(ss.ToList());
        }

        //
        // POST: /TypeWaste/Edit

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<type_of_waste> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                type_of_waste s = db.type_of_waste.Find(source.id);
                s.name = source.name;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        //
        // POST: /TypeWaste/Delete

        [HttpPost]
        public ActionResult Delete(IEnumerable<type_of_waste> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                type_of_waste s = db.type_of_waste.Find(source.id);
                db.type_of_waste.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

    }
}

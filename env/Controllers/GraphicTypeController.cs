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
    public class GraphicTypeController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();

        //
        // GET: /GraphicType/

        public ActionResult Index()
        {
            return PartialView();
        }

        //
        // POST: /GraphicType/Binding

        [HttpPost]
        public JsonResult Binding()
        {
            List<GraphicTypeWrapper> list = db.graphic_type.Select(p => new GraphicTypeWrapper { id = p.id, name = p.name, peraturan = p.peraturan }).OrderByDescending(p => p.id).ToList();
            return Json(list);
        }

        //
        // POST: /GraphicType/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<graphic_type> models)
        {
            List<GraphicTypeWrapper> ss = new List<GraphicTypeWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new graphic_type
                {
                    name = source.name,
                    peraturan = source.peraturan
                };

                db.graphic_type.Add(s);
                db.SaveChanges();
                // store the product in the result
                ss.Add(new GraphicTypeWrapper { id = s.id, name = s.name, peraturan = s.peraturan });
            }
            return Json(ss.ToList());
        }

        //
        // POST: /GraphicType/Edit

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<graphic_type> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                graphic_type s = db.graphic_type.Find(source.id);
                s.name = source.name;
                s.peraturan = source.peraturan;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        //
        // POST: /GraphicType/Delete

        [HttpPost]
        public ActionResult Delete(IEnumerable<graphic_type> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                graphic_type s = db.graphic_type.Find(source.id);
                db.graphic_type.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

    }
}

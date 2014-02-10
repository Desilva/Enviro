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
    public class GraphicsParameterController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();

        //
        // GET: /GraphicsParameter/

        public ActionResult Index()
        {
            return PartialView();
        }

        //
        // POST: /GraphicsParameter/Binding

        [HttpPost]
        public JsonResult Binding()
        {
            List<GraphicParameterWrapper> list = db.graphic_parameter.Select(p => new GraphicParameterWrapper { id = p.id, parameter = p.parameter, type = p.type }).OrderByDescending(p => p.id).ToList();
            foreach (GraphicParameterWrapper ls in list)
            {
                graphic_type gts = db.graphic_type.Find(ls.type);
                GraphicTypeWrapper gt = new GraphicTypeWrapper
                {
                    id = gts.id,
                    name = gts.name
                };
                ls.graphic_type = gt;
            }
            return Json(list);
        }

        //
        // POST: /GraphicsParameter/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<graphic_parameter> models)
        {
            List<GraphicParameterWrapper> ss = new List<GraphicParameterWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new graphic_parameter
                {
                    parameter = source.parameter,
                    type = source.type
                };

                db.graphic_parameter.Add(s);
                db.SaveChanges();

                GraphicTypeWrapper ls = db.graphic_type.Select(p => new GraphicTypeWrapper { id = p.id, name = p.name }).Where(p => p.id == source.type).FirstOrDefault();

                // store the product in the result
                ss.Add(new GraphicParameterWrapper { id = s.id, parameter = s.parameter, type = s.type, graphic_type = ls });
            }
            return Json(ss.ToList());
        }

        //
        // POST: /GraphicsParameter/Edit

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<graphic_parameter> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                graphic_parameter s = db.graphic_parameter.Find(source.id);
                s.parameter = source.parameter;
                s.type = source.type;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        //
        // POST: /GraphicsParameter/Delete

        [HttpPost]
        public ActionResult Delete(IEnumerable<graphic_parameter> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                graphic_parameter s = db.graphic_parameter.Find(source.id);
                db.graphic_parameter.Remove(s);
                db.SaveChanges();
            }

            return Json(null);
        }

        #region binding dropdown
        public JsonResult BindingType()
        {
            var a = db.graphic_type;
            List<GraphicTypeWrapper> result = new List<GraphicTypeWrapper>();

            foreach (graphic_type lok in a)
            {

                GraphicTypeWrapper temp = new GraphicTypeWrapper
                {
                    id = lok.id,
                    name = lok.name
                };
                result.Add(temp);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}

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
    public class GraphicsLokasiController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();

        //
        // GET: /GraphicsLokasi/

        public ActionResult Index()
        {
            return PartialView();
        }

        //
        // POST: /GraphicsLokasi/Binding

        [HttpPost]
        public JsonResult Binding()
        {
            List<GraphicLokasiSamplingWrapper> list = db.lokasi_sampling.Select(p => new GraphicLokasiSamplingWrapper { id = p.id, lokasi_sampling1 = p.lokasi_sampling1, type = p.type }).OrderByDescending(p => p.id).ToList();
            foreach (GraphicLokasiSamplingWrapper ls in list)
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
        // POST: /GraphicsLokasi/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<lokasi_sampling> models)
        {
            List<GraphicLokasiSamplingWrapper> ss = new List<GraphicLokasiSamplingWrapper>();
            //Iterate all created products which are posted by the Kendo Grid
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                var s = new lokasi_sampling
                {
                    lokasi_sampling1 = source.lokasi_sampling1,
                    type = source.type
                };

                db.lokasi_sampling.Add(s);
                db.SaveChanges();

                GraphicTypeWrapper ls = db.graphic_type.Select(p => new GraphicTypeWrapper { id = p.id, name = p.name }).Where(p => p.id == source.type).FirstOrDefault();

                // store the product in the result
                ss.Add(new GraphicLokasiSamplingWrapper { id = s.id, lokasi_sampling1 = s.lokasi_sampling1, type = s.type, graphic_type = ls });
            }
            return Json(ss.ToList());
        }

        //
        // POST: /GraphicsLokasi/Edit

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<lokasi_sampling> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                lokasi_sampling s = db.lokasi_sampling.Find(source.id);
                s.lokasi_sampling1 = source.lokasi_sampling1;
                s.type = source.type;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(null);
        }

        //
        // POST: /GraphicsLokasi/Delete

        [HttpPost]
        public ActionResult Delete(IEnumerable<lokasi_sampling> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                lokasi_sampling s = db.lokasi_sampling.Find(source.id);
                db.lokasi_sampling.Remove(s);
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

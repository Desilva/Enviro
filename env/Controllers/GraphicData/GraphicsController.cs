using env.Models;
using env.Models.Wrapper;
using env.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace env.Controllers.GraphicData
{
    public class GraphicsController : Controller
    {
        public static star_energy_enviroEntities db = new star_energy_enviroEntities();
        public static List<GraphicTypeWrapper> lgt = (from type in db.graphic_type
                                               select new GraphicTypeWrapper
                                               {
                                                   id = type.id,
                                                   name = type.name,
                                                   peraturan = type.peraturan
                                               }).ToList();
        //
        // GET: /Graphics/

        #region graphic data
        public ActionResult Index(int? type)
        {
            ViewBag.type = type;
            return PartialView(lgt.Find(p => p.id == type));
        }

        [HttpPost]
        public JsonResult Binding(int type)
        {
            List<GraphicDataWrapper> result = GraphicWrapper.All(p => p.date, type);
            return Json(result);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<GraphicDataWrapper> models)
        {
            List<GraphicDataWrapper> ss = new List<GraphicDataWrapper>();

            foreach (var source in models)
            {
                int id = GraphicWrapper.Insert(source);

                GraphicLokasiSamplingSelect ls = db.lokasi_sampling.Select(p => new GraphicLokasiSamplingSelect { id = p.id, name = p.lokasi_sampling1 }).Where(p => p.id == source.id_lokasi).FirstOrDefault();
                GraphicParameterSelect pr = db.graphic_parameter.Select(p => new GraphicParameterSelect { id = p.id, name = p.parameter }).Where(p => p.id == source.id_parameter).FirstOrDefault();

                // store the product in the result
                ss.Add(new GraphicDataWrapper { id = id, lokasi_sampling = ls, id_lokasi = source.id_lokasi, id_parameter = source.id_parameter, date = source.date, hasil_analisis = source.hasil_analisis });
            }
            return Json(ss.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<GraphicDataWrapper> models,int type)
        {
            foreach (var source in models)
            {
                GraphicWrapper.Update(source,type);
            }

            return Json(null);
        }

        [HttpPost]
        public ActionResult Delete(IEnumerable<GraphicDataWrapper> models, int type)
        {
            foreach (var source in models)
            {
                GraphicWrapper.Delete(source.id, type);
            }

            return Json(null);
        }

        #region binding dropdown
        public JsonResult BindingLokasiSampling(int? type)
        {
            var a = db.lokasi_sampling.Where(p => p.type == type);
            List<GraphicLokasiSamplingSelect> result = new List<GraphicLokasiSamplingSelect>();
            foreach (lokasi_sampling lok in a)
            {

                GraphicLokasiSamplingSelect temp = new GraphicLokasiSamplingSelect
                {
                    id = lok.id,
                    name = lok.lokasi_sampling1
                };
                result.Add(temp);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BindingParameter(int? type)
        {
            var a = db.graphic_parameter.Where(p => p.type == type);
            List<GraphicParameterSelect> result = new List<GraphicParameterSelect>();
            foreach (graphic_parameter lok in a)
            {

                GraphicParameterSelect temp = new GraphicParameterSelect
                {
                    id = lok.id,
                    name = lok.parameter
                };
                result.Add(temp);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #endregion

        public ActionResult Graphic(int? type)
        {
            ViewBag.type = type;
            return PartialView(lgt.Find(p => p.id == type));
        }

        public ActionResult OverallGraphic()
        {
            //ViewBag.type = type;
            List<GraphicParameterWrapper> lgp = (from type in db.graphic_parameter
                                                 select new GraphicParameterWrapper
                                                 {
                                                     id = type.id,
                                                     type = type.type,
                                                     parameter = type.parameter
                                                 }).ToList();
            ViewBag.lgp = lgp;
            ViewBag.lgt = lgt;
            return PartialView();
        }

        public ActionResult ExportData(int id)
        {
            List<GraphicReportWrapper> result = new List<GraphicReportWrapper>();
            List<GraphicDataWrapper> results = GraphicWrapper.All(p => p.date, id).OrderBy(p => p.date).ThenBy(p => p.lokasi_sampling.id).ToList();
            graphic_type gt = db.graphic_type.Find(id); 
            foreach (GraphicDataWrapper gdw in results)
            {
                GraphicReportWrapper rep = new GraphicReportWrapper
                {
                    date = gdw.date != null ? gdw.date.Value.ToShortDateString() : "",
                    lokasi_sampling = gdw.lokasi_sampling.name,
                    graphic_parameter = gdw.graphic_parameter.name,
                    hasil_analisis = (gdw.is_galat == 1 ? "< " : "") + gdw.hasil_analisis
                };
                result.Add(rep);
            }
            GridView gv = new GridView();
            gv.Caption = "" + gt.name;
            gv.DataSource = result;
            if (result.Count == 0)
            {
                return new JavaScriptResult();
            }
            gv.DataBind();
            gv.HeaderRow.Cells[0].Text = "Date";
            gv.HeaderRow.Cells[1].Text = "Lokasi Sampling";
            gv.HeaderRow.Cells[2].Text = "Parameter";
            gv.HeaderRow.Cells[3].Text = "Hasil Analisis";
            if (gv != null)
            {
                return new DownloadFileActionResult(gv, "Environmental Monitoring for " + gt.name + ".xls");
            }
            else
            {
                return new JavaScriptResult();
            }
        }

    }
}

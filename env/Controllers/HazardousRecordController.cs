using env.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using env.Models.Wrapper;
using System.Data;

namespace env.Controllers
{
    public class HazardousRecordController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /HazardousRecord/

        public ActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult BindingIn()
        {
            var a = db.hazardous_record.Include(p => p.waste_hazardous).Include(p => p.source_of_waste).Where(p => p.type == 0);
            List<HazardousWasteInRecordWrapper> result = new List<HazardousWasteInRecordWrapper>();

            foreach (hazardous_record hazard in a)
            {

                HazardousWasteInRecordWrapper temp = new HazardousWasteInRecordWrapper
                {
                    id = hazard.id,
                    id_waste = hazard.id_waste,
                    id_source = hazard.id_source,
                    waste = hazard.waste_hazardous.name + " (" + hazard.waste_hazardous.waste_code + ")",
                    source = hazard.source_of_waste.source,
                    date = hazard.date,
                    no_kemasan = hazard.no_kemasan,
                    kemasan = hazard.kemasan,
                    volume_weight = hazard.volume_weight + " " + db.satuan_unit.Find(hazard.id_satuan).satuan,
                    internal_document = hazard.internal_document,
                    max_penyimpanan = hazard.max_penyimpanan
                };
                result.Add(temp);
            }
            return Json(result);
        }

        [HttpPost]
        public JsonResult BindingOut()
        {
            var a = db.hazardous_record.Include(p => p.waste_hazardous).Include(p => p.source_of_waste).Where(p => p.type == 1);
            List<HazardousWasteOutRecordWrapper> result = new List<HazardousWasteOutRecordWrapper>();

            foreach (hazardous_record hazard in a)
            {

                HazardousWasteOutRecordWrapper temp = new HazardousWasteOutRecordWrapper
                {
                    id = hazard.id,
                    id_waste = hazard.id_waste,
                    waste = hazard.waste_hazardous.name + " (" + hazard.waste_hazardous.waste_code + ")",
                    date = hazard.date,
                    kemasan = hazard.kemasan,
                    volume_weight = hazard.volume_weight + " " + db.satuan_unit.Find(hazard.id_satuan).satuan,
                    internal_document = hazard.internal_document,
                    tujuan = hazard.tujuan,
                    external_document = hazard.external_document
                };
                result.Add(temp);
            }
            return Json(result);
        }

        public ActionResult Create()
        {
            ViewBag.waste = getWaste();
            ViewBag.source = getSource();
            ViewBag.satuan = getSatuan();
            return PartialView(new hazardous_record());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(hazardous_record hazard)
        {
            if (hazard.type == 0)
            {
                hazard.max_penyimpanan = hazard.date.Value.AddDays(90);
            }
            db.hazardous_record.Add(hazard);
            db.SaveChanges();
            return Json(true);
        }

        public ActionResult Edit(int id)
        {
            hazardous_record hazard = db.hazardous_record.Find(id);
            ViewBag.waste = getWaste(hazard.id_waste.ToString());
            ViewBag.source = getSource(hazard.id_source.ToString());
            ViewBag.satuan = getSatuan(hazard.id_satuan.ToString());
            return PartialView("Create", hazard);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EditAjax(hazardous_record hazard)
        {
            if (ModelState.IsValid)
            {
                if (hazard.type == 0)
                {
                    hazard.max_penyimpanan = hazard.date.Value.AddDays(90);
                }
                db.Entry(hazard).State = EntityState.Modified;
                db.SaveChanges();
                return Json(true);
            }

            return Json(false);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            hazardous_record hazard = db.hazardous_record.Find(id);
            if (hazard != null)
            {
                db.hazardous_record.Remove(hazard);
                db.SaveChanges();
                return Json(true);
            }
            return Json(false);
        }

        #region select
        private SelectList getWaste(string defaultValue = "")
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            var r = (from waste in db.waste_hazardous
                     select new WasteWrapper
                     {
                         id = waste.id,
                         name = waste.name,
                         waste_code = waste.waste_code
                     }).OrderBy(p => p.name).ToList();
            foreach (var c in r)
            {
                dict[""+c.id] = c.name + " - " + c.waste_code;
            }

            return new SelectList(dict.Select(x => new { value = x.Key, text = x.Value }), "value", "text", defaultValue);
        }

        private SelectList getSource(string defaultValue = "")
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            var r = (from source in db.source_of_waste
                     select new SourceWasteWrapper
                     {
                         id = source.id,
                         source = source.source
                     }).OrderBy(p => p.source).ToList();
            foreach (var c in r)
            {
                dict["" + c.id] = c.source;
            }

            return new SelectList(dict.Select(x => new { value = x.Key, text = x.Value }), "value", "text", defaultValue);
        }

        private SelectList getSatuan(string defaultValue = "")
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            var r = (from satuan in db.satuan_unit
                     select new WasteUnitWrapper
                     {
                         id = satuan.id,
                         satuan = satuan.satuan,
                         unit_conversion = satuan.unit_conversion
                     }).OrderBy(p => p.satuan).ToList();
            foreach (var c in r)
            {
                dict["" + c.id] = c.satuan;
            }

            return new SelectList(dict.Select(x => new { value = x.Key, text = x.Value }), "value", "text", defaultValue);
        }
        #endregion

    }
}

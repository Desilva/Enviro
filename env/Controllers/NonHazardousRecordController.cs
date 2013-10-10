using env.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using env.Models.Wrapper;
using System.Data;
using System.Diagnostics;

namespace env.Controllers
{
    public class NonHazardousRecordController : Controller
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();
        //
        // GET: /NonHazardousRecord/

        public ActionResult Index()
        {
            return PartialView();
        }

        public JsonResult Binding()
        {
            var a = db.non_hazardous_record.Include(p => p.type_of_waste);
            List<NonHazardousWasteRecordWrapper> result = new List<NonHazardousWasteRecordWrapper>();

            foreach (non_hazardous_record non_hazard in a)
            {

                NonHazardousWasteRecordWrapper temp = new NonHazardousWasteRecordWrapper
                {
                    id = non_hazard.id,
                    date = non_hazard.date,
                    id_type = non_hazard.id_type,
                    type_name = new TypeWasteWrapper { id = non_hazard.id_type.Value, name = non_hazard.type_of_waste.name },
                    waste_in = non_hazard.waste_in,
                    waste_out = non_hazard.waste_out,
                    recycle_rate = non_hazard.recycle_rate
                };
                result.Add(temp);
            }
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        public JsonResult BindingDropDown()
        {
            var a = db.type_of_waste;
            List<TypeWasteWrapper> result = new List<TypeWasteWrapper>();

            foreach (type_of_waste type in a)
            {

                TypeWasteWrapper temp = new TypeWasteWrapper
                {
                    id = type.id,
                    name = type.name
                };
                result.Add(temp);
            }
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(IEnumerable<NonHazardousWasteRecordWrapper> models)
        {
            List<NonHazardousWasteRecordWrapper> ss = new List<NonHazardousWasteRecordWrapper>();
            double total = 0;

            foreach (var source in models)
            {
                List<NonHazardousWasteRecordWrapper> all = db.non_hazardous_record.Where(p => p.date == source.date).Select(p => new NonHazardousWasteRecordWrapper { id = p.id, waste_in = p.waste_in, waste_out = p.waste_out, id_type = p.id_type, date = p.date }).ToList();
                if (all.Count() != 0)
                {
                    total = all.Sum(p => p.waste_in).Value + source.waste_in.Value;
                    foreach (NonHazardousWasteRecordWrapper a in all)
                    {
                        non_hazardous_record nn = new non_hazardous_record
                        {
                            id = a.id,
                            date = a.date,
                            waste_in = a.waste_in,
                            waste_out = a.waste_out,
                            id_type = a.id_type,
                            recycle_rate = a.waste_out / total * 100
                        };
                        db.Entry(nn).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                {
                    total = source.waste_in.Value;
                }

                var s = new non_hazardous_record
                {
                    date = source.date,
                    waste_in = source.waste_in,
                    waste_out = source.waste_out,
                    id_type = source.id_type,
                    recycle_rate = source.waste_out / total * 100
                };

                db.non_hazardous_record.Add(s);
                db.SaveChanges();

                
                
                TypeWasteWrapper tw = db.type_of_waste.Select(p => new TypeWasteWrapper { id = p.id, name = p.name }).Where(p => p.id == s.id_type).FirstOrDefault();

                
                // store the product in the result
                ss.Add(new NonHazardousWasteRecordWrapper { id = s.id, type_name = tw, waste_in = s.waste_in, waste_out = s.waste_out, date = s.date });
            }
            return Json(ss.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(IEnumerable<NonHazardousWasteRecordWrapper> models)
        {
            DateTime prevDate = DateTime.Today;
            double total = 0;
            foreach (var source in models)
            {
                non_hazardous_record s = db.non_hazardous_record.Find(source.id);
                List<NonHazardousWasteRecordWrapper> all = db.non_hazardous_record.Where(p => p.date == source.date && p.id != s.id).Select(p => new NonHazardousWasteRecordWrapper { id = p.id, waste_in = p.waste_in, waste_out = p.waste_out, id_type = p.id_type, date = p.date }).ToList();
                if (all.Count() != 0)
                {
                    total = all.Sum(p => p.waste_in).Value + source.waste_in.Value;
                    foreach (var a in all)
                    {
                        non_hazardous_record nn = new non_hazardous_record
                        {
                            id = a.id,
                            date = a.date,
                            waste_in = a.waste_in,
                            waste_out = a.waste_out,
                            id_type = a.id_type,
                            recycle_rate = a.waste_out / total * 100
                        };
                        db.Entry(nn).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                {
                    total = source.waste_in.Value;
                }

                prevDate = s.date.Value;
                s.date = source.date;
                s.waste_in = source.waste_in;
                s.waste_out = source.waste_out;
                s.id_type = source.id_type;
                s.recycle_rate = source.waste_out / total * 100;

                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();

                if (prevDate != source.date)
                {
                    all = db.non_hazardous_record.Where(p => p.date == prevDate).Select(p => new NonHazardousWasteRecordWrapper { id = p.id, waste_in = p.waste_in, waste_out = p.waste_out, id_type = p.id_type, date = p.date }).ToList();
                    if (all.Count() != 0)
                    {
                        total = all.Sum(p => p.waste_in).Value;
                        foreach (var a in all)
                        {
                            non_hazardous_record nn = new non_hazardous_record
                            {
                                id = a.id,
                                date = a.date,
                                waste_in = a.waste_in,
                                waste_out = a.waste_out,
                                id_type = a.id_type,
                                recycle_rate = a.waste_out / total * 100
                            };
                            db.Entry(nn).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }

            return Json(null);
        }

        //jangan lupa diselesaikan dulu

        [HttpPost]
        public ActionResult Delete(IEnumerable<NonHazardousWasteRecordWrapper> models)
        {
            foreach (var source in models)
            {
                // Create a new Product entity and set its properties from productViewModel
                non_hazardous_record s = db.non_hazardous_record.Find(source.id);
                db.non_hazardous_record.Remove(s);
                db.SaveChanges();
                double total = 0;
                List<NonHazardousWasteRecordWrapper> all = db.non_hazardous_record.Where(p => p.date == source.date).Select(p => new NonHazardousWasteRecordWrapper { id = p.id, waste_in = p.waste_in, waste_out = p.waste_out, id_type = p.id_type, date = p.date }).ToList();
                if (all.Count() != 0)
                {
                    total = all.Sum(p => p.waste_in).Value;
                    foreach (var a in all)
                    {
                        non_hazardous_record nn = new non_hazardous_record
                        {
                            id = a.id,
                            date = a.date,
                            waste_in = a.waste_in,
                            waste_out = a.waste_out,
                            id_type = a.id_type,
                            recycle_rate = a.waste_out / total * 100
                        };
                        db.Entry(nn).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }

            return Json(null);
        }
    }
}

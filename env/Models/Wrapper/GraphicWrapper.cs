using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;

namespace env.Models.Wrapper
{
    public class GraphicTypeWrapper
    {
        public int id { get; set; }
        public string name { get; set; }
        public string peraturan { get; set; }
    }

    public class GraphicLokasiSamplingWrapper
    {
        public int id { get; set; }
        public string lokasi_sampling1 { get; set; }
        public Nullable<byte> type { get; set; }

        public GraphicTypeWrapper graphic_type { get; set; }
    }

    public class GraphicLokasiSamplingSelect
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class GraphicParameterWrapper
    {
        public int id { get; set; }
        public string parameter { get; set; }
        public Nullable<int> type { get; set; }

        public GraphicTypeWrapper graphic_type { get; set; }
    }

    public class GraphicParameterSelect
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class GraphicDataWrapper
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_lokasi { get; set; }
        public GraphicLokasiSamplingSelect lokasi_sampling { get; set; }
        public Nullable<int> id_parameter { get; set; }
        public GraphicParameterSelect graphic_parameter { get; set; }
        public Nullable<double> hasil_analisis { get; set; }
        public Nullable<byte> type { get; set; }
        public Nullable<byte> is_galat { get; set; }
    }

    public class GraphicReportWrapper
    {
        public Nullable<System.DateTime> date { get; set; }
        public string lokasi_sampling { get; set; }
        public string graphic_parameter { get; set; }
        public string hasil_analisis { get; set; }
    }

    public class GraphicWrapper
    {
        private static star_energy_enviroEntities db = new star_energy_enviroEntities();

        public static List<GraphicDataWrapper> All(Func<graphic_data, object> orderBy, int type)
        {
            List<GraphicDataWrapper> lcg = new List<GraphicDataWrapper>();
            var lc = db.graphic_data.Include(p => p.lokasi_sampling).Include(p => p.graphic_parameter).Where(x => x.type == type).OrderByDescending(orderBy);
            foreach (graphic_data c in lc)
            {
                GraphicDataWrapper gdw = new GraphicDataWrapper
                {
                    id = c.id,
                    date = c.date,
                    id_lokasi = c.id_lokasi,
                    lokasi_sampling = new GraphicLokasiSamplingSelect{ id = c.lokasi_sampling.id, name = c.lokasi_sampling.lokasi_sampling1 },
                    id_parameter = c.id_parameter,
                    graphic_parameter = new GraphicParameterSelect { id = c.graphic_parameter.id, name = c.graphic_parameter.parameter },
                    hasil_analisis = c.hasil_analisis,
                    type = c.type,
                    is_galat = c.is_galat
                };
                lcg.Add(gdw);
            }

            return lcg;
        }

        public static GraphicDataWrapper One(Func<GraphicDataWrapper, bool> predicate, int type)
        {
            return All(x => x.id, type).Where(predicate).Where(x => x.type == type).OrderByDescending(x => x.id).FirstOrDefault();
        }

        public static int Insert(GraphicDataWrapper gdw)
        {
            graphic_data gd = new graphic_data
            {
                id_lokasi = gdw.id_lokasi,
                id_parameter = gdw.id_parameter,
                date = gdw.date,
                hasil_analisis = gdw.hasil_analisis,
                type = gdw.type,
                is_galat = gdw.is_galat
            };
            db.graphic_data.Add(gd);
            db.SaveChanges();

            return gd.id;
        }

        public static void Update(GraphicDataWrapper gdw, int type)
        {
            graphic_data target = db.graphic_data.Where(p => p.id == gdw.id && p.type == type).FirstOrDefault();
            if (target != null)
            {
                target.date = gdw.date;
                target.id_lokasi = gdw.id_lokasi;
                target.id_parameter = gdw.id_parameter;
                target.hasil_analisis = gdw.hasil_analisis;
                target.is_galat = gdw.is_galat;
                db.Entry(target).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool Delete(int id, int type)
        {
            graphic_data target = db.graphic_data.Where(p => p.id == id && p.type == type).FirstOrDefault();
            if (target != null)
            {
                db.graphic_data.Remove(target);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace env.Models.Wrapper
{
    public class HazardousWasteInRecordWrapper
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_waste { get; set; }
        public Nullable<int> id_source { get; set; }
        public string waste { get; set; }
        public string source { get; set; }
        public string no_kemasan { get; set; }
        public string kemasan { get; set; }
        public string volume_weight { get; set; }
        public string internal_document { get; set; }
        public Nullable<DateTime> max_penyimpanan { get; set; }
        public byte type = 0;
    }

    public class HazardousWasteOutRecordWrapper
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_waste { get; set; }
        public string waste { get; set; }
        public string kemasan { get; set; }
        public string volume_weight { get; set; }
        public string tujuan { get; set; }
        public string external_document { get; set; }
        public string internal_document { get; set; }
        public byte type = 1;
    }

    public class NonHazardousWasteRecordWrapper
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_type { get; set; }
        public Nullable<Double> waste_in { get; set; }
        public Nullable<Double> waste_out { get; set; }
        public Nullable<double> recycle_rate { get; set; }

        public TypeWasteWrapper type_name { get; set; }
    }
}
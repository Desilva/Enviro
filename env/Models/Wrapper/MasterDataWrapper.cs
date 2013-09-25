using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace env.Models.Wrapper
{
    public class SourceWasteWrapper
    {
        public int id { get; set; }
        public string source { get; set; }
    }

    public class WasteWrapper
    {
        public int id { get; set; }
        public string name { get; set; }
        public string waste_code { get; set; }
    }

    public class TypeWasteWrapper
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class WasteUnitWrapper
    {
        public int id { get; set; }
        public string satuan { get; set; }
        public Nullable<double> unit_conversion { get; set; }
    }
}
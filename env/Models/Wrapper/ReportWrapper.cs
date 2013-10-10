using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace env.Models.Wrapper
{
    public class ReportMonthWrapper
    {
        public int month { get; set; }
        public int year { get; set; }
        public List<ReportMonthItemWrapper> list_waste { get; set; }
    }

    public class ReportMonthItemWrapper
    {
        public int id_waste { get; set; }
        public string waste_name { get; set; }
        public string waste_code { get; set; }
        public Nullable<DateTime> date_in { get; set; }
        public string from { get; set; }
        public string quantity_now { get; set; }
        public string quantity_last { get; set; }
        public Nullable<DateTime> date_out { get; set; }
        public string quantity_out { get; set; }
        public string tujuan { get; set; }
        public string sisa { get; set; }
        public Nullable<DateTime> max_penyimpanan { get; set; }
    }
}
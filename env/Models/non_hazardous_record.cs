//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace env.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class non_hazardous_record
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_type { get; set; }
        public Nullable<double> waste_in { get; set; }
        public Nullable<double> waste_out { get; set; }
        public Nullable<double> recycle_rate { get; set; }
    
        public virtual type_of_waste type_of_waste { get; set; }
    }
}

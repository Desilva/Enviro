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
    
    public partial class hazardous_record
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_waste { get; set; }
        public Nullable<int> id_source { get; set; }
        public string no_kemasan { get; set; }
        public string kemasan { get; set; }
        public Nullable<double> volume_weight { get; set; }
        public string internal_document { get; set; }
        public Nullable<byte> type { get; set; }
        public string tujuan { get; set; }
        public string external_document { get; set; }
        public Nullable<int> id_satuan { get; set; }
        public Nullable<System.DateTime> max_penyimpanan { get; set; }
    
        public virtual satuan_unit satuan_unit { get; set; }
        public virtual source_of_waste source_of_waste { get; set; }
        public virtual waste_hazardous waste_hazardous { get; set; }
    }
}

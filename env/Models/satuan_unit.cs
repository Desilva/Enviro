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
    
    public partial class satuan_unit
    {
        public satuan_unit()
        {
            this.hazardous_record = new HashSet<hazardous_record>();
        }
    
        public int id { get; set; }
        public string satuan { get; set; }
        public Nullable<double> unit_conversion { get; set; }
    
        public virtual ICollection<hazardous_record> hazardous_record { get; set; }
    }
}

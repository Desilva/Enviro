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
    
    public partial class lokasi_sampling
    {
        public lokasi_sampling()
        {
            this.graphic_data = new HashSet<graphic_data>();
        }
    
        public int id { get; set; }
        public string lokasi_sampling1 { get; set; }
        public Nullable<byte> type { get; set; }
    
        public virtual ICollection<graphic_data> graphic_data { get; set; }
    }
}
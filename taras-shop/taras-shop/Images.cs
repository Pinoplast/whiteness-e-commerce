//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace taras_shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Images
    {
        public int id { get; set; }
        public string image { get; set; }
        public int owner_id { get; set; }
    
        public virtual Unit Unit { get; set; }
    }
}

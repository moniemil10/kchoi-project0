//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ID { get; set; }
        public int RestaurantID { get; set; }
        public Nullable<int> ReviewerID { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseRegistrationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class payments
    {
        public int id { get; set; }
        public int sid { get; set; }
        public int clid { get; set; }
        public int amount { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual student student { get; set; }
        public virtual classlist classlist { get; set; }
    }
}

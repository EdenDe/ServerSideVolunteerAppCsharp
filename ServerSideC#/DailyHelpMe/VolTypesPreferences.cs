//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DailyHelpMe
{
    using System;
    using System.Collections.Generic;
    
    public partial class VolTypesPreferences
    {
        public int VolunteerCode { get; set; }
        public string ID { get; set; }
        public Nullable<bool> Dummy { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual VolunteerType VolunteerType { get; set; }
    }
}

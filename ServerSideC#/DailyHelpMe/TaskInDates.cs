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
    
    public partial class TaskInDates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskInDates()
        {
            this.InterestedInRegistered = new HashSet<InterestedInRegistered>();
            this.RegisteredTo = new HashSet<RegisteredTo>();
        }
    
        public int TaskDateNum { get; set; }
        public System.DateTime TaskDate { get; set; }
        public int TaskNumber { get; set; }
    
        public virtual Dates Dates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterestedInRegistered> InterestedInRegistered { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredTo> RegisteredTo { get; set; }
        public virtual Task Task { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSBuildExtensionPack.SQLiteEFContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuildEventCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildEventCode()
        {
            this.BuildLogs = new HashSet<BuildLog>();
        }
    
        public long Id { get; set; }
        public string EventCode { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildLog> BuildLogs { get; set; }
    }
}

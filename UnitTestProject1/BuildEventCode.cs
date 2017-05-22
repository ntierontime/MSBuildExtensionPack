namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildEventCode")]
    public partial class BuildEventCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildEventCode()
        {
            BuildLogs = new HashSet<BuildLog>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string EventCode { get; set; }

        [StringLength(1500)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildLog> BuildLogs { get; set; }
    }
}

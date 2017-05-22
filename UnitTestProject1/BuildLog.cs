namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildLog")]
    public partial class BuildLog
    {
        public long Id { get; set; }

        public long BuildId { get; set; }

        public int BuildEventCodeId { get; set; }

        [StringLength(1500)]
        public string Message { get; set; }

        public DateTime EventTime { get; set; }

        public virtual Build Build { get; set; }

        public virtual BuildEventCode BuildEventCode { get; set; }
    }
}

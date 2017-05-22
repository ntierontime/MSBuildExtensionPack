namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organization")]
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            Organization1 = new HashSet<Organization>();
            Solutions = new HashSet<Solution>();
        }

        public long Id { get; set; }

        public long ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsSystemBuiltIn { get; set; }

        public Guid UniqueIdentifier { get; set; }

        public DateTime CreatedDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string CharColumn { get; set; }

        [Required]
        public string VarcharColumn { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string TextColumn { get; set; }

        [Required]
        [StringLength(1)]
        public string NcharColumn { get; set; }

        [Required]
        public string NvarcharColumn { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string NtextColumn { get; set; }

        public bool BitColumn { get; set; }

        [MaxLength(10)]
        public byte[] BinaryColumn { get; set; }

        public byte[] VarbinaryColumn { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageColumn { get; set; }

        public byte TinyintColumn { get; set; }

        public short SmallintColumn { get; set; }

        public int IntColumn { get; set; }

        public long BigintColumn { get; set; }

        public decimal DecimalColumn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NumericColumn { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SmallmoneyColumn { get; set; }

        [Column(TypeName = "money")]
        public decimal MoneyColumn { get; set; }

        public float FloatColumn { get; set; }

        public float RealColumn { get; set; }

        public DateTime DatetimeColumn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Datetime2Column { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SmalldatetimeColumn { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateColumn { get; set; }

        public TimeSpan TimeColumn { get; set; }

        public Guid UniqueidentifierColumn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organization> Organization1 { get; set; }

        public virtual Organization Organization2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solution> Solutions { get; set; }
    }
}

namespace MSBuildExtensionPack.EntityFrameworkContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbo.Organization")]
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization ()
        {
            this.Organization_ParentIds = new HashSet<Organization>();
            this.Solutions = new HashSet<Solution>();

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Int64 Id { get; set; }

        public System.Int64 ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public System.String Name { get; set; }

        public System.Boolean IsSystemBuiltIn { get; set; }

        public System.Guid UniqueIdentifier { get; set; }

        public System.DateTime CreatedDateTime { get; set; }

        [Required]
        [StringLength(10)]
        public System.String CharColumn { get; set; }

        [Required]
        public System.String VarcharColumn { get; set; }

        [Required]
        public System.String TextColumn { get; set; }

        [Required]
        [StringLength(1)]
        public System.String NcharColumn { get; set; }

        [Required]
        public System.String NvarcharColumn { get; set; }

        [Required]
        public System.String NtextColumn { get; set; }

        public System.Boolean BitColumn { get; set; }

        public System.Byte[] BinaryColumn { get; set; }

        public System.Byte[] VarbinaryColumn { get; set; }

        public System.Byte[] ImageColumn { get; set; }

        public System.Byte TinyintColumn { get; set; }

        public System.Int16 SmallintColumn { get; set; }

        public System.Int32 IntColumn { get; set; }

        public System.Int64 BigintColumn { get; set; }

        public System.Decimal DecimalColumn { get; set; }

        public System.Decimal NumericColumn { get; set; }

        [Column(TypeName = "smallmoney")]
        public System.Decimal SmallmoneyColumn { get; set; }

        [Column(TypeName = "money")]
        public System.Decimal MoneyColumn { get; set; }

        public System.Single FloatColumn { get; set; }

        public System.Single RealColumn { get; set; }

        public System.DateTime DatetimeColumn { get; set; }

        public System.DateTime Datetime2Column { get; set; }

        public System.DateTime SmalldatetimeColumn { get; set; }

        [Column(TypeName = "date")]
        public System.DateTime DateColumn { get; set; }

        public System.TimeSpan TimeColumn { get; set; }

        public System.Guid UniqueidentifierColumn { get; set; }

        public Organization Parent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Organization> Organization_ParentIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Solution> Solutions { get; set; }

    }
}


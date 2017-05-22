namespace UnitTestProject1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MSBuildExtensionPack")
        {
        }

        public virtual DbSet<Build> Builds { get; set; }
        public virtual DbSet<BuildEventCode> BuildEventCodes { get; set; }
        public virtual DbSet<BuildLog> BuildLogs { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Solution> Solutions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Build>()
                .HasMany(e => e.BuildLogs)
                .WithRequired(e => e.Build)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuildEventCode>()
                .HasMany(e => e.BuildLogs)
                .WithRequired(e => e.BuildEventCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.CharColumn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.VarcharColumn)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.TextColumn)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.NcharColumn)
                .IsFixedLength();

            modelBuilder.Entity<Organization>()
                .Property(e => e.BinaryColumn)
                .IsFixedLength();

            modelBuilder.Entity<Organization>()
                .Property(e => e.DecimalColumn)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Organization>()
                .Property(e => e.NumericColumn)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Organization>()
                .Property(e => e.SmallmoneyColumn)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Organization>()
                .Property(e => e.MoneyColumn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Organization1)
                .WithRequired(e => e.Organization2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Solution>()
                .HasMany(e => e.Builds)
                .WithRequired(e => e.Solution)
                .WillCascadeOnDelete(false);
        }
    }
}

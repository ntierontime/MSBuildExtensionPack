//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace MSBuildExtensionPack.EntityFrameworkContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;

    public partial class MSBuildExtensionPackEntities : DbContext
    {
        public MSBuildExtensionPackEntities()
            : base("name=MSBuildExtensionPackEntities")
        {
        }
    

        public DbSet<Build> Builds { get; set; }



        public DbSet<BuildEventCode> BuildEventCodes { get; set; }



        public DbSet<BuildLog> BuildLogs { get; set; }



        public DbSet<Organization> Organizations { get; set; }



        public DbSet<Solution> Solutions { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

			#region #1.1 MSBuildExtensionPack.Build

			// A. Foreign Keys, tables referenced to this table
			// A.1. BuildLogs - Build
            modelBuilder.Entity<Build>()
                .HasMany(e => e.BuildLogs)
                .WithRequired(e => e.Build)
				.HasForeignKey(e => e.BuildId)
                .WillCascadeOnDelete(false);


			// B. Special Type Property

			#endregion #1.1 MSBuildExtensionPack.Build


			#region #1.2 MSBuildExtensionPack.BuildEventCode

			// A. Foreign Keys, tables referenced to this table
			// A.1. BuildLogs - BuildEventCode
            modelBuilder.Entity<BuildEventCode>()
                .HasMany(e => e.BuildLogs)
                .WithRequired(e => e.BuildEventCode)
				.HasForeignKey(e => e.BuildEventCodeId)
                .WillCascadeOnDelete(false);


			// B. Special Type Property

			#endregion #1.2 MSBuildExtensionPack.BuildEventCode


			#region #1.3 MSBuildExtensionPack.BuildLog

			// A. Foreign Keys, tables referenced to this table

			// B. Special Type Property

			#endregion #1.3 MSBuildExtensionPack.BuildLog


			#region #1.4 MSBuildExtensionPack.Organization

			// A. Foreign Keys, tables referenced to this table
			// A.1. Organization_ParentIds - Parent
            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Organization_ParentIds)
                .WithRequired(e => e.Parent)
				.HasForeignKey(e => e.ParentId)
                .WillCascadeOnDelete(false);

			// A.2. Solutions - Organization
            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Solutions)
                .WithRequired(e => e.Organization)
				.HasForeignKey(e => e.OrganizationId)
                .WillCascadeOnDelete(false);


			// B. Special Type Property
			// B.1. CharColumn -- Char(10) -- System.String
            modelBuilder.Entity<Organization>()
                .Property(e => e.CharColumn)
                .IsFixedLength();

			// B.2. NcharColumn -- NChar(1) -- System.String
            modelBuilder.Entity<Organization>()
                .Property(e => e.NcharColumn)
                .IsFixedLength();

			// B.3. DecimalColumn -- Decimal(10,2) -- System.Decimal
            modelBuilder.Entity<Organization>()
                .Property(e => e.DecimalColumn)
                .HasPrecision(10, 2);

			// B.4. NumericColumn -- Decimal(10,2) -- System.Decimal
            modelBuilder.Entity<Organization>()
                .Property(e => e.NumericColumn)
                .HasPrecision(10, 2);

			// B.5. MoneyColumn -- Money -- System.Decimal
            modelBuilder.Entity<Organization>()
                .Property(e => e.MoneyColumn)
                .HasPrecision(19, 4);


			#endregion #1.4 MSBuildExtensionPack.Organization


			#region #1.5 MSBuildExtensionPack.Solution

			// A. Foreign Keys, tables referenced to this table
			// A.1. Builds - Solution
            modelBuilder.Entity<Solution>()
                .HasMany(e => e.Builds)
                .WithRequired(e => e.Solution)
				.HasForeignKey(e => e.SolutionId)
                .WillCascadeOnDelete(false);


			// B. Special Type Property

			#endregion #1.5 MSBuildExtensionPack.Solution


        }


		#region GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization 

        public virtual ObjectResult<RecursivePathResultOfParentIdOfMSBuildExtensionPack_Organization> GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(
			System.Int64 Id
			)
        {
			var IdParameter = new ObjectParameter("Id", Id);
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RecursivePathResultOfParentIdOfMSBuildExtensionPack_Organization>(
                "GetAscendantOfParentIdOfMSBuildExtensionPack_Organization"
				,IdParameter
				);
        }

        public virtual ObjectResult<RecursivePathResultOfParentIdOfMSBuildExtensionPack_Organization> GetDescendantOfParentIdOfMSBuildExtensionPack_Organization(
			System.Int64 Id
			)
        {
			var IdParameter = new ObjectParameter("Id", Id);
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RecursivePathResultOfParentIdOfMSBuildExtensionPack_Organization>(
                "GetDescendantOfParentIdOfMSBuildExtensionPack_Organization"
				, IdParameter
				);
        }

		#endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization 


    }
}


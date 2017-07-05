namespace MSBuildExtensionPack.DataSourceEntities
{  
	using System.Collections.Generic;
	using System.Linq;

	public partial class QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization : MSBuildExtensionPack.EntityContracts.IQueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization
    {

		#region constructors

		//public QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization()
		//{
		//}

        public QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization(
System.Guid uniqueIdentifier)
		{

            this.UniqueIdentifier = uniqueIdentifier;

		}

		#endregion constructors


	    public System.Guid UniqueIdentifier { get; set; }

    }
}
namespace MSBuildExtensionPack.DataSourceEntities
{  
	using System.Collections.Generic;
	using System.Linq;

	public partial class QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization : MSBuildExtensionPack.EntityContracts.IQueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization
    {

		#region constructors

		//public QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization()
		//{
		//}

        public QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization(
System.Guid uniqueidentifierColumn)
		{

            this.UniqueidentifierColumn = uniqueidentifierColumn;

		}

		#endregion constructors


	    public System.Guid UniqueidentifierColumn { get; set; }

    }
}


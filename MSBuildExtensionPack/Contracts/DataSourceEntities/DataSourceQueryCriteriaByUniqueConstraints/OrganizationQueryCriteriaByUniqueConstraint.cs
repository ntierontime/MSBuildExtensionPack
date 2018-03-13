namespace MSBuildExtensionPack.DataSourceEntities
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class QueryCriteriaByUCOfOrganization : MSBuildExtensionPack.EntityContracts.IQueryCriteriaByUCOfOrganization
    {

        #region constructors

        //public QueryCriteriaByUCOfOrganization()
        //{
        //}

        public QueryCriteriaByUCOfOrganization(
System.Guid uniqueIdentifier)
        {

            this.UniqueIdentifier = uniqueIdentifier;

        }

        #endregion constructors

        public System.Guid UniqueIdentifier { get; set; }

    }
}


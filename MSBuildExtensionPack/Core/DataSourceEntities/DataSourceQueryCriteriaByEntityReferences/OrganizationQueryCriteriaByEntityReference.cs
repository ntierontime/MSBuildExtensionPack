using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    ///  DataSourceQueryCriteriaByEntityReference of entity <see cref="MSBuildExtensionPack.Organization"/>
    /// </summary>
    public partial class OrganizationQueryCriteriaByEntityReference : MSBuildExtensionPack.EntityContracts.IQueryCriteriaOrganizationByFKs
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public OrganizationQueryCriteriaByEntityReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public OrganizationQueryCriteriaByEntityReference(
bool isToCompareParentId, System.Int64 comparedToParentId)
        {

            this.IsToCompareParentId = isToCompareParentId;
            this.ComparedToParentId = comparedToParentId;

        }

        #endregion constructors

        #region properties

        public bool IsToCompareParentId { get; set; }
        public System.Int64 ComparedToParentId { get; set; }

        #endregion properties

    }
}
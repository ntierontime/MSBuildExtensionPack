using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    ///  DataSourceQueryCriteriaByEntityReference of entity <see cref="MSBuildExtensionPack.Solution"/>
    /// </summary>
    public partial class SolutionQueryCriteriaByEntityReference : MSBuildExtensionPack.EntityContracts.IQueryCriteriaSolutionByFKs
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public SolutionQueryCriteriaByEntityReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public SolutionQueryCriteriaByEntityReference(
bool isToCompareOrganizationId, System.Nullable<System.Int64> comparedToOrganizationId)
        {

            this.IsToCompareOrganizationId = isToCompareOrganizationId;
            this.ComparedToOrganizationId = comparedToOrganizationId;

        }

        #endregion constructors

        #region properties

        public bool IsToCompareOrganizationId { get; set; }
        public System.Nullable<System.Int64> ComparedToOrganizationId { get; set; }

        #endregion properties

    }
}
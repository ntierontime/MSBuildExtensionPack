using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    ///  DataSourceQueryCriteriaByEntityReference of entity <see cref="MSBuildExtensionPack.Build"/>
    /// </summary>
    public partial class BuildQueryCriteriaByEntityReference : MSBuildExtensionPack.EntityContracts.IQueryCriteriaBuildByFKs
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public BuildQueryCriteriaByEntityReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByEntityReference"/> class.
        /// </summary>
        public BuildQueryCriteriaByEntityReference(
bool isToCompareSolutionId, System.Int32 comparedToSolutionId)
        {

            this.IsToCompareSolutionId = isToCompareSolutionId;
            this.ComparedToSolutionId = comparedToSolutionId;

        }

        #endregion constructors

        #region properties

        public bool IsToCompareSolutionId { get; set; }
        public System.Int32 ComparedToSolutionId { get; set; }

        #endregion properties

    }
}


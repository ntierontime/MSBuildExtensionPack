using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.CommonBLLEntities
{

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Common
    /// </summary>
    public partial class BuildQueryCriteriaCommon
    {
        public BuildQueryCriteriaCommon()
        {
        }

        public QuerySystemInt32EqualsCriteria SolutionId { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_1Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemDateTimeRangeCriteria BuildStartTimeRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemStringContainsCriteria Name { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria Description { get; set; } = new QuerySystemStringContainsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class BuildQueryCriteriaAll
    {
        public BuildQueryCriteriaAll()
        {
        }

    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=FKOnly
    /// </summary>
    public partial class BuildQueryCriteriaFKOnly
    {
        public BuildQueryCriteriaFKOnly()
        {
        }

        public QuerySystemInt32EqualsCriteria SolutionId { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_1Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Identifier
    /// </summary>
    public partial class BuildQueryCriteriaIdentifier
    {
        public BuildQueryCriteriaIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=FKStringContains
    /// </summary>
    public partial class BuildQueryCriteriaFKStringContains
    {
        public BuildQueryCriteriaFKStringContains()
        {
        }

        public QuerySystemStringContainsCriteria SolutionName { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria SolutionDescription { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria Organization_1Name { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria Organization_2Name { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria BuildName { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria BuildDescription { get; set; } = new QuerySystemStringContainsCriteria();
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.EntityContracts;
using Framework;

namespace MSBuildExtensionPack.CommonBLLEntities
{

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Common
    /// </summary>
    public partial class BuildLogQueryCriteriaCommon
    {
        public BuildLogQueryCriteriaCommon()
        {
        }

        public QuerySystemInt64EqualsCriteria IdCommonOfBuild_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_1 { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria IdCommonOfBuildEventCode_1 { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemDateTimeRangeCriteria EventTimeCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemStringContainsCriteria MessageCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class BuildLogQueryCriteriaAll
    {
        public BuildLogQueryCriteriaAll()
        {
        }

    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildLogQueryCriteriaByFKOnly
    {
        public BuildLogQueryCriteriaByFKOnly()
        {
        }

        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfBuild_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_1 { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfBuildEventCode_1 { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildLogQueryCriteriaByIdentifier
    {
        public BuildLogQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria IdByIdentifierOft { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

}


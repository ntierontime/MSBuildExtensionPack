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
    public partial class BuildQueryCriteriaCommon
    {
        public BuildQueryCriteriaCommon()
        {
        }

        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_1 { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemDateTimeRangeCriteria BuildStartTimeCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
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
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildQueryCriteriaByFKOnly
    {
        public BuildQueryCriteriaByFKOnly()
        {
        }

        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_1 { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildQueryCriteriaByIdentifier
    {
        public BuildQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria IdByIdentifierOft { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

}


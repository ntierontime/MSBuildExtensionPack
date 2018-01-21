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
    public partial class SolutionQueryCriteriaCommon
    {
        public SolutionQueryCriteriaCommon()
        {
        }

        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemStringContainsCriteria ExternalParentIdCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class SolutionQueryCriteriaAll
    {
        public SolutionQueryCriteriaAll()
        {
        }

    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class SolutionQueryCriteriaByFKOnly
    {
        public SolutionQueryCriteriaByFKOnly()
        {
        }

        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_1 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class SolutionQueryCriteriaByIdentifier
    {
        public SolutionQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt32EqualsCriteria IdByIdentifierOft { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

}


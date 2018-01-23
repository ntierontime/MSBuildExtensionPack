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

        public QuerySystemInt64EqualsCriteria OrganizationId { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemStringContainsCriteria ExternalParentId { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria Name { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria Description { get; set; } = new QuerySystemStringContainsCriteria();
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

        public QuerySystemInt64EqualsCriteria OrganizationId { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class SolutionQueryCriteriaByIdentifier
    {
        public SolutionQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt32EqualsCriteria Id { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

}


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

        public QuerySystemInt64EqualsCriteria BuildId { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria Solution_1Id { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_1Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria BuildEventCodeId { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemDateTimeRangeCriteria EventTimeRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemStringContainsCriteria Message { get; set; } = new QuerySystemStringContainsCriteria();
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

        public QuerySystemInt64EqualsCriteria BuildId { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria Solution_1Id { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_1Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria BuildEventCodeId { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildLogQueryCriteriaByIdentifier
    {
        public BuildLogQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

}


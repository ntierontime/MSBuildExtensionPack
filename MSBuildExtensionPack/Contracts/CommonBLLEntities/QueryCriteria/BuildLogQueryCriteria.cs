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
    /// BusinessLogicLayerQueryCriteria, key=FKOnly
    /// </summary>
    public partial class BuildLogQueryCriteriaFKOnly
    {
        public BuildLogQueryCriteriaFKOnly()
        {
        }

        public QuerySystemInt64EqualsCriteria BuildId { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria Solution_1Id { get; set; } = new QuerySystemInt32EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_1Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt64EqualsCriteria Organization_2Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemInt32EqualsCriteria BuildEventCodeId { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Identifier
    /// </summary>
    public partial class BuildLogQueryCriteriaIdentifier
    {
        public BuildLogQueryCriteriaIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

}


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
    public partial class BuildEventCodeQueryCriteriaCommon
    {
        public BuildEventCodeQueryCriteriaCommon()
        {
        }

        public QuerySystemStringContainsCriteria EventCodeCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class BuildEventCodeQueryCriteriaAll
    {
        public BuildEventCodeQueryCriteriaAll()
        {
        }

    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildEventCodeQueryCriteriaByIdentifier
    {
        public BuildEventCodeQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt32EqualsCriteria IdByIdentifierOft { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

}


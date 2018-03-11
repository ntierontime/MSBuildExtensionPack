using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.CommonBLLEntities
{

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
    /// BusinessLogicLayerQueryCriteria, key=Common
    /// </summary>
    public partial class BuildEventCodeQueryCriteriaCommon
    {
        public BuildEventCodeQueryCriteriaCommon()
        {
        }

        public QuerySystemStringContainsCriteria EventCode { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria Description { get; set; } = new QuerySystemStringContainsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Identifier
    /// </summary>
    public partial class BuildEventCodeQueryCriteriaIdentifier
    {
        public BuildEventCodeQueryCriteriaIdentifier()
        {
        }

        public QuerySystemInt32EqualsCriteria Id { get; set; } = new QuerySystemInt32EqualsCriteria();
    }

}


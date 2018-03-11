using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.CommonBLLEntities
{

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildLogChainedQueryCriteriaAll
    {
        public BuildLogChainedQueryCriteriaAll()
        {
        }

        public BuildLogQueryCriteriaAll All { get; set; } = new BuildLogQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Common
    /// </summary>
    public class BuildLogChainedQueryCriteriaCommon
    {
        public BuildLogChainedQueryCriteriaCommon()
        {
        }

        public BuildLogQueryCriteriaCommon Common { get; set; } = new BuildLogQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=FKOnly
    /// </summary>
    public class BuildLogChainedQueryCriteriaFKOnly
    {
        public BuildLogChainedQueryCriteriaFKOnly()
        {
        }

        public BuildLogQueryCriteriaFKOnly FKOnly { get; set; } = new BuildLogQueryCriteriaFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Identifier
    /// </summary>
    public class BuildLogChainedQueryCriteriaIdentifier
    {
        public BuildLogChainedQueryCriteriaIdentifier()
        {
        }

        public BuildLogQueryCriteriaIdentifier Identifier { get; set; } = new BuildLogQueryCriteriaIdentifier();
    }

}


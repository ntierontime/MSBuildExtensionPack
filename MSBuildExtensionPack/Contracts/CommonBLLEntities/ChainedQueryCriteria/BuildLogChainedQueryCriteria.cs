using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.EntityContracts;
using Framework;

namespace MSBuildExtensionPack.CommonBLLEntities
{

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Common
    /// </summary>
    public class BuildLogChainedQueryCriteriaCommon
    {
        public BuildLogChainedQueryCriteriaCommon()
        {
        }

        public BuildLogQueryCriteriaCommon BuildLogQueryCriteriaCommon { get; set; } = new BuildLogQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildLogChainedQueryCriteriaAll
    {
        public BuildLogChainedQueryCriteriaAll()
        {
        }

        public BuildLogQueryCriteriaAll BuildLogQueryCriteriaAll { get; set; } = new BuildLogQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BuildLogChainedQueryCriteriaByFKOnly
    {
        public BuildLogChainedQueryCriteriaByFKOnly()
        {
        }

        public BuildLogQueryCriteriaByFKOnly BuildLogQueryCriteriaByFKOnly { get; set; } = new BuildLogQueryCriteriaByFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BuildLogChainedQueryCriteriaByIdentifier
    {
        public BuildLogChainedQueryCriteriaByIdentifier()
        {
        }

        public BuildLogQueryCriteriaByIdentifier BuildLogQueryCriteriaByIdentifier { get; set; } = new BuildLogQueryCriteriaByIdentifier();
    }

}


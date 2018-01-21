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
    public class BuildChainedQueryCriteriaCommon
    {
        public BuildChainedQueryCriteriaCommon()
        {
        }

        public BuildQueryCriteriaCommon BuildQueryCriteriaCommon { get; set; } = new BuildQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildChainedQueryCriteriaAll
    {
        public BuildChainedQueryCriteriaAll()
        {
        }

        public BuildQueryCriteriaAll BuildQueryCriteriaAll { get; set; } = new BuildQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BuildChainedQueryCriteriaByFKOnly
    {
        public BuildChainedQueryCriteriaByFKOnly()
        {
        }

        public BuildQueryCriteriaByFKOnly BuildQueryCriteriaByFKOnly { get; set; } = new BuildQueryCriteriaByFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BuildChainedQueryCriteriaByIdentifier
    {
        public BuildChainedQueryCriteriaByIdentifier()
        {
        }

        public BuildQueryCriteriaByIdentifier BuildQueryCriteriaByIdentifier { get; set; } = new BuildQueryCriteriaByIdentifier();
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.EntityContracts;

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

        public BuildQueryCriteriaCommon Common { get; set; } = new BuildQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildChainedQueryCriteriaAll
    {
        public BuildChainedQueryCriteriaAll()
        {
        }

        public BuildQueryCriteriaAll All { get; set; } = new BuildQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=FKOnly
    /// </summary>
    public class BuildChainedQueryCriteriaFKOnly
    {
        public BuildChainedQueryCriteriaFKOnly()
        {
        }

        public BuildQueryCriteriaFKOnly FKOnly { get; set; } = new BuildQueryCriteriaFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Identifier
    /// </summary>
    public class BuildChainedQueryCriteriaIdentifier
    {
        public BuildChainedQueryCriteriaIdentifier()
        {
        }

        public BuildQueryCriteriaIdentifier Identifier { get; set; } = new BuildQueryCriteriaIdentifier();
    }

}


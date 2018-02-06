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
    public class BuildEventCodeChainedQueryCriteriaCommon
    {
        public BuildEventCodeChainedQueryCriteriaCommon()
        {
        }

        public BuildEventCodeQueryCriteriaCommon Common { get; set; } = new BuildEventCodeQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildEventCodeChainedQueryCriteriaAll
    {
        public BuildEventCodeChainedQueryCriteriaAll()
        {
        }

        public BuildEventCodeQueryCriteriaAll All { get; set; } = new BuildEventCodeQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Identifier
    /// </summary>
    public class BuildEventCodeChainedQueryCriteriaIdentifier
    {
        public BuildEventCodeChainedQueryCriteriaIdentifier()
        {
        }

        public BuildEventCodeQueryCriteriaIdentifier Identifier { get; set; } = new BuildEventCodeQueryCriteriaIdentifier();
    }

}


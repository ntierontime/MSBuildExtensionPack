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

        public BuildEventCodeQueryCriteriaCommon BuildEventCodeQueryCriteriaCommon { get; set; } = new BuildEventCodeQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildEventCodeChainedQueryCriteriaAll
    {
        public BuildEventCodeChainedQueryCriteriaAll()
        {
        }

        public BuildEventCodeQueryCriteriaAll BuildEventCodeQueryCriteriaAll { get; set; } = new BuildEventCodeQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BuildEventCodeChainedQueryCriteriaByIdentifier
    {
        public BuildEventCodeChainedQueryCriteriaByIdentifier()
        {
        }

        public BuildEventCodeQueryCriteriaByIdentifier BuildEventCodeQueryCriteriaByIdentifier { get; set; } = new BuildEventCodeQueryCriteriaByIdentifier();
    }

}


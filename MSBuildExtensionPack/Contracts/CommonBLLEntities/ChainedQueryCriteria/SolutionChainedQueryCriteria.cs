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
    public class SolutionChainedQueryCriteriaCommon
    {
        public SolutionChainedQueryCriteriaCommon()
        {
        }

        public SolutionQueryCriteriaCommon SolutionQueryCriteriaCommon { get; set; } = new SolutionQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class SolutionChainedQueryCriteriaAll
    {
        public SolutionChainedQueryCriteriaAll()
        {
        }

        public SolutionQueryCriteriaAll SolutionQueryCriteriaAll { get; set; } = new SolutionQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class SolutionChainedQueryCriteriaByFKOnly
    {
        public SolutionChainedQueryCriteriaByFKOnly()
        {
        }

        public SolutionQueryCriteriaByFKOnly SolutionQueryCriteriaByFKOnly { get; set; } = new SolutionQueryCriteriaByFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class SolutionChainedQueryCriteriaByIdentifier
    {
        public SolutionChainedQueryCriteriaByIdentifier()
        {
        }

        public SolutionQueryCriteriaByIdentifier SolutionQueryCriteriaByIdentifier { get; set; } = new SolutionQueryCriteriaByIdentifier();
    }

}


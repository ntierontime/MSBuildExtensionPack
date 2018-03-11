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
    public class SolutionChainedQueryCriteriaAll
    {
        public SolutionChainedQueryCriteriaAll()
        {
        }

        public SolutionQueryCriteriaAll All { get; set; } = new SolutionQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Common
    /// </summary>
    public class SolutionChainedQueryCriteriaCommon
    {
        public SolutionChainedQueryCriteriaCommon()
        {
        }

        public SolutionQueryCriteriaCommon Common { get; set; } = new SolutionQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=FKOnly
    /// </summary>
    public class SolutionChainedQueryCriteriaFKOnly
    {
        public SolutionChainedQueryCriteriaFKOnly()
        {
        }

        public SolutionQueryCriteriaFKOnly FKOnly { get; set; } = new SolutionQueryCriteriaFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Identifier
    /// </summary>
    public class SolutionChainedQueryCriteriaIdentifier
    {
        public SolutionChainedQueryCriteriaIdentifier()
        {
        }

        public SolutionQueryCriteriaIdentifier Identifier { get; set; } = new SolutionQueryCriteriaIdentifier();
    }

}


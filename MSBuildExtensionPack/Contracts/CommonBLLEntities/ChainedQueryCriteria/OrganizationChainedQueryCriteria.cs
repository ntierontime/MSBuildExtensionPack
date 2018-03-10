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
    public class OrganizationChainedQueryCriteriaCommon
    {
        public OrganizationChainedQueryCriteriaCommon()
        {
        }

        public OrganizationQueryCriteriaCommon Common { get; set; } = new OrganizationQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class OrganizationChainedQueryCriteriaAll
    {
        public OrganizationChainedQueryCriteriaAll()
        {
        }

        public OrganizationQueryCriteriaAll All { get; set; } = new OrganizationQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=FKOnly
    /// </summary>
    public class OrganizationChainedQueryCriteriaFKOnly
    {
        public OrganizationChainedQueryCriteriaFKOnly()
        {
        }

        public OrganizationQueryCriteriaFKOnly FKOnly { get; set; } = new OrganizationQueryCriteriaFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=Identifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaIdentifier
    {
        public OrganizationChainedQueryCriteriaIdentifier()
        {
        }

        public OrganizationQueryCriteriaIdentifier Identifier { get; set; } = new OrganizationQueryCriteriaIdentifier();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintByUC
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintByUC
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintByUC()
        {
        }

        public OrganizationQueryCriteriaUniqueConstraintByUC UniqueConstraintByUC { get; set; } = new OrganizationQueryCriteriaUniqueConstraintByUC();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public class OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint
    {
        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint()
        {
        }

        public OrganizationQueryCriteriaIdentifierAndUniqueConstraint IdentifierAndUniqueConstraint { get; set; } = new OrganizationQueryCriteriaIdentifierAndUniqueConstraint();
    }

}


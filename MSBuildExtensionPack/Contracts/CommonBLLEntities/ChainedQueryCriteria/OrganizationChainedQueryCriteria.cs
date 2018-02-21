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
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintByUC_Organization_UniqueIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintByUC_Organization_UniqueIdentifier
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintByUC_Organization_UniqueIdentifier()
        {
        }

        public OrganizationQueryCriteriaUniqueConstraintByUC_Organization_UniqueIdentifier UniqueConstraintByUC_Organization_UniqueIdentifier { get; set; } = new OrganizationQueryCriteriaUniqueConstraintByUC_Organization_UniqueIdentifier();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintByUC_Organization_UniqueidentifierColumn
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintByUC_Organization_UniqueidentifierColumn
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintByUC_Organization_UniqueidentifierColumn()
        {
        }

        public OrganizationQueryCriteriaUniqueConstraintByUC_Organization_UniqueidentifierColumn UniqueConstraintByUC_Organization_UniqueidentifierColumn { get; set; } = new OrganizationQueryCriteriaUniqueConstraintByUC_Organization_UniqueidentifierColumn();
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


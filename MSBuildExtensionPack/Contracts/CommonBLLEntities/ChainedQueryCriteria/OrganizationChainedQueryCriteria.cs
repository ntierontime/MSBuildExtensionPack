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
    public class OrganizationChainedQueryCriteriaCommon
    {
        public OrganizationChainedQueryCriteriaCommon()
        {
        }

        public OrganizationQueryCriteriaCommon OrganizationQueryCriteriaCommon { get; set; } = new OrganizationQueryCriteriaCommon();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class OrganizationChainedQueryCriteriaAll
    {
        public OrganizationChainedQueryCriteriaAll()
        {
        }

        public OrganizationQueryCriteriaAll OrganizationQueryCriteriaAll { get; set; } = new OrganizationQueryCriteriaAll();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class OrganizationChainedQueryCriteriaByFKOnly
    {
        public OrganizationChainedQueryCriteriaByFKOnly()
        {
        }

        public OrganizationQueryCriteriaByFKOnly OrganizationQueryCriteriaByFKOnly { get; set; } = new OrganizationQueryCriteriaByFKOnly();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaByIdentifier
    {
        public OrganizationChainedQueryCriteriaByIdentifier()
        {
        }

        public OrganizationQueryCriteriaByIdentifier OrganizationQueryCriteriaByIdentifier { get; set; } = new OrganizationQueryCriteriaByIdentifier();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier()
        {
        }

        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier { get; set; } = new OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueidentifierColumn
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn()
        {
        }

        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn { get; set; } = new OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn();
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public class OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint
    {
        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint()
        {
        }

        public OrganizationQueryCriteriaIdentifierAndUniqueConstraint OrganizationQueryCriteriaIdentifierAndUniqueConstraint { get; set; } = new OrganizationQueryCriteriaIdentifierAndUniqueConstraint();
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.EntityContracts;
using Framework;

namespace MSBuildExtensionPack.CommonBLLEntities
{

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Common
    /// </summary>
    public partial class OrganizationQueryCriteriaCommon
    {
        public OrganizationQueryCriteriaCommon()
        {
        }

        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemBooleanEqualsCriteria IsSystemBuiltInCommonOft { get; set; } = new QuerySystemBooleanEqualsCriteria();
        public QuerySystemDateTimeRangeCriteria CreatedDateTimeCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemBooleanEqualsCriteria BitColumnCommonOft { get; set; } = new QuerySystemBooleanEqualsCriteria();
        public QuerySystemDateTimeRangeCriteria DatetimeColumnCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemDateTimeRangeCriteria Datetime2ColumnCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemDateTimeRangeCriteria SmalldatetimeColumnCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemDateTimeRangeCriteria DateColumnCommonOft { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria CharColumnCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria VarcharColumnCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria TextColumnCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NcharColumnCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NvarcharColumnCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NtextColumnCommonOft { get; set; } = new QuerySystemStringContainsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class OrganizationQueryCriteriaAll
    {
        public OrganizationQueryCriteriaAll()
        {
        }

    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class OrganizationQueryCriteriaByFKOnly
    {
        public OrganizationQueryCriteriaByFKOnly()
        {
        }

        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_2 { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class OrganizationQueryCriteriaByIdentifier
    {
        public OrganizationQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria IdByIdentifierOft { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueIdentifier
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
    {
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier()
        {
        }

        public QuerySystemGuidEqualsCriteria UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft { get; set; } = new QuerySystemGuidEqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueidentifierColumn
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
    {
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn()
        {
        }

        public QuerySystemGuidEqualsCriteria UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft { get; set; } = new QuerySystemGuidEqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public partial class OrganizationQueryCriteriaIdentifierAndUniqueConstraint
    {
        public OrganizationQueryCriteriaIdentifierAndUniqueConstraint()
        {
        }

        public QuerySystemInt64EqualsCriteria IdIdentifierAndUniqueConstraintOft { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemGuidEqualsCriteria UniqueIdentifierIdentifierAndUniqueConstraintOft { get; set; } = new QuerySystemGuidEqualsCriteria();
        public QuerySystemGuidEqualsCriteria UniqueidentifierColumnIdentifierAndUniqueConstraintOft { get; set; } = new QuerySystemGuidEqualsCriteria();
    }

}


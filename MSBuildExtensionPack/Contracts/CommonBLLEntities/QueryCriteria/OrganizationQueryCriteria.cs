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

        public QuerySystemInt64EqualsCriteria ParentId { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemBooleanEqualsCriteria IsSystemBuiltIn { get; set; } = new QuerySystemBooleanEqualsCriteria();
        public QuerySystemDateTimeRangeCriteria CreatedDateTimeRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemBooleanEqualsCriteria BitColumn { get; set; } = new QuerySystemBooleanEqualsCriteria();
        public QuerySystemDateTimeRangeCriteria DatetimeColumnRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemDateTimeRangeCriteria Datetime2ColumnRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemDateTimeRangeCriteria SmalldatetimeColumnRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemDateTimeRangeCriteria DateColumnRange { get; set; } = new QuerySystemDateTimeRangeCriteria();
        public QuerySystemStringContainsCriteria Name { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria CharColumn { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria VarcharColumn { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria TextColumn { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NcharColumn { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NvarcharColumn { get; set; } = new QuerySystemStringContainsCriteria();
        public QuerySystemStringContainsCriteria NtextColumn { get; set; } = new QuerySystemStringContainsCriteria();
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

        public QuerySystemInt64EqualsCriteria ParentId { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class OrganizationQueryCriteriaByIdentifier
    {
        public OrganizationQueryCriteriaByIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueIdentifier
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
    {
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier()
        {
        }

        public QuerySystemGuidEqualsCriteria UniqueIdentifier { get; set; } = new QuerySystemGuidEqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueidentifierColumn
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
    {
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn()
        {
        }

        public QuerySystemGuidEqualsCriteria UniqueidentifierColumn { get; set; } = new QuerySystemGuidEqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public partial class OrganizationQueryCriteriaIdentifierAndUniqueConstraint
    {
        public OrganizationQueryCriteriaIdentifierAndUniqueConstraint()
        {
        }

        public QuerySystemInt64EqualsCriteria Id { get; set; } = new QuerySystemInt64EqualsCriteria();
        public QuerySystemGuidEqualsCriteria UniqueIdentifier { get; set; } = new QuerySystemGuidEqualsCriteria();
        public QuerySystemGuidEqualsCriteria UniqueidentifierColumn { get; set; } = new QuerySystemGuidEqualsCriteria();
    }

}


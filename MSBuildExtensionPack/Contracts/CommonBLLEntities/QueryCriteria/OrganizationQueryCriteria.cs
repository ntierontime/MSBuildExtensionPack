using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.EntityContracts;

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
    /// BusinessLogicLayerQueryCriteria, key=FKOnly
    /// </summary>
    public partial class OrganizationQueryCriteriaFKOnly
    {
        public OrganizationQueryCriteriaFKOnly()
        {
        }

        public QuerySystemInt64EqualsCriteria ParentId { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=Identifier
    /// </summary>
    public partial class OrganizationQueryCriteriaIdentifier
    {
        public OrganizationQueryCriteriaIdentifier()
        {
        }

        public QuerySystemInt64EqualsCriteria Id { get; set; } = new QuerySystemInt64EqualsCriteria();
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintByUC
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintByUC
    {
        public OrganizationQueryCriteriaUniqueConstraintByUC()
        {
        }

        public QuerySystemGuidEqualsCriteria UniqueIdentifier { get; set; } = new QuerySystemGuidEqualsCriteria();
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
    }

}


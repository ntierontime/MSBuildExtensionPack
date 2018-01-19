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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommon"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaCommon(
            OrganizationQueryCriteriaCommon organizationQueryCriteriaCommon
            )
        {
            this.OrganizationQueryCriteriaCommon = organizationQueryCriteriaCommon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="idCommonOfOrganization_2OfCommon">Initialize criteria of IdCommonOfOrganization_2OfCommon</param>
        /// <param name="isSystemBuiltInCommonOftOfCommon">Initialize criteria of IsSystemBuiltInCommonOftOfCommon</param>
        /// <param name="createdDateTimeCommonOftOfCommon">Initialize criteria of CreatedDateTimeCommonOftOfCommon</param>
        /// <param name="bitColumnCommonOftOfCommon">Initialize criteria of BitColumnCommonOftOfCommon</param>
        /// <param name="datetimeColumnCommonOftOfCommon">Initialize criteria of DatetimeColumnCommonOftOfCommon</param>
        /// <param name="datetime2ColumnCommonOftOfCommon">Initialize criteria of Datetime2ColumnCommonOftOfCommon</param>
        /// <param name="smalldatetimeColumnCommonOftOfCommon">Initialize criteria of SmalldatetimeColumnCommonOftOfCommon</param>
        /// <param name="dateColumnCommonOftOfCommon">Initialize criteria of DateColumnCommonOftOfCommon</param>
        /// <param name="nameCommonOftOfCommon">Initialize criteria of NameCommonOftOfCommon</param>
        /// <param name="charColumnCommonOftOfCommon">Initialize criteria of CharColumnCommonOftOfCommon</param>
        /// <param name="varcharColumnCommonOftOfCommon">Initialize criteria of VarcharColumnCommonOftOfCommon</param>
        /// <param name="textColumnCommonOftOfCommon">Initialize criteria of TextColumnCommonOftOfCommon</param>
        /// <param name="ncharColumnCommonOftOfCommon">Initialize criteria of NcharColumnCommonOftOfCommon</param>
        /// <param name="nvarcharColumnCommonOftOfCommon">Initialize criteria of NvarcharColumnCommonOftOfCommon</param>
        /// <param name="ntextColumnCommonOftOfCommon">Initialize criteria of NtextColumnCommonOftOfCommon</param>
        public OrganizationChainedQueryCriteriaCommon(
            QuerySystemInt64EqualsCriteria idCommonOfOrganization_2OfCommon
            , QuerySystemBooleanEqualsCriteria isSystemBuiltInCommonOftOfCommon
            , QuerySystemDateTimeRangeCriteria createdDateTimeCommonOftOfCommon
            , QuerySystemBooleanEqualsCriteria bitColumnCommonOftOfCommon
            , QuerySystemDateTimeRangeCriteria datetimeColumnCommonOftOfCommon
            , QuerySystemDateTimeRangeCriteria datetime2ColumnCommonOftOfCommon
            , QuerySystemDateTimeRangeCriteria smalldatetimeColumnCommonOftOfCommon
            , QuerySystemDateTimeRangeCriteria dateColumnCommonOftOfCommon
            , QuerySystemStringContainsCriteria nameCommonOftOfCommon
            , QuerySystemStringContainsCriteria charColumnCommonOftOfCommon
            , QuerySystemStringContainsCriteria varcharColumnCommonOftOfCommon
            , QuerySystemStringContainsCriteria textColumnCommonOftOfCommon
            , QuerySystemStringContainsCriteria ncharColumnCommonOftOfCommon
            , QuerySystemStringContainsCriteria nvarcharColumnCommonOftOfCommon
            , QuerySystemStringContainsCriteria ntextColumnCommonOftOfCommon
            )
            : this(
            new OrganizationQueryCriteriaCommon(idCommonOfOrganization_2OfCommon,isSystemBuiltInCommonOftOfCommon,createdDateTimeCommonOftOfCommon,bitColumnCommonOftOfCommon,datetimeColumnCommonOftOfCommon,datetime2ColumnCommonOftOfCommon,smalldatetimeColumnCommonOftOfCommon,dateColumnCommonOftOfCommon,nameCommonOftOfCommon,charColumnCommonOftOfCommon,varcharColumnCommonOftOfCommon,textColumnCommonOftOfCommon,ncharColumnCommonOftOfCommon,nvarcharColumnCommonOftOfCommon,ntextColumnCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfOrganization_2OfCommon">will compare/filter IdCommonOfOrganization_2OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2OfCommon">value to compare/filter with IdCommonOfOrganization_2OfCommon property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltInCommonOftOfCommon">will compare/filter IsSystemBuiltInCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIsSystemBuiltInCommonOftOfCommon">value to compare/filter with IsSystemBuiltInCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeCommonOftOfCommon">will compare/filter CreatedDateTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundCreatedDateTimeCommonOftOfCommon">will compare/filter to lower bound of CreatedDateTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundCreatedDateTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundCreatedDateTimeCommonOftOfCommon">will compare/filter to upper bound of CreatedDateTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundCreatedDateTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareBitColumnCommonOftOfCommon">will compare/filter BitColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareBitColumnCommonOftOfCommon">value to compare/filter with BitColumnCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDatetimeColumnCommonOftOfCommon">will compare/filter DatetimeColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetimeColumnCommonOftOfCommon">will compare/filter to lower bound of DatetimeColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetimeColumnCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetimeColumnCommonOftOfCommon">will compare/filter to upper bound of DatetimeColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetimeColumnCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnCommonOftOfCommon">will compare/filter Datetime2ColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetime2ColumnCommonOftOfCommon">will compare/filter to lower bound of Datetime2ColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetime2ColumnCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetime2ColumnCommonOftOfCommon">will compare/filter to upper bound of Datetime2ColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetime2ColumnCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnCommonOftOfCommon">will compare/filter SmalldatetimeColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon">will compare/filter to lower bound of SmalldatetimeColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundSmalldatetimeColumnCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon">will compare/filter to upper bound of SmalldatetimeColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundSmalldatetimeColumnCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareDateColumnCommonOftOfCommon">will compare/filter DateColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDateColumnCommonOftOfCommon">will compare/filter to lower bound of DateColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDateColumnCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDateColumnCommonOftOfCommon">will compare/filter to upper bound of DateColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDateColumnCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareCharColumnCommonOftOfCommon">will compare/filter CharColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedCharColumnCommonOftOfCommon">value to compare/filter with CharColumnCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareVarcharColumnCommonOftOfCommon">will compare/filter VarcharColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedVarcharColumnCommonOftOfCommon">value to compare/filter with VarcharColumnCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareTextColumnCommonOftOfCommon">will compare/filter TextColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedTextColumnCommonOftOfCommon">value to compare/filter with TextColumnCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNcharColumnCommonOftOfCommon">will compare/filter NcharColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNcharColumnCommonOftOfCommon">value to compare/filter with NcharColumnCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNvarcharColumnCommonOftOfCommon">will compare/filter NvarcharColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNvarcharColumnCommonOftOfCommon">value to compare/filter with NvarcharColumnCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNtextColumnCommonOftOfCommon">will compare/filter NtextColumnCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNtextColumnCommonOftOfCommon">value to compare/filter with NtextColumnCommonOftOfCommon property/field/column</param>
        public OrganizationChainedQueryCriteriaCommon(
            bool isToCompareIdCommonOfOrganization_2OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_2OfCommon
            , bool isToCompareIsSystemBuiltInCommonOftOfCommon, System.Boolean? valueToCompareIsSystemBuiltInCommonOftOfCommon
            , bool isToCompareCreatedDateTimeCommonOftOfCommon, bool isToCompareLowerBoundCreatedDateTimeCommonOftOfCommon, System.DateTime? lowerBoundCreatedDateTimeCommonOftOfCommon, bool isToCompareUpperBoundCreatedDateTimeCommonOftOfCommon, System.DateTime? upperBoundCreatedDateTimeCommonOftOfCommon
            , bool isToCompareBitColumnCommonOftOfCommon, System.Boolean? valueToCompareBitColumnCommonOftOfCommon
            , bool isToCompareDatetimeColumnCommonOftOfCommon, bool isToCompareLowerBoundDatetimeColumnCommonOftOfCommon, System.DateTime? lowerBoundDatetimeColumnCommonOftOfCommon, bool isToCompareUpperBoundDatetimeColumnCommonOftOfCommon, System.DateTime? upperBoundDatetimeColumnCommonOftOfCommon
            , bool isToCompareDatetime2ColumnCommonOftOfCommon, bool isToCompareLowerBoundDatetime2ColumnCommonOftOfCommon, System.DateTime? lowerBoundDatetime2ColumnCommonOftOfCommon, bool isToCompareUpperBoundDatetime2ColumnCommonOftOfCommon, System.DateTime? upperBoundDatetime2ColumnCommonOftOfCommon
            , bool isToCompareSmalldatetimeColumnCommonOftOfCommon, bool isToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon, System.DateTime? lowerBoundSmalldatetimeColumnCommonOftOfCommon, bool isToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon, System.DateTime? upperBoundSmalldatetimeColumnCommonOftOfCommon
            , bool isToCompareDateColumnCommonOftOfCommon, bool isToCompareLowerBoundDateColumnCommonOftOfCommon, System.DateTime? lowerBoundDateColumnCommonOftOfCommon, bool isToCompareUpperBoundDateColumnCommonOftOfCommon, System.DateTime? upperBoundDateColumnCommonOftOfCommon
            , bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
            , bool isToCompareCharColumnCommonOftOfCommon, System.String valueToBeContainedCharColumnCommonOftOfCommon
            , bool isToCompareVarcharColumnCommonOftOfCommon, System.String valueToBeContainedVarcharColumnCommonOftOfCommon
            , bool isToCompareTextColumnCommonOftOfCommon, System.String valueToBeContainedTextColumnCommonOftOfCommon
            , bool isToCompareNcharColumnCommonOftOfCommon, System.String valueToBeContainedNcharColumnCommonOftOfCommon
            , bool isToCompareNvarcharColumnCommonOftOfCommon, System.String valueToBeContainedNvarcharColumnCommonOftOfCommon
            , bool isToCompareNtextColumnCommonOftOfCommon, System.String valueToBeContainedNtextColumnCommonOftOfCommon
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2OfCommon, valueToCompareIdCommonOfOrganization_2OfCommon)
            , new QuerySystemBooleanEqualsCriteria(isToCompareIsSystemBuiltInCommonOftOfCommon, valueToCompareIsSystemBuiltInCommonOftOfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareCreatedDateTimeCommonOftOfCommon, isToCompareLowerBoundCreatedDateTimeCommonOftOfCommon, lowerBoundCreatedDateTimeCommonOftOfCommon, isToCompareUpperBoundCreatedDateTimeCommonOftOfCommon, upperBoundCreatedDateTimeCommonOftOfCommon)
            , new QuerySystemBooleanEqualsCriteria(isToCompareBitColumnCommonOftOfCommon, valueToCompareBitColumnCommonOftOfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareDatetimeColumnCommonOftOfCommon, isToCompareLowerBoundDatetimeColumnCommonOftOfCommon, lowerBoundDatetimeColumnCommonOftOfCommon, isToCompareUpperBoundDatetimeColumnCommonOftOfCommon, upperBoundDatetimeColumnCommonOftOfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareDatetime2ColumnCommonOftOfCommon, isToCompareLowerBoundDatetime2ColumnCommonOftOfCommon, lowerBoundDatetime2ColumnCommonOftOfCommon, isToCompareUpperBoundDatetime2ColumnCommonOftOfCommon, upperBoundDatetime2ColumnCommonOftOfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareSmalldatetimeColumnCommonOftOfCommon, isToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon, lowerBoundSmalldatetimeColumnCommonOftOfCommon, isToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon, upperBoundSmalldatetimeColumnCommonOftOfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareDateColumnCommonOftOfCommon, isToCompareLowerBoundDateColumnCommonOftOfCommon, lowerBoundDateColumnCommonOftOfCommon, isToCompareUpperBoundDateColumnCommonOftOfCommon, upperBoundDateColumnCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareCharColumnCommonOftOfCommon, valueToBeContainedCharColumnCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareVarcharColumnCommonOftOfCommon, valueToBeContainedVarcharColumnCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareTextColumnCommonOftOfCommon, valueToBeContainedTextColumnCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareNcharColumnCommonOftOfCommon, valueToBeContainedNcharColumnCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareNvarcharColumnCommonOftOfCommon, valueToBeContainedNvarcharColumnCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareNtextColumnCommonOftOfCommon, valueToBeContainedNtextColumnCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public OrganizationQueryCriteriaCommon OrganizationQueryCriteriaCommon { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class OrganizationChainedQueryCriteriaAll
    {
        public OrganizationChainedQueryCriteriaAll()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaAll"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaAll(
            OrganizationQueryCriteriaAll organizationQueryCriteriaAll
            )
        {
            this.OrganizationQueryCriteriaAll = organizationQueryCriteriaAll;
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public OrganizationQueryCriteriaAll OrganizationQueryCriteriaAll { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class OrganizationChainedQueryCriteriaByFKOnly
    {
        public OrganizationChainedQueryCriteriaByFKOnly()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaByFKOnly(
            OrganizationQueryCriteriaByFKOnly organizationQueryCriteriaByFKOnly
            )
        {
            this.OrganizationQueryCriteriaByFKOnly = organizationQueryCriteriaByFKOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="idByFKOnlyOfOrganization_2OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_2OfByFKOnly</param>
        public OrganizationChainedQueryCriteriaByFKOnly(
            QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2OfByFKOnly
            )
            : this(
            new OrganizationQueryCriteriaByFKOnly(idByFKOnlyOfOrganization_2OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        public OrganizationChainedQueryCriteriaByFKOnly(
            bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public OrganizationQueryCriteriaByFKOnly OrganizationQueryCriteriaByFKOnly { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaByIdentifier
    {
        public OrganizationChainedQueryCriteriaByIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaByIdentifier(
            OrganizationQueryCriteriaByIdentifier organizationQueryCriteriaByIdentifier
            )
        {
            this.OrganizationQueryCriteriaByIdentifier = organizationQueryCriteriaByIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>
        public OrganizationChainedQueryCriteriaByIdentifier(
            QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
            )
            : this(
            new OrganizationQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        public OrganizationChainedQueryCriteriaByIdentifier(
            bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64? valueToCompareIdByIdentifierOftOfByIdentifier
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public OrganizationQueryCriteriaByIdentifier OrganizationQueryCriteriaByIdentifier { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(
            OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier organizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
            )
        {
            this.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier = organizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
        /// <param name="uniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">Initialize criteria of UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(
            QuerySystemGuidEqualsCriteria uniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            )
            : this(
            new OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(uniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">will compare/filter UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">value to compare/filter with UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(
            bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            )
            : this(
            new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is UniqueConstraintOfUC_Organization_UniqueIdentifier
        /// </summary>
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueidentifierColumn
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
    {
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn organizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            )
        {
            this.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn = organizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
        /// <param name="uniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">Initialize criteria of UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            QuerySystemGuidEqualsCriteria uniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            )
            : this(
            new OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(uniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">will compare/filter UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">value to compare/filter with UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            )
            : this(
            new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is UniqueConstraintOfUC_Organization_UniqueidentifierColumn
        /// </summary>
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public class OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint
    {
        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>

        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
            OrganizationQueryCriteriaIdentifierAndUniqueConstraint organizationQueryCriteriaIdentifierAndUniqueConstraint
            )
        {
            this.OrganizationQueryCriteriaIdentifierAndUniqueConstraint = organizationQueryCriteriaIdentifierAndUniqueConstraint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
        /// <param name="idIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">Initialize criteria of IdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint</param>
        /// <param name="uniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">Initialize criteria of UniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint</param>
        /// <param name="uniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">Initialize criteria of UniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint</param>
        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
            QuerySystemInt64EqualsCriteria idIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , QuerySystemGuidEqualsCriteria uniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , QuerySystemGuidEqualsCriteria uniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            )
            : this(
            new OrganizationQueryCriteriaIdentifierAndUniqueConstraint(idIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint,uniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint,uniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
        /// <param name="isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">will compare/filter IdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">value to compare/filter with IdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column</param>
        /// <param name="isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">will compare/filter UniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">value to compare/filter with UniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">will compare/filter UniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">value to compare/filter with UniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column</param>
        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
            bool isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , bool isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , bool isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
            , new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
            , new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is IdentifierAndUniqueConstraint
        /// </summary>
        public OrganizationQueryCriteriaIdentifierAndUniqueConstraint OrganizationQueryCriteriaIdentifierAndUniqueConstraint { get; set; }
    }

}


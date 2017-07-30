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
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaCommon"/> class.
        /// </summary>
		public OrganizationQueryCriteriaCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemBooleanEqualsCriteria">Initialize criteria of IsSystemBuiltIn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of CreatedDateTime</param>
        /// <param name="QuerySystemBooleanEqualsCriteria">Initialize criteria of BitColumn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of DatetimeColumn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of Datetime2Column</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of SmalldatetimeColumn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of DateColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of CharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of VarcharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of TextColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of NcharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of NvarcharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of NtextColumn</param>
		public OrganizationQueryCriteriaCommon(
			QuerySystemInt64EqualsCriteria idCommonOfOrganization_2
			, QuerySystemBooleanEqualsCriteria isSystemBuiltInCommonOft
			, QuerySystemDateTimeRangeCriteria createdDateTimeCommonOft
			, QuerySystemBooleanEqualsCriteria bitColumnCommonOft
			, QuerySystemDateTimeRangeCriteria datetimeColumnCommonOft
			, QuerySystemDateTimeRangeCriteria datetime2ColumnCommonOft
			, QuerySystemDateTimeRangeCriteria smalldatetimeColumnCommonOft
			, QuerySystemDateTimeRangeCriteria dateColumnCommonOft
			, QuerySystemStringContainsCriteria nameCommonOft
			, QuerySystemStringContainsCriteria charColumnCommonOft
			, QuerySystemStringContainsCriteria varcharColumnCommonOft
			, QuerySystemStringContainsCriteria textColumnCommonOft
			, QuerySystemStringContainsCriteria ncharColumnCommonOft
			, QuerySystemStringContainsCriteria nvarcharColumnCommonOft
			, QuerySystemStringContainsCriteria ntextColumnCommonOft
			)
		{
			this.IdCommonOfOrganization_2 = idCommonOfOrganization_2;
			this.IsSystemBuiltInCommonOft = isSystemBuiltInCommonOft;
			this.CreatedDateTimeCommonOft = createdDateTimeCommonOft;
			this.BitColumnCommonOft = bitColumnCommonOft;
			this.DatetimeColumnCommonOft = datetimeColumnCommonOft;
			this.Datetime2ColumnCommonOft = datetime2ColumnCommonOft;
			this.SmalldatetimeColumnCommonOft = smalldatetimeColumnCommonOft;
			this.DateColumnCommonOft = dateColumnCommonOft;
			this.NameCommonOft = nameCommonOft;
			this.CharColumnCommonOft = charColumnCommonOft;
			this.VarcharColumnCommonOft = varcharColumnCommonOft;
			this.TextColumnCommonOft = textColumnCommonOft;
			this.NcharColumnCommonOft = ncharColumnCommonOft;
			this.NvarcharColumnCommonOft = nvarcharColumnCommonOft;
			this.NtextColumnCommonOft = ntextColumnCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfOrganization_2">will compare/filter IdCommonOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2">value to compare/filter with IdCommonOfOrganization_2 property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltInCommonOft">will compare/filter IsSystemBuiltInCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIsSystemBuiltInCommonOft">value to compare/filter with IsSystemBuiltInCommonOft property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeCommonOft">will compare/filter CreatedDateTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundCreatedDateTimeCommonOft">will compare/filter to lower bound of CreatedDateTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundCreatedDateTimeCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundCreatedDateTimeCommonOft">will compare/filter to upper bound of CreatedDateTimeCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundCreatedDateTimeCommonOft">upper bound</param>
        /// <param name="isToCompareBitColumnCommonOft">will compare/filter BitColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareBitColumnCommonOft">value to compare/filter with BitColumnCommonOft property/field/column</param>
        /// <param name="isToCompareDatetimeColumnCommonOft">will compare/filter DatetimeColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetimeColumnCommonOft">will compare/filter to lower bound of DatetimeColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetimeColumnCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetimeColumnCommonOft">will compare/filter to upper bound of DatetimeColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetimeColumnCommonOft">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnCommonOft">will compare/filter Datetime2ColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetime2ColumnCommonOft">will compare/filter to lower bound of Datetime2ColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetime2ColumnCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetime2ColumnCommonOft">will compare/filter to upper bound of Datetime2ColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetime2ColumnCommonOft">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnCommonOft">will compare/filter SmalldatetimeColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundSmalldatetimeColumnCommonOft">will compare/filter to lower bound of SmalldatetimeColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundSmalldatetimeColumnCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundSmalldatetimeColumnCommonOft">will compare/filter to upper bound of SmalldatetimeColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundSmalldatetimeColumnCommonOft">upper bound</param>
        /// <param name="isToCompareDateColumnCommonOft">will compare/filter DateColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDateColumnCommonOft">will compare/filter to lower bound of DateColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDateColumnCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDateColumnCommonOft">will compare/filter to upper bound of DateColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDateColumnCommonOft">upper bound</param>
        /// <param name="isToCompareNameCommonOft">will compare/filter NameCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOft">value to compare/filter with NameCommonOft property/field/column</param>
        /// <param name="isToCompareCharColumnCommonOft">will compare/filter CharColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedCharColumnCommonOft">value to compare/filter with CharColumnCommonOft property/field/column</param>
        /// <param name="isToCompareVarcharColumnCommonOft">will compare/filter VarcharColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedVarcharColumnCommonOft">value to compare/filter with VarcharColumnCommonOft property/field/column</param>
        /// <param name="isToCompareTextColumnCommonOft">will compare/filter TextColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedTextColumnCommonOft">value to compare/filter with TextColumnCommonOft property/field/column</param>
        /// <param name="isToCompareNcharColumnCommonOft">will compare/filter NcharColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNcharColumnCommonOft">value to compare/filter with NcharColumnCommonOft property/field/column</param>
        /// <param name="isToCompareNvarcharColumnCommonOft">will compare/filter NvarcharColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNvarcharColumnCommonOft">value to compare/filter with NvarcharColumnCommonOft property/field/column</param>
        /// <param name="isToCompareNtextColumnCommonOft">will compare/filter NtextColumnCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNtextColumnCommonOft">value to compare/filter with NtextColumnCommonOft property/field/column</param>
		public OrganizationQueryCriteriaCommon(
			bool isToCompareIdCommonOfOrganization_2, System.Int64? valueToCompareIdCommonOfOrganization_2
			, bool isToCompareIsSystemBuiltInCommonOft, System.Boolean? valueToCompareIsSystemBuiltInCommonOft
			, bool isToCompareCreatedDateTimeCommonOft, bool isToCompareLowerBoundCreatedDateTimeCommonOft, System.DateTime? lowerBoundCreatedDateTimeCommonOft, bool isToCompareUpperBoundCreatedDateTimeCommonOft, System.DateTime? upperBoundCreatedDateTimeCommonOft
			, bool isToCompareBitColumnCommonOft, System.Boolean? valueToCompareBitColumnCommonOft
			, bool isToCompareDatetimeColumnCommonOft, bool isToCompareLowerBoundDatetimeColumnCommonOft, System.DateTime? lowerBoundDatetimeColumnCommonOft, bool isToCompareUpperBoundDatetimeColumnCommonOft, System.DateTime? upperBoundDatetimeColumnCommonOft
			, bool isToCompareDatetime2ColumnCommonOft, bool isToCompareLowerBoundDatetime2ColumnCommonOft, System.DateTime? lowerBoundDatetime2ColumnCommonOft, bool isToCompareUpperBoundDatetime2ColumnCommonOft, System.DateTime? upperBoundDatetime2ColumnCommonOft
			, bool isToCompareSmalldatetimeColumnCommonOft, bool isToCompareLowerBoundSmalldatetimeColumnCommonOft, System.DateTime? lowerBoundSmalldatetimeColumnCommonOft, bool isToCompareUpperBoundSmalldatetimeColumnCommonOft, System.DateTime? upperBoundSmalldatetimeColumnCommonOft
			, bool isToCompareDateColumnCommonOft, bool isToCompareLowerBoundDateColumnCommonOft, System.DateTime? lowerBoundDateColumnCommonOft, bool isToCompareUpperBoundDateColumnCommonOft, System.DateTime? upperBoundDateColumnCommonOft
			, bool isToCompareNameCommonOft, System.String valueToBeContainedNameCommonOft
			, bool isToCompareCharColumnCommonOft, System.String valueToBeContainedCharColumnCommonOft
			, bool isToCompareVarcharColumnCommonOft, System.String valueToBeContainedVarcharColumnCommonOft
			, bool isToCompareTextColumnCommonOft, System.String valueToBeContainedTextColumnCommonOft
			, bool isToCompareNcharColumnCommonOft, System.String valueToBeContainedNcharColumnCommonOft
			, bool isToCompareNvarcharColumnCommonOft, System.String valueToBeContainedNvarcharColumnCommonOft
			, bool isToCompareNtextColumnCommonOft, System.String valueToBeContainedNtextColumnCommonOft
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2, valueToCompareIdCommonOfOrganization_2)
				, new QuerySystemBooleanEqualsCriteria(isToCompareIsSystemBuiltInCommonOft, valueToCompareIsSystemBuiltInCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareCreatedDateTimeCommonOft, isToCompareLowerBoundCreatedDateTimeCommonOft, lowerBoundCreatedDateTimeCommonOft, isToCompareUpperBoundCreatedDateTimeCommonOft, upperBoundCreatedDateTimeCommonOft)
				, new QuerySystemBooleanEqualsCriteria(isToCompareBitColumnCommonOft, valueToCompareBitColumnCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareDatetimeColumnCommonOft, isToCompareLowerBoundDatetimeColumnCommonOft, lowerBoundDatetimeColumnCommonOft, isToCompareUpperBoundDatetimeColumnCommonOft, upperBoundDatetimeColumnCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareDatetime2ColumnCommonOft, isToCompareLowerBoundDatetime2ColumnCommonOft, lowerBoundDatetime2ColumnCommonOft, isToCompareUpperBoundDatetime2ColumnCommonOft, upperBoundDatetime2ColumnCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareSmalldatetimeColumnCommonOft, isToCompareLowerBoundSmalldatetimeColumnCommonOft, lowerBoundSmalldatetimeColumnCommonOft, isToCompareUpperBoundSmalldatetimeColumnCommonOft, upperBoundSmalldatetimeColumnCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareDateColumnCommonOft, isToCompareLowerBoundDateColumnCommonOft, lowerBoundDateColumnCommonOft, isToCompareUpperBoundDateColumnCommonOft, upperBoundDateColumnCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOft, valueToBeContainedNameCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareCharColumnCommonOft, valueToBeContainedCharColumnCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareVarcharColumnCommonOft, valueToBeContainedVarcharColumnCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareTextColumnCommonOft, valueToBeContainedTextColumnCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNcharColumnCommonOft, valueToBeContainedNcharColumnCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNvarcharColumnCommonOft, valueToBeContainedNvarcharColumnCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNtextColumnCommonOft, valueToBeContainedNtextColumnCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; }

        /// <summary>
        /// criteria of IsSystemBuiltIn, filter type: Equals
        /// </summary>
        public QuerySystemBooleanEqualsCriteria IsSystemBuiltInCommonOft { get; set; }

        /// <summary>
        /// criteria of CreatedDateTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria CreatedDateTimeCommonOft { get; set; }

        /// <summary>
        /// criteria of BitColumn, filter type: Equals
        /// </summary>
        public QuerySystemBooleanEqualsCriteria BitColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of DatetimeColumn, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria DatetimeColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of Datetime2Column, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria Datetime2ColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of SmalldatetimeColumn, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria SmalldatetimeColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of DateColumn, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria DateColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of Name, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; }

        /// <summary>
        /// criteria of CharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria CharColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of VarcharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria VarcharColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of TextColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria TextColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of NcharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NcharColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of NvarcharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NvarcharColumnCommonOft { get; set; }

        /// <summary>
        /// criteria of NtextColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NtextColumnCommonOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class OrganizationQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaAll"/> class.
        /// </summary>
		public OrganizationQueryCriteriaAll()
		{
		}


		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class OrganizationQueryCriteriaByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByFKOnly"/> class.
        /// </summary>
		public OrganizationQueryCriteriaByFKOnly()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
		public OrganizationQueryCriteriaByFKOnly(
			QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2
			)
		{
			this.IdByFKOnlyOfOrganization_2 = idByFKOnlyOfOrganization_2;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2">will compare/filter IdByFKOnlyOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2">value to compare/filter with IdByFKOnlyOfOrganization_2 property/field/column</param>
		public OrganizationQueryCriteriaByFKOnly(
			bool isToCompareIdByFKOnlyOfOrganization_2, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2, valueToCompareIdByFKOnlyOfOrganization_2)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_2 { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class OrganizationQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public OrganizationQueryCriteriaByIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
		public OrganizationQueryCriteriaByIdentifier(
			QuerySystemInt64EqualsCriteria idByIdentifierOft
			)
		{
			this.IdByIdentifierOft = idByIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
		public OrganizationQueryCriteriaByIdentifier(
			bool isToCompareIdByIdentifierOft, System.Int64? valueToCompareIdByIdentifierOft
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOft, valueToCompareIdByIdentifierOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByIdentifierOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueIdentifier
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
		public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemGuidEqualsCriteria">Initialize criteria of UniqueIdentifier</param>
		public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(
			QuerySystemGuidEqualsCriteria uniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft
			)
		{
			this.UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft = uniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft">will compare/filter UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft">value to compare/filter with UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft property/field/column</param>
		public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(
			bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft
			)
			: this(
				new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft, valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of UniqueIdentifier, filter type: Equals
        /// </summary>
        public QuerySystemGuidEqualsCriteria UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueidentifierColumn
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
		public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
        /// <param name="QuerySystemGuidEqualsCriteria">Initialize criteria of UniqueidentifierColumn</param>
		public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
			QuerySystemGuidEqualsCriteria uniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft
			)
		{
			this.UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft = uniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft">will compare/filter UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft">value to compare/filter with UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft property/field/column</param>
		public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
			bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft
			)
			: this(
				new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft, valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of UniqueidentifierColumn, filter type: Equals
        /// </summary>
        public QuerySystemGuidEqualsCriteria UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public partial class OrganizationQueryCriteriaIdentifierAndUniqueConstraint
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
		public OrganizationQueryCriteriaIdentifierAndUniqueConstraint()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemGuidEqualsCriteria">Initialize criteria of UniqueIdentifier</param>
        /// <param name="QuerySystemGuidEqualsCriteria">Initialize criteria of UniqueidentifierColumn</param>
		public OrganizationQueryCriteriaIdentifierAndUniqueConstraint(
			QuerySystemInt64EqualsCriteria idIdentifierAndUniqueConstraintOft
			, QuerySystemGuidEqualsCriteria uniqueIdentifierIdentifierAndUniqueConstraintOft
			, QuerySystemGuidEqualsCriteria uniqueidentifierColumnIdentifierAndUniqueConstraintOft
			)
		{
			this.IdIdentifierAndUniqueConstraintOft = idIdentifierAndUniqueConstraintOft;
			this.UniqueIdentifierIdentifierAndUniqueConstraintOft = uniqueIdentifierIdentifierAndUniqueConstraintOft;
			this.UniqueidentifierColumnIdentifierAndUniqueConstraintOft = uniqueidentifierColumnIdentifierAndUniqueConstraintOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
        /// <param name="isToCompareIdIdentifierAndUniqueConstraintOft">will compare/filter IdIdentifierAndUniqueConstraintOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdIdentifierAndUniqueConstraintOft">value to compare/filter with IdIdentifierAndUniqueConstraintOft property/field/column</param>
        /// <param name="isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOft">will compare/filter UniqueIdentifierIdentifierAndUniqueConstraintOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOft">value to compare/filter with UniqueIdentifierIdentifierAndUniqueConstraintOft property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOft">will compare/filter UniqueidentifierColumnIdentifierAndUniqueConstraintOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOft">value to compare/filter with UniqueidentifierColumnIdentifierAndUniqueConstraintOft property/field/column</param>
		public OrganizationQueryCriteriaIdentifierAndUniqueConstraint(
			bool isToCompareIdIdentifierAndUniqueConstraintOft, System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOft
			, bool isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOft, System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOft
			, bool isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOft, System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOft
			)
			: this(
				new QuerySystemInt64EqualsCriteria(isToCompareIdIdentifierAndUniqueConstraintOft, valueToCompareIdIdentifierAndUniqueConstraintOft)
				, new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOft, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOft)
				, new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOft, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdIdentifierAndUniqueConstraintOft { get; set; }

        /// <summary>
        /// criteria of UniqueIdentifier, filter type: Equals
        /// </summary>
        public QuerySystemGuidEqualsCriteria UniqueIdentifierIdentifierAndUniqueConstraintOft { get; set; }

        /// <summary>
        /// criteria of UniqueidentifierColumn, filter type: Equals
        /// </summary>
        public QuerySystemGuidEqualsCriteria UniqueidentifierColumnIdentifierAndUniqueConstraintOft { get; set; }

		#endregion Propertyies
	}


    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=UniqueConstraintsWithCommon
    /// </summary>
    public partial class OrganizationQueryCriteriaUniqueConstraintsWithCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintsWithCommon"/> class.
        /// </summary>
		public OrganizationQueryCriteriaUniqueConstraintsWithCommon()
		{
		}


        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintsWithCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemGuidEqualsCriteria">Initialize criteria of UniqueIdentifier</param>
        /// <param name="QuerySystemGuidEqualsCriteria">Initialize criteria of UniqueidentifierColumn</param>
        /// <param name="QuerySystemBooleanEqualsCriteria">Initialize criteria of IsSystemBuiltIn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of CreatedDateTime</param>
        /// <param name="QuerySystemBooleanEqualsCriteria">Initialize criteria of BitColumn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of DatetimeColumn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of Datetime2Column</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of SmalldatetimeColumn</param>
        /// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of DateColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of CharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of VarcharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of TextColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of NcharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of NvarcharColumn</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of NtextColumn</param>
		public OrganizationQueryCriteriaUniqueConstraintsWithCommon(
			QuerySystemGuidEqualsCriteria uniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2
			, QuerySystemGuidEqualsCriteria uniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2
			, QuerySystemBooleanEqualsCriteria isSystemBuiltInUniqueConstraintsWithCommonOft
			, QuerySystemDateTimeRangeCriteria createdDateTimeUniqueConstraintsWithCommonOft
			, QuerySystemBooleanEqualsCriteria bitColumnUniqueConstraintsWithCommonOft
			, QuerySystemDateTimeRangeCriteria datetimeColumnUniqueConstraintsWithCommonOft
			, QuerySystemDateTimeRangeCriteria datetime2ColumnUniqueConstraintsWithCommonOft
			, QuerySystemDateTimeRangeCriteria smalldatetimeColumnUniqueConstraintsWithCommonOft
			, QuerySystemDateTimeRangeCriteria dateColumnUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria nameUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria charColumnUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria varcharColumnUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria textColumnUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria ncharColumnUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria nvarcharColumnUniqueConstraintsWithCommonOft
			, QuerySystemStringContainsCriteria ntextColumnUniqueConstraintsWithCommonOft
			)
		{
			this.UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2 = uniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2;
			this.UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2 = uniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2;
			this.IsSystemBuiltInUniqueConstraintsWithCommonOft = isSystemBuiltInUniqueConstraintsWithCommonOft;
			this.CreatedDateTimeUniqueConstraintsWithCommonOft = createdDateTimeUniqueConstraintsWithCommonOft;
			this.BitColumnUniqueConstraintsWithCommonOft = bitColumnUniqueConstraintsWithCommonOft;
			this.DatetimeColumnUniqueConstraintsWithCommonOft = datetimeColumnUniqueConstraintsWithCommonOft;
			this.Datetime2ColumnUniqueConstraintsWithCommonOft = datetime2ColumnUniqueConstraintsWithCommonOft;
			this.SmalldatetimeColumnUniqueConstraintsWithCommonOft = smalldatetimeColumnUniqueConstraintsWithCommonOft;
			this.DateColumnUniqueConstraintsWithCommonOft = dateColumnUniqueConstraintsWithCommonOft;
			this.NameUniqueConstraintsWithCommonOft = nameUniqueConstraintsWithCommonOft;
			this.CharColumnUniqueConstraintsWithCommonOft = charColumnUniqueConstraintsWithCommonOft;
			this.VarcharColumnUniqueConstraintsWithCommonOft = varcharColumnUniqueConstraintsWithCommonOft;
			this.TextColumnUniqueConstraintsWithCommonOft = textColumnUniqueConstraintsWithCommonOft;
			this.NcharColumnUniqueConstraintsWithCommonOft = ncharColumnUniqueConstraintsWithCommonOft;
			this.NvarcharColumnUniqueConstraintsWithCommonOft = nvarcharColumnUniqueConstraintsWithCommonOft;
			this.NtextColumnUniqueConstraintsWithCommonOft = ntextColumnUniqueConstraintsWithCommonOft;
		}
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationQueryCriteriaUniqueConstraintsWithCommon"/> class.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2">will compare/filter UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2">value to compare/filter with UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2 property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2">will compare/filter UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2">value to compare/filter with UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2 property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOft">will compare/filter IsSystemBuiltInUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOft">value to compare/filter with IsSystemBuiltInUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeUniqueConstraintsWithCommonOft">will compare/filter CreatedDateTimeUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOft">will compare/filter to lower bound of CreatedDateTimeUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOft">will compare/filter to upper bound of CreatedDateTimeUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundCreatedDateTimeUniqueConstraintsWithCommonOft">upper bound</param>
        /// <param name="isToCompareBitColumnUniqueConstraintsWithCommonOft">will compare/filter BitColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareBitColumnUniqueConstraintsWithCommonOft">value to compare/filter with BitColumnUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareDatetimeColumnUniqueConstraintsWithCommonOft">will compare/filter DatetimeColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOft">will compare/filter to lower bound of DatetimeColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetimeColumnUniqueConstraintsWithCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOft">will compare/filter to upper bound of DatetimeColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetimeColumnUniqueConstraintsWithCommonOft">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnUniqueConstraintsWithCommonOft">will compare/filter Datetime2ColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOft">will compare/filter to lower bound of Datetime2ColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOft">will compare/filter to upper bound of Datetime2ColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetime2ColumnUniqueConstraintsWithCommonOft">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOft">will compare/filter SmalldatetimeColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft">will compare/filter to lower bound of SmalldatetimeColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft">will compare/filter to upper bound of SmalldatetimeColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft">upper bound</param>
        /// <param name="isToCompareDateColumnUniqueConstraintsWithCommonOft">will compare/filter DateColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOft">will compare/filter to lower bound of DateColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDateColumnUniqueConstraintsWithCommonOft">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOft">will compare/filter to upper bound of DateColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDateColumnUniqueConstraintsWithCommonOft">upper bound</param>
        /// <param name="isToCompareNameUniqueConstraintsWithCommonOft">will compare/filter NameUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameUniqueConstraintsWithCommonOft">value to compare/filter with NameUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareCharColumnUniqueConstraintsWithCommonOft">will compare/filter CharColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedCharColumnUniqueConstraintsWithCommonOft">value to compare/filter with CharColumnUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareVarcharColumnUniqueConstraintsWithCommonOft">will compare/filter VarcharColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOft">value to compare/filter with VarcharColumnUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareTextColumnUniqueConstraintsWithCommonOft">will compare/filter TextColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedTextColumnUniqueConstraintsWithCommonOft">value to compare/filter with TextColumnUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareNcharColumnUniqueConstraintsWithCommonOft">will compare/filter NcharColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNcharColumnUniqueConstraintsWithCommonOft">value to compare/filter with NcharColumnUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareNvarcharColumnUniqueConstraintsWithCommonOft">will compare/filter NvarcharColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOft">value to compare/filter with NvarcharColumnUniqueConstraintsWithCommonOft property/field/column</param>
        /// <param name="isToCompareNtextColumnUniqueConstraintsWithCommonOft">will compare/filter NtextColumnUniqueConstraintsWithCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNtextColumnUniqueConstraintsWithCommonOft">value to compare/filter with NtextColumnUniqueConstraintsWithCommonOft property/field/column</param>
		public OrganizationQueryCriteriaUniqueConstraintsWithCommon(
			bool isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2
			, bool isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2
			, bool isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOft, System.Boolean? valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOft
			, bool isToCompareCreatedDateTimeUniqueConstraintsWithCommonOft, bool isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOft, System.DateTime? lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOft, bool isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOft, System.DateTime? upperBoundCreatedDateTimeUniqueConstraintsWithCommonOft
			, bool isToCompareBitColumnUniqueConstraintsWithCommonOft, System.Boolean? valueToCompareBitColumnUniqueConstraintsWithCommonOft
			, bool isToCompareDatetimeColumnUniqueConstraintsWithCommonOft, bool isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOft, System.DateTime? lowerBoundDatetimeColumnUniqueConstraintsWithCommonOft, bool isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOft, System.DateTime? upperBoundDatetimeColumnUniqueConstraintsWithCommonOft
			, bool isToCompareDatetime2ColumnUniqueConstraintsWithCommonOft, bool isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOft, System.DateTime? lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOft, bool isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOft, System.DateTime? upperBoundDatetime2ColumnUniqueConstraintsWithCommonOft
			, bool isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOft, bool isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft, System.DateTime? lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft, bool isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft, System.DateTime? upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft
			, bool isToCompareDateColumnUniqueConstraintsWithCommonOft, bool isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOft, System.DateTime? lowerBoundDateColumnUniqueConstraintsWithCommonOft, bool isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOft, System.DateTime? upperBoundDateColumnUniqueConstraintsWithCommonOft
			, bool isToCompareNameUniqueConstraintsWithCommonOft, System.String valueToBeContainedNameUniqueConstraintsWithCommonOft
			, bool isToCompareCharColumnUniqueConstraintsWithCommonOft, System.String valueToBeContainedCharColumnUniqueConstraintsWithCommonOft
			, bool isToCompareVarcharColumnUniqueConstraintsWithCommonOft, System.String valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOft
			, bool isToCompareTextColumnUniqueConstraintsWithCommonOft, System.String valueToBeContainedTextColumnUniqueConstraintsWithCommonOft
			, bool isToCompareNcharColumnUniqueConstraintsWithCommonOft, System.String valueToBeContainedNcharColumnUniqueConstraintsWithCommonOft
			, bool isToCompareNvarcharColumnUniqueConstraintsWithCommonOft, System.String valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOft
			, bool isToCompareNtextColumnUniqueConstraintsWithCommonOft, System.String valueToBeContainedNtextColumnUniqueConstraintsWithCommonOft
			)
			: this(
				new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2, valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2)
				, new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2, valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2)
				, new QuerySystemBooleanEqualsCriteria(isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOft, valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareCreatedDateTimeUniqueConstraintsWithCommonOft, isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOft, lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOft, isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOft, upperBoundCreatedDateTimeUniqueConstraintsWithCommonOft)
				, new QuerySystemBooleanEqualsCriteria(isToCompareBitColumnUniqueConstraintsWithCommonOft, valueToCompareBitColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareDatetimeColumnUniqueConstraintsWithCommonOft, isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOft, lowerBoundDatetimeColumnUniqueConstraintsWithCommonOft, isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOft, upperBoundDatetimeColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareDatetime2ColumnUniqueConstraintsWithCommonOft, isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOft, lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOft, isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOft, upperBoundDatetime2ColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOft, isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft, lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft, isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft, upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemDateTimeRangeCriteria(isToCompareDateColumnUniqueConstraintsWithCommonOft, isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOft, lowerBoundDateColumnUniqueConstraintsWithCommonOft, isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOft, upperBoundDateColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNameUniqueConstraintsWithCommonOft, valueToBeContainedNameUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareCharColumnUniqueConstraintsWithCommonOft, valueToBeContainedCharColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareVarcharColumnUniqueConstraintsWithCommonOft, valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareTextColumnUniqueConstraintsWithCommonOft, valueToBeContainedTextColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNcharColumnUniqueConstraintsWithCommonOft, valueToBeContainedNcharColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNvarcharColumnUniqueConstraintsWithCommonOft, valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOft)
				, new QuerySystemStringContainsCriteria(isToCompareNtextColumnUniqueConstraintsWithCommonOft, valueToBeContainedNtextColumnUniqueConstraintsWithCommonOft)
				)
		{
		}


		#endregion constructors

		#region Propertyies


        /// <summary>
        /// criteria of UniqueIdentifier, filter type: Equals
        /// </summary>
        public QuerySystemGuidEqualsCriteria UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2 { get; set; }

        /// <summary>
        /// criteria of UniqueidentifierColumn, filter type: Equals
        /// </summary>
        public QuerySystemGuidEqualsCriteria UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2 { get; set; }

        /// <summary>
        /// criteria of IsSystemBuiltIn, filter type: Equals
        /// </summary>
        public QuerySystemBooleanEqualsCriteria IsSystemBuiltInUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of CreatedDateTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria CreatedDateTimeUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of BitColumn, filter type: Equals
        /// </summary>
        public QuerySystemBooleanEqualsCriteria BitColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of DatetimeColumn, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria DatetimeColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of Datetime2Column, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria Datetime2ColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of SmalldatetimeColumn, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria SmalldatetimeColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of DateColumn, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria DateColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of Name, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NameUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of CharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria CharColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of VarcharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria VarcharColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of TextColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria TextColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of NcharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NcharColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of NvarcharColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NvarcharColumnUniqueConstraintsWithCommonOft { get; set; }

        /// <summary>
        /// criteria of NtextColumn, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NtextColumnUniqueConstraintsWithCommonOft { get; set; }

		#endregion Propertyies
	}


}
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
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommon"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaCommon()
			: this(new OrganizationChainedQueryCriteriaCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaCommon(OrganizationChainedQueryCriteriaCommonFlatten input)
            : this(
				input.IsToCompareIdCommonOfOrganization_2OfCommon, input.ValueToCompareIdCommonOfOrganization_2OfCommon.HasValue ? input.ValueToCompareIdCommonOfOrganization_2OfCommon.Value : default(long)
				, input.IsToCompareIsSystemBuiltInCommonOftOfCommon, input.ValueToCompareIsSystemBuiltInCommonOftOfCommon
				, input.IsToCompareCreatedDateTimeCommonOftOfCommon, input.IsToCompareLowerBoundCreatedDateTimeCommonOftOfCommon, input.LowerBoundCreatedDateTimeCommonOftOfCommon.HasValue ? input.LowerBoundCreatedDateTimeCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundCreatedDateTimeCommonOftOfCommon, input.UpperBoundCreatedDateTimeCommonOftOfCommon.HasValue ? input.UpperBoundCreatedDateTimeCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareBitColumnCommonOftOfCommon, input.ValueToCompareBitColumnCommonOftOfCommon
				, input.IsToCompareDatetimeColumnCommonOftOfCommon, input.IsToCompareLowerBoundDatetimeColumnCommonOftOfCommon, input.LowerBoundDatetimeColumnCommonOftOfCommon.HasValue ? input.LowerBoundDatetimeColumnCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundDatetimeColumnCommonOftOfCommon, input.UpperBoundDatetimeColumnCommonOftOfCommon.HasValue ? input.UpperBoundDatetimeColumnCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareDatetime2ColumnCommonOftOfCommon, input.IsToCompareLowerBoundDatetime2ColumnCommonOftOfCommon, input.LowerBoundDatetime2ColumnCommonOftOfCommon.HasValue ? input.LowerBoundDatetime2ColumnCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundDatetime2ColumnCommonOftOfCommon, input.UpperBoundDatetime2ColumnCommonOftOfCommon.HasValue ? input.UpperBoundDatetime2ColumnCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareSmalldatetimeColumnCommonOftOfCommon, input.IsToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon, input.LowerBoundSmalldatetimeColumnCommonOftOfCommon.HasValue ? input.LowerBoundSmalldatetimeColumnCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon, input.UpperBoundSmalldatetimeColumnCommonOftOfCommon.HasValue ? input.UpperBoundSmalldatetimeColumnCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareDateColumnCommonOftOfCommon, input.IsToCompareLowerBoundDateColumnCommonOftOfCommon, input.LowerBoundDateColumnCommonOftOfCommon.HasValue ? input.LowerBoundDateColumnCommonOftOfCommon.Value : DateTime.Now, input.IsToCompareUpperBoundDateColumnCommonOftOfCommon, input.UpperBoundDateColumnCommonOftOfCommon.HasValue ? input.UpperBoundDateColumnCommonOftOfCommon.Value : DateTime.Now
				, input.IsToCompareNameCommonOftOfCommon, input.ValueToBeContainedNameCommonOftOfCommon
				, input.IsToCompareCharColumnCommonOftOfCommon, input.ValueToBeContainedCharColumnCommonOftOfCommon
				, input.IsToCompareVarcharColumnCommonOftOfCommon, input.ValueToBeContainedVarcharColumnCommonOftOfCommon
				, input.IsToCompareTextColumnCommonOftOfCommon, input.ValueToBeContainedTextColumnCommonOftOfCommon
				, input.IsToCompareNcharColumnCommonOftOfCommon, input.ValueToBeContainedNcharColumnCommonOftOfCommon
				, input.IsToCompareNvarcharColumnCommonOftOfCommon, input.ValueToBeContainedNvarcharColumnCommonOftOfCommon
				, input.IsToCompareNtextColumnCommonOftOfCommon, input.ValueToBeContainedNtextColumnCommonOftOfCommon
			)
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
			, bool isToCompareCreatedDateTimeCommonOftOfCommon, bool isToCompareLowerBoundCreatedDateTimeCommonOftOfCommon, System.DateTime lowerBoundCreatedDateTimeCommonOftOfCommon, bool isToCompareUpperBoundCreatedDateTimeCommonOftOfCommon, System.DateTime upperBoundCreatedDateTimeCommonOftOfCommon
			, bool isToCompareBitColumnCommonOftOfCommon, System.Boolean? valueToCompareBitColumnCommonOftOfCommon
			, bool isToCompareDatetimeColumnCommonOftOfCommon, bool isToCompareLowerBoundDatetimeColumnCommonOftOfCommon, System.DateTime lowerBoundDatetimeColumnCommonOftOfCommon, bool isToCompareUpperBoundDatetimeColumnCommonOftOfCommon, System.DateTime upperBoundDatetimeColumnCommonOftOfCommon
			, bool isToCompareDatetime2ColumnCommonOftOfCommon, bool isToCompareLowerBoundDatetime2ColumnCommonOftOfCommon, System.DateTime lowerBoundDatetime2ColumnCommonOftOfCommon, bool isToCompareUpperBoundDatetime2ColumnCommonOftOfCommon, System.DateTime upperBoundDatetime2ColumnCommonOftOfCommon
			, bool isToCompareSmalldatetimeColumnCommonOftOfCommon, bool isToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon, System.DateTime lowerBoundSmalldatetimeColumnCommonOftOfCommon, bool isToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon, System.DateTime upperBoundSmalldatetimeColumnCommonOftOfCommon
			, bool isToCompareDateColumnCommonOftOfCommon, bool isToCompareLowerBoundDateColumnCommonOftOfCommon, System.DateTime lowerBoundDateColumnCommonOftOfCommon, bool isToCompareUpperBoundDateColumnCommonOftOfCommon, System.DateTime upperBoundDateColumnCommonOftOfCommon
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



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public OrganizationQueryCriteriaCommon OrganizationQueryCriteriaCommon { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaCommonFlatten()
		{
			this.IsToCompareIdCommonOfOrganization_2OfCommon= false; this.ValueToCompareIdCommonOfOrganization_2OfCommon= default(long);
			this.IsToCompareIsSystemBuiltInCommonOftOfCommon= false; this.ValueToCompareIsSystemBuiltInCommonOftOfCommon= true;
			this.IsToCompareCreatedDateTimeCommonOftOfCommon= false; this.IsToCompareLowerBoundCreatedDateTimeCommonOftOfCommon=false;this.LowerBoundCreatedDateTimeCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundCreatedDateTimeCommonOftOfCommon=false;this.UpperBoundCreatedDateTimeCommonOftOfCommon=DateTime.Now;
			this.IsToCompareBitColumnCommonOftOfCommon= false; this.ValueToCompareBitColumnCommonOftOfCommon= true;
			this.IsToCompareDatetimeColumnCommonOftOfCommon= false; this.IsToCompareLowerBoundDatetimeColumnCommonOftOfCommon=false;this.LowerBoundDatetimeColumnCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundDatetimeColumnCommonOftOfCommon=false;this.UpperBoundDatetimeColumnCommonOftOfCommon=DateTime.Now;
			this.IsToCompareDatetime2ColumnCommonOftOfCommon= false; this.IsToCompareLowerBoundDatetime2ColumnCommonOftOfCommon=false;this.LowerBoundDatetime2ColumnCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundDatetime2ColumnCommonOftOfCommon=false;this.UpperBoundDatetime2ColumnCommonOftOfCommon=DateTime.Now;
			this.IsToCompareSmalldatetimeColumnCommonOftOfCommon= false; this.IsToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon=false;this.LowerBoundSmalldatetimeColumnCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon=false;this.UpperBoundSmalldatetimeColumnCommonOftOfCommon=DateTime.Now;
			this.IsToCompareDateColumnCommonOftOfCommon= false; this.IsToCompareLowerBoundDateColumnCommonOftOfCommon=false;this.LowerBoundDateColumnCommonOftOfCommon=DateTime.Now;this.IsToCompareUpperBoundDateColumnCommonOftOfCommon=false;this.UpperBoundDateColumnCommonOftOfCommon=DateTime.Now;
			this.IsToCompareNameCommonOftOfCommon= false; this.ValueToBeContainedNameCommonOftOfCommon= null;
			this.IsToCompareCharColumnCommonOftOfCommon= false; this.ValueToBeContainedCharColumnCommonOftOfCommon= null;
			this.IsToCompareVarcharColumnCommonOftOfCommon= false; this.ValueToBeContainedVarcharColumnCommonOftOfCommon= null;
			this.IsToCompareTextColumnCommonOftOfCommon= false; this.ValueToBeContainedTextColumnCommonOftOfCommon= null;
			this.IsToCompareNcharColumnCommonOftOfCommon= false; this.ValueToBeContainedNcharColumnCommonOftOfCommon= null;
			this.IsToCompareNvarcharColumnCommonOftOfCommon= false; this.ValueToBeContainedNvarcharColumnCommonOftOfCommon= null;
			this.IsToCompareNtextColumnCommonOftOfCommon= false; this.ValueToBeContainedNtextColumnCommonOftOfCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommonFlatten"/> class.
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
		public OrganizationChainedQueryCriteriaCommonFlatten(
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
		{
			this.IsToCompareIdCommonOfOrganization_2OfCommon= isToCompareIdCommonOfOrganization_2OfCommon; this.ValueToCompareIdCommonOfOrganization_2OfCommon= valueToCompareIdCommonOfOrganization_2OfCommon;
			this.IsToCompareIsSystemBuiltInCommonOftOfCommon= isToCompareIsSystemBuiltInCommonOftOfCommon; this.ValueToCompareIsSystemBuiltInCommonOftOfCommon= valueToCompareIsSystemBuiltInCommonOftOfCommon;
			this.IsToCompareCreatedDateTimeCommonOftOfCommon= isToCompareCreatedDateTimeCommonOftOfCommon; this.IsToCompareLowerBoundCreatedDateTimeCommonOftOfCommon=isToCompareLowerBoundCreatedDateTimeCommonOftOfCommon;this.LowerBoundCreatedDateTimeCommonOftOfCommon=lowerBoundCreatedDateTimeCommonOftOfCommon;this.IsToCompareUpperBoundCreatedDateTimeCommonOftOfCommon=isToCompareUpperBoundCreatedDateTimeCommonOftOfCommon;this.UpperBoundCreatedDateTimeCommonOftOfCommon=upperBoundCreatedDateTimeCommonOftOfCommon;
			this.IsToCompareBitColumnCommonOftOfCommon= isToCompareBitColumnCommonOftOfCommon; this.ValueToCompareBitColumnCommonOftOfCommon= valueToCompareBitColumnCommonOftOfCommon;
			this.IsToCompareDatetimeColumnCommonOftOfCommon= isToCompareDatetimeColumnCommonOftOfCommon; this.IsToCompareLowerBoundDatetimeColumnCommonOftOfCommon=isToCompareLowerBoundDatetimeColumnCommonOftOfCommon;this.LowerBoundDatetimeColumnCommonOftOfCommon=lowerBoundDatetimeColumnCommonOftOfCommon;this.IsToCompareUpperBoundDatetimeColumnCommonOftOfCommon=isToCompareUpperBoundDatetimeColumnCommonOftOfCommon;this.UpperBoundDatetimeColumnCommonOftOfCommon=upperBoundDatetimeColumnCommonOftOfCommon;
			this.IsToCompareDatetime2ColumnCommonOftOfCommon= isToCompareDatetime2ColumnCommonOftOfCommon; this.IsToCompareLowerBoundDatetime2ColumnCommonOftOfCommon=isToCompareLowerBoundDatetime2ColumnCommonOftOfCommon;this.LowerBoundDatetime2ColumnCommonOftOfCommon=lowerBoundDatetime2ColumnCommonOftOfCommon;this.IsToCompareUpperBoundDatetime2ColumnCommonOftOfCommon=isToCompareUpperBoundDatetime2ColumnCommonOftOfCommon;this.UpperBoundDatetime2ColumnCommonOftOfCommon=upperBoundDatetime2ColumnCommonOftOfCommon;
			this.IsToCompareSmalldatetimeColumnCommonOftOfCommon= isToCompareSmalldatetimeColumnCommonOftOfCommon; this.IsToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon=isToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon;this.LowerBoundSmalldatetimeColumnCommonOftOfCommon=lowerBoundSmalldatetimeColumnCommonOftOfCommon;this.IsToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon=isToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon;this.UpperBoundSmalldatetimeColumnCommonOftOfCommon=upperBoundSmalldatetimeColumnCommonOftOfCommon;
			this.IsToCompareDateColumnCommonOftOfCommon= isToCompareDateColumnCommonOftOfCommon; this.IsToCompareLowerBoundDateColumnCommonOftOfCommon=isToCompareLowerBoundDateColumnCommonOftOfCommon;this.LowerBoundDateColumnCommonOftOfCommon=lowerBoundDateColumnCommonOftOfCommon;this.IsToCompareUpperBoundDateColumnCommonOftOfCommon=isToCompareUpperBoundDateColumnCommonOftOfCommon;this.UpperBoundDateColumnCommonOftOfCommon=upperBoundDateColumnCommonOftOfCommon;
			this.IsToCompareNameCommonOftOfCommon= isToCompareNameCommonOftOfCommon; this.ValueToBeContainedNameCommonOftOfCommon= valueToBeContainedNameCommonOftOfCommon;
			this.IsToCompareCharColumnCommonOftOfCommon= isToCompareCharColumnCommonOftOfCommon; this.ValueToBeContainedCharColumnCommonOftOfCommon= valueToBeContainedCharColumnCommonOftOfCommon;
			this.IsToCompareVarcharColumnCommonOftOfCommon= isToCompareVarcharColumnCommonOftOfCommon; this.ValueToBeContainedVarcharColumnCommonOftOfCommon= valueToBeContainedVarcharColumnCommonOftOfCommon;
			this.IsToCompareTextColumnCommonOftOfCommon= isToCompareTextColumnCommonOftOfCommon; this.ValueToBeContainedTextColumnCommonOftOfCommon= valueToBeContainedTextColumnCommonOftOfCommon;
			this.IsToCompareNcharColumnCommonOftOfCommon= isToCompareNcharColumnCommonOftOfCommon; this.ValueToBeContainedNcharColumnCommonOftOfCommon= valueToBeContainedNcharColumnCommonOftOfCommon;
			this.IsToCompareNvarcharColumnCommonOftOfCommon= isToCompareNvarcharColumnCommonOftOfCommon; this.ValueToBeContainedNvarcharColumnCommonOftOfCommon= valueToBeContainedNvarcharColumnCommonOftOfCommon;
			this.IsToCompareNtextColumnCommonOftOfCommon= isToCompareNtextColumnCommonOftOfCommon; this.ValueToBeContainedNtextColumnCommonOftOfCommon= valueToBeContainedNtextColumnCommonOftOfCommon;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaCommonFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaCommonFlatten(OrganizationChainedQueryCriteriaCommon input)
			: this(
			input.OrganizationQueryCriteriaCommon.IdCommonOfOrganization_2.IsToCompare, input.OrganizationQueryCriteriaCommon.IdCommonOfOrganization_2.ValueToCompare
			, input.OrganizationQueryCriteriaCommon.IsSystemBuiltInCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.IsSystemBuiltInCommonOft.ValueToCompare
			, input.OrganizationQueryCriteriaCommon.CreatedDateTimeCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.CreatedDateTimeCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaCommon.CreatedDateTimeCommonOft.LowerBound, input.OrganizationQueryCriteriaCommon.CreatedDateTimeCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaCommon.CreatedDateTimeCommonOft.UpperBound
			, input.OrganizationQueryCriteriaCommon.BitColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.BitColumnCommonOft.ValueToCompare
			, input.OrganizationQueryCriteriaCommon.DatetimeColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.DatetimeColumnCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaCommon.DatetimeColumnCommonOft.LowerBound, input.OrganizationQueryCriteriaCommon.DatetimeColumnCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaCommon.DatetimeColumnCommonOft.UpperBound
			, input.OrganizationQueryCriteriaCommon.Datetime2ColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.Datetime2ColumnCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaCommon.Datetime2ColumnCommonOft.LowerBound, input.OrganizationQueryCriteriaCommon.Datetime2ColumnCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaCommon.Datetime2ColumnCommonOft.UpperBound
			, input.OrganizationQueryCriteriaCommon.SmalldatetimeColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.SmalldatetimeColumnCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaCommon.SmalldatetimeColumnCommonOft.LowerBound, input.OrganizationQueryCriteriaCommon.SmalldatetimeColumnCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaCommon.SmalldatetimeColumnCommonOft.UpperBound
			, input.OrganizationQueryCriteriaCommon.DateColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.DateColumnCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaCommon.DateColumnCommonOft.LowerBound, input.OrganizationQueryCriteriaCommon.DateColumnCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaCommon.DateColumnCommonOft.UpperBound
			, input.OrganizationQueryCriteriaCommon.NameCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.NameCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaCommon.CharColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.CharColumnCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaCommon.VarcharColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.VarcharColumnCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaCommon.TextColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.TextColumnCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaCommon.NcharColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.NcharColumnCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaCommon.NvarcharColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.NvarcharColumnCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaCommon.NtextColumnCommonOft.IsToCompare, input.OrganizationQueryCriteriaCommon.NtextColumnCommonOft.ValueToBeContained
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdCommonOfOrganization_2OfCommon { get; set; } public System.Int64? ValueToCompareIdCommonOfOrganization_2OfCommon { get; set; }
		public bool IsToCompareIsSystemBuiltInCommonOftOfCommon { get; set; } public System.Boolean? ValueToCompareIsSystemBuiltInCommonOftOfCommon { get; set; }
		public bool IsToCompareCreatedDateTimeCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundCreatedDateTimeCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundCreatedDateTimeCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundCreatedDateTimeCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundCreatedDateTimeCommonOftOfCommon { get; set; }
		public bool IsToCompareBitColumnCommonOftOfCommon { get; set; } public System.Boolean? ValueToCompareBitColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareDatetimeColumnCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundDatetimeColumnCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundDatetimeColumnCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundDatetimeColumnCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundDatetimeColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareDatetime2ColumnCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundDatetime2ColumnCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundDatetime2ColumnCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundDatetime2ColumnCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundDatetime2ColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareSmalldatetimeColumnCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundSmalldatetimeColumnCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundSmalldatetimeColumnCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundSmalldatetimeColumnCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundSmalldatetimeColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareDateColumnCommonOftOfCommon { get; set; } public bool IsToCompareLowerBoundDateColumnCommonOftOfCommon { get; set; } public System.DateTime? LowerBoundDateColumnCommonOftOfCommon { get; set; } public bool IsToCompareUpperBoundDateColumnCommonOftOfCommon { get; set; } public System.DateTime? UpperBoundDateColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareNameCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNameCommonOftOfCommon { get; set; }
		public bool IsToCompareCharColumnCommonOftOfCommon { get; set; } public System.String ValueToBeContainedCharColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareVarcharColumnCommonOftOfCommon { get; set; } public System.String ValueToBeContainedVarcharColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareTextColumnCommonOftOfCommon { get; set; } public System.String ValueToBeContainedTextColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareNcharColumnCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNcharColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareNvarcharColumnCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNvarcharColumnCommonOftOfCommon { get; set; }
		public bool IsToCompareNtextColumnCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNtextColumnCommonOftOfCommon { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class OrganizationChainedQueryCriteriaAll
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaAll"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaAll()
			
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaAll(OrganizationChainedQueryCriteriaAllFlatten input)
            : this(

			)
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


		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public OrganizationQueryCriteriaAll OrganizationQueryCriteriaAll { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaAllFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaAllFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaAllFlatten()
		{

		}



		#endregion constructors

		#region Propertyies



		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class OrganizationChainedQueryCriteriaByFKOnly
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaByFKOnly()
			: this(new OrganizationChainedQueryCriteriaByFKOnlyFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaByFKOnly(OrganizationChainedQueryCriteriaByFKOnlyFlatten input)
            : this(
				input.IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, input.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.Value : default(long)
			)
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
			bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public OrganizationQueryCriteriaByFKOnly OrganizationQueryCriteriaByFKOnly { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaByFKOnlyFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnlyFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaByFKOnlyFlatten()
		{
			this.IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= default(long);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnlyFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>	
		public OrganizationChainedQueryCriteriaByFKOnlyFlatten(
			bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
			)
		{
			this.IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly; this.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByFKOnlyFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaByFKOnlyFlatten(OrganizationChainedQueryCriteriaByFKOnly input)
			: this(
			input.OrganizationQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2.IsToCompare, input.OrganizationQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2.ValueToCompare
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly { get; set; } public System.Int64? ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaByIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaByIdentifier()
			: this(new OrganizationChainedQueryCriteriaByIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaByIdentifier(OrganizationChainedQueryCriteriaByIdentifierFlatten input)
            : this(
				input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(long)
			)
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
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public OrganizationQueryCriteriaByIdentifier OrganizationQueryCriteriaByIdentifier { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaByIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaByIdentifierFlatten()
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(long);
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>	
		public OrganizationChainedQueryCriteriaByIdentifierFlatten(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64? valueToCompareIdByIdentifierOftOfByIdentifier
			)
		{
			this.IsToCompareIdByIdentifierOftOfByIdentifier= isToCompareIdByIdentifierOftOfByIdentifier; this.ValueToCompareIdByIdentifierOftOfByIdentifier= valueToCompareIdByIdentifierOftOfByIdentifier;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaByIdentifierFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaByIdentifierFlatten(OrganizationChainedQueryCriteriaByIdentifier input)
			: this(
			input.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare, input.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdByIdentifierOftOfByIdentifier { get; set; } public System.Int64? ValueToCompareIdByIdentifierOftOfByIdentifier { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueIdentifier
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier()
			: this(new OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier(OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten input)
            : this(
				input.IsToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, input.ValueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier.HasValue ? input.ValueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier.Value : new Guid()
			)
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
			bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, System.Guid valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
			)
			: this(
			new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is UniqueConstraintOfUC_Organization_UniqueIdentifier
        /// </summary>
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten()
		{
			this.IsToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier= false; this.ValueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier= new Guid();
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">will compare/filter UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">value to compare/filter with UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column</param>	
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten(
			bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
			)
		{
			this.IsToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier= isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier; this.ValueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier= valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifierFlatten(OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier input)
			: this(
			input.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOft.ValueToCompare
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier { get; set; } public System.Guid? ValueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintOfUC_Organization_UniqueidentifierColumn
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn()
			: this(new OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn(OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten input)
            : this(
				input.IsToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, input.ValueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.HasValue ? input.ValueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.Value : new Guid()
			)
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
			bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, System.Guid valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
			)
			: this(
			new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is UniqueConstraintOfUC_Organization_UniqueidentifierColumn
        /// </summary>
        public OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten()
		{
			this.IsToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn= false; this.ValueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn= new Guid();
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">will compare/filter UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">value to compare/filter with UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column</param>	
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten(
			bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
			)
		{
			this.IsToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn= isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn; this.ValueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn= valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumnFlatten(OrganizationChainedQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn input)
			: this(
			input.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOft.ValueToCompare
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn { get; set; } public System.Guid? ValueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=IdentifierAndUniqueConstraint
    /// </summary>
    public class OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint()
			: this(new OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten input)
            : this(
				input.IsToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, input.ValueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue ? input.ValueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.Value : default(long)
				, input.IsToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, input.ValueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue ? input.ValueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.Value : new Guid()
				, input.IsToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, input.ValueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue ? input.ValueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.Value : new Guid()
			)
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
			bool isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Int64 valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
			, bool isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Guid valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
			, bool isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Guid valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
			)
			: this(
			new QuerySystemInt64EqualsCriteria(isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
			, new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
			, new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is IdentifierAndUniqueConstraint
        /// </summary>
        public OrganizationQueryCriteriaIdentifierAndUniqueConstraint OrganizationQueryCriteriaIdentifierAndUniqueConstraint { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten()
		{
			this.IsToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= false; this.ValueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= default(long);
			this.IsToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= false; this.ValueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= new Guid();
			this.IsToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= false; this.ValueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= new Guid();
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">will compare/filter IdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">value to compare/filter with IdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column</param>
        /// <param name="isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">will compare/filter UniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">value to compare/filter with UniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">will compare/filter UniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint">value to compare/filter with UniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint property/field/column</param>	
		public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten(
			bool isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
			, bool isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
			, bool isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
			)
		{
			this.IsToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= isToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint; this.ValueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint;
			this.IsToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= isToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint; this.ValueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint;
			this.IsToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= isToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint; this.ValueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint= valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraintFlatten(OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint input)
			: this(
			input.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.IdIdentifierAndUniqueConstraintOft.IsToCompare, input.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.IdIdentifierAndUniqueConstraintOft.ValueToCompare
			, input.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifierIdentifierAndUniqueConstraintOft.IsToCompare, input.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifierIdentifierAndUniqueConstraintOft.ValueToCompare
			, input.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumnIdentifierAndUniqueConstraintOft.IsToCompare, input.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumnIdentifierAndUniqueConstraintOft.ValueToCompare
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint { get; set; } public System.Int64? ValueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint { get; set; }
		public bool IsToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint { get; set; } public System.Guid? ValueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint { get; set; }
		public bool IsToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint { get; set; } public System.Guid? ValueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint { get; set; }

		#endregion Propertyies
	}



    
	/// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=UniqueConstraintsWithCommon
    /// </summary>
    public class OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon()
			: this(new OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten())
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon(OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten input)
            : this(
				input.IsToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, input.ValueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon.HasValue ? input.ValueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon.Value : new Guid()
				, input.IsToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, input.ValueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon.HasValue ? input.ValueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon.Value : new Guid()
				, input.IsToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.IsToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.LowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.LowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now, input.IsToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.UpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.UpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now
				, input.IsToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.IsToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.LowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.LowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now, input.IsToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.UpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.UpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now
				, input.IsToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.IsToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.LowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.LowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now, input.IsToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.UpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.UpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now
				, input.IsToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.IsToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.LowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.LowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now, input.IsToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.UpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.UpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now
				, input.IsToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.IsToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.LowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.LowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now, input.IsToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.UpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.HasValue ? input.UpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon.Value : DateTime.Now
				, input.IsToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
				, input.IsToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, input.ValueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon"/> class.
        /// </summary>

		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon(
			OrganizationQueryCriteriaUniqueConstraintsWithCommon organizationQueryCriteriaUniqueConstraintsWithCommon			
			)
		{
			this.OrganizationQueryCriteriaUniqueConstraintsWithCommon = organizationQueryCriteriaUniqueConstraintsWithCommon;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon"/> class.
		/// </summary>
        /// <param name="uniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">Initialize criteria of UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon</param>
        /// <param name="uniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">Initialize criteria of UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon</param>
        /// <param name="isSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of IsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="createdDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="bitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of BitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="datetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="smalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="dateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="nameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of NameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="charColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of CharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="varcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of VarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="textColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of TextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="ncharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of NcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="nvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of NvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>
        /// <param name="ntextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">Initialize criteria of NtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon</param>	
		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon(
			QuerySystemGuidEqualsCriteria uniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon
			, QuerySystemGuidEqualsCriteria uniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon
			, QuerySystemBooleanEqualsCriteria isSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemDateTimeRangeCriteria createdDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemBooleanEqualsCriteria bitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemDateTimeRangeCriteria datetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemDateTimeRangeCriteria datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemDateTimeRangeCriteria smalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemDateTimeRangeCriteria dateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria nameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria charColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria varcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria textColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria ncharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria nvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, QuerySystemStringContainsCriteria ntextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			)
			: this(
			new OrganizationQueryCriteriaUniqueConstraintsWithCommon(uniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon,uniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon,isSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,createdDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,bitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,datetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,smalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,dateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,nameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,charColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,varcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,textColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,ncharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,nvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon,ntextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
				)
		{
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon"/> class.
		/// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">will compare/filter UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">value to compare/filter with UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">will compare/filter UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">value to compare/filter with UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter IsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with IsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter BitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with BitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter CharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with CharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter VarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with VarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter TextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with TextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>	
		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon(
			bool isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon
			, bool isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon
			, bool isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.Boolean? valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime upperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.Boolean? valueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime lowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime upperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime upperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime lowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime upperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			)
			: this(
			new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon)
			, new QuerySystemGuidEqualsCriteria(isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon)
			, new QuerySystemBooleanEqualsCriteria(isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, upperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemBooleanEqualsCriteria(isToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, lowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, upperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, upperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemDateTimeRangeCriteria(isToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, lowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, upperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
			, new QuerySystemStringContainsCriteria(isToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, valueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon)
				)
		{
		}



		#endregion constructors

		#region Propertyies

		
        /// <summary>
        /// DataQueryPerQuerySetting, key is UniqueConstraintsWithCommon
        /// </summary>
        public OrganizationQueryCriteriaUniqueConstraintsWithCommon OrganizationQueryCriteriaUniqueConstraintsWithCommon { get; set; }
		#endregion Propertyies
	}

	public class OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten
    {
		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten"/> class.
        /// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten()
		{
			this.IsToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= false; this.ValueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= new Guid();
			this.IsToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= false; this.ValueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= new Guid();
			this.IsToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= true;
			this.IsToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.IsToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.LowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;this.IsToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.UpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;
			this.IsToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= true;
			this.IsToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.IsToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.LowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;this.IsToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.UpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;
			this.IsToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.IsToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.LowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;this.IsToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.UpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;
			this.IsToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.IsToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.LowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;this.IsToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.UpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;
			this.IsToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.IsToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.LowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;this.IsToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=false;this.UpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=DateTime.Now;
			this.IsToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
			this.IsToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
			this.IsToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
			this.IsToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
			this.IsToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
			this.IsToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
			this.IsToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= false; this.ValueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten"/> class.
		/// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">will compare/filter UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">value to compare/filter with UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">will compare/filter UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon">value to compare/filter with UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter IsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with IsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of CreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter BitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with BitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of DatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of Datetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of SmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to lower bound of DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter to upper bound of DateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">upper bound</param>
        /// <param name="isToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter CharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with CharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter VarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with VarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter TextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with TextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>
        /// <param name="isToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">will compare/filter NtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon">value to compare/filter with NtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon property/field/column</param>	
		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten(
			bool isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon
			, bool isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon
			, bool isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.Boolean? valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? upperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.Boolean? valueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? lowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? upperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? upperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? lowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, bool isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.DateTime? upperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			, bool isToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon, System.String valueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon
			)
		{
			this.IsToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= isToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon; this.ValueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= valueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon;
			this.IsToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= isToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon; this.ValueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon= valueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon;
			this.IsToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.IsToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.LowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=lowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.IsToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.UpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=upperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.IsToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.LowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=lowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.IsToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.UpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=upperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.IsToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.LowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=lowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.IsToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.UpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=upperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.IsToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.LowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=lowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.IsToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.UpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=upperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.IsToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.LowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=lowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.IsToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=isToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;this.UpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon=upperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
			this.IsToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= isToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon; this.ValueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon= valueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten"/> class.
		/// </summary>
		public OrganizationChainedQueryCriteriaUniqueConstraintsWithCommonFlatten(OrganizationChainedQueryCriteriaUniqueConstraintsWithCommon input)
			: this(
			input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.UniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2.ValueToCompare
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.UniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2.ValueToCompare
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.IsSystemBuiltInUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.IsSystemBuiltInUniqueConstraintsWithCommonOft.ValueToCompare
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CreatedDateTimeUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CreatedDateTimeUniqueConstraintsWithCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CreatedDateTimeUniqueConstraintsWithCommonOft.LowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CreatedDateTimeUniqueConstraintsWithCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CreatedDateTimeUniqueConstraintsWithCommonOft.UpperBound
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.BitColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.BitColumnUniqueConstraintsWithCommonOft.ValueToCompare
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DatetimeColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DatetimeColumnUniqueConstraintsWithCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DatetimeColumnUniqueConstraintsWithCommonOft.LowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DatetimeColumnUniqueConstraintsWithCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DatetimeColumnUniqueConstraintsWithCommonOft.UpperBound
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.Datetime2ColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.Datetime2ColumnUniqueConstraintsWithCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.Datetime2ColumnUniqueConstraintsWithCommonOft.LowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.Datetime2ColumnUniqueConstraintsWithCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.Datetime2ColumnUniqueConstraintsWithCommonOft.UpperBound
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.SmalldatetimeColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.SmalldatetimeColumnUniqueConstraintsWithCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.SmalldatetimeColumnUniqueConstraintsWithCommonOft.LowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.SmalldatetimeColumnUniqueConstraintsWithCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.SmalldatetimeColumnUniqueConstraintsWithCommonOft.UpperBound
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DateColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DateColumnUniqueConstraintsWithCommonOft.IsToCompareLowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DateColumnUniqueConstraintsWithCommonOft.LowerBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DateColumnUniqueConstraintsWithCommonOft.IsToCompareUpperBound, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.DateColumnUniqueConstraintsWithCommonOft.UpperBound
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NameUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NameUniqueConstraintsWithCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CharColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.CharColumnUniqueConstraintsWithCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.VarcharColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.VarcharColumnUniqueConstraintsWithCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.TextColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.TextColumnUniqueConstraintsWithCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NcharColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NcharColumnUniqueConstraintsWithCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NvarcharColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NvarcharColumnUniqueConstraintsWithCommonOft.ValueToBeContained
			, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NtextColumnUniqueConstraintsWithCommonOft.IsToCompare, input.OrganizationQueryCriteriaUniqueConstraintsWithCommon.NtextColumnUniqueConstraintsWithCommonOft.ValueToBeContained
			)
		{
		}



		#endregion constructors

		#region Propertyies

		public bool IsToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon { get; set; } public System.Guid? ValueToCompareUniqueIdentifierUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon { get; set; } public System.Guid? ValueToCompareUniqueidentifierColumnUniqueConstraintsWithCommonOfOrganization_2OfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.Boolean? ValueToCompareIsSystemBuiltInUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareLowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? LowerBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareUpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? UpperBoundCreatedDateTimeUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.Boolean? ValueToCompareBitColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareLowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? LowerBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareUpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? UpperBoundDatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareLowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? LowerBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareUpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? UpperBoundDatetime2ColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareLowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? LowerBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareUpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? UpperBoundSmalldatetimeColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareLowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? LowerBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public bool IsToCompareUpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.DateTime? UpperBoundDateColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedNameUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedCharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedVarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedTextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedNcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedNvarcharColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }
		public bool IsToCompareNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; } public System.String ValueToBeContainedNtextColumnUniqueConstraintsWithCommonOftOfUniqueConstraintsWithCommon { get; set; }

		#endregion Propertyies
	}



}


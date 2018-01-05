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
            bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
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
            bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64? valueToCompareIdByIdentifierOftOfByIdentifier
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
            bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
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
            bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
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

}


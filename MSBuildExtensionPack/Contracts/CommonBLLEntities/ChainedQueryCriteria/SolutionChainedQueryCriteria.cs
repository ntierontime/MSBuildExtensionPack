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
    public class SolutionChainedQueryCriteriaCommon
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommon"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaCommon()
            : this(new SolutionChainedQueryCriteriaCommonFlatten())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public SolutionChainedQueryCriteriaCommon(SolutionChainedQueryCriteriaCommonFlatten input)
            : this(
                input.IsToCompareIdCommonOfOrganization_1OfCommon, input.ValueToCompareIdCommonOfOrganization_1OfCommon.HasValue ? input.ValueToCompareIdCommonOfOrganization_1OfCommon.Value : default(long)
                , input.IsToCompareIdCommonOfOrganization_2OfCommon, input.ValueToCompareIdCommonOfOrganization_2OfCommon.HasValue ? input.ValueToCompareIdCommonOfOrganization_2OfCommon.Value : default(long)
                , input.IsToCompareExternalParentIdCommonOftOfCommon, input.ValueToBeContainedExternalParentIdCommonOftOfCommon
                , input.IsToCompareNameCommonOftOfCommon, input.ValueToBeContainedNameCommonOftOfCommon
                , input.IsToCompareDescriptionCommonOftOfCommon, input.ValueToBeContainedDescriptionCommonOftOfCommon
            )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommon"/> class.
        /// </summary>

        public SolutionChainedQueryCriteriaCommon(
            SolutionQueryCriteriaCommon solutionQueryCriteriaCommon
            )
        {
            this.SolutionQueryCriteriaCommon = solutionQueryCriteriaCommon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="idCommonOfOrganization_1OfCommon">Initialize criteria of IdCommonOfOrganization_1OfCommon</param>
        /// <param name="idCommonOfOrganization_2OfCommon">Initialize criteria of IdCommonOfOrganization_2OfCommon</param>
        /// <param name="externalParentIdCommonOftOfCommon">Initialize criteria of ExternalParentIdCommonOftOfCommon</param>
        /// <param name="nameCommonOftOfCommon">Initialize criteria of NameCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>
        public SolutionChainedQueryCriteriaCommon(
            QuerySystemInt64EqualsCriteria idCommonOfOrganization_1OfCommon
            , QuerySystemInt64EqualsCriteria idCommonOfOrganization_2OfCommon
            , QuerySystemStringContainsCriteria externalParentIdCommonOftOfCommon
            , QuerySystemStringContainsCriteria nameCommonOftOfCommon
            , QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
            )
            : this(
            new SolutionQueryCriteriaCommon(idCommonOfOrganization_1OfCommon,idCommonOfOrganization_2OfCommon,externalParentIdCommonOftOfCommon,nameCommonOftOfCommon,descriptionCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfOrganization_1OfCommon">will compare/filter IdCommonOfOrganization_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_1OfCommon">value to compare/filter with IdCommonOfOrganization_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_2OfCommon">will compare/filter IdCommonOfOrganization_2OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2OfCommon">value to compare/filter with IdCommonOfOrganization_2OfCommon property/field/column</param>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        public SolutionChainedQueryCriteriaCommon(
            bool isToCompareIdCommonOfOrganization_1OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_1OfCommon
            , bool isToCompareIdCommonOfOrganization_2OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_2OfCommon
            , bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
            , bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
            , bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_1OfCommon, valueToCompareIdCommonOfOrganization_1OfCommon)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2OfCommon, valueToCompareIdCommonOfOrganization_2OfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
                )
        {
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public SolutionQueryCriteriaCommon SolutionQueryCriteriaCommon { get; set; }
        #endregion Propertyies
    }

    public class SolutionChainedQueryCriteriaCommonFlatten
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaCommonFlatten()
        {
            this.IsToCompareIdCommonOfOrganization_1OfCommon= false; this.ValueToCompareIdCommonOfOrganization_1OfCommon= default(long);
            this.IsToCompareIdCommonOfOrganization_2OfCommon= false; this.ValueToCompareIdCommonOfOrganization_2OfCommon= default(long);
            this.IsToCompareExternalParentIdCommonOftOfCommon= false; this.ValueToBeContainedExternalParentIdCommonOftOfCommon= null;
            this.IsToCompareNameCommonOftOfCommon= false; this.ValueToBeContainedNameCommonOftOfCommon= null;
            this.IsToCompareDescriptionCommonOftOfCommon= false; this.ValueToBeContainedDescriptionCommonOftOfCommon= null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfOrganization_1OfCommon">will compare/filter IdCommonOfOrganization_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_1OfCommon">value to compare/filter with IdCommonOfOrganization_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_2OfCommon">will compare/filter IdCommonOfOrganization_2OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2OfCommon">value to compare/filter with IdCommonOfOrganization_2OfCommon property/field/column</param>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        public SolutionChainedQueryCriteriaCommonFlatten(
            bool isToCompareIdCommonOfOrganization_1OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_1OfCommon
            , bool isToCompareIdCommonOfOrganization_2OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_2OfCommon
            , bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
            , bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
            , bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
            )
        {
            this.IsToCompareIdCommonOfOrganization_1OfCommon= isToCompareIdCommonOfOrganization_1OfCommon; this.ValueToCompareIdCommonOfOrganization_1OfCommon= valueToCompareIdCommonOfOrganization_1OfCommon;
            this.IsToCompareIdCommonOfOrganization_2OfCommon= isToCompareIdCommonOfOrganization_2OfCommon; this.ValueToCompareIdCommonOfOrganization_2OfCommon= valueToCompareIdCommonOfOrganization_2OfCommon;
            this.IsToCompareExternalParentIdCommonOftOfCommon= isToCompareExternalParentIdCommonOftOfCommon; this.ValueToBeContainedExternalParentIdCommonOftOfCommon= valueToBeContainedExternalParentIdCommonOftOfCommon;
            this.IsToCompareNameCommonOftOfCommon= isToCompareNameCommonOftOfCommon; this.ValueToBeContainedNameCommonOftOfCommon= valueToBeContainedNameCommonOftOfCommon;
            this.IsToCompareDescriptionCommonOftOfCommon= isToCompareDescriptionCommonOftOfCommon; this.ValueToBeContainedDescriptionCommonOftOfCommon= valueToBeContainedDescriptionCommonOftOfCommon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaCommonFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaCommonFlatten(SolutionChainedQueryCriteriaCommon input)
            : this(
            input.SolutionQueryCriteriaCommon.IdCommonOfOrganization_1.IsToCompare, input.SolutionQueryCriteriaCommon.IdCommonOfOrganization_1.ValueToCompare
            , input.SolutionQueryCriteriaCommon.IdCommonOfOrganization_2.IsToCompare, input.SolutionQueryCriteriaCommon.IdCommonOfOrganization_2.ValueToCompare
            , input.SolutionQueryCriteriaCommon.ExternalParentIdCommonOft.IsToCompare, input.SolutionQueryCriteriaCommon.ExternalParentIdCommonOft.ValueToBeContained
            , input.SolutionQueryCriteriaCommon.NameCommonOft.IsToCompare, input.SolutionQueryCriteriaCommon.NameCommonOft.ValueToBeContained
            , input.SolutionQueryCriteriaCommon.DescriptionCommonOft.IsToCompare, input.SolutionQueryCriteriaCommon.DescriptionCommonOft.ValueToBeContained
            )
        {
        }

        #endregion constructors

        #region Propertyies

        public bool IsToCompareIdCommonOfOrganization_1OfCommon { get; set; } public System.Int64? ValueToCompareIdCommonOfOrganization_1OfCommon { get; set; }
        public bool IsToCompareIdCommonOfOrganization_2OfCommon { get; set; } public System.Int64? ValueToCompareIdCommonOfOrganization_2OfCommon { get; set; }
        public bool IsToCompareExternalParentIdCommonOftOfCommon { get; set; } public System.String ValueToBeContainedExternalParentIdCommonOftOfCommon { get; set; }
        public bool IsToCompareNameCommonOftOfCommon { get; set; } public System.String ValueToBeContainedNameCommonOftOfCommon { get; set; }
        public bool IsToCompareDescriptionCommonOftOfCommon { get; set; } public System.String ValueToBeContainedDescriptionCommonOftOfCommon { get; set; }

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class SolutionChainedQueryCriteriaAll
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaAll"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaAll()

        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaAll"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public SolutionChainedQueryCriteriaAll(SolutionChainedQueryCriteriaAllFlatten input)
            : this(

            )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaAll"/> class.
        /// </summary>

        public SolutionChainedQueryCriteriaAll(
            SolutionQueryCriteriaAll solutionQueryCriteriaAll
            )
        {
            this.SolutionQueryCriteriaAll = solutionQueryCriteriaAll;
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public SolutionQueryCriteriaAll SolutionQueryCriteriaAll { get; set; }
        #endregion Propertyies
    }

    public class SolutionChainedQueryCriteriaAllFlatten
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaAllFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaAllFlatten()
        {

        }

        #endregion constructors

        #region Propertyies

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class SolutionChainedQueryCriteriaByFKOnly
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaByFKOnly()
            : this(new SolutionChainedQueryCriteriaByFKOnlyFlatten())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public SolutionChainedQueryCriteriaByFKOnly(SolutionChainedQueryCriteriaByFKOnlyFlatten input)
            : this(
                input.IsToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, input.ValueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.Value : default(long)
                , input.IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, input.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.HasValue ? input.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.Value : default(long)
            )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>

        public SolutionChainedQueryCriteriaByFKOnly(
            SolutionQueryCriteriaByFKOnly solutionQueryCriteriaByFKOnly
            )
        {
            this.SolutionQueryCriteriaByFKOnly = solutionQueryCriteriaByFKOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="idByFKOnlyOfOrganization_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfOrganization_2OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_2OfByFKOnly</param>
        public SolutionChainedQueryCriteriaByFKOnly(
            QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_1OfByFKOnly
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2OfByFKOnly
            )
            : this(
            new SolutionQueryCriteriaByFKOnly(idByFKOnlyOfOrganization_1OfByFKOnly,idByFKOnlyOfOrganization_2OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        public SolutionChainedQueryCriteriaByFKOnly(
            bool isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly)
                )
        {
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public SolutionQueryCriteriaByFKOnly SolutionQueryCriteriaByFKOnly { get; set; }
        #endregion Propertyies
    }

    public class SolutionChainedQueryCriteriaByFKOnlyFlatten
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnlyFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaByFKOnlyFlatten()
        {
            this.IsToCompareIdByFKOnlyOfOrganization_1OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly= default(long);
            this.IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= false; this.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= default(long);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnlyFlatten"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        public SolutionChainedQueryCriteriaByFKOnlyFlatten(
            bool isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            )
        {
            this.IsToCompareIdByFKOnlyOfOrganization_1OfByFKOnly= isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly; this.ValueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly= valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly;
            this.IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly; this.ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly= valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByFKOnlyFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaByFKOnlyFlatten(SolutionChainedQueryCriteriaByFKOnly input)
            : this(
            input.SolutionQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_1.IsToCompare, input.SolutionQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_1.ValueToCompare
            , input.SolutionQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2.IsToCompare, input.SolutionQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2.ValueToCompare
            )
        {
        }

        #endregion constructors

        #region Propertyies

        public bool IsToCompareIdByFKOnlyOfOrganization_1OfByFKOnly { get; set; } public System.Int64? ValueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly { get; set; }
        public bool IsToCompareIdByFKOnlyOfOrganization_2OfByFKOnly { get; set; } public System.Int64? ValueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly { get; set; }

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class SolutionChainedQueryCriteriaByIdentifier
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaByIdentifier()
            : this(new SolutionChainedQueryCriteriaByIdentifierFlatten())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="input">Flatten query class</param>
        public SolutionChainedQueryCriteriaByIdentifier(SolutionChainedQueryCriteriaByIdentifierFlatten input)
            : this(
                input.IsToCompareIdByIdentifierOftOfByIdentifier, input.ValueToCompareIdByIdentifierOftOfByIdentifier.HasValue ? input.ValueToCompareIdByIdentifierOftOfByIdentifier.Value : default(int)
            )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

        public SolutionChainedQueryCriteriaByIdentifier(
            SolutionQueryCriteriaByIdentifier solutionQueryCriteriaByIdentifier
            )
        {
            this.SolutionQueryCriteriaByIdentifier = solutionQueryCriteriaByIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>
        public SolutionChainedQueryCriteriaByIdentifier(
            QuerySystemInt32EqualsCriteria idByIdentifierOftOfByIdentifier
            )
            : this(
            new SolutionQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        public SolutionChainedQueryCriteriaByIdentifier(
            bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32? valueToCompareIdByIdentifierOftOfByIdentifier
            )
            : this(
            new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
                )
        {
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public SolutionQueryCriteriaByIdentifier SolutionQueryCriteriaByIdentifier { get; set; }
        #endregion Propertyies
    }

    public class SolutionChainedQueryCriteriaByIdentifierFlatten
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaByIdentifierFlatten()
        {
            this.IsToCompareIdByIdentifierOftOfByIdentifier= false; this.ValueToCompareIdByIdentifierOftOfByIdentifier= default(int);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        public SolutionChainedQueryCriteriaByIdentifierFlatten(
            bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32? valueToCompareIdByIdentifierOftOfByIdentifier
            )
        {
            this.IsToCompareIdByIdentifierOftOfByIdentifier= isToCompareIdByIdentifierOftOfByIdentifier; this.ValueToCompareIdByIdentifierOftOfByIdentifier= valueToCompareIdByIdentifierOftOfByIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionChainedQueryCriteriaByIdentifierFlatten"/> class.
        /// </summary>
        public SolutionChainedQueryCriteriaByIdentifierFlatten(SolutionChainedQueryCriteriaByIdentifier input)
            : this(
            input.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare, input.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare
            )
        {
        }

        #endregion constructors

        #region Propertyies

        public bool IsToCompareIdByIdentifierOftOfByIdentifier { get; set; } public System.Int32? ValueToCompareIdByIdentifierOftOfByIdentifier { get; set; }

        #endregion Propertyies
    }

}


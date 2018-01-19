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
    public class BuildChainedQueryCriteriaCommon
    {
        public BuildChainedQueryCriteriaCommon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
        /// </summary>

        public BuildChainedQueryCriteriaCommon(
            BuildQueryCriteriaCommon buildQueryCriteriaCommon
            )
        {
            this.BuildQueryCriteriaCommon = buildQueryCriteriaCommon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="idCommonOfSolution_1OfCommon">Initialize criteria of IdCommonOfSolution_1OfCommon</param>
        /// <param name="idCommonOfOrganization_1OfCommon">Initialize criteria of IdCommonOfOrganization_1OfCommon</param>
        /// <param name="idCommonOfOrganization_2OfCommon">Initialize criteria of IdCommonOfOrganization_2OfCommon</param>
        /// <param name="buildStartTimeCommonOftOfCommon">Initialize criteria of BuildStartTimeCommonOftOfCommon</param>
        /// <param name="nameCommonOftOfCommon">Initialize criteria of NameCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>
        public BuildChainedQueryCriteriaCommon(
            QuerySystemInt32EqualsCriteria idCommonOfSolution_1OfCommon
            , QuerySystemInt64EqualsCriteria idCommonOfOrganization_1OfCommon
            , QuerySystemInt64EqualsCriteria idCommonOfOrganization_2OfCommon
            , QuerySystemDateTimeRangeCriteria buildStartTimeCommonOftOfCommon
            , QuerySystemStringContainsCriteria nameCommonOftOfCommon
            , QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
            )
            : this(
            new BuildQueryCriteriaCommon(idCommonOfSolution_1OfCommon,idCommonOfOrganization_1OfCommon,idCommonOfOrganization_2OfCommon,buildStartTimeCommonOftOfCommon,nameCommonOftOfCommon,descriptionCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_1OfCommon">will compare/filter IdCommonOfOrganization_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_1OfCommon">value to compare/filter with IdCommonOfOrganization_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_2OfCommon">will compare/filter IdCommonOfOrganization_2OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2OfCommon">value to compare/filter with IdCommonOfOrganization_2OfCommon property/field/column</param>
        /// <param name="isToCompareBuildStartTimeCommonOftOfCommon">will compare/filter BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundBuildStartTimeCommonOftOfCommon">will compare/filter to lower bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundBuildStartTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundBuildStartTimeCommonOftOfCommon">will compare/filter to upper bound of BuildStartTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundBuildStartTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        public BuildChainedQueryCriteriaCommon(
            bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32? valueToCompareIdCommonOfSolution_1OfCommon
            , bool isToCompareIdCommonOfOrganization_1OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_1OfCommon
            , bool isToCompareIdCommonOfOrganization_2OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_2OfCommon
            , bool isToCompareBuildStartTimeCommonOftOfCommon, bool isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, System.DateTime? lowerBoundBuildStartTimeCommonOftOfCommon, bool isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, System.DateTime? upperBoundBuildStartTimeCommonOftOfCommon
            , bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
            , bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
            )
            : this(
            new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_1OfCommon, valueToCompareIdCommonOfOrganization_1OfCommon)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2OfCommon, valueToCompareIdCommonOfOrganization_2OfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOftOfCommon, isToCompareLowerBoundBuildStartTimeCommonOftOfCommon, lowerBoundBuildStartTimeCommonOftOfCommon, isToCompareUpperBoundBuildStartTimeCommonOftOfCommon, upperBoundBuildStartTimeCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BuildQueryCriteriaCommon BuildQueryCriteriaCommon { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildChainedQueryCriteriaAll
    {
        public BuildChainedQueryCriteriaAll()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaAll"/> class.
        /// </summary>

        public BuildChainedQueryCriteriaAll(
            BuildQueryCriteriaAll buildQueryCriteriaAll
            )
        {
            this.BuildQueryCriteriaAll = buildQueryCriteriaAll;
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BuildQueryCriteriaAll BuildQueryCriteriaAll { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BuildChainedQueryCriteriaByFKOnly
    {
        public BuildChainedQueryCriteriaByFKOnly()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>

        public BuildChainedQueryCriteriaByFKOnly(
            BuildQueryCriteriaByFKOnly buildQueryCriteriaByFKOnly
            )
        {
            this.BuildQueryCriteriaByFKOnly = buildQueryCriteriaByFKOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="idByFKOnlyOfSolution_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfSolution_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfOrganization_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfOrganization_2OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_2OfByFKOnly</param>
        public BuildChainedQueryCriteriaByFKOnly(
            QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1OfByFKOnly
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_1OfByFKOnly
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2OfByFKOnly
            )
            : this(
            new BuildQueryCriteriaByFKOnly(idByFKOnlyOfSolution_1OfByFKOnly,idByFKOnlyOfOrganization_1OfByFKOnly,idByFKOnlyOfOrganization_2OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        public BuildChainedQueryCriteriaByFKOnly(
            bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            )
            : this(
            new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public BuildQueryCriteriaByFKOnly BuildQueryCriteriaByFKOnly { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BuildChainedQueryCriteriaByIdentifier
    {
        public BuildChainedQueryCriteriaByIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

        public BuildChainedQueryCriteriaByIdentifier(
            BuildQueryCriteriaByIdentifier buildQueryCriteriaByIdentifier
            )
        {
            this.BuildQueryCriteriaByIdentifier = buildQueryCriteriaByIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>
        public BuildChainedQueryCriteriaByIdentifier(
            QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
            )
            : this(
            new BuildQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        public BuildChainedQueryCriteriaByIdentifier(
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
        public BuildQueryCriteriaByIdentifier BuildQueryCriteriaByIdentifier { get; set; }
    }

}


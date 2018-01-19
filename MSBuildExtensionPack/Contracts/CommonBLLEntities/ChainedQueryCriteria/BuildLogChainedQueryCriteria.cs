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
    public class BuildLogChainedQueryCriteriaCommon
    {
        public BuildLogChainedQueryCriteriaCommon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
        /// </summary>

        public BuildLogChainedQueryCriteriaCommon(
            BuildLogQueryCriteriaCommon buildLogQueryCriteriaCommon
            )
        {
            this.BuildLogQueryCriteriaCommon = buildLogQueryCriteriaCommon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="idCommonOfBuild_1OfCommon">Initialize criteria of IdCommonOfBuild_1OfCommon</param>
        /// <param name="idCommonOfSolution_1OfCommon">Initialize criteria of IdCommonOfSolution_1OfCommon</param>
        /// <param name="idCommonOfOrganization_1OfCommon">Initialize criteria of IdCommonOfOrganization_1OfCommon</param>
        /// <param name="idCommonOfOrganization_2OfCommon">Initialize criteria of IdCommonOfOrganization_2OfCommon</param>
        /// <param name="idCommonOfBuildEventCode_1OfCommon">Initialize criteria of IdCommonOfBuildEventCode_1OfCommon</param>
        /// <param name="eventTimeCommonOftOfCommon">Initialize criteria of EventTimeCommonOftOfCommon</param>
        /// <param name="messageCommonOftOfCommon">Initialize criteria of MessageCommonOftOfCommon</param>
        public BuildLogChainedQueryCriteriaCommon(
            QuerySystemInt64EqualsCriteria idCommonOfBuild_1OfCommon
            , QuerySystemInt32EqualsCriteria idCommonOfSolution_1OfCommon
            , QuerySystemInt64EqualsCriteria idCommonOfOrganization_1OfCommon
            , QuerySystemInt64EqualsCriteria idCommonOfOrganization_2OfCommon
            , QuerySystemInt32EqualsCriteria idCommonOfBuildEventCode_1OfCommon
            , QuerySystemDateTimeRangeCriteria eventTimeCommonOftOfCommon
            , QuerySystemStringContainsCriteria messageCommonOftOfCommon
            )
            : this(
            new BuildLogQueryCriteriaCommon(idCommonOfBuild_1OfCommon,idCommonOfSolution_1OfCommon,idCommonOfOrganization_1OfCommon,idCommonOfOrganization_2OfCommon,idCommonOfBuildEventCode_1OfCommon,eventTimeCommonOftOfCommon,messageCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_1OfCommon">will compare/filter IdCommonOfOrganization_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_1OfCommon">value to compare/filter with IdCommonOfOrganization_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_2OfCommon">will compare/filter IdCommonOfOrganization_2OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2OfCommon">value to compare/filter with IdCommonOfOrganization_2OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        public BuildLogChainedQueryCriteriaCommon(
            bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64? valueToCompareIdCommonOfBuild_1OfCommon
            , bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32? valueToCompareIdCommonOfSolution_1OfCommon
            , bool isToCompareIdCommonOfOrganization_1OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_1OfCommon
            , bool isToCompareIdCommonOfOrganization_2OfCommon, System.Int64? valueToCompareIdCommonOfOrganization_2OfCommon
            , bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32? valueToCompareIdCommonOfBuildEventCode_1OfCommon
            , bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime? lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime? upperBoundEventTimeCommonOftOfCommon
            , bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfBuild_1OfCommon, valueToCompareIdCommonOfBuild_1OfCommon)
            , new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1OfCommon, valueToCompareIdCommonOfSolution_1OfCommon)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_1OfCommon, valueToCompareIdCommonOfOrganization_1OfCommon)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2OfCommon, valueToCompareIdCommonOfOrganization_2OfCommon)
            , new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfBuildEventCode_1OfCommon, valueToCompareIdCommonOfBuildEventCode_1OfCommon)
            , new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeCommonOftOfCommon, isToCompareLowerBoundEventTimeCommonOftOfCommon, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon, upperBoundEventTimeCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareMessageCommonOftOfCommon, valueToBeContainedMessageCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BuildLogQueryCriteriaCommon BuildLogQueryCriteriaCommon { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildLogChainedQueryCriteriaAll
    {
        public BuildLogChainedQueryCriteriaAll()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaAll"/> class.
        /// </summary>

        public BuildLogChainedQueryCriteriaAll(
            BuildLogQueryCriteriaAll buildLogQueryCriteriaAll
            )
        {
            this.BuildLogQueryCriteriaAll = buildLogQueryCriteriaAll;
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BuildLogQueryCriteriaAll BuildLogQueryCriteriaAll { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class BuildLogChainedQueryCriteriaByFKOnly
    {
        public BuildLogChainedQueryCriteriaByFKOnly()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>

        public BuildLogChainedQueryCriteriaByFKOnly(
            BuildLogQueryCriteriaByFKOnly buildLogQueryCriteriaByFKOnly
            )
        {
            this.BuildLogQueryCriteriaByFKOnly = buildLogQueryCriteriaByFKOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="idByFKOnlyOfBuild_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfBuild_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfSolution_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfSolution_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfOrganization_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_1OfByFKOnly</param>
        /// <param name="idByFKOnlyOfOrganization_2OfByFKOnly">Initialize criteria of IdByFKOnlyOfOrganization_2OfByFKOnly</param>
        /// <param name="idByFKOnlyOfBuildEventCode_1OfByFKOnly">Initialize criteria of IdByFKOnlyOfBuildEventCode_1OfByFKOnly</param>
        public BuildLogChainedQueryCriteriaByFKOnly(
            QuerySystemInt64EqualsCriteria idByFKOnlyOfBuild_1OfByFKOnly
            , QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1OfByFKOnly
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_1OfByFKOnly
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2OfByFKOnly
            , QuerySystemInt32EqualsCriteria idByFKOnlyOfBuildEventCode_1OfByFKOnly
            )
            : this(
            new BuildLogQueryCriteriaByFKOnly(idByFKOnlyOfBuild_1OfByFKOnly,idByFKOnlyOfSolution_1OfByFKOnly,idByFKOnlyOfOrganization_1OfByFKOnly,idByFKOnlyOfOrganization_2OfByFKOnly,idByFKOnlyOfBuildEventCode_1OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        public BuildLogChainedQueryCriteriaByFKOnly(
            bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            , bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
            )
            : this(
            new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly)
            , new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly)
            , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly)
            , new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public BuildLogQueryCriteriaByFKOnly BuildLogQueryCriteriaByFKOnly { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BuildLogChainedQueryCriteriaByIdentifier
    {
        public BuildLogChainedQueryCriteriaByIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

        public BuildLogChainedQueryCriteriaByIdentifier(
            BuildLogQueryCriteriaByIdentifier buildLogQueryCriteriaByIdentifier
            )
        {
            this.BuildLogQueryCriteriaByIdentifier = buildLogQueryCriteriaByIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>
        public BuildLogChainedQueryCriteriaByIdentifier(
            QuerySystemInt64EqualsCriteria idByIdentifierOftOfByIdentifier
            )
            : this(
            new BuildLogQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        public BuildLogChainedQueryCriteriaByIdentifier(
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
        public BuildLogQueryCriteriaByIdentifier BuildLogQueryCriteriaByIdentifier { get; set; }
    }

}


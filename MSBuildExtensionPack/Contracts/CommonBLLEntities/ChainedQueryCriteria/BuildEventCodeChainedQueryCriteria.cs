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
    public class BuildEventCodeChainedQueryCriteriaCommon
    {
        public BuildEventCodeChainedQueryCriteriaCommon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
        /// </summary>

        public BuildEventCodeChainedQueryCriteriaCommon(
            BuildEventCodeQueryCriteriaCommon buildEventCodeQueryCriteriaCommon
            )
        {
            this.BuildEventCodeQueryCriteriaCommon = buildEventCodeQueryCriteriaCommon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="eventCodeCommonOftOfCommon">Initialize criteria of EventCodeCommonOftOfCommon</param>
        /// <param name="descriptionCommonOftOfCommon">Initialize criteria of DescriptionCommonOftOfCommon</param>
        public BuildEventCodeChainedQueryCriteriaCommon(
            QuerySystemStringContainsCriteria eventCodeCommonOftOfCommon
            , QuerySystemStringContainsCriteria descriptionCommonOftOfCommon
            )
            : this(
            new BuildEventCodeQueryCriteriaCommon(eventCodeCommonOftOfCommon,descriptionCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareEventCodeCommonOftOfCommon">will compare/filter EventCodeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedEventCodeCommonOftOfCommon">value to compare/filter with EventCodeCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        public BuildEventCodeChainedQueryCriteriaCommon(
            bool isToCompareEventCodeCommonOftOfCommon, System.String valueToBeContainedEventCodeCommonOftOfCommon
            , bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
            )
            : this(
            new QuerySystemStringContainsCriteria(isToCompareEventCodeCommonOftOfCommon, valueToBeContainedEventCodeCommonOftOfCommon)
            , new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public BuildEventCodeQueryCriteriaCommon BuildEventCodeQueryCriteriaCommon { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class BuildEventCodeChainedQueryCriteriaAll
    {
        public BuildEventCodeChainedQueryCriteriaAll()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaAll"/> class.
        /// </summary>

        public BuildEventCodeChainedQueryCriteriaAll(
            BuildEventCodeQueryCriteriaAll buildEventCodeQueryCriteriaAll
            )
        {
            this.BuildEventCodeQueryCriteriaAll = buildEventCodeQueryCriteriaAll;
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public BuildEventCodeQueryCriteriaAll BuildEventCodeQueryCriteriaAll { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class BuildEventCodeChainedQueryCriteriaByIdentifier
    {
        public BuildEventCodeChainedQueryCriteriaByIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>

        public BuildEventCodeChainedQueryCriteriaByIdentifier(
            BuildEventCodeQueryCriteriaByIdentifier buildEventCodeQueryCriteriaByIdentifier
            )
        {
            this.BuildEventCodeQueryCriteriaByIdentifier = buildEventCodeQueryCriteriaByIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="idByIdentifierOftOfByIdentifier">Initialize criteria of IdByIdentifierOftOfByIdentifier</param>
        public BuildEventCodeChainedQueryCriteriaByIdentifier(
            QuerySystemInt32EqualsCriteria idByIdentifierOftOfByIdentifier
            )
            : this(
            new BuildEventCodeQueryCriteriaByIdentifier(idByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeChainedQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        public BuildEventCodeChainedQueryCriteriaByIdentifier(
            bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32? valueToCompareIdByIdentifierOftOfByIdentifier
            )
            : this(
            new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
                )
        {
        }

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public BuildEventCodeQueryCriteriaByIdentifier BuildEventCodeQueryCriteriaByIdentifier { get; set; }
    }

}


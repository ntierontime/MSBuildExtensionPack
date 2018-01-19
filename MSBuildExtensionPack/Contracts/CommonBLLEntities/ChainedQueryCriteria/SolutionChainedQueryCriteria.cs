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
        public SolutionChainedQueryCriteriaCommon()
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

        /// <summary>
        /// DataQueryPerQuerySetting, key is Common
        /// </summary>
        public SolutionQueryCriteriaCommon SolutionQueryCriteriaCommon { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=All
    /// </summary>
    public class SolutionChainedQueryCriteriaAll
    {
        public SolutionChainedQueryCriteriaAll()
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

        /// <summary>
        /// DataQueryPerQuerySetting, key is All
        /// </summary>
        public SolutionQueryCriteriaAll SolutionQueryCriteriaAll { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByFKOnly
    /// </summary>
    public class SolutionChainedQueryCriteriaByFKOnly
    {
        public SolutionChainedQueryCriteriaByFKOnly()
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

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByFKOnly
        /// </summary>
        public SolutionQueryCriteriaByFKOnly SolutionQueryCriteriaByFKOnly { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerChainedQueryCriteria, key=ByIdentifier
    /// </summary>
    public class SolutionChainedQueryCriteriaByIdentifier
    {
        public SolutionChainedQueryCriteriaByIdentifier()
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

        /// <summary>
        /// DataQueryPerQuerySetting, key is ByIdentifier
        /// </summary>
        public SolutionQueryCriteriaByIdentifier SolutionQueryCriteriaByIdentifier { get; set; }
    }

}


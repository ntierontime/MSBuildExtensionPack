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
    public partial class BuildQueryCriteriaCommon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaCommon"/> class.
        /// </summary>
        public BuildQueryCriteriaCommon()
        {
            this.IdCommonOfOrganization_1 = new QuerySystemInt64EqualsCriteria();
            this.IdCommonOfOrganization_2 = new QuerySystemInt64EqualsCriteria();
            this.IdCommonOfSolution_1 = new QuerySystemInt32EqualsCriteria();
            this.BuildStartTimeCommonOft = new QuerySystemDateTimeRangeCriteria();
            this.DescriptionCommonOft = new QuerySystemStringContainsCriteria();
            this.NameCommonOft = new QuerySystemStringContainsCriteria();
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="BuildQueryCriteriaCommon"/> class.
        ///// </summary>
        ///// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        ///// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        ///// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        ///// <param name="QuerySystemDateTimeRangeCriteria">Initialize criteria of BuildStartTime</param>
        ///// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        ///// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Description</param>
        //public BuildQueryCriteriaCommon(
        //    QuerySystemInt32EqualsCriteria idCommonOfSolution_1
        //    , QuerySystemInt64EqualsCriteria idCommonOfOrganization_1
        //    , QuerySystemInt64EqualsCriteria idCommonOfOrganization_2
        //    , QuerySystemDateTimeRangeCriteria buildStartTimeCommonOft
        //    , QuerySystemStringContainsCriteria nameCommonOft
        //    , QuerySystemStringContainsCriteria descriptionCommonOft
        //    )
        //{
        //    this.IdCommonOfSolution_1 = idCommonOfSolution_1;
        //    this.IdCommonOfOrganization_1 = idCommonOfOrganization_1;
        //    this.IdCommonOfOrganization_2 = idCommonOfOrganization_2;
        //    this.BuildStartTimeCommonOft = buildStartTimeCommonOft;
        //    this.NameCommonOft = nameCommonOft;
        //    this.DescriptionCommonOft = descriptionCommonOft;
        //}
        ///// <summary>
        ///// Initializes a new instance of the <see cref="BuildQueryCriteriaCommon"/> class.
        ///// </summary>
        ///// <param name="isToCompareIdCommonOfSolution_1">will compare/filter IdCommonOfSolution_1 property/field/column if true, otherwise false</param>
        ///// <param name="valueToCompareIdCommonOfSolution_1">value to compare/filter with IdCommonOfSolution_1 property/field/column</param>
        ///// <param name="isToCompareIdCommonOfOrganization_1">will compare/filter IdCommonOfOrganization_1 property/field/column if true, otherwise false</param>
        ///// <param name="valueToCompareIdCommonOfOrganization_1">value to compare/filter with IdCommonOfOrganization_1 property/field/column</param>
        ///// <param name="isToCompareIdCommonOfOrganization_2">will compare/filter IdCommonOfOrganization_2 property/field/column if true, otherwise false</param>
        ///// <param name="valueToCompareIdCommonOfOrganization_2">value to compare/filter with IdCommonOfOrganization_2 property/field/column</param>
        ///// <param name="isToCompareBuildStartTimeCommonOft">will compare/filter BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        ///// <param name="isToCompareLowerBoundBuildStartTimeCommonOft">will compare/filter to lower bound of BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        ///// <param name="lowerBoundBuildStartTimeCommonOft">value of lower bound</param>
        ///// <param name="isToCompareUpperBoundBuildStartTimeCommonOft">will compare/filter to upper bound of BuildStartTimeCommonOft property/field/column if true, otherwise false</param>
        ///// <param name="upperBoundBuildStartTimeCommonOft">upper bound</param>
        ///// <param name="isToCompareNameCommonOft">will compare/filter NameCommonOft property/field/column if true, otherwise false</param>
        ///// <param name="valueToBeContainedNameCommonOft">value to compare/filter with NameCommonOft property/field/column</param>
        ///// <param name="isToCompareDescriptionCommonOft">will compare/filter DescriptionCommonOft property/field/column if true, otherwise false</param>
        ///// <param name="valueToBeContainedDescriptionCommonOft">value to compare/filter with DescriptionCommonOft property/field/column</param>
        //public BuildQueryCriteriaCommon(
        //    bool isToCompareIdCommonOfSolution_1, System.Int32? valueToCompareIdCommonOfSolution_1
        //    , bool isToCompareIdCommonOfOrganization_1, System.Int64? valueToCompareIdCommonOfOrganization_1
        //    , bool isToCompareIdCommonOfOrganization_2, System.Int64? valueToCompareIdCommonOfOrganization_2
        //    , bool isToCompareBuildStartTimeCommonOft, bool isToCompareLowerBoundBuildStartTimeCommonOft, System.DateTime? lowerBoundBuildStartTimeCommonOft, bool isToCompareUpperBoundBuildStartTimeCommonOft, System.DateTime? upperBoundBuildStartTimeCommonOft
        //    , bool isToCompareNameCommonOft, System.String valueToBeContainedNameCommonOft
        //    , bool isToCompareDescriptionCommonOft, System.String valueToBeContainedDescriptionCommonOft
        //    )
        //    : this(
        //        new QuerySystemInt32EqualsCriteria(isToCompareIdCommonOfSolution_1, valueToCompareIdCommonOfSolution_1)
        //        , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_1, valueToCompareIdCommonOfOrganization_1)
        //        , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2, valueToCompareIdCommonOfOrganization_2)
        //        , new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeCommonOft, isToCompareLowerBoundBuildStartTimeCommonOft, lowerBoundBuildStartTimeCommonOft, isToCompareUpperBoundBuildStartTimeCommonOft, upperBoundBuildStartTimeCommonOft)
        //        , new QuerySystemStringContainsCriteria(isToCompareNameCommonOft, valueToBeContainedNameCommonOft)
        //        , new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOft, valueToBeContainedDescriptionCommonOft)
        //        )
        //{
        //}

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdCommonOfSolution_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; }

        /// <summary>
        /// criteria of BuildStartTime, filter type: Range
        /// </summary>
        public QuerySystemDateTimeRangeCriteria BuildStartTimeCommonOft { get; set; }

        /// <summary>
        /// criteria of Name, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; }

        /// <summary>
        /// criteria of Description, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; }
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class BuildQueryCriteriaAll
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaAll"/> class.
        /// </summary>
        public BuildQueryCriteriaAll()
        {
        }

        #endregion constructors

        #region Propertyies

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class BuildQueryCriteriaByFKOnly
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByFKOnly"/> class.
        /// </summary>
        public BuildQueryCriteriaByFKOnly()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        public BuildQueryCriteriaByFKOnly(
            QuerySystemInt32EqualsCriteria idByFKOnlyOfSolution_1
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_1
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2
            )
        {
            this.IdByFKOnlyOfSolution_1 = idByFKOnlyOfSolution_1;
            this.IdByFKOnlyOfOrganization_1 = idByFKOnlyOfOrganization_1;
            this.IdByFKOnlyOfOrganization_2 = idByFKOnlyOfOrganization_2;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1">will compare/filter IdByFKOnlyOfSolution_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1">value to compare/filter with IdByFKOnlyOfSolution_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1">will compare/filter IdByFKOnlyOfOrganization_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1">value to compare/filter with IdByFKOnlyOfOrganization_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2">will compare/filter IdByFKOnlyOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2">value to compare/filter with IdByFKOnlyOfOrganization_2 property/field/column</param>
        public BuildQueryCriteriaByFKOnly(
            bool isToCompareIdByFKOnlyOfSolution_1, System.Int32? valueToCompareIdByFKOnlyOfSolution_1
            , bool isToCompareIdByFKOnlyOfOrganization_1, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1
            , bool isToCompareIdByFKOnlyOfOrganization_2, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2
            )
            : this(
                new QuerySystemInt32EqualsCriteria(isToCompareIdByFKOnlyOfSolution_1, valueToCompareIdByFKOnlyOfSolution_1)
                , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_1, valueToCompareIdByFKOnlyOfOrganization_1)
                , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2, valueToCompareIdByFKOnlyOfOrganization_2)
                )
        {
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByFKOnlyOfSolution_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdByFKOnlyOfOrganization_2 { get; set; }

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByIdentifier
    /// </summary>
    public partial class BuildQueryCriteriaByIdentifier
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByIdentifier"/> class.
        /// </summary>
        public BuildQueryCriteriaByIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        public BuildQueryCriteriaByIdentifier(
            QuerySystemInt64EqualsCriteria idByIdentifierOft
            )
        {
            this.IdByIdentifierOft = idByIdentifierOft;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
        public BuildQueryCriteriaByIdentifier(
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

}


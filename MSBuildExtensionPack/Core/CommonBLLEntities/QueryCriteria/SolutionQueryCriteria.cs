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
    public partial class SolutionQueryCriteriaCommon
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaCommon"/> class.
        /// </summary>
        public SolutionQueryCriteriaCommon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of ExternalParentId</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Name</param>
        /// <param name="QuerySystemStringContainsCriteria">Initialize criteria of Description</param>
        public SolutionQueryCriteriaCommon(
            QuerySystemInt64EqualsCriteria idCommonOfOrganization_1
            , QuerySystemInt64EqualsCriteria idCommonOfOrganization_2
            , QuerySystemStringContainsCriteria externalParentIdCommonOft
            , QuerySystemStringContainsCriteria nameCommonOft
            , QuerySystemStringContainsCriteria descriptionCommonOft
            )
        {
            this.IdCommonOfOrganization_1 = idCommonOfOrganization_1;
            this.IdCommonOfOrganization_2 = idCommonOfOrganization_2;
            this.ExternalParentIdCommonOft = externalParentIdCommonOft;
            this.NameCommonOft = nameCommonOft;
            this.DescriptionCommonOft = descriptionCommonOft;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaCommon"/> class.
        /// </summary>
        /// <param name="isToCompareIdCommonOfOrganization_1">will compare/filter IdCommonOfOrganization_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_1">value to compare/filter with IdCommonOfOrganization_1 property/field/column</param>
        /// <param name="isToCompareIdCommonOfOrganization_2">will compare/filter IdCommonOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfOrganization_2">value to compare/filter with IdCommonOfOrganization_2 property/field/column</param>
        /// <param name="isToCompareExternalParentIdCommonOft">will compare/filter ExternalParentIdCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOft">value to compare/filter with ExternalParentIdCommonOft property/field/column</param>
        /// <param name="isToCompareNameCommonOft">will compare/filter NameCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOft">value to compare/filter with NameCommonOft property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOft">will compare/filter DescriptionCommonOft property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOft">value to compare/filter with DescriptionCommonOft property/field/column</param>
        public SolutionQueryCriteriaCommon(
            bool isToCompareIdCommonOfOrganization_1, System.Int64? valueToCompareIdCommonOfOrganization_1
            , bool isToCompareIdCommonOfOrganization_2, System.Int64? valueToCompareIdCommonOfOrganization_2
            , bool isToCompareExternalParentIdCommonOft, System.String valueToBeContainedExternalParentIdCommonOft
            , bool isToCompareNameCommonOft, System.String valueToBeContainedNameCommonOft
            , bool isToCompareDescriptionCommonOft, System.String valueToBeContainedDescriptionCommonOft
            )
            : this(
                new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_1, valueToCompareIdCommonOfOrganization_1)
                , new QuerySystemInt64EqualsCriteria(isToCompareIdCommonOfOrganization_2, valueToCompareIdCommonOfOrganization_2)
                , new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOft, valueToBeContainedExternalParentIdCommonOft)
                , new QuerySystemStringContainsCriteria(isToCompareNameCommonOft, valueToBeContainedNameCommonOft)
                , new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOft, valueToBeContainedDescriptionCommonOft)
                )
        {
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_1 { get; set; }

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt64EqualsCriteria IdCommonOfOrganization_2 { get; set; }

        /// <summary>
        /// criteria of ExternalParentId, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria ExternalParentIdCommonOft { get; set; }

        /// <summary>
        /// criteria of Name, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria NameCommonOft { get; set; }

        /// <summary>
        /// criteria of Description, filter type: Contains
        /// </summary>
        public QuerySystemStringContainsCriteria DescriptionCommonOft { get; set; }

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=All
    /// </summary>
    public partial class SolutionQueryCriteriaAll
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaAll"/> class.
        /// </summary>
        public SolutionQueryCriteriaAll()
        {
        }

        #endregion constructors

        #region Propertyies

        #endregion Propertyies
    }

    /// <summary>
    /// BusinessLogicLayerQueryCriteria, key=ByFKOnly
    /// </summary>
    public partial class SolutionQueryCriteriaByFKOnly
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByFKOnly"/> class.
        /// </summary>
        public SolutionQueryCriteriaByFKOnly()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        /// <param name="QuerySystemInt64EqualsCriteria">Initialize criteria of Id</param>
        public SolutionQueryCriteriaByFKOnly(
            QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_1
            , QuerySystemInt64EqualsCriteria idByFKOnlyOfOrganization_2
            )
        {
            this.IdByFKOnlyOfOrganization_1 = idByFKOnlyOfOrganization_1;
            this.IdByFKOnlyOfOrganization_2 = idByFKOnlyOfOrganization_2;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByFKOnly"/> class.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1">will compare/filter IdByFKOnlyOfOrganization_1 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1">value to compare/filter with IdByFKOnlyOfOrganization_1 property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2">will compare/filter IdByFKOnlyOfOrganization_2 property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2">value to compare/filter with IdByFKOnlyOfOrganization_2 property/field/column</param>
        public SolutionQueryCriteriaByFKOnly(
            bool isToCompareIdByFKOnlyOfOrganization_1, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1
            , bool isToCompareIdByFKOnlyOfOrganization_2, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2
            )
            : this(
                new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_1, valueToCompareIdByFKOnlyOfOrganization_1)
                , new QuerySystemInt64EqualsCriteria(isToCompareIdByFKOnlyOfOrganization_2, valueToCompareIdByFKOnlyOfOrganization_2)
                )
        {
        }

        #endregion constructors

        #region Propertyies

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
    public partial class SolutionQueryCriteriaByIdentifier
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByIdentifier"/> class.
        /// </summary>
        public SolutionQueryCriteriaByIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="QuerySystemInt32EqualsCriteria">Initialize criteria of Id</param>
        public SolutionQueryCriteriaByIdentifier(
            QuerySystemInt32EqualsCriteria idByIdentifierOft
            )
        {
            this.IdByIdentifierOft = idByIdentifierOft;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionQueryCriteriaByIdentifier"/> class.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOft">will compare/filter IdByIdentifierOft property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOft">value to compare/filter with IdByIdentifierOft property/field/column</param>
        public SolutionQueryCriteriaByIdentifier(
            bool isToCompareIdByIdentifierOft, System.Int32? valueToCompareIdByIdentifierOft
            )
            : this(
                new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOft, valueToCompareIdByIdentifierOft)
                )
        {
        }

        #endregion constructors

        #region Propertyies

        /// <summary>
        /// criteria of Id, filter type: Equals
        /// </summary>
        public QuerySystemInt32EqualsCriteria IdByIdentifierOft { get; set; }

        #endregion Propertyies
    }

}
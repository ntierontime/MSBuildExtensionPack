using System.Collections.Generic;
using System.Linq;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// collection class for entity <see cref="Organization"/>
    /// </summary>
	public partial class OrganizationCollection : List<Organization>
	{ 

		#region constructors

        /// <summary>
        ///  default constructors
        /// </summary>
		public OrganizationCollection(): base()
		{
		}

        /// <summary>
        /// constructor with IEnumerable input
        /// </summary>
        /// <param name="input">a set of <see cref="IEnumerable<Organization"/></param>
        public OrganizationCollection(IEnumerable<Organization> input)
            : base(input)
        {
        }

		#endregion constructors

        #region Add(...)

        /// <summary>
        /// add an item with parameters of .net value type for each property
        /// </summary>
        public void Add(
			System.Int64 id
			, System.Int64 parentId
			, System.String name
			, System.Boolean isSystemBuiltIn
			, System.Guid uniqueIdentifier
			, System.DateTime createdDateTime
			, System.String charColumn
			, System.String varcharColumn
			, System.String textColumn
			, System.String ncharColumn
			, System.String nvarcharColumn
			, System.String ntextColumn
			, System.Boolean bitColumn
			, System.Byte[] binaryColumn
			, System.Byte[] varbinaryColumn
			, System.Byte[] imageColumn
			, System.Byte tinyintColumn
			, System.Int16 smallintColumn
			, System.Int32 intColumn
			, System.Int64 bigintColumn
			, System.Decimal decimalColumn
			, System.Decimal numericColumn
			, System.Decimal smallmoneyColumn
			, System.Decimal moneyColumn
			, System.Single floatColumn
			, System.Single realColumn
			, System.DateTime datetimeColumn
			, System.DateTime datetime2Column
			, System.DateTime smalldatetimeColumn
			, System.DateTime dateColumn
			, System.TimeSpan timeColumn
			, System.Guid uniqueidentifierColumn)
        {
            Organization _Item = new Organization(
				id
				, parentId
				, name
				, isSystemBuiltIn
				, uniqueIdentifier
				, createdDateTime
				, charColumn
				, varcharColumn
				, textColumn
				, ncharColumn
				, nvarcharColumn
				, ntextColumn
				, bitColumn
				, binaryColumn
				, varbinaryColumn
				, imageColumn
				, tinyintColumn
				, smallintColumn
				, intColumn
				, bigintColumn
				, decimalColumn
				, numericColumn
				, smallmoneyColumn
				, moneyColumn
				, floatColumn
				, realColumn
				, datetimeColumn
				, datetime2Column
				, smalldatetimeColumn
				, dateColumn
				, timeColumn
				, uniqueidentifierColumn			);
            this.Add(_Item);
        }

        #endregion Add(...)



        #region PrediacteByFKs

        /// <summary>
        /// Existses the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>true if any, otherwise false</returns>
		public bool ExistsByFKs(OrganizationQueryCriteriaByEntityReference criteria)
		{
            MSBuildExtensionPack.EntityContracts.QueryPredicateOrganizationByFKs<Organization> _PrediacteByFKs = new MSBuildExtensionPack.EntityContracts.QueryPredicateOrganizationByFKs<Organization>(criteria);
            return this.Count(_PrediacteByFKs.Predicate) > 0;
		}

        /// <summary>
        /// Gets the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>the first entity if any, otherwise null</returns>
        public Organization GetByFKs(OrganizationQueryCriteriaByEntityReference criteria)
		{
            MSBuildExtensionPack.EntityContracts.QueryPredicateOrganizationByFKs<Organization> _PrediacteByFKs = new MSBuildExtensionPack.EntityContracts.QueryPredicateOrganizationByFKs<Organization>(criteria);
            return this.Single(_PrediacteByFKs.Predicate);
		}

        /// <summary>
        /// Gets the collection by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>a collection</returns>
        public OrganizationCollection GetCollectionByFKs(OrganizationQueryCriteriaByEntityReference criteria)
        {
            MSBuildExtensionPack.EntityContracts.QueryPredicateOrganizationByFKs<Organization> _PrediacteByFKs = new MSBuildExtensionPack.EntityContracts.QueryPredicateOrganizationByFKs<Organization>(criteria);
            return new OrganizationCollection(this.Where(_PrediacteByFKs.Predicate));
		}

        #endregion PrediacteByFKs



        #region QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization
//
//        /// <summary>
//        /// Existses the by Unique Constraint.
//        /// </summary>
//        /// <param name="criteria">The criteria.</param>
//        /// <returns>true if any, otherwise false</returns>
//        public bool ExistsByUC_Organization_UniqueIdentifierOfOrganization(QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization criteria)
//        {
//            MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueIdentifierOfOrganization<Organization> _Predicate = new MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueIdentifierOfOrganization<Organization>(criteria);
//            return this.Count(_Predicate.Predicate) > 0;
//        }
//
//        /// <summary>
//        /// Gets the by Unique Constraint.
//        /// </summary>
//        /// <param name="criteria">The criteria.</param>
//        /// <returns>the first entity if any, otherwise null</returns>
//        public Organization GetByUC_Organization_UniqueIdentifierOfOrganization(QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization criteria)
//        {
//            MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueIdentifierOfOrganization<Organization> _Predicate = new MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueIdentifierOfOrganization<Organization>(criteria);
//            return this.Single(_Predicate.Predicate);
//        }

        #endregion QueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization




        #region QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization
//
//        /// <summary>
//        /// Existses the by Unique Constraint.
//        /// </summary>
//        /// <param name="criteria">The criteria.</param>
//        /// <returns>true if any, otherwise false</returns>
//        public bool ExistsByUC_Organization_UniqueidentifierColumnOfOrganization(QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization criteria)
//        {
//            MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueidentifierColumnOfOrganization<Organization> _Predicate = new MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueidentifierColumnOfOrganization<Organization>(criteria);
//            return this.Count(_Predicate.Predicate) > 0;
//        }
//
//        /// <summary>
//        /// Gets the by Unique Constraint.
//        /// </summary>
//        /// <param name="criteria">The criteria.</param>
//        /// <returns>the first entity if any, otherwise null</returns>
//        public Organization GetByUC_Organization_UniqueidentifierColumnOfOrganization(QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization criteria)
//        {
//            MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueidentifierColumnOfOrganization<Organization> _Predicate = new MSBuildExtensionPack.EntityContracts.QueryPredicateByUC_Organization_UniqueidentifierColumnOfOrganization<Organization>(criteria);
//            return this.Single(_Predicate.Predicate);
//        }

        #endregion QueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization



	}

		    /// <summary>

    /// <summary>
    ///  a property defined when <see cref="IOrganizationCollection"/> is used in other classes.
    /// </summary>
	public partial interface IOrganizationCollection
	{ 
        /// <summary>
        /// Gets or sets the OrganizationCollection
        /// </summary>
        /// <value>
        /// OrganizationCollection
        /// </value>
		OrganizationCollection OrganizationCollection { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="OrganizationCollection"/> and <see cref="Framework.DataSourceEntities.DataAccessLayerMessageBase&lt;T&gt;"/> />
    /// </summary>
	public partial class DataAccessLayerMessageOfEntityCollectionOrganization
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<OrganizationCollection>
    {
    }


}
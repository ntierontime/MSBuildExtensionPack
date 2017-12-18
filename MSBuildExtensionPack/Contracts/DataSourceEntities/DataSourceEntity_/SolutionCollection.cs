using System.Collections.Generic;
using System.Linq;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// collection class for entity <see cref="Solution"/>
    /// </summary>
    public partial class SolutionCollection : List<Solution>
    {

        #region constructors

        /// <summary>
        ///  default constructors
        /// </summary>
        public SolutionCollection(): base()
        {
        }

        /// <summary>
        /// constructor with IEnumerable input
        /// </summary>
        /// <param name="input">a set of <see cref="IEnumerable<Solution"/></param>
        public SolutionCollection(IEnumerable<Solution> input)
            : base(input)
        {
        }

        #endregion constructors

        #region Add(...)

        /// <summary>
        /// add an item with parameters of .net value type for each property
        /// </summary>
        public void Add(
            System.Int32 id
            , System.String externalParentId
            , System.String name
            , System.String description
            , System.Nullable<System.Int64> organizationId)
        {
            Solution _Item = new Solution(
                id
                , externalParentId
                , name
                , description
                , organizationId            );
            this.Add(_Item);
        }

        #endregion Add(...)

        #region PrediacteByFKs

        /// <summary>
        /// Existses the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>true if any, otherwise false</returns>
        public bool ExistsByFKs(SolutionQueryCriteriaByEntityReference criteria)
        {
            MSBuildExtensionPack.EntityContracts.QueryPredicateSolutionByFKs<Solution> _PrediacteByFKs = new MSBuildExtensionPack.EntityContracts.QueryPredicateSolutionByFKs<Solution>(criteria);
            return this.Count(_PrediacteByFKs.Predicate) > 0;
        }

        /// <summary>
        /// Gets the by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>the first entity if any, otherwise null</returns>
        public Solution GetByFKs(SolutionQueryCriteriaByEntityReference criteria)
        {
            MSBuildExtensionPack.EntityContracts.QueryPredicateSolutionByFKs<Solution> _PrediacteByFKs = new MSBuildExtensionPack.EntityContracts.QueryPredicateSolutionByFKs<Solution>(criteria);
            return this.Single(_PrediacteByFKs.Predicate);
        }

        /// <summary>
        /// Gets the collection by FKs.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns>a collection</returns>
        public SolutionCollection GetCollectionByFKs(SolutionQueryCriteriaByEntityReference criteria)
        {
            MSBuildExtensionPack.EntityContracts.QueryPredicateSolutionByFKs<Solution> _PrediacteByFKs = new MSBuildExtensionPack.EntityContracts.QueryPredicateSolutionByFKs<Solution>(criteria);
            return new SolutionCollection(this.Where(_PrediacteByFKs.Predicate));
        }

        #endregion PrediacteByFKs

    }

    /// <summary>
    ///  a property defined when <see cref="ISolutionCollection"/> is used in other classes.
    /// </summary>
    public partial interface ISolutionCollection
    {
        /// <summary>
        /// Gets or sets the SolutionCollection
        /// </summary>
        /// <value>
        /// SolutionCollection
        /// </value>
        SolutionCollection SolutionCollection { get; set; }
    }

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="SolutionCollection"/> and <see cref="Framework.DataSourceEntities.DataAccessLayerMessageBase&lt;T&gt;"/> />
    /// </summary>
    public partial class DataAccessLayerMessageOfEntityCollectionSolution
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<SolutionCollection>
    {
    }
}


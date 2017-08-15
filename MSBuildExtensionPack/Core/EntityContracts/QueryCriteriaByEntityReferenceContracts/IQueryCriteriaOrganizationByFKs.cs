using System;
using System.Runtime.Serialization;
using System.Linq.Expressions;
using System.Linq;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// Interaction logic for IQueryCriteriaOrganizationByFKs
    /// </summary>
    public partial interface IQueryCriteriaOrganizationByFKs
    {

                bool IsToCompareParentId { get; set; }
                System.Int64 ComparedToParentId { get; set; }

    }

    #region PrediacteByFKs

    public class QueryPredicateOrganizationByFKs<T>
        where T: IOrganization
    {
        public IQueryCriteriaOrganizationByFKs Criteria { get; set; }

        public QueryPredicateOrganizationByFKs(IQueryCriteriaOrganizationByFKs criteria)
        {
            this. Criteria = criteria;
        }

        public bool Predicate(T input)
        {
            Expression<Func<T, bool>> _retvalExpression = GetPredicateExpression();
            return _retvalExpression.Compile()(input);

            //return Criteria != null && input != null &&
//<<<<<6>>>>>;
        }

        public Expression<Func<T, bool>> GetPredicateExpression()
        {
            Expression<Func<T, bool>> _retval = input =>
                (Criteria != null && input != null &&

 (this.Criteria.IsToCompareParentId == false || this.Criteria.IsToCompareParentId == true && input.ParentId == this.Criteria.ComparedToParentId)

);

            return _retval;
        }
    }

    #endregion PrediacteByID
}
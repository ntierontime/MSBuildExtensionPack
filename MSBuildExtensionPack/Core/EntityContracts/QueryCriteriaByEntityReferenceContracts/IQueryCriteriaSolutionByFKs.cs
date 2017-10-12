using System;
using System.Runtime.Serialization;
using System.Linq.Expressions;
using System.Linq;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// Interaction logic for IQueryCriteriaSolutionByFKs
    /// </summary>
    public partial interface IQueryCriteriaSolutionByFKs
    {

                bool IsToCompareOrganizationId { get; set; }
                System.Nullable<System.Int64> ComparedToOrganizationId { get; set; }

    }

    #region PrediacteByFKs

    public class QueryPredicateSolutionByFKs<T>
        where T: ISolution
    {
        public IQueryCriteriaSolutionByFKs Criteria { get; set; }

        public QueryPredicateSolutionByFKs(IQueryCriteriaSolutionByFKs criteria)
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

 (this.Criteria.IsToCompareOrganizationId == false || this.Criteria.IsToCompareOrganizationId == true && input.OrganizationId == this.Criteria.ComparedToOrganizationId)

);

            return _retval;
        }
    }

    #endregion PrediacteByID
}
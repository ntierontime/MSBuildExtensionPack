namespace MSBuildExtensionPack.EntityContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IQueryCriteriaByUCOfOrganization
    {

        System.Guid UniqueIdentifier { get; set; }

    }

    public class QueryPredicateByUCOfOrganization<T>
        where T : IOrganization

    {
        public QueryPredicateByUCOfOrganization(IQueryCriteriaByUCOfOrganization criteria)
        {
            this.Criteria = criteria;
        }

        public IQueryCriteriaByUCOfOrganization Criteria { get; set; }

        public bool Predicate(T input)
        {
            Expression<Func<T, bool>> _retvalExpression = GetPredicateExpression();
            return _retvalExpression.Compile()(input);
            //return input != null &&  this.Criteria != null
//input.UniqueIdentifier == this.Criteria.UniqueIdentifier//;
        }

        public Expression<Func<T, bool>> GetPredicateExpression()
        {
            Expression<Func<T, bool>> _retval = input =>
                (Criteria != null && input != null

                 && (input.UniqueIdentifier == this.Criteria.UniqueIdentifier)

                );
            return _retval;
        }

    }
}


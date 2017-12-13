namespace MSBuildExtensionPack.EntityContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IQueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization
    {

        System.Guid UniqueIdentifier { get; set; }

    }

    public class QueryPredicateByUC_Organization_UniqueIdentifierOfOrganization<T>
        where T : IOrganization

    {
        public QueryPredicateByUC_Organization_UniqueIdentifierOfOrganization(IQueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization criteria)
        {
            this.Criteria = criteria;
        }

        public IQueryCriteriaByUC_Organization_UniqueIdentifierOfOrganization Criteria { get; set; }

        public bool Predicate(T input)
        {
            Expression<Func<T, bool>> _retvalExpression = GetPredicateExpression();
            return _retvalExpression.Compile()(input);
            //return input != null &&  this.Criteria != null input.UniqueIdentifier == this.Criteria.UniqueIdentifier//;
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
namespace MSBuildExtensionPack.EntityContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IQueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization
    {

        System.Guid UniqueidentifierColumn { get; set; }

    }

    public class QueryPredicateByUC_Organization_UniqueidentifierColumnOfOrganization<T>
        where T : IOrganization

    {
        public QueryPredicateByUC_Organization_UniqueidentifierColumnOfOrganization(IQueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization criteria)
        {
            this.Criteria = criteria;
        }

        public IQueryCriteriaByUC_Organization_UniqueidentifierColumnOfOrganization Criteria { get; set; }

        public bool Predicate(T input)
        {
            Expression<Func<T, bool>> _retvalExpression = GetPredicateExpression();
            return _retvalExpression.Compile()(input);
            //return input != null &&  this.Criteria != null input.UniqueidentifierColumn == this.Criteria.UniqueidentifierColumn//;
        }

        public Expression<Func<T, bool>> GetPredicateExpression()
        {
            Expression<Func<T, bool>> _retval = input =>
                (Criteria != null && input != null

                 && (input.UniqueidentifierColumn == this.Criteria.UniqueidentifierColumn)

                );
            return _retval;
        }

    }
}


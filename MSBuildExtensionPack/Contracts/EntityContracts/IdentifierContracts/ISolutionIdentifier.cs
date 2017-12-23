using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{

    public partial interface ISolutionIdentifier
    {

        System.Int32 Id { get; set; }

    }

    public class QueryPredicateSolutionByIdentifier<T>
        where T : ISolution
    {
        public QueryPredicateSolutionByIdentifier(ISolutionIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public ISolutionIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }
}


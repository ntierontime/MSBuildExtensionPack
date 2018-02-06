using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{

    public partial interface IBuildIdentifier
    {

        System.Int64 Id { get; set; }

    }

    public class QueryPredicateBuildByIdentifier<T>
        where T : IBuild
    {
        public QueryPredicateBuildByIdentifier(IBuildIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public IBuildIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }
}


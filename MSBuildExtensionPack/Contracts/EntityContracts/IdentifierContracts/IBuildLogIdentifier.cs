using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{

    public partial interface IBuildLogIdentifier
    {

        System.Int64 Id { get; set; }

    }

    public class QueryPredicateBuildLogByIdentifier<T>
        where T : IBuildLog
    {
        public QueryPredicateBuildLogByIdentifier(IBuildLogIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public IBuildLogIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }
}


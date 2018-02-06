using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{

    public partial interface IBuildEventCodeIdentifier
    {

        System.Int32 Id { get; set; }

    }

    public class QueryPredicateBuildEventCodeByIdentifier<T>
        where T : IBuildEventCode
    {
        public QueryPredicateBuildEventCodeByIdentifier(IBuildEventCodeIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public IBuildEventCodeIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }
}


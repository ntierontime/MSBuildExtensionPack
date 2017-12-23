using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{

    public partial interface IOrganizationIdentifier
    {

        System.Int64 Id { get; set; }

    }

    public class QueryPredicateOrganizationByIdentifier<T>
        where T : IOrganization
    {
        public QueryPredicateOrganizationByIdentifier(IOrganizationIdentifier criteria)
        {
            this.Criteria = criteria;
        }

        public IOrganizationIdentifier Criteria { get; set; }

        public bool Predicate(T input)
        {
            return input != null && this.Criteria != null &&

        input.Id == this.Criteria.Id
;
        }
    }
}


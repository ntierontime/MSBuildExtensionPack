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


    /// <summary>
    ///  a property defined when <see cref="OrganizationIdentifier"/> is used in other classes.
    /// </summary>
    public partial interface WithIdentifierContractOrganization<T>
        where T : IOrganizationIdentifier
    {
        T OrganizationIdentifier { get; set; }
    }
}
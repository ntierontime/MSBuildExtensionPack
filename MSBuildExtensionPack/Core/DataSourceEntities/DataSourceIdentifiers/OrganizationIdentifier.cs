using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// table/entity identifier, inherit from entity interface, <see cref="MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier"/>
    /// </summary>
    public partial class OrganizationIdentifier
        : MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier
    {

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationIdentifier"/> class.
        /// </summary>
        public OrganizationIdentifier ()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationIdentifier"/> class.
        /// </summary>
        public OrganizationIdentifier (
System.Int64 id)
        {

            this.Id=id;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationIdentifier"/> class.
        /// </summary>
        public OrganizationIdentifier(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier item)
        {
            MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Copy<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, OrganizationIdentifier>(item, this);
        }

        #endregion constructors

        #region properties

        public System.Int64 Id { get; set; }

        #endregion properties

        #region override methods

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance, using ToString method in entity contract helper in EntityContract project
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.ToString<OrganizationIdentifier>(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance , using Equals method in entity contract helper in EntityContract project
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            bool _retval = obj is OrganizationIdentifier;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Equals<OrganizationIdentifier, OrganizationIdentifier>(this, (OrganizationIdentifier)obj);
            }
            return _retval;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion override methods

        #region Method of OrganizationIdentifier GetAClone()

        /// <summary>
        /// Gets the A clone, using clone method in entity contract helper in EntityContract project.
        /// </summary>
        /// <returns>a new instance of <see cref="OrganizationIdentifier"/></returns>
        public OrganizationIdentifier GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Clone<OrganizationIdentifier, OrganizationIdentifier>(this);
        }

        #endregion Method of OrganizationIdentifier GetAClone()
    }

    /// <summary>
    ///  a property defined when <see cref="WithIdentifierContractOrganization"/> is used in other classes.
    /// </summary>
    public partial interface WithIdentifierContractOrganization
    {
        /// <summary>
        /// Gets or sets the OrganizationIdentifier
        /// </summary>
        /// <value>
        /// The OrganizationIdentifier
        /// </value>
        OrganizationIdentifier OrganizationIdentifier { get; set; }
    }
}
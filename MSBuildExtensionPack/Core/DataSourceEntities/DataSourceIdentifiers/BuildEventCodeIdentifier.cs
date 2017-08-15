using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// table/entity identifier, inherit from entity interface, <see cref="MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier"/>
    /// </summary>
    public partial class BuildEventCodeIdentifier
        : MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier
    {

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeIdentifier"/> class.
        /// </summary>
        public BuildEventCodeIdentifier ()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeIdentifier"/> class.
        /// </summary>
        public BuildEventCodeIdentifier (
System.Int32 id)
        {

            this.Id=id;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildEventCodeIdentifier"/> class.
        /// </summary>
        public BuildEventCodeIdentifier(MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier item)
        {
            MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, BuildEventCodeIdentifier>(item, this);
        }

        #endregion constructors

        #region properties

        public System.Int32 Id { get; set; }

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
            return MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.ToString<BuildEventCodeIdentifier>(this);
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
            bool _retval = obj is BuildEventCodeIdentifier;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Equals<BuildEventCodeIdentifier, BuildEventCodeIdentifier>(this, (BuildEventCodeIdentifier)obj);
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

        #region Method of BuildEventCodeIdentifier GetAClone()

        /// <summary>
        /// Gets the A clone, using clone method in entity contract helper in EntityContract project.
        /// </summary>
        /// <returns>a new instance of <see cref="BuildEventCodeIdentifier"/></returns>
        public BuildEventCodeIdentifier GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<BuildEventCodeIdentifier, BuildEventCodeIdentifier>(this);
        }

        #endregion Method of BuildEventCodeIdentifier GetAClone()
    }

    /// <summary>
    ///  a property defined when <see cref="WithIdentifierContractBuildEventCode"/> is used in other classes.
    /// </summary>
    public partial interface WithIdentifierContractBuildEventCode
    {
        /// <summary>
        /// Gets or sets the BuildEventCodeIdentifier
        /// </summary>
        /// <value>
        /// The BuildEventCodeIdentifier
        /// </value>
        BuildEventCodeIdentifier BuildEventCodeIdentifier { get; set; }
    }
}
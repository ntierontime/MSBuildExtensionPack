using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// definition of Solution with parameters of .Net value type.
    /// </summary>
    public partial interface ISolution : ISolutionIdentifier
    {

        System.Nullable<System.Int64> OrganizationId { get; set; }

        System.String ExternalParentId { get; set; }

        System.String Name { get; set; }

        System.String Description { get; set; }

    }
}


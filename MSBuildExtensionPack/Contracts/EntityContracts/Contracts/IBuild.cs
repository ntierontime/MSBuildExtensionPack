using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// definition of Build with parameters of .Net value type.
    /// </summary>
    public partial interface IBuild : IBuildIdentifier
    {

        System.Int32 SolutionId { get; set; }

        System.String Name { get; set; }

        System.String Description { get; set; }

        System.DateTime BuildStartTime { get; set; }

    }
}


using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// definition of BuildEventCode with parameters of .Net value type.
    /// </summary>
    public partial interface IBuildEventCode : IBuildEventCodeIdentifier
    {

        System.String EventCode { get; set; }

        System.String Description { get; set; }

    }
}


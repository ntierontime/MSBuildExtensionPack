using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// definition of BuildLog with parameters of .Net value type.
    /// </summary>
    public partial interface IBuildLog : IBuildLogIdentifier
    {

        System.Int64 BuildId { get; set; }

        System.Int32 BuildEventCodeId { get; set; }

        System.String Message { get; set; }

        System.DateTime EventTime { get; set; }

    }
}


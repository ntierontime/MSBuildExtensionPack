using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildExtensionPack.Build
    /// </summary>
    public partial class BuildResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildCollection>
    {

        #region Nested Views classes and their collection classes 2

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildExtensionPack.Build
        /// </summary>
        public partial class Default
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.Build
        /// </summary>
        public partial class KeyInformation
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 2
    }
}


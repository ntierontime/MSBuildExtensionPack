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

        #region Nested Views classes and their collection classes 4

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildExtensionPack.Build
        /// </summary>
        public partial class Default
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view DefaultGroupedDataView of entity MSBuildExtensionPack.Build
        /// </summary>
        public partial class DefaultGroupedDataView
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.Build
        /// </summary>
        public partial class KeyInformation
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view UpdateNameRequest of entity MSBuildExtensionPack.Build
        /// </summary>
        public partial class UpdateNameRequest
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 4
    }
}


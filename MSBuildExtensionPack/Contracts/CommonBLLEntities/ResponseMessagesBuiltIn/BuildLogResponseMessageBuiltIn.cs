using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildExtensionPack.BuildLog
    /// </summary>
    public partial class BuildLogResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>
    {

        #region Nested Views classes and their collection classes 3

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildExtensionPack.BuildLog
        /// </summary>
        public partial class Default
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view DefaultGroupedDataView of entity MSBuildExtensionPack.BuildLog
        /// </summary>
        public partial class DefaultGroupedDataView
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.BuildLog
        /// </summary>
        public partial class KeyInformation
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 3
    }
}


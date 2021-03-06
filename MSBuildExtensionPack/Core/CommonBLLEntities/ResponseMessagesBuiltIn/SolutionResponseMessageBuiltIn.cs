using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildExtensionPack.Solution
    /// </summary>
    public partial class SolutionResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>
    {

        #region Nested Views classes and their collection classes 3

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildExtensionPack.Solution
        /// </summary>
        public partial class Default
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view DefaultGroupedDataView of entity MSBuildExtensionPack.Solution
        /// </summary>
        public partial class DefaultGroupedDataView
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>
        {
        }

        /// <summary>
        /// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.Solution
        /// </summary>
        public partial class KeyInformation
            : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 3
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildExtensionPack.BuildEventCode
    /// </summary>
	public partial class BuildEventCodeResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection>
    {

		#region Nested Views classes and their collection classes 1


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.BuildEventCode
		/// </summary>
		public partial class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 1
    }
}
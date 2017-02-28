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

		#region Nested Views classes and their collection classes 1


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.Solution
		/// </summary>
		public partial class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 1
    }
}
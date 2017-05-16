using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLLEntities
{
    /// <summary>
    /// BusinessLogicLayerResponseMessage of entity MSBuildExtensionPack.Organization
    /// </summary>
	public partial class OrganizationResponseMessageBuiltIn
        : Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>
    {

		#region Nested Views classes and their collection classes 4


	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view Default of entity MSBuildExtensionPack.Organization
		/// </summary>
		public partial class Default
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view DefaultWithPath of entity MSBuildExtensionPack.Organization
		/// </summary>
		public partial class DefaultWithPath
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view DefaultGroupedDataView of entity MSBuildExtensionPack.Organization
		/// </summary>
		public partial class DefaultGroupedDataView
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>
		{
		}



	    /// <summary>
		/// BusinessLogicLayerResponseMessage of of view KeyInformation of entity MSBuildExtensionPack.Organization
		/// </summary>
		public partial class KeyInformation
			: Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBase<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 4
    }
}
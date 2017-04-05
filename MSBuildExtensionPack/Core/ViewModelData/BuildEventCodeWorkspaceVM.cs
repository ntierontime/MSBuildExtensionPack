using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{


    public partial class WPCommonOfBuildEventCodeVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection>
    {
        public WPCommonOfBuildEventCodeVM()
            : base()
        {
        }



        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }




    public partial class WPEntityRelatedOfBuildEventCodeVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier>
    {
        public WPEntityRelatedOfBuildEventCodeVM()
            : base(null)
        { }

        public WPEntityRelatedOfBuildEventCodeVM(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_BuildLog_BuildEventCode = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly();
        }

		//1. FK_BuildLog_BuildEventCode
		public MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly CriteriaOfFK_BuildLog_BuildEventCode { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_BuildEventCode { get; set; }
		public string StatusMessageOfFK_BuildLog_BuildEventCode { get; set; }
		public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_BuildEventCode { get; set; }
    }




}



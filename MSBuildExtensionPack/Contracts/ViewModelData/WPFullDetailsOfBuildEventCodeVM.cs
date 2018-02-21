using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPFullDetailsOfBuildEventCodeVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaIdentifier>
    {
        public WPFullDetailsOfBuildEventCodeVM()
            : base(null)
        { }

        public WPFullDetailsOfBuildEventCodeVM(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
            this.CriteriaOfFK_BuildLog_BuildEventCode = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaFKOnly();
        }

        //1. FK_BuildLog_BuildEventCode
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaFKOnly CriteriaOfFK_BuildLog_BuildEventCode { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_BuildEventCode { get; set; }
        public string StatusMessageOfFK_BuildLog_BuildEventCode { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_BuildEventCode { get; set; }
    }
}


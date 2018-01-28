using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class WPUpdateNameOnlyOfBuildVM
        : MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier>
    {
        public WPUpdateNameOnlyOfBuildVM ()
            : base(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier())
        {
        }

        public WPUpdateNameOnlyOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
        }

        public void LoadData()
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfUpdateNameRequestOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];
                this.StatusOfMasterEntity = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild.UpdateNameOnly_Description;
            }
            else
            {
                this.StatusMessageOfMasterEntity = masterEntityResult.GetStatusMessage();
#if DEBUG
                this.StatusMessageOfMasterEntity = string.Format("{0} {1}", this.StatusMessageOfMasterEntity, masterEntityResult.ServerErrorMessage);
#endif
            }
        }
        public void SaveData()
        {
            var request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly();
            request.Criteria = this.MasterEntity;
            var response = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.UpdateNameOnly(request);
            this.StatusOfMasterEntity = response.BusinessLogicLayerResponseStatus;
            if (this.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild.UpdateNameOnly_Success; // Success
            }
            else
            {
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild.UpdateNameOnly_Failed; // failed
            }
        }
    }
}


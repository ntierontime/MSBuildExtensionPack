using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class WPEntityRelatedOfBuildEventCodeVM
        : MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildEventCodeVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildEventCodeVM(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
        }

        public void LoadData(
            bool isToLoadFK_BuildLog_BuildEventCode = true
            )
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);
            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

                // 2. accessory part - Aside UIWorkspaceItemSetting -- RelatedEntityWhenMasterViewIsFKEntity

                // 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree -- RelatedEntityWhenMasterViewIsPKEntity

                // MSBuildExtensionPack.BuildLog
                if(isToLoadFK_BuildLog_BuildEventCode)
                {
                    this.CriteriaOfFK_BuildLog_BuildEventCode.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId = new Framework.EntityContracts.QuerySystemInt32EqualsCriteria(this.MasterEntity.Id);
                    var resultFK_BuildLog_BuildEventCode = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_BuildLog_BuildEventCode, this.QueryPagingSetting, null);
                    this.StatusOfFK_BuildLog_BuildEventCode = resultFK_BuildLog_BuildEventCode.BusinessLogicLayerResponseStatus;
                    if (resultFK_BuildLog_BuildEventCode.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.FK_BuildLog_BuildEventCode = resultFK_BuildLog_BuildEventCode.Message;
                    }
                    else
                    {
                        this.StatusMessageOfFK_BuildLog_BuildEventCode = resultFK_BuildLog_BuildEventCode.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfFK_BuildLog_BuildEventCode = string.Format("{0} {1}", this.StatusMessageOfFK_BuildLog_BuildEventCode, resultFK_BuildLog_BuildEventCode.ServerErrorMessage);
    #endif
                    }
                }

                // 4. Major part - Article UIWorkspaceItemSetting - EntityReference/FK CrossJoin -- RelatedEntityWhenMasterViewIsPKEntityViaCrossJoin

            }
            else
            {
                this.StatusMessageOfMasterEntity = masterEntityResult.GetStatusMessage();
#if DEBUG
                this.StatusMessageOfMasterEntity = string.Format("{0} {1}", this.StatusMessageOfMasterEntity, masterEntityResult.ServerErrorMessage);
#endif
            }
        }
    }
}


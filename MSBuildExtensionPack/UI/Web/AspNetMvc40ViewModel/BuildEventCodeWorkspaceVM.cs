using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{

    public partial class WPCommonOfBuildEventCodeVM : MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM
    {
        public WPCommonOfBuildEventCodeVM ()
            : base()
        {
        }

        public Framework.Mvc.UISharedViewModel UISharedViewModel { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {

            this.UISharedViewModel = Framework.Mvc.UISharedViewModel.GetUISharedViewModel(this.ListOfQueryOrderBySettingCollecionInString, this.QueryPagingSetting.PageSizeSelectionList, this.ListOfDataExport);
        }

        //public override void LoadData()
        /// <summary>
        /// Loads the data.
        /// </summary>
        public void LoadData(bool isToLoadDropDownlistContent)
        {
            if (isToLoadDropDownlistContent)
            {

            }

            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfCommon(
                this.Criteria
                , this.QueryPagingSetting
                , this.QueryOrderBySettingCollection);

            this.StatusOfResult = searchResult.BusinessLogicLayerResponseStatus;

            if (this.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.Result = searchResult.Message;

                if (searchResult.QueryPagingResult != null)
                {
                    this.QueryPagingSetting.CountOfRecords = searchResult.QueryPagingResult.CountOfRecords;
                    this.QueryPagingSetting.RecordCountOfCurrentPage = searchResult.QueryPagingResult.RecordCountOfCurrentPage;
                }
            }
            else
            {
                this.StatusMessageOfResult = searchResult.GetStatusMessage();
#if DEBUG
                this.StatusMessageOfResult = string.Format("{0} {1}", this.StatusMessageOfResult, searchResult.ServerErrorMessage);
#endif
            }
        }
    }

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

                // 2. accessory part - Aside UIWorkspaceItemSetting

                // 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
                            // FK_BuildLog_BuildEventCode
                if(isToLoadFK_BuildLog_BuildEventCode)
                {
                    this.CriteriaOfFK_BuildLog_BuildEventCode.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuildEventCode_1.IsToCompare = true;
                    this.CriteriaOfFK_BuildLog_BuildEventCode.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuildEventCode_1.ValueToCompare = this.MasterEntity.Id;
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

                // 4. Major part - Article UIWorkspaceItemSetting - EntityReference/FK CrossJoin

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


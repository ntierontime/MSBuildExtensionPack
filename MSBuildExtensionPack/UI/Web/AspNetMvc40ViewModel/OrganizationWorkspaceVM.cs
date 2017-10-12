using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{

    public partial class WPCommonOfOrganizationVM : MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM
    {
        public WPCommonOfOrganizationVM ()
            : base()
        {
        }
        public List<SelectListItem> SelectListOfMSBuildExtensionPack_Organization { get; set; }

        public Framework.Mvc.UISharedViewModel UISharedViewModel { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfOrganizationVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {
            this.NameValueCollectionOfMSBuildExtensionPack_Organization = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
            this.SelectListOfMSBuildExtensionPack_Organization = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Organization);

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
            this.NameValueCollectionOfMSBuildExtensionPack_Organization = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
            this.SelectListOfMSBuildExtensionPack_Organization = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Organization);

            }

            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfCommon(
                new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon(this.Criteria)
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

    public partial class WPEntityRelatedOfOrganizationVM
        : MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfOrganizationVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfOrganizationVM(MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {

        }

        public void LoadData(
            bool isToLoadFK_Organization_ParentId = true
            , bool isToLoadFK_Solution_OrganizationId = true
            , bool isToLoadOrganization_2 = true
            )
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfIdentifierAndUniqueConstraint(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

                // 2. accessory part - Aside UIWorkspaceItemSetting
                            // MSBuildExtensionPack.CommonBLLIoC.IoCOrganization
                if(isToLoadOrganization_2)
                {
                    this.CriteriaOfOrganization_2.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
                    this.CriteriaOfOrganization_2.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.ParentId;
                    var resultOrganization_2 = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfOrganization_2, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfOrganization_2 = resultOrganization_2.BusinessLogicLayerResponseStatus;
                    if (resultOrganization_2.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Organization_2 = resultOrganization_2.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfOrganization_2 = resultOrganization_2.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfOrganization_2 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCOrganization GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfOrganization_2, resultOrganization_2.ServerErrorMessage);
    #endif
                    }
                }

                // 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
                            // FK_Organization_ParentId
                if(isToLoadFK_Organization_ParentId)
                {
                    this.CriteriaOfFK_Organization_ParentId.OrganizationQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2.IsToCompare = true;
                    this.CriteriaOfFK_Organization_ParentId.OrganizationQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2.ValueToCompare = this.MasterEntity.Id;
                    var resultFK_Organization_ParentId = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_Organization_ParentId, this.QueryPagingSetting, null);
                    this.StatusOfFK_Organization_ParentId = resultFK_Organization_ParentId.BusinessLogicLayerResponseStatus;
                    if (resultFK_Organization_ParentId.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.FK_Organization_ParentId = resultFK_Organization_ParentId.Message;
                    }
                    else
                    {
                        this.StatusMessageOfFK_Organization_ParentId = resultFK_Organization_ParentId.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfFK_Organization_ParentId = string.Format("{0} {1}", this.StatusMessageOfFK_Organization_ParentId, resultFK_Organization_ParentId.ServerErrorMessage);
    #endif
                    }
                }

                            // FK_Solution_OrganizationId
                if(isToLoadFK_Solution_OrganizationId)
                {
                    this.CriteriaOfFK_Solution_OrganizationId.SolutionQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_1.IsToCompare = true;
                    this.CriteriaOfFK_Solution_OrganizationId.SolutionQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_1.ValueToCompare = this.MasterEntity.Id;
                    var resultFK_Solution_OrganizationId = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_Solution_OrganizationId, this.QueryPagingSetting, null);
                    this.StatusOfFK_Solution_OrganizationId = resultFK_Solution_OrganizationId.BusinessLogicLayerResponseStatus;
                    if (resultFK_Solution_OrganizationId.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.FK_Solution_OrganizationId = resultFK_Solution_OrganizationId.Message;
                    }
                    else
                    {
                        this.StatusMessageOfFK_Solution_OrganizationId = resultFK_Solution_OrganizationId.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfFK_Solution_OrganizationId = string.Format("{0} {1}", this.StatusMessageOfFK_Solution_OrganizationId, resultFK_Solution_OrganizationId.ServerErrorMessage);
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


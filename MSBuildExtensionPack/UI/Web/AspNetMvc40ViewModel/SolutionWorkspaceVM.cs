using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{

    public partial class WPCommonOfSolutionVM : MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM
    {
        public WPCommonOfSolutionVM ()
            : base()
        {
        }
        public List<SelectListItem> SelectListOfMSBuildExtensionPack_Organization { get; set; }

        public Framework.Mvc.UISharedViewModel UISharedViewModel { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
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

            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfCommon(
                new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(this.Criteria)
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

    public partial class WPEntityRelatedOfSolutionVM
        : MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfSolutionVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfSolutionVM(MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {

        }

        public void LoadData(
            bool isToLoadFK_Build_Solution = true
            , bool isToLoadOrganization_1 = true
            , bool isToLoadOrganization_2 = true
            )
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

                // 2. accessory part - Aside UIWorkspaceItemSetting
                            // MSBuildExtensionPack.CommonBLLIoC.IoCOrganization
                if(isToLoadOrganization_1)
                {
                    this.CriteriaOfOrganization_1.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
                    this.CriteriaOfOrganization_1.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.OrganizationId.HasValue ? this.MasterEntity.OrganizationId.Value : default(System.Int64);
                    var resultOrganization_1 = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfOrganization_1, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfOrganization_1 = resultOrganization_1.BusinessLogicLayerResponseStatus;
                    if (resultOrganization_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Organization_1 = resultOrganization_1.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfOrganization_1 = resultOrganization_1.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfOrganization_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCOrganization GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfOrganization_1, resultOrganization_1.ServerErrorMessage);
    #endif
                    }
                }

                            // MSBuildExtensionPack.CommonBLLIoC.IoCOrganization
                if(isToLoadOrganization_2)
                {
                    this.CriteriaOfOrganization_2.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
                    this.CriteriaOfOrganization_2.OrganizationQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.Organization_2Id;
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
                            // FK_Build_Solution
                if(isToLoadFK_Build_Solution)
                {
                    this.CriteriaOfFK_Build_Solution.BuildQueryCriteriaByFKOnly.IdByFKOnlyOfSolution_1.IsToCompare = true;
                    this.CriteriaOfFK_Build_Solution.BuildQueryCriteriaByFKOnly.IdByFKOnlyOfSolution_1.ValueToCompare = this.MasterEntity.Id;
                    var resultFK_Build_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_Build_Solution, this.QueryPagingSetting, null);
                    this.StatusOfFK_Build_Solution = resultFK_Build_Solution.BusinessLogicLayerResponseStatus;
                    if (resultFK_Build_Solution.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.FK_Build_Solution = resultFK_Build_Solution.Message;
                    }
                    else
                    {
                        this.StatusMessageOfFK_Build_Solution = resultFK_Build_Solution.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfFK_Build_Solution = string.Format("{0} {1}", this.StatusMessageOfFK_Build_Solution, resultFK_Build_Solution.ServerErrorMessage);
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


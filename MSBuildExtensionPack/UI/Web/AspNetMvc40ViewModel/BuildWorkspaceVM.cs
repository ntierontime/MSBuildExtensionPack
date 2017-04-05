using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{

    public partial class WPCommonOfBuildVM : MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM //Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>
    {
        public WPCommonOfBuildVM ()
            : base()
        {
        }
        public List<SelectListItem> SelectListOfMSBuildExtensionPack_Solution { get; set; }


        public Framework.Mvc.UISharedViewModel UISharedViewModel { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {
			this.NameValueCollectionOfMSBuildExtensionPack_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
			this.SelectListOfMSBuildExtensionPack_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Solution);


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
			this.NameValueCollectionOfMSBuildExtensionPack_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
			this.SelectListOfMSBuildExtensionPack_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Solution);

            }

            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(
                new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon(this.Criteria)
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




    public partial class WPEntityRelatedOfBuildVM 
		: MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildVM
		//: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {

        }

        public void LoadData(
			bool isToLoadFK_BuildLog_Build = true
			, bool isToLoadSolution_1 = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting
							// MSBuildExtensionPack.CommonBLLIoC.IoCSolution
				if(isToLoadSolution_1)
				{
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.SolutionId;
					var resultSolution_1 = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfSolution_1, this.QueryPagingSettingOneRecord, null);
					this.StatusOfSolution_1 = resultSolution_1.BusinessLogicLayerResponseStatus;
					if (resultSolution_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.Solution_1 = resultSolution_1.Message[0];
					}
					else
					{
						this.StatusMessageOfSolution_1 = resultSolution_1.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfSolution_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCSolution GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfSolution_1, resultSolution_1.ServerErrorMessage);
	#endif
					}
				}


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree
							// FK_BuildLog_Build
				if(isToLoadFK_BuildLog_Build)
				{
					this.CriteriaOfFK_BuildLog_Build.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuild_1.IsToCompare = true;
					this.CriteriaOfFK_BuildLog_Build.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuild_1.ValueToCompare = this.MasterEntity.Id;
					var resultFK_BuildLog_Build = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(this.CriteriaOfFK_BuildLog_Build, this.QueryPagingSetting, null);
					this.StatusOfFK_BuildLog_Build = resultFK_BuildLog_Build.BusinessLogicLayerResponseStatus;
					if (resultFK_BuildLog_Build.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.FK_BuildLog_Build = resultFK_BuildLog_Build.Message;
					}
					else
					{
						this.StatusMessageOfFK_BuildLog_Build = resultFK_BuildLog_Build.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfFK_BuildLog_Build = string.Format("{0} {1}", this.StatusMessageOfFK_BuildLog_Build, resultFK_BuildLog_Build.ServerErrorMessage);
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




    public partial class WPUpdateNameOnlyOfBuildVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
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
				this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Description;
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
            request.Critieria = this.MasterEntity;
            var response = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.UpdateNameOnly(request);
            this.StatusOfMasterEntity = response.BusinessLogicLayerResponseStatus;
            if (this.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Success; // Success
            }
            else
            {
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Failed; // failed
            }
        }
    }





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
				this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Description;
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
            request.Critieria = this.MasterEntity;
            var response = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.UpdateNameOnly(request);
            this.StatusOfMasterEntity = response.BusinessLogicLayerResponseStatus;
            if (this.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Success; // Success
            }
            else
            {
                this.StatusMessageOfMasterEntity = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.UpdateNameOnly_Failed; // failed
            }
        }
    }



}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{

    public partial class WPCommonOfBuildLogVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>
    {
        public WPCommonOfBuildLogVM ()
            : base()
        {
        }
        public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Solution { get; set; }
        public List<SelectListItem> SelectListOfMSBuildExtensionPack_Solution { get; set; }
	
        public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_BuildEventCode { get; set; }
        public List<SelectListItem> SelectListOfMSBuildExtensionPack_BuildEventCode { get; set; }
	
        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.AspNetMvc40ViewModel.Common.OrderByLists.WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {
            this.NameValueCollectionOfMSBuildExtensionPack_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildExtensionPack_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Solution);
	
            this.NameValueCollectionOfMSBuildExtensionPack_BuildEventCode = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(-1, -1), null);
				this.SelectListOfMSBuildExtensionPack_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_BuildEventCode);
	
        }
    }




    public partial class WPEntityRelatedOfBuildLogVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildLogVM(MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfBuild_1 = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier();
			this.CriteriaOfSolution_1 = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier();
			this.CriteriaOfBuildEventCode_1 = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier();
        }

		//Build_1
		public MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier CriteriaOfBuild_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuild_1 { get; set; }
		public string StatusMessageOfBuild_1 { get; set; }
		public MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation Build_1 { get; set; }
		//Solution_1
		public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier CriteriaOfSolution_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1 { get; set; }
		public string StatusMessageOfSolution_1 { get; set; }
		public MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation Solution_1 { get; set; }
		//BuildEventCode_1
		public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier CriteriaOfBuildEventCode_1 { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuildEventCode_1 { get; set; }
		public string StatusMessageOfBuildEventCode_1 { get; set; }
		public MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation BuildEventCode_1 { get; set; }

        public void LoadData(
			bool isToLoadBuild_1 = true
			, bool isToLoadSolution_1 = true
			, bool isToLoadBuildEventCode_1 = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting
							// MSBuildExtensionPack.CommonBLLIoC.IoCBuild
				if(isToLoadBuild_1)
				{
					this.CriteriaOfBuild_1.BuildQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfBuild_1.BuildQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.BuildId;
					var resultBuild_1 = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfBuild_1, this.QueryPagingSettingOneRecord, null);
					this.StatusOfBuild_1 = resultBuild_1.BusinessLogicLayerResponseStatus;
					if (resultBuild_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.Build_1 = resultBuild_1.Message[0];
					}
					else
					{
						this.StatusMessageOfBuild_1 = resultBuild_1.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfBuild_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCBuild GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfBuild_1, resultBuild_1.ServerErrorMessage);
	#endif
					}
				}

							// MSBuildExtensionPack.CommonBLLIoC.IoCSolution
				if(isToLoadSolution_1)
				{
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfSolution_1.SolutionQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.Solution_1Id;
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

							// MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode
				if(isToLoadBuildEventCode_1)
				{
					this.CriteriaOfBuildEventCode_1.BuildEventCodeQueryCriteriaByIdentifier.IdByIdentifierOft.IsToCompare = true;
					this.CriteriaOfBuildEventCode_1.BuildEventCodeQueryCriteriaByIdentifier.IdByIdentifierOft.ValueToCompare = this.MasterEntity.BuildEventCodeId;
					var resultBuildEventCode_1 = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfKeyInformationOfByIdentifier(this.CriteriaOfBuildEventCode_1, this.QueryPagingSettingOneRecord, null);
					this.StatusOfBuildEventCode_1 = resultBuildEventCode_1.BusinessLogicLayerResponseStatus;
					if (resultBuildEventCode_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
					{
						this.BuildEventCode_1 = resultBuildEventCode_1.Message[0];
					}
					else
					{
						this.StatusMessageOfBuildEventCode_1 = resultBuildEventCode_1.GetStatusMessage();
	#if DEBUG
						this.StatusMessageOfBuildEventCode_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode GetMessageOfKeyInformationOfByIdentifier", this.StatusMessageOfBuildEventCode_1, resultBuildEventCode_1.ServerErrorMessage);
	#endif
					}
				}


				// 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree


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


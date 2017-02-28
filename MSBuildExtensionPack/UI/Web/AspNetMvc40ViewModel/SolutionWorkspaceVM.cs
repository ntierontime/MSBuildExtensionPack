using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{

    public partial class WPCommonOfSolutionVM : Framework.Mvc.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>
    {
        public WPCommonOfSolutionVM ()
            : base()
        {
        }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.AspNetMvc40ViewModel.Common.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }

        public override void GetDefaultPerViewModel()
        {

        }
    }




    public partial class WPEntityRelatedOfSolutionVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfSolutionVM(MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_Build_Solution = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly();
        }

		//FK_Build_Solution
		public MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly CriteriaOfFK_Build_Solution { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_Build_Solution { get; set; }
		public string StatusMessageOfFK_Build_Solution { get; set; }
		public MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection FK_Build_Solution { get; set; }

        public void LoadData(
			bool isToLoadFK_Build_Solution = true
			)
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
			var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);

            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

				// 2. accessory part - Aside UIWorkspaceItemSetting


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


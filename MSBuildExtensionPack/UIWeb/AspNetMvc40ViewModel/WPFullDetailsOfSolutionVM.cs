using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class WPFullDetailsOfSolutionVM
        : MSBuildExtensionPack.ViewModelData.WPFullDetailsOfSolutionVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPFullDetailsOfSolutionVM(MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
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
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);
            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

                // 2. accessory part - Aside UIWorkspaceItemSetting -- RelatedEntityWhenMasterViewIsFKEntity

                // MSBuildExtensionPack.Organization
                if(isToLoadOrganization_1)
                {
                    this.CriteriaOfOrganization_1.Identifier.Id = new Framework.EntityContracts.QuerySystemInt64EqualsCriteria(this.MasterEntity.OrganizationId);
                    var resultOrganization_1 = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfKeyInformationByIdentifier(this.CriteriaOfOrganization_1, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfOrganization_1 = resultOrganization_1.BusinessLogicLayerResponseStatus;
                    if (resultOrganization_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Organization_1 = resultOrganization_1.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfOrganization_1 = resultOrganization_1.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfOrganization_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCOrganization GetMessageOfKeyInformationByIdentifier", this.StatusMessageOfOrganization_1, resultOrganization_1.ServerErrorMessage);
    #endif
                    }
                }

                // MSBuildExtensionPack.Organization
                if(isToLoadOrganization_2)
                {
                    this.CriteriaOfOrganization_2.Identifier.Id = new Framework.EntityContracts.QuerySystemInt64EqualsCriteria(this.MasterEntity.Organization_2Id);
                    var resultOrganization_2 = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfKeyInformationByIdentifier(this.CriteriaOfOrganization_2, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfOrganization_2 = resultOrganization_2.BusinessLogicLayerResponseStatus;
                    if (resultOrganization_2.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Organization_2 = resultOrganization_2.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfOrganization_2 = resultOrganization_2.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfOrganization_2 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCOrganization GetMessageOfKeyInformationByIdentifier", this.StatusMessageOfOrganization_2, resultOrganization_2.ServerErrorMessage);
    #endif
                    }
                }

                // 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree -- RelatedEntityWhenMasterViewIsPKEntity

                // MSBuildExtensionPack.Build
                if(isToLoadFK_Build_Solution)
                {
                    this.CriteriaOfFK_Build_Solution.FKOnly.SolutionId = new Framework.EntityContracts.QuerySystemInt32EqualsCriteria(this.MasterEntity.Id);
                    var resultFK_Build_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultByFKOnly(this.CriteriaOfFK_Build_Solution, this.QueryPagingSetting, null);
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


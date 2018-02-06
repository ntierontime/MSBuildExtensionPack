using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class WPEntityRelatedOfBuildVM
        : MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPEntityRelatedOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
        }

        public void LoadData(
            bool isToLoadFK_BuildLog_Build = true
            , bool isToLoadSolution_1 = true
            , bool isToLoadOrganization_1 = true
            , bool isToLoadOrganization_2 = true
            )
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);
            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

                // 2. accessory part - Aside UIWorkspaceItemSetting -- RelatedEntityWhenMasterViewIsFKEntity

                // MSBuildExtensionPack.Solution
                if(isToLoadSolution_1)
                {
                    this.CriteriaOfSolution_1.Identifier.Id = new Framework.EntityContracts.QuerySystemInt32EqualsCriteria(this.MasterEntity.SolutionId);
                    var resultSolution_1 = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfKeyInformationByIdentifier(this.CriteriaOfSolution_1, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfSolution_1 = resultSolution_1.BusinessLogicLayerResponseStatus;
                    if (resultSolution_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Solution_1 = resultSolution_1.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfSolution_1 = resultSolution_1.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfSolution_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCSolution GetMessageOfKeyInformationByIdentifier", this.StatusMessageOfSolution_1, resultSolution_1.ServerErrorMessage);
    #endif
                    }
                }

                // MSBuildExtensionPack.Organization
                if(isToLoadOrganization_1)
                {
                    this.CriteriaOfOrganization_1.Identifier.Id = new Framework.EntityContracts.QuerySystemInt64EqualsCriteria(this.MasterEntity.Organization_1Id);
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

                // MSBuildExtensionPack.BuildLog
                if(isToLoadFK_BuildLog_Build)
                {
                    this.CriteriaOfFK_BuildLog_Build.FKOnly.BuildId = new Framework.EntityContracts.QuerySystemInt64EqualsCriteria(this.MasterEntity.Id);
                    var resultFK_BuildLog_Build = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultByFKOnly(this.CriteriaOfFK_BuildLog_Build, this.QueryPagingSetting, null);
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


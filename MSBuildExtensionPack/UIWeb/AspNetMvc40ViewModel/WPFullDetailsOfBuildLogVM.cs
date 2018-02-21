using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class WPFullDetailsOfBuildLogVM
        : MSBuildExtensionPack.ViewModelData.WPFullDetailsOfBuildLogVM
        //: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaIdentifier, Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus>
    {
        public WPFullDetailsOfBuildLogVM(MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
        }

        public void LoadData(
            bool isToLoadBuild_1 = true
            , bool isToLoadSolution_1 = true
            , bool isToLoadOrganization_1 = true
            , bool isToLoadOrganization_2 = true
            , bool isToLoadBuildEventCode_1 = true
            )
        {
            // 1. master on accessory part - Aside UIWorkspaceItemSetting
            var masterEntityResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultByIdentifier(this.CriteriaOfMasterEntity, this.QueryPagingSettingOneRecord, null);
            this.StatusOfMasterEntity = masterEntityResult.BusinessLogicLayerResponseStatus;

            if (masterEntityResult.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                this.MasterEntity = masterEntityResult.Message[0];

                // 2. accessory part - Aside UIWorkspaceItemSetting -- RelatedEntityWhenMasterViewIsFKEntity

                // MSBuildExtensionPack.Build
                if(isToLoadBuild_1)
                {
                    this.CriteriaOfBuild_1.Identifier.Id = new Framework.EntityContracts.QuerySystemInt64EqualsCriteria(this.MasterEntity.BuildId);
                    var resultBuild_1 = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfKeyInformationByIdentifier(this.CriteriaOfBuild_1, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfBuild_1 = resultBuild_1.BusinessLogicLayerResponseStatus;
                    if (resultBuild_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Build_1 = resultBuild_1.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfBuild_1 = resultBuild_1.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfBuild_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCBuild GetMessageOfKeyInformationByIdentifier", this.StatusMessageOfBuild_1, resultBuild_1.ServerErrorMessage);
    #endif
                    }
                }

                // MSBuildExtensionPack.Solution
                if(isToLoadSolution_1)
                {
                    this.CriteriaOfSolution_1.Identifier.Id = new Framework.EntityContracts.QuerySystemInt32EqualsCriteria(this.MasterEntity.Solution_1Id);
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

                // MSBuildExtensionPack.BuildEventCode
                if(isToLoadBuildEventCode_1)
                {
                    this.CriteriaOfBuildEventCode_1.Identifier.Id = new Framework.EntityContracts.QuerySystemInt32EqualsCriteria(this.MasterEntity.BuildEventCodeId);
                    var resultBuildEventCode_1 = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfKeyInformationByIdentifier(this.CriteriaOfBuildEventCode_1, this.QueryPagingSettingOneRecord, null);
                    this.StatusOfBuildEventCode_1 = resultBuildEventCode_1.BusinessLogicLayerResponseStatus;
                    if (resultBuildEventCode_1.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.BuildEventCode_1 = resultBuildEventCode_1.Message[0];
                    }
                    else
                    {
                        this.StatusMessageOfBuildEventCode_1 = resultBuildEventCode_1.GetStatusMessage();
    #if DEBUG
                        this.StatusMessageOfBuildEventCode_1 = string.Format("MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode GetMessageOfKeyInformationByIdentifier", this.StatusMessageOfBuildEventCode_1, resultBuildEventCode_1.ServerErrorMessage);
    #endif
                    }
                }

                // 3. Major part - Article UIWorkspaceItemSetting - EntityReference/FK downtree -- RelatedEntityWhenMasterViewIsPKEntity

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


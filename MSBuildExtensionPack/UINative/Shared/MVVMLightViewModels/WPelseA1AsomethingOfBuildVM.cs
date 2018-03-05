using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public partial class WPelseA1AsomethingOfBuildVM : Framework.Xaml.ViewModelEntityUpdateBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier, MSBuildExtensionPack.EntityContracts.IBuildIdentifier>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Build";
        public override string EntityName { get { return EntityName_Static; } }

        public const string ViewName_Static = "WPelseA1AsomethingOfBuildVM";
        public override string ViewName { get { return ViewName_Static; } }

        public WPelseA1AsomethingOfBuildVM ()
            : base()
        {
        }

        protected override void DoSearch()
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPelseA1AsomethingOfBuildVM();
                vmData.CriteriaOfMasterEntity = this.CriteriaOfMasterEntity;
                vmData.QueryPagingSetting = this.QueryPagingSetting;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPelseA1AsomethingOfBuildVM((System.Int64)vmData.CriteriaOfMasterEntity.Identifier.Id.ValueToCompare)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfMasterEntity = result.StatusOfMasterEntity;
                    this.StatusMessageOfMasterEntity = result.StatusMessageOfMasterEntity;
                    if (result.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        // 1. MasterEntity
                        this.MasterEntity = result.MasterEntity;
                        this.CriteriaOfMasterEntity = result.CriteriaOfMasterEntity;
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        protected override MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier GetCriteria(MSBuildExtensionPack.EntityContracts.IBuildIdentifier o)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier();
             criteria.Identifier.Id.NullableValueToCompare = (System.Int64)o.Id;
            return criteria;
        }

        protected override void DoUpdate()
        {
            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Update;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPelseA1AsomethingOfBuildVM();
                vmData.CriteriaOfMasterEntity = this.CriteriaOfMasterEntity;
                vmData.QueryPagingSetting = this.QueryPagingSetting;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.WPelseA1AsomethingOfBuildVM(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfMasterEntity = result.StatusOfMasterEntity;
                    this.StatusMessageOfMasterEntity = result.StatusMessageOfMasterEntity;
                    if (result.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        // 1. MasterEntity
                        this.MasterEntity = result.MasterEntity;
                        this.CriteriaOfMasterEntity = result.CriteriaOfMasterEntity;
                    }
                });
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }
    }
}


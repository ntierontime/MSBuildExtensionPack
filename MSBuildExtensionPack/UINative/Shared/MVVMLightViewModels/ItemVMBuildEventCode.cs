using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    /// <summary>
    /// This class contains single item view model
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </summary>
    public partial class ItemVMBuildEventCode
        : Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier, MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.BuildEventCode";
        public override string EntityName { get { return EntityName_Static; } }

        public ItemVMBuildEventCode()
            : base()
        {
        }

        protected override void Add()
        {
            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {

                var client = new MSBuildExtensionPack.WebApiClient.BuildEventCodeApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.InsertEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(this.Item))).Result;

                if (result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    if (!this.SuppressMVVMLightEventToCommandMessage)
                        Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        protected override void Delete()
        {
            string viewName = ViewName_Delete;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildEventCodeApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.DeleteEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(this.Item))).Result;

                if (result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    if (!this.SuppressMVVMLightEventToCommandMessage)
                        Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        protected override void Save()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {

                var client = new MSBuildExtensionPack.WebApiClient.BuildEventCodeApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.UpdateEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(this.Item))).Result;

                if (result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    if (!this.SuppressMVVMLightEventToCommandMessage)
                        Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    RaisePropertyChanged("Item");
                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        public override void ReLoadItem(MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier identifier)
        {
            if (identifier != null)
            {
                this.Criteria = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier>(identifier);
            }
            else
            {
                this.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier(this.Item);
            }

            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildEventCodeApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetBuildEventCodeItemVMAsync(identifier.Id)).Result;

                this.StatusOfResult = result.StatusOfResult;
                this.StatusMessageOfResult = result.StatusMessageOfResult;
                if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    this.Item = result.Item;
                    if (!this.SuppressMVVMLightEventToCommandMessage)
                        Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        protected override void LaunchDetailsView(MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item;

            base.LaunchDetailsView(o);
        }

        protected override void LaunchEditView(MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item;

            base.LaunchEditView(o);
        }

        protected override void LaunchCopyView(MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item.GetACloneWithoutIdentifier();

            base.LaunchCopyView(o);
        }

        #region Cleanup()

        public override void Cleanup()
        {
            base.Cleanup();
        }

        #endregion Cleanup()
    }
}


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
    public partial class ItemVMOrganization
        : Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier, MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.Organization.Default>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Organization";
        public override string EntityName { get { return EntityName_Static; } }

        public ItemVMOrganization()
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

                this.Item.ParentId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem.Value;

                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.InsertEntityAsync(MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(this.Item))).Result;

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
                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.DeleteEntityAsync(MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(this.Item))).Result;

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

                this.Item.ParentId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem.Value;

                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.UpdateEntityAsync(MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(this.Item))).Result;

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

        public override void ReLoadItem(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier identifier)
        {
            if (identifier != null)
            {
                this.Criteria = MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier>(identifier);
            }
            else
            {
                this.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(this.Item);
            }

            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetOrganizationItemVMAsync(identifier.Id)).Result;

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

        protected override void LaunchDetailsView(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item;

            //MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.GetDropDownContentsOfOrganization_2();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.ParentId, o.Organization_2_Name);

            base.LaunchDetailsView(o);
        }

        protected override void LaunchEditView(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item;

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.GetDropDownContentsOfOrganization_2();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.ParentId, o.Organization_2_Name);

            base.LaunchEditView(o);
        }

        protected override void LaunchCopyView(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item.GetACloneWithoutIdentifier();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.GetDropDownContentsOfOrganization_2();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.ParentId, o.Organization_2_Name);

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


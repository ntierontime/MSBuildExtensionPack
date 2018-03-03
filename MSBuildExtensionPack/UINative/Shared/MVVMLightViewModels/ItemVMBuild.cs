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
    public partial class ItemVMBuild
        : Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildIdentifier, MSBuildExtensionPack.EntityContracts.IBuildIdentifier, MSBuildExtensionPack.DataSourceEntities.Build.Default>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Build";
        public override string EntityName { get { return EntityName_Static; } }

        public ItemVMBuild()
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

                this.Item.Organization_2Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem.Value;

                this.Item.Organization_1Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem.Value;

                this.Item.SolutionId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem.Value;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.InsertEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(this.Item))).Result;

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
                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.DeleteEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(this.Item))).Result;

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

                this.Item.Organization_2Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem.Value;

                this.Item.Organization_1Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem.Value;

                this.Item.SolutionId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem.Value;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.UpdateEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(this.Item))).Result;

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

        public override void ReLoadItem(MSBuildExtensionPack.EntityContracts.IBuildIdentifier o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.EntityContracts.IBuildIdentifier identifier)
        {
            if (identifier != null)
            {
                this.Criteria = MSBuildExtensionPack.EntityContracts.IBuildIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier>(identifier);
            }
            else
            {
                this.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildIdentifier(this.Item);
            }

            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetBuildItemVMAsync(identifier.Id)).Result;

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

        protected override void LaunchDetailsView(MSBuildExtensionPack.EntityContracts.IBuildIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item;

            //MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_2();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.SolutionId, o.Solution_1_Name);

            base.LaunchDetailsView(o);
        }

        protected override void LaunchEditView(MSBuildExtensionPack.EntityContracts.IBuildIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item;

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_2();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.SolutionId, o.Solution_1_Name);

            base.LaunchEditView(o);
        }

        protected override void LaunchCopyView(MSBuildExtensionPack.EntityContracts.IBuildIdentifier oo)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildIdentifierHelper.Clone<MSBuildExtensionPack.EntityContracts.IBuildIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier>(oo);
            this.LoadItem(identifier);
            var o = this.Item.GetACloneWithoutIdentifier();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_2();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.SolutionId, o.Solution_1_Name);

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


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
		: Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildIdentifier, MSBuildExtensionPack.DataSourceEntities.Build.Default>
    {
		#region override string EntityName
	    
        public const string EntityName_Static = "MSBuildExtensionPack.Build";

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

		#endregion override string EntityName

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ItemVMBuild class.
        /// </summary>
        public ItemVMBuild()
			: base()
        {
        }

        #endregion Constructor

        protected override void Add()
        {
            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
				var result = Task.Run(() => client.InsertEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(this.Item))).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    if (result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    }
                });
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

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    if (result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        protected override void RefreshItemNoMessage()
        {
            this.Item = this.OriginalItem.GetAClone();
        }

        protected override void Save()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {

                this.Item.Organization_1Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem.Value;


                this.Item.Organization_2Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem.Value;


                this.Item.SolutionId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem.Value;



                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
				var result = Task.Run(() => client.UpdateEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(this.Item))).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    if (result.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        public override void ReLoadItem(MSBuildExtensionPack.DataSourceEntities.Build.Default o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildIdentifierHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.DataSourceEntities.BuildIdentifier identifier)
        {
            if (identifier != null)
            {
                this.Criteria = identifier;
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

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    this.StatusMessageOfResult = result.StatusMessageOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Item = result.Item;
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        protected override void LaunchDetailsView(MSBuildExtensionPack.DataSourceEntities.Build.Default o)
        {
            base.LaunchDetailsView(o);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfSolution_1(new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_1(new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name));




            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.SolutionId, o.Solution_1_Name);


        }

        protected override void LaunchEditView(MSBuildExtensionPack.DataSourceEntities.Build.Default oo)
        {
			var o = oo == null ? this.Item.GetACloneWithoutIdentifier() : oo.GetACloneWithoutIdentifier();


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfSolution_1(new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_1(new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name));




            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.SolutionId, o.Solution_1_Name);



            base.LaunchEditView(o);
        }

        protected override void LaunchCopyView(MSBuildExtensionPack.DataSourceEntities.Build.Default oo)
        {
			var o = oo == null ? this.Item.GetACloneWithoutIdentifier() : oo.GetACloneWithoutIdentifier();


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfSolution_1(new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_1(new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name));




            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_1Id, o.Organization_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem = new Framework.NameValuePair<System.Int64>(o.Organization_2Id, o.Organization_2_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.SolutionId, o.Solution_1_Name);



            base.LaunchCopyView(o);
        }

        #region Cleanup()

        public override void Cleanup()
        {
            base.Cleanup();
            this.Criteria = null;
            this.ContentData = null;
        }

        #endregion Cleanup()
    }
}


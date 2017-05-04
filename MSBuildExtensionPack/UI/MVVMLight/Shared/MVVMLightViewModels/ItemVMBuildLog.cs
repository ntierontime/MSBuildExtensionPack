using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;
using MSBuildExtensionPack.DataSourceEntities;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    /// <summary>
    /// This class contains single item view model
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </summary>
    public partial class ItemVMBuildLog
		: Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
    {
		#region override string EntityName
	    
        public const string EntityName_Static = "MSBuildExtensionPack.BuildLog";

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
        /// Initializes a new instance of the ItemVMBuildLog class.
        /// </summary>
        public ItemVMBuildLog()
			: base()
        {
            MessengerInstance.Register<Framework.UISelectedItemChangedMessage>(this, message => {
                if(message.SourceTypeFullName == EntityName)
                {
                    if (message.SourcePropertyName == MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog.PropertyName_DropDownContentsOfBuildEventCode_1SelectedItem)
                    {
                        var selectedItem = (Framework.NameValuePair<System.Int32>)message.SelectedItem;
                        this.Item.BuildEventCodeId = selectedItem.Value;
                    }
                    else if (message.SourcePropertyName == MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog.PropertyName_DropDownContentsOfBuild_1SelectedItem)
                    {
                        var selectedItem = (Framework.NameValuePair<System.Int64>)message.SelectedItem;
                        this.Item.BuildId = selectedItem.Value;
                    }
                    else if (message.SourcePropertyName == MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog.PropertyName_DropDownContentsOfSolution_1SelectedItem)
                    {
                        var selectedItem = (Framework.NameValuePair<System.Int32>)message.SelectedItem;
                        this.Item.Solution_1Id = selectedItem.Value;
                    }
                }
            });
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
                var client = new MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);

                var resultVMData = Task.Run(() => client.InsertEntityAsync(MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog>(this.Item))).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    if (resultVMData.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
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
                var client = new MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);

                var resultVMData = Task.Run(() => client.DeleteEntitySync(MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog>(this.Item))).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    if (resultVMData.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
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

                this.Item.Solution_1Id = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfSolution_1SelectedItem.Value;


                this.Item.BuildId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuild_1SelectedItem.Value;


                this.Item.BuildEventCodeId = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuildEventCode_1SelectedItem.Value;



                var client = new MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);

                var resultVMData = Task.Run(() => client.UpdateEntitySync(MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog>(this.Item))).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    if (resultVMData.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
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

        public override void ReLoadItem(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildLogIdentifierHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            if (identifier != null)
            {
                this.Criteria = identifier;
            }
            else
            {
                this.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier(this.Item);
            }

            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);

                var resultVMData = Task.Run(() => client.GetBuildLogItemVMSync(identifier.Id)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = resultVMData.StatusOfResult;
                    this.StatusMessageOfResult = resultVMData.StatusMessageOfResult;
                    if (resultVMData.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        this.Item = resultVMData.Item;
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

        protected override void LaunchEditView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default oo)
        {
            BuildLog.Default o = oo == null ? this.Item.GetACloneWithoutIdentifier() : oo.GetACloneWithoutIdentifier();


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.GetDropDownContentsOfBuild_1(new Framework.NameValuePair<int>(o.Solution_1Id, o.Solution_1_Name));




            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.Solution_1Id, o.Solution_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuild_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.BuildId, o.Build_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuildEventCode_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.BuildEventCodeId, o.BuildEventCode_1_Name);


            base.LaunchEditView(o);
        }

        protected override void LaunchDetailsView(BuildLog.Default oo)
        {
            BuildLog.Default o = oo == null ? this.Item.GetACloneWithoutIdentifier() : oo.GetACloneWithoutIdentifier();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.GetDropDownContentsOfBuild_1(new Framework.NameValuePair<int>(o.Solution_1Id, o.Solution_1_Name));




            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.Solution_1Id, o.Solution_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuild_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.BuildId, o.Build_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuildEventCode_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.BuildEventCodeId, o.BuildEventCode_1_Name);

            base.LaunchDetailsView(o);
        }

        protected override void LaunchCopyView(BuildLog.Default oo)
        {
            BuildLog.Default o = oo == null ? this.Item.GetACloneWithoutIdentifier() : oo.GetACloneWithoutIdentifier();

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.GetDropDownContentsOfBuild_1(new Framework.NameValuePair<int>(o.Solution_1Id, o.Solution_1_Name));




            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfSolution_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.Solution_1Id, o.Solution_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuild_1SelectedItem = new Framework.NameValuePair<System.Int64>(o.BuildId, o.Build_1_Name);


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.DropDownContentsOfBuildEventCode_1SelectedItem = new Framework.NameValuePair<System.Int32>(o.BuildEventCodeId, o.BuildEventCode_1_Name);

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


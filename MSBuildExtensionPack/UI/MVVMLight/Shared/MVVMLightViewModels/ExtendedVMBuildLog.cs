using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class ExtendedVMBuildLog: GalaSoft.MvvmLight.ViewModelBase
    {
        public const string EntityName_Static = "MSBuildExtensionPack.BuildLog";

        public string EntityName { get { return EntityName_Static; } }

        public ExtendedVMBuildLog()
            : base()
        {

            // 1.1. Build_1 LaunchBuild_1DetailsView and its command
            this.LaunchBuild_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchBuild_1DetailsView);

            // 2.1. Solution_1 LaunchSolution_1DetailsView and its command
            this.LaunchSolution_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchSolution_1DetailsView);

            // 2.2. Solution_1 GetDropDownContentsOfSolution_1SelectionChanged and its command
            this.GetDropDownContentsOfSolution_1SelectionChangedCommand = new RelayCommand<Framework.NameValuePair<System.Int32>>(this.GetDropDownContentsOfBuild_1);

            // 3.1. Organization_1 LaunchOrganization_1DetailsView and its command
            this.LaunchOrganization_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchOrganization_1DetailsView);

            // 3.2. Organization_1 GetDropDownContentsOfOrganization_1SelectionChanged and its command
            this.GetDropDownContentsOfOrganization_1SelectionChangedCommand = new RelayCommand<Framework.NameValuePair<System.Int64>>(this.GetDropDownContentsOfSolution_1);

            // 4.1. Organization_2 LaunchOrganization_2DetailsView and its command
            this.LaunchOrganization_2DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchOrganization_2DetailsView);

            // 4.2. Organization_2 GetDropDownContentsOfOrganization_2SelectionChanged and its command
            this.GetDropDownContentsOfOrganization_2Command = new RelayCommand(this.GetDropDownContentsOfOrganization_2);
            this.GetDropDownContentsOfOrganization_2SelectionChangedCommand = new RelayCommand<Framework.NameValuePair<System.Int64>>(this.GetDropDownContentsOfOrganization_1);
            this.GetDropDownContentsOfOrganization_2Command.Execute(null);

            // 5.1. BuildEventCode_1 LaunchBuildEventCode_1DetailsView and its command
            this.LaunchBuildEventCode_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchBuildEventCode_1DetailsView);

            // 5.2. BuildEventCode_1 GetDropDownContentsOfBuildEventCode_1SelectionChanged and its command
            this.GetDropDownContentsOfBuildEventCode_1Command = new RelayCommand(this.GetDropDownContentsOfBuildEventCode_1);
            this.GetDropDownContentsOfBuildEventCode_1Command.Execute(null);

        }

        #region 1. Build_1

        // 1.1. Build_1 LaunchBuild_1DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchBuild_1DetailsViewCommand { get; protected set; }
        protected void LaunchBuild_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.BuildIdentifier(item.BuildId));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static.Item);
        }

        // 1.2. Build_1 DropDownContentsOfBuild_1 and its commands

        public Framework.NameValuePair<System.Int64> m_DropDownContentsOfBuild_1SelectedItem;
        public Framework.NameValuePair<System.Int64> DropDownContentsOfBuild_1SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfBuild_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfBuild_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfBuild_1SelectedItem = value;
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfBuild_1SelectedItem, value));
                RaisePropertyChanged(PropertyName_DropDownContentsOfBuild_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfBuild_1SelectedItem = "DropDownContentsOfBuild_1SelectedItem";
        public const string PropertyName_DropDownContentsOfBuild_1 = "DropDownContentsOfBuild_1";

        public ObservableCollection<Framework.NameValuePair<System.Int64>> m_DropDownContentsOfBuild_1 = new ObservableCollection<Framework.NameValuePair<System.Int64>>();
        public ObservableCollection<Framework.NameValuePair<System.Int64>> DropDownContentsOfBuild_1
        {
            get
            {
                return this.m_DropDownContentsOfBuild_1;
            }
        }

        public RelayCommand<Framework.NameValuePair<System.Int64>> GetDropDownContentsOfBuild_1SelectionChangedCommand { get; private set; }
        public void GetDropDownContentsOfBuild_1(Framework.NameValuePair<System.Int32> input)
        {
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetCollectionOfNameValuePairOfByFKOnlyAsync(true, input.Value,false, default(System.Int64),false, default(System.Int64), -1, -1, null)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.DropDownContentsOfBuild_1.Clear();
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            int value;
                            if (int.TryParse(item.Value, out value))
                            {
                                this.DropDownContentsOfBuild_1.Add(new Framework.NameValuePair<System.Int64>(value, item.Name));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfBuild_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 1. Build_1

        #region 2. Solution_1

        // 2.1. Solution_1 LaunchSolution_1DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchSolution_1DetailsViewCommand { get; protected set; }
        protected void LaunchSolution_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(item.Solution_1Id));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.Item);
        }

        // 2.2. Solution_1 DropDownContentsOfSolution_1 and its commands

        public Framework.NameValuePair<System.Int32> m_DropDownContentsOfSolution_1SelectedItem;
        public Framework.NameValuePair<System.Int32> DropDownContentsOfSolution_1SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfSolution_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfSolution_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfSolution_1SelectedItem = value;
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfSolution_1SelectedItem, value));
                GetDropDownContentsOfBuild_1(value);
                RaisePropertyChanged(PropertyName_DropDownContentsOfSolution_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfSolution_1SelectedItem = "DropDownContentsOfSolution_1SelectedItem";
        public const string PropertyName_DropDownContentsOfSolution_1 = "DropDownContentsOfSolution_1";

        public ObservableCollection<Framework.NameValuePair<System.Int32>> m_DropDownContentsOfSolution_1 = new ObservableCollection<Framework.NameValuePair<System.Int32>>();
        public ObservableCollection<Framework.NameValuePair<System.Int32>> DropDownContentsOfSolution_1
        {
            get
            {
                return this.m_DropDownContentsOfSolution_1;
            }
        }

        public RelayCommand<Framework.NameValuePair<System.Int32>> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }

        public void GetDropDownContentsOfSolution_1(Framework.NameValuePair<System.Int64> input)
        {
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.SolutionApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetCollectionOfNameValuePairOfByFKOnlyAsync(true, input.Value,false, default(System.Int64), -1, -1, null)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.DropDownContentsOfSolution_1.Clear();
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            int value;
                            if (int.TryParse(item.Value, out value))
                            {
                                this.DropDownContentsOfSolution_1.Add(new Framework.NameValuePair<System.Int32>(value, item.Name));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfSolution_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 2. Solution_1

        #region 3. Organization_1

        // 3.1. Organization_1 LaunchOrganization_1DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchOrganization_1DetailsViewCommand { get; protected set; }
        protected void LaunchOrganization_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(item.Organization_1Id));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.Item);
        }

        // 3.2. Organization_1 DropDownContentsOfOrganization_1 and its commands

        public Framework.NameValuePair<System.Int64> m_DropDownContentsOfOrganization_1SelectedItem;
        public Framework.NameValuePair<System.Int64> DropDownContentsOfOrganization_1SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfOrganization_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfOrganization_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfOrganization_1SelectedItem = value;
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfOrganization_1SelectedItem, value));
                GetDropDownContentsOfSolution_1(value);
                RaisePropertyChanged(PropertyName_DropDownContentsOfOrganization_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfOrganization_1SelectedItem = "DropDownContentsOfOrganization_1SelectedItem";
        public const string PropertyName_DropDownContentsOfOrganization_1 = "DropDownContentsOfOrganization_1";

        public ObservableCollection<Framework.NameValuePair<System.Int64>> m_DropDownContentsOfOrganization_1 = new ObservableCollection<Framework.NameValuePair<System.Int64>>();
        public ObservableCollection<Framework.NameValuePair<System.Int64>> DropDownContentsOfOrganization_1
        {
            get
            {
                return this.m_DropDownContentsOfOrganization_1;
            }
        }

        public RelayCommand<Framework.NameValuePair<System.Int64>> GetDropDownContentsOfOrganization_1SelectionChangedCommand { get; private set; }

        public void GetDropDownContentsOfOrganization_1(Framework.NameValuePair<System.Int64> input)
        {
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetCollectionOfNameValuePairOfByFKOnlyAsync(true, input.Value, -1, -1, null)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.DropDownContentsOfOrganization_1.Clear();
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            int value;
                            if (int.TryParse(item.Value, out value))
                            {
                                this.DropDownContentsOfOrganization_1.Add(new Framework.NameValuePair<System.Int64>(value, item.Name));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfOrganization_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 3. Organization_1

        #region 4. Organization_2

        // 4.1. Organization_2 LaunchOrganization_2DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchOrganization_2DetailsViewCommand { get; protected set; }
        protected void LaunchOrganization_2DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(item.Organization_2Id));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.Item);
        }

        // 4.2. Organization_2 DropDownContentsOfOrganization_2 and its commands

        public Framework.NameValuePair<System.Int64> m_DropDownContentsOfOrganization_2SelectedItem;
        public Framework.NameValuePair<System.Int64> DropDownContentsOfOrganization_2SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfOrganization_2SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfOrganization_2SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfOrganization_2SelectedItem = value;
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfOrganization_2SelectedItem, value));
                GetDropDownContentsOfOrganization_1(value);
                RaisePropertyChanged(PropertyName_DropDownContentsOfOrganization_2SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfOrganization_2SelectedItem = "DropDownContentsOfOrganization_2_1SelectedItem";
        public const string PropertyName_DropDownContentsOfOrganization_2 = "DropDownContentsOfOrganization_2";

        public ObservableCollection<Framework.NameValuePair<System.Int64>> m_DropDownContentsOfOrganization_2 = new ObservableCollection<Framework.NameValuePair<System.Int64>>();
        public ObservableCollection<Framework.NameValuePair<System.Int64>> DropDownContentsOfOrganization_2
        {
            get
            {
                return this.m_DropDownContentsOfOrganization_2;
            }
        }

        public RelayCommand<Framework.NameValuePair<System.Int64>> GetDropDownContentsOfOrganization_2SelectionChangedCommand { get; private set; }

        public RelayCommand GetDropDownContentsOfOrganization_2Command { get; private set; }
        public void GetDropDownContentsOfOrganization_2()
        {
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetCollectionOfNameValuePairOfAllAsync(-1, -1, null)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.DropDownContentsOfOrganization_2.Clear();
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            int value;
                            if (int.TryParse(item.Value, out value))
                            {
                                this.DropDownContentsOfOrganization_2.Add(new Framework.NameValuePair<System.Int64>(value, item.Name));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfOrganization_2, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 4. Organization_2

        #region 5. BuildEventCode_1

        // 5.1. BuildEventCode_1 LaunchBuildEventCode_1DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchBuildEventCode_1DetailsViewCommand { get; protected set; }
        protected void LaunchBuildEventCode_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier(item.BuildEventCodeId));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode_Static.Item);
        }

        // 5.2. BuildEventCode_1 DropDownContentsOfBuildEventCode_1 and its commands

        public Framework.NameValuePair<System.Int32> m_DropDownContentsOfBuildEventCode_1SelectedItem;
        public Framework.NameValuePair<System.Int32> DropDownContentsOfBuildEventCode_1SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfBuildEventCode_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfBuildEventCode_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfBuildEventCode_1SelectedItem = value;
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfBuildEventCode_1SelectedItem, value));
                RaisePropertyChanged(PropertyName_DropDownContentsOfBuildEventCode_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfBuildEventCode_1SelectedItem = "DropDownContentsOfBuildEventCode_1_1SelectedItem";
        public const string PropertyName_DropDownContentsOfBuildEventCode_1 = "DropDownContentsOfBuildEventCode_1";

        public ObservableCollection<Framework.NameValuePair<System.Int32>> m_DropDownContentsOfBuildEventCode_1 = new ObservableCollection<Framework.NameValuePair<System.Int32>>();
        public ObservableCollection<Framework.NameValuePair<System.Int32>> DropDownContentsOfBuildEventCode_1
        {
            get
            {
                return this.m_DropDownContentsOfBuildEventCode_1;
            }
        }

        public RelayCommand<Framework.NameValuePair<System.Int32>> GetDropDownContentsOfBuildEventCode_1SelectionChangedCommand { get; private set; }

        public RelayCommand GetDropDownContentsOfBuildEventCode_1Command { get; private set; }
        public void GetDropDownContentsOfBuildEventCode_1()
        {
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.BuildEventCodeApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetCollectionOfNameValuePairOfAllAsync(-1, -1, null)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.DropDownContentsOfBuildEventCode_1.Clear();
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            int value;
                            if (int.TryParse(item.Value, out value))
                            {
                                this.DropDownContentsOfBuildEventCode_1.Add(new Framework.NameValuePair<System.Int32>(value, item.Name));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfBuildEventCode_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 5. BuildEventCode_1

        public override void Cleanup()
        {
        }
    }
}


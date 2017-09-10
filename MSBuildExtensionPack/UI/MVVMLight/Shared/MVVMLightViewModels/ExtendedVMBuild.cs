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
    public class ExtendedVMBuild: GalaSoft.MvvmLight.ViewModelBase
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Build";

        public string EntityName { get { return EntityName_Static; } }

        public ExtendedVMBuild()
            : base()
        {

            // 1.1. Solution_1 LaunchSolution_1DetailsView and its command
            this.LaunchSolution_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default>(this.LaunchSolution_1DetailsView);

            // 2.1. Organization_1 LaunchOrganization_1DetailsView and its command
            this.LaunchOrganization_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default>(this.LaunchOrganization_1DetailsView);

            // 2.2. Organization_1 GetDropDownContentsOfOrganization_1SelectionChanged and its command
            this.GetDropDownContentsOfOrganization_1SelectionChangedCommand = new RelayCommand<Framework.NameValuePair<System.Int64>>(this.GetDropDownContentsOfSolution_1);

            // 3.1. Organization_2 LaunchOrganization_2DetailsView and its command
            this.LaunchOrganization_2DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default>(this.LaunchOrganization_2DetailsView);

            // 3.2. Organization_2 GetDropDownContentsOfOrganization_2SelectionChanged and its command
            this.GetDropDownContentsOfOrganization_2Command = new RelayCommand(this.GetDropDownContentsOfOrganization_2);
            this.GetDropDownContentsOfOrganization_2SelectionChangedCommand = new RelayCommand<Framework.NameValuePair<System.Int64>>(this.GetDropDownContentsOfOrganization_1);
            this.GetDropDownContentsOfOrganization_2Command.Execute(null);

        }

        #region 1. Solution_1

        // 1.1. Solution_1 LaunchSolution_1DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default> LaunchSolution_1DetailsViewCommand { get; protected set; }
        protected void LaunchSolution_1DetailsView(MSBuildExtensionPack.DataSourceEntities.Build.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(item.SolutionId));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.Item);
        }

        // 1.2. Solution_1 DropDownContentsOfSolution_1 and its commands

        public Framework.NameValuePair<System.Int32> m_DropDownContentsOfSolution_1SelectedItem;
        public Framework.NameValuePair<System.Int32> DropDownContentsOfSolution_1SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfSolution_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfSolution_1SelectedItem != null && this.m_DropDownContentsOfSolution_1SelectedItem.Equals(value))
                {
                    return;
                }

                this.m_DropDownContentsOfSolution_1SelectedItem = this.DropDownContentsOfSolution_1.FirstOrDefault(t => t.Value == value.Value);
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfSolution_1SelectedItem, value));
                RaisePropertyChanged(PropertyName_DropDownContentsOfSolution_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfSolution_1SelectedItem = "DropDownContentsOfSolution_1SelectedItem";
        public const string PropertyName_DropDownContentsOfSolution_1 = "DropDownContentsOfSolution_1";

        public List<Framework.NameValuePair<System.Int32>> m_DropDownContentsOfSolution_1 = new List<Framework.NameValuePair<System.Int32>>();
        public List<Framework.NameValuePair<System.Int32>> DropDownContentsOfSolution_1
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
                if (input != null)
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
                else
                {
                    this.DropDownContentsOfSolution_1.Clear();
                }
                RaisePropertyChanged("DropDownContentsOfSolution_1");
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfSolution_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 1. Solution_1

        #region 2. Organization_1

        // 2.1. Organization_1 LaunchOrganization_1DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default> LaunchOrganization_1DetailsViewCommand { get; protected set; }
        protected void LaunchOrganization_1DetailsView(MSBuildExtensionPack.DataSourceEntities.Build.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(item.Organization_1Id));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.Item);
        }

        // 2.2. Organization_1 DropDownContentsOfOrganization_1 and its commands

        public Framework.NameValuePair<System.Int64> m_DropDownContentsOfOrganization_1SelectedItem;
        public Framework.NameValuePair<System.Int64> DropDownContentsOfOrganization_1SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfOrganization_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfOrganization_1SelectedItem != null && this.m_DropDownContentsOfOrganization_1SelectedItem.Equals(value))
                {
                    return;
                }

                this.m_DropDownContentsOfOrganization_1SelectedItem = this.DropDownContentsOfOrganization_1.FirstOrDefault(t=>t.Value ==  value.Value);
                MessengerInstance.Send<Framework.UISelectedItemChangedMessage>(new Framework.UISelectedItemChangedMessage(EntityName, PropertyName_DropDownContentsOfOrganization_1SelectedItem, value));
                GetDropDownContentsOfSolution_1(value);
                RaisePropertyChanged(PropertyName_DropDownContentsOfOrganization_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfOrganization_1SelectedItem = "DropDownContentsOfOrganization_1SelectedItem";
        public const string PropertyName_DropDownContentsOfOrganization_1 = "DropDownContentsOfOrganization_1";

        public List<Framework.NameValuePair<System.Int64>> m_DropDownContentsOfOrganization_1 = new List<Framework.NameValuePair<System.Int64>>();
        public List<Framework.NameValuePair<System.Int64>> DropDownContentsOfOrganization_1
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
                if (input != null)
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
                else
                {
                    this.DropDownContentsOfOrganization_1.Clear();
                }
                RaisePropertyChanged("DropDownContentsOfOrganization_1");
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfOrganization_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 2. Organization_1

        #region 3. Organization_2

        // 3.1. Organization_2 LaunchOrganization_2DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default> LaunchOrganization_2DetailsViewCommand { get; protected set; }
        protected void LaunchOrganization_2DetailsView(MSBuildExtensionPack.DataSourceEntities.Build.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(item.Organization_2Id));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.Item);
        }

        // 3.2. Organization_2 DropDownContentsOfOrganization_2 and its commands

        public Framework.NameValuePair<System.Int64> m_DropDownContentsOfOrganization_2SelectedItem;
        public Framework.NameValuePair<System.Int64> DropDownContentsOfOrganization_2SelectedItem
        {
            get
            {
                return this.m_DropDownContentsOfOrganization_2SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfOrganization_2SelectedItem != null && this.m_DropDownContentsOfOrganization_2SelectedItem.Equals(value))
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

        public List<Framework.NameValuePair<System.Int64>> m_DropDownContentsOfOrganization_2 = new List<Framework.NameValuePair<System.Int64>>();
        public List<Framework.NameValuePair<System.Int64>> DropDownContentsOfOrganization_2
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
                RaisePropertyChanged("DropDownContentsOfOrganization_2");
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName_Static, PropertyName_DropDownContentsOfOrganization_2, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion 3. Organization_2

        public override void Cleanup()
        {
        }
    }
}


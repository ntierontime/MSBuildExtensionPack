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
    public class ExtendedVMOrganization: GalaSoft.MvvmLight.ViewModelBase
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Organization";

        public string EntityName { get { return EntityName_Static; } }

        public ExtendedVMOrganization()
			: base()
        {

			// 1.1. Organization_2 LaunchOrganization_2DetailsView and its command
			this.LaunchOrganization_2DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.Organization.Default>(this.LaunchOrganization_2DetailsView);

			// 1.2. Organization_2 GetDropDownContentsOfOrganization_2SelectionChanged and its command
			this.GetDropDownContentsOfOrganization_2Command = new RelayCommand(this.GetDropDownContentsOfOrganization_2);


        }



		#region 1. Organization_2

		// 1.1. Organization_2 LaunchOrganization_2DetailsView and its command

        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.Organization.Default> LaunchOrganization_2DetailsViewCommand { get; protected set; }
        protected void LaunchOrganization_2DetailsView(MSBuildExtensionPack.DataSourceEntities.Organization.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(item.ParentId));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LaunchDetailsViewCommand.Execute(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.Item);
        }


		// 1.2. Organization_2 DropDownContentsOfOrganization_2 and its commands

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
            set
            {
                if (this.m_DropDownContentsOfOrganization_2 == value)
                {
                    return;
                }

                this.m_DropDownContentsOfOrganization_2 = value;
                RaisePropertyChanged("DropDownContentsOfOrganization_2");
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

		#endregion 1. Organization_2



        public override void Cleanup()
        {
        }
    }
}


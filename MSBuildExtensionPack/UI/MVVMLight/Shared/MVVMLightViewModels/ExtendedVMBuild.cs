using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class ExtendedVMBuild: GalaSoft.MvvmLight.ViewModelBase
    {
        #region constructor

        public ExtendedVMBuild()
			: base()
        {

		#region Commands for Cascading ComboBox

            this.GetDropDownContentsOfSolution_1Command = new RelayCommand(this.GetDropDownContentsOfSolution_1);


		#endregion Commands for Cascading ComboBox



            #region Commands for LinkedButton in List


            this.LaunchSolution_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default>(this.LaunchSolution_1DetailsView);



            #endregion Commands for LinkedButton in List
        }

        #endregion constructor


		#region Commands for Cascading ComboBox

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
                RaisePropertyChanged(PropertyName_DropDownContentsOfSolution_1SelectedItem);
            }
        }

        public const string PropertyName_DropDownContentsOfSolution_1SelectedItem = "DropDownContentsOfSolution_1_1SelectedItem";
        public const string PropertyName_DropDownContentsOfSolution_1 = "DropDownContentsOfSolution_1";

        public List<Framework.NameValuePair<System.Int32>> m_DropDownContentsOfSolution_1 = new List<Framework.NameValuePair<System.Int32>>();

        public List<Framework.NameValuePair<System.Int32>> DropDownContentsOfSolution_1
        {
            get
            {
                return this.m_DropDownContentsOfSolution_1;
            }
            set
            {
                if (this.m_DropDownContentsOfSolution_1 == value)
                {
                    return;
                }

                this.m_DropDownContentsOfSolution_1 = value;
                RaisePropertyChanged("DropDownContentsOfSolution_1");
            }
        }

        public RelayCommand<Framework.NameValuePair<System.Int32>> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }

        public RelayCommand GetDropDownContentsOfSolution_1Command { get; private set; }
        public void GetDropDownContentsOfSolution_1()
        {
            try
            {
                var client = new MSBuildExtensionPack.WebApiClient.SolutionApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);

                var resultVMData = client.GetCollectionOfNameValuePairOfAllAsync(0, 0, null);

                var result = resultVMData.Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();
                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.DropDownContentsOfSolution_1.Clear();
                    if (resultVMData.Result != null)
                    {
                        foreach (var item in resultVMData.Result)
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
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, PropertyName_DropDownContentsOfSolution_1, Framework.UIAction.Search, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

		#endregion Commands for Cascading ComboBox



        #region LinkButton Command to Details of referenced entities


        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default> LaunchSolution_1DetailsViewCommand { get; protected set; }

        protected void LaunchSolution_1DetailsView(MSBuildExtensionPack.DataSourceEntities.Build.Default item)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(item.SolutionId));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LaunchDetailsViewCommand.Execute(null);
        }



        #endregion LinkButton Command to Details of referenced entities

        public override void Cleanup()
        {
        }
    }
}


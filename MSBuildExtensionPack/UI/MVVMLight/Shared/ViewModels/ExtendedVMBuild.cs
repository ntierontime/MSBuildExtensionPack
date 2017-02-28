using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;

namespace MSBuildExtensionPack.ViewModels
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

        public ObservableCollection<Framework.NameValuePair> m_DropDownContentsOfSolution_1 = new ObservableCollection<Framework.NameValuePair>();

        public ObservableCollection<Framework.NameValuePair> DropDownContentsOfSolution_1
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

#if WINDOWS_PHONE
        public Framework.NameValuePair m_DropDownContentsOfSolution_1SelectedItem;
        /// <summary>
        /// For Windows Phone PickList for now only
        /// </summary>
        public Framework.NameValuePair DropDownContentsOfSolution_1SelectedItem 
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
                RaisePropertyChanged("DropDownContentsOfSolution_1SelectedItem");
            }
        }

        private System.Int32 ParseDropDownContentsOfSolution_1SelectedItem()
        {
            if (this.m_DropDownContentsOfSolution_1SelectedItem == null)
            {
                return default(System.Int32);
            }
            else
            {
                return this.m_DropDownContentsOfSolution_1SelectedItem.ParseToSystemInt32(this.DropDownContentsOfSolution_1[0].Value);
            }
        }
#endif

        public RelayCommand<Framework.NameValuePair> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }
//#if NETFX_CORE
//        public RelayCommand<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }
//#else
//        public RelayCommand<System.Windows.Controls.SelectionChangedEventArgs> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }
//#endif

        public RelayCommand GetDropDownContentsOfSolution_1Command { get; private set; }
        public void GetDropDownContentsOfSolution_1()
        {
            MSBuildExtensionPack.WcfContracts.ISolutionServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceSolution();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
                try
                {
#if WINDOWS_PHONE
                    DispatcherHelper.Initialize();
#endif
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
                    {
                        var responseMessage = _Instance.EndGetCollectionOfNameValuePairOfAll(result);
                        Framework.NameValueCollection collection = responseMessage.Message;
                        this.DropDownContentsOfSolution_1.Clear();
                        if (collection != null)
                        {
                            foreach (Framework.NameValuePair item in collection)
                            {
                                this.DropDownContentsOfSolution_1.Add(item);
                            }
                        }
                    });
                }
                catch (Exception ex)
                {

                }
            };

            try
            {
                MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll()
                {
                    Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(),
                    QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(-1, -1),
                    QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection(null),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
                };

                _Instance.BeginGetCollectionOfNameValuePairOfAll(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {

            }
        }

		#endregion Commands for Cascading ComboBox



        #region LinkButton Command to Details of referenced entities


        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.Build.Default> LaunchSolution_1DetailsViewCommand { get; protected set; }

        protected void LaunchSolution_1DetailsView(MSBuildExtensionPack.DataSourceEntities.Build.Default item)
        {
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMSolution_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(item.SolutionId));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMSolution_Static.LaunchDetailsViewCommand.Execute(null);
        }



        #endregion LinkButton Command to Details of referenced entities

        public override void Cleanup()
        {
        }
    }
}


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
    public class ExtendedVMBuildLog: GalaSoft.MvvmLight.ViewModelBase
    {
        #region constructor

        public ExtendedVMBuildLog()
			: base()
        {

		#region Commands for Cascading ComboBox

            this.GetDropDownContentsOfBuildEventCode_1Command = new RelayCommand(this.GetDropDownContentsOfBuildEventCode_1);

            this.GetDropDownContentsOfSolution_1Command = new RelayCommand(this.GetDropDownContentsOfSolution_1);


            this.GetDropDownContentsOfSolution_1SelectionChangedCommand = new RelayCommand<Framework.NameValuePair>(this.GetDropDownContentsOfBuild_1);
//#if NETFX_CORE
//            this.GetDropDownContentsOfSolution_1SelectionChangedCommand = new RelayCommand<Windows.UI.Xaml.Controls.SelectionChangedEventArgs>(
//                (e) =>
//                {
//                    if (e.AddedItems.Count > 0)
//                    {
//                        Framework.NameValuePair item = (Framework.NameValuePair)e.AddedItems[0];
//                        this.GetDropDownContentsOfBuild_1(item);
//                    }
//                });
//#else
//            this.GetDropDownContentsOfSolution_1SelectionChangedCommand = new RelayCommand<System.Windows.Controls.SelectionChangedEventArgs>(
//                (e) =>
//                {
//                    if (e.AddedItems.Count > 0)
//                    {
//                        Framework.NameValuePair item = (Framework.NameValuePair)e.AddedItems[0];
//                        this.GetDropDownContentsOfBuild_1(item);
//                    }
//                });
//#endif


		#endregion Commands for Cascading ComboBox



            #region Commands for LinkedButton in List


            this.LaunchBuild_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchBuild_1DetailsView);


            this.LaunchSolution_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchSolution_1DetailsView);


            this.LaunchBuildEventCode_1DetailsViewCommand = new RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>(this.LaunchBuildEventCode_1DetailsView);



            #endregion Commands for LinkedButton in List
        }

        #endregion constructor


		#region Commands for Cascading ComboBox

        public ObservableCollection<Framework.NameValuePair> m_DropDownContentsOfBuildEventCode_1 = new ObservableCollection<Framework.NameValuePair>();

        public ObservableCollection<Framework.NameValuePair> DropDownContentsOfBuildEventCode_1
        {
            get
            {
                return this.m_DropDownContentsOfBuildEventCode_1;
            }
            set
            {
                if (this.m_DropDownContentsOfBuildEventCode_1 == value)
                {
                    return;
                }

                this.m_DropDownContentsOfBuildEventCode_1 = value;
                RaisePropertyChanged("DropDownContentsOfBuildEventCode_1");
            }
        }

#if WINDOWS_PHONE
        public Framework.NameValuePair m_DropDownContentsOfBuildEventCode_1SelectedItem;
        /// <summary>
        /// For Windows Phone PickList for now only
        /// </summary>
        public Framework.NameValuePair DropDownContentsOfBuildEventCode_1SelectedItem 
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
                RaisePropertyChanged("DropDownContentsOfBuildEventCode_1SelectedItem");
            }
        }

        private System.Int32 ParseDropDownContentsOfBuildEventCode_1SelectedItem()
        {
            if (this.m_DropDownContentsOfBuildEventCode_1SelectedItem == null)
            {
                return default(System.Int32);
            }
            else
            {
                return this.m_DropDownContentsOfBuildEventCode_1SelectedItem.ParseToSystemInt32(this.DropDownContentsOfBuildEventCode_1[0].Value);
            }
        }
#endif

        public RelayCommand<Framework.NameValuePair> GetDropDownContentsOfBuildEventCode_1SelectionChangedCommand { get; private set; }
//#if NETFX_CORE
//        public RelayCommand<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> GetDropDownContentsOfBuildEventCode_1SelectionChangedCommand { get; private set; }
//#else
//        public RelayCommand<System.Windows.Controls.SelectionChangedEventArgs> GetDropDownContentsOfBuildEventCode_1SelectionChangedCommand { get; private set; }
//#endif

        public RelayCommand GetDropDownContentsOfBuildEventCode_1Command { get; private set; }
        public void GetDropDownContentsOfBuildEventCode_1()
        {
            MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

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
                        this.DropDownContentsOfBuildEventCode_1.Clear();
                        if (collection != null)
                        {
                            foreach (Framework.NameValuePair item in collection)
                            {
                                this.DropDownContentsOfBuildEventCode_1.Add(item);
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
                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll()
                {
                    Critieria = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(),
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
        public ObservableCollection<Framework.NameValuePair> m_DropDownContentsOfBuild_1 = new ObservableCollection<Framework.NameValuePair>();

        public ObservableCollection<Framework.NameValuePair> DropDownContentsOfBuild_1
        {
            get
            {
                return this.m_DropDownContentsOfBuild_1;
            }
        }

#if WINDOWS_PHONE
        public Framework.NameValuePair m_DropDownContentsOfBuild_1SelectedItem;
        /// <summary>
        /// For Windows Phone PickList for now only
        /// </summary>
        public Framework.NameValuePair DropDownContentsOfBuild_1SelectedItem 
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
                RaisePropertyChanged("DDropDownContentsOfBuild_1SelectedItem");
            }
        }

        private System.Int64 ParseDropDownContentsOfBuild_1SelectedItem()
        {
            if (this.m_DropDownContentsOfBuild_1SelectedItem == null)
            {
                return default(System.Int64);
            }
            else
            {
                return this.m_DropDownContentsOfBuild_1SelectedItem.ParseToSystemInt64(this.DropDownContentsOfBuild_1[0].Value);
            }
        }
#endif

        public void GetDropDownContentsOfBuild_1(Framework.NameValuePair input)
        {
            MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier parentIdentifier = MSBuildExtensionPack.EntityContracts.ISolutionIdentifierHelper.Create<MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier>(input.Value);

            MSBuildExtensionPack.WcfContracts.IBuildServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuild();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
                try
                {
#if WINDOWS_PHONE
                    DispatcherHelper.Initialize();
#endif
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
                    {
                        var responseMessage = _Instance.EndGetCollectionOfNameValuePairOfByFKOnly(result);
                        Framework.NameValueCollection collection = responseMessage.Message;
                        this.DropDownContentsOfBuild_1.Clear();
                        if (collection != null)
                        {
                            foreach (Framework.NameValuePair item in collection)
                            {
                                this.DropDownContentsOfBuild_1.Add(item);
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
                MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly()
                {
                    Critieria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(true,parentIdentifier.Id),
                    QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(-1, -1),
                    QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection(null),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
                };

                _Instance.BeginGetCollectionOfNameValuePairOfByFKOnly(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {

            }
        }

		#endregion Commands for Cascading ComboBox



        #region LinkButton Command to Details of referenced entities


        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchBuild_1DetailsViewCommand { get; protected set; }

        protected void LaunchBuild_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMBuild_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.BuildIdentifier(item.BuildId));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMBuild_Static.LaunchDetailsViewCommand.Execute(null);
        }


        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchSolution_1DetailsViewCommand { get; protected set; }

        protected void LaunchSolution_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMSolution_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(item.Solution_1Id));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMSolution_Static.LaunchDetailsViewCommand.Execute(null);
        }


        public RelayCommand<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> LaunchBuildEventCode_1DetailsViewCommand { get; protected set; }

        protected void LaunchBuildEventCode_1DetailsView(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item)
        {
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode_Static.LoadItem(new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier(item.BuildEventCodeId));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode_Static.LaunchDetailsViewCommand.Execute(null);
        }



        #endregion LinkButton Command to Details of referenced entities

        public override void Cleanup()
        {
        }
    }
}


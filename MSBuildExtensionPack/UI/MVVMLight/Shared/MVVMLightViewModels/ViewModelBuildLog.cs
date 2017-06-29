using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{

    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// After 2014-01-31 is Asyncronized Wcf Method call
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>WPCommonOfBuildLogVM
    public class WPCommonOfBuildLogVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
    {
        #region override string EntityName and ViewName

        public const string EntityName_Static = "MSBuildExtensionPack.BuildLog";

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        public const string ViewName_Static = "WPCommonOfBuildLogVM";

        public override string ViewName
        {
            get
            {
                return ViewName_Static;
            }
        }

        #endregion override string EntityName and ViewName

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the WPCommonOfBuildLog class.
        /// </summary>
        public WPCommonOfBuildLogVM()
        {
            this.EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>();

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real": Connect to service, etc...
            ////}
        }

        #endregion Constructor

        #region ClearSearchResult

        /// <summary>
        /// Clears the search result in this.EntityCollection.
        /// </summary>
        protected override void ClearSearchResult()
        {
            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.ClearResult;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            this.m_EntityCollectionDefault.Clear();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        #endregion ClearSearchResult

        #region Implement abstract Search

        protected override void Search()
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                if (this.QueryPagingSetting != null && this.QueryPagingSetting.CurrentPage == 0)
                {
                    this.QueryPagingSetting.CurrentPage = 1;
                }

                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM();
                vmData.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten(this.Criteria);
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);


				//TO-DO:
                var result = Task.Run(() => client.GetWPCommonOfBuildLogVMAsync(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (this.m_EntityCollectionDefault == null)
                        {
                            this.m_EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>();
                        }
                        else
                        {
                            this.m_EntityCollectionDefault.Clear();
                        }

                        if (result.Result != null)
                        {
                            foreach (var item in result.Result)
                            {
                                this.m_EntityCollectionDefault.Add(item);
                            }
                        }

                        this.QueryPagingSetting = result.QueryPagingSetting;
                        this.OriginalQueryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
                        this.QueryOrderBySettingCollection = result.QueryOrderBySettingCollection;
                    }
                    else
                    {
                        this.StatusMessageOfResult = result.StatusMessageOfResult;
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }

        #endregion Implement abstract Search

        public void SearchForUnitTest()
        {
            this.Search();
        }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Build_1_Name~ASC", "Build_1_Name A-Z");
					list.Add("Build_1_Name~DESC", "Build_1_Name Z-A");
            return list;
        }
    }


}



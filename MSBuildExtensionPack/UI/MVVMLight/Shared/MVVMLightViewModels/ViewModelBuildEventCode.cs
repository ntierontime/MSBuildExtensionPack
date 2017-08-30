using System;
using System.Linq;
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
    /// </summary>
    public class WPCommonOfBuildEventCodeVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>
    {
        #region override string EntityName and ViewName

        public const string EntityName_Static = "MSBuildExtensionPack.BuildEventCode";

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        public const string ViewName_Static = "WPCommonOfBuildEventCodeVM";

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
        /// Initializes a new instance of the WPCommonOfBuildEventCode class.
        /// </summary>
        public WPCommonOfBuildEventCodeVM()
        {
            this.EntityCollection = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>();

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

            this.m_EntityCollection.Clear();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        #endregion ClearSearchResult

        protected override void DoSearch(bool isToClearExistingResult)
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM();
                vmData.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten(this.Criteria);
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.BuildEventCodeApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPCommonOfBuildEventCodeVMAsync(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (isToClearExistingResult)
                        {
                            this.EntityCollection = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(result.Result.ToList());
                        }
                        else
                        {
                            if (this.EntityCollection == null)
                            {
                                this.EntityCollection = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>();
                            }

                            foreach (var item in result.Result)
                            {
                                this.EntityCollection.Add(item);
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

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("EventCode~ASC", "EventCode A-Z");
                    list.Add("EventCode~DESC", "EventCode Z-A");
            return list;
        }
    }

}


using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

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
    public class WPCommonOfBuildVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildCollection, MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.Build.Default>
    {
        #region override string EntityName and ViewName

        public const string EntityName_Static = "MSBuildExtensionPack.Build";

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        public const string ViewName_Static = "WPCommonOfBuildVM";

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
        /// Initializes a new instance of the WPCommonOfBuild class.
        /// </summary>
        public WPCommonOfBuildVM()
        {
            this.EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.Default>();

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

                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM();
                vmData.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten(this.Criteria);
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);

                var resultVMData = client.GetWPCommonOfBuildVMAsync(vmData);
                var result = resultVMData.Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (this.m_EntityCollectionDefault == null)
                        {
                            this.m_EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.Default>();
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

                        this.QueryPagingSetting = resultVMData.Result.QueryPagingSetting;
                        this.OriginalQueryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
                        this.QueryOrderBySettingCollection = resultVMData.Result.QueryOrderBySettingCollection;
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

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Solution_1_Name~ASC", "Solution_1_Name A-Z");
					list.Add("Solution_1_Name~DESC", "Solution_1_Name Z-A");
            return list;
        }
    }


}



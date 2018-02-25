using System;
using System.Linq;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class WPxTabSomethingOfBuildVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaFKStringContains, MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection, MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation>
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

        public const string ViewName_Static = "WPxTabSomethingOfBuildVM";

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
        /// Initializes a new instance of the WPxTabSomethingOfBuildVM class.
        /// </summary>
        public WPxTabSomethingOfBuildVM()
        {
            this.EntityCollection = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation>();

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
                var vmData = new MSBuildExtensionPack.ViewModelData.WPxTabSomethingOfBuildVM();
                vmData.Criteria = this.Criteria;
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPxTabSomethingOfBuildVMAsync(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (this.EntityCollection == null)
                        {
                            this.EntityCollection = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation>();
                        }
                        if (isToClearExistingResult)
                        {
                            this.EntityCollection = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation>(result.Result.ToList());
                        }
                        else
                        {
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
            list.Add("Name~ASC", "Name A-Z");
        list.Add("Name~DESC", "Name Z-A");
            return list;
        }
    }
}


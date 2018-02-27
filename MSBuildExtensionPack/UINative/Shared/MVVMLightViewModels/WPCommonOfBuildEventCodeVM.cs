using System;
using System.Linq;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class WPCommonOfBuildEventCodeVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.BuildEventCode";

        public override string EntityName { get { return EntityName_Static; } }

        public const string ViewName_Static = "WPCommonOfBuildEventCodeVM";

        public override string ViewName { get { return ViewName_Static; } }

        /// <summary>
        /// Initializes a new instance of the WPCommonOfBuildEventCodeVM class.
        /// </summary>
        public WPCommonOfBuildEventCodeVM()
        {
            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>();

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real": Connect to service, etc...
            ////}
        }

        protected override void DoSearch(bool isToClearExistingResult)
        {

            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM();
                vmData.Criteria = this.Criteria;
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
                        if (this.Result == null)
                        {
                            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>();
                        }
                        if (isToClearExistingResult)
                        {
                            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(result.Result.ToList());
                        }
                        else
                        {
                            foreach (var item in result.Result)
                            {
                                this.Result.Add(item);
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

        /// <summary>
        /// Clears the search result in this.Result.
        /// </summary>
        protected override void ClearSearchResult()
        {
            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.ClearResult;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            this.m_Result.Clear();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
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


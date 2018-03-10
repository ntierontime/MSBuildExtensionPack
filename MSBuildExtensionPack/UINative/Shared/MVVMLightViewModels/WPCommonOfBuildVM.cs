using System;
using System.Linq;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class WPCommonOfBuildVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.Build.Default>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Build";

        public override string EntityName { get { return EntityName_Static; } }

        public const string ViewName_Static = "WPCommonOfBuildVM";

        public override string ViewName { get { return ViewName_Static; } }

        /// <summary>
        /// Initializes a new instance of the WPCommonOfBuildVM class.
        /// </summary>
        public WPCommonOfBuildVM()
        {
            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.Default>();

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
#if (XAMARIN)
            Criteria.Common.Organization_2Id.NullableValueToCompare = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem != null ? MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_2SelectedItem.Value : default(System.Int64?);
            Criteria.Common.Organization_1Id.NullableValueToCompare = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem != null ? MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfOrganization_1SelectedItem.Value : default(System.Int64?);
            Criteria.Common.SolutionId.NullableValueToCompare = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem != null ? MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.DropDownContentsOfSolution_1SelectedItem.Value : default(System.Int32?);

#endif

            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM();
                vmData.Criteria = this.Criteria;
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPCommonOfBuildVMAsync(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (this.Result == null)
                        {
                            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.Default>();
                        }
                        if (isToClearExistingResult)
                        {
                            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Build.Default>(result.Result.ToList());
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
            list.Add("Solution_1_Name~ASC", "Solution_1_Name A-Z");
        list.Add("Solution_1_Name~DESC", "Solution_1_Name Z-A");
            return list;
        }
    }
}


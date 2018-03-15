using System;
using System.Linq;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class WPCommonOfSolutionVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.Solution.Default>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Solution";

        public override string EntityName { get { return EntityName_Static; } }

        public const string ViewName_Static = "WPCommonOfSolutionVM";

        public override string ViewName { get { return ViewName_Static; } }

        /// <summary>
        /// Initializes a new instance of the WPCommonOfSolutionVM class.
        /// </summary>
        public WPCommonOfSolutionVM()
        {
            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Solution.Default>();

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
            Criteria.Common.Organization_2Id.NullableValueToCompare = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution_Static.DropDownContentsOfOrganization_2SelectedItem != null ? MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution_Static.DropDownContentsOfOrganization_2SelectedItem.Value : default(System.Int64?);
            Criteria.Common.OrganizationId.NullableValueToCompare = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution_Static.DropDownContentsOfOrganization_1SelectedItem != null ? MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution_Static.DropDownContentsOfOrganization_1SelectedItem.Value : default(System.Guid?);

#endif

            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM();
                vmData.Criteria = this.Criteria;
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.SolutionApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPCommonOfSolutionVMAsync(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (this.Result == null)
                        {
                            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Solution.Default>();
                        }
                        if (isToClearExistingResult)
                        {
                            this.Result = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Solution.Default>(result.Result.ToList());
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
            list.Add("Organization_1_Name~ASC", "Organization_1_Name A-Z");
        list.Add("Organization_1_Name~DESC", "Organization_1_Name Z-A");
            return list;
        }
    }
}


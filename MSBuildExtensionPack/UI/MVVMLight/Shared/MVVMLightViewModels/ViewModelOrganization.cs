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
    public class WPCommonOfOrganizationVM
        : Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.Organization.Default>
    {
        #region override string EntityName and ViewName

        public const string EntityName_Static = "MSBuildExtensionPack.Organization";

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        public const string ViewName_Static = "WPCommonOfOrganizationVM";

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
        /// Initializes a new instance of the WPCommonOfOrganization class.
        /// </summary>
        public WPCommonOfOrganizationVM()
        {
            this.EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Organization.Default>();

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

        protected override void DoSearch(bool isToClearExistingResult)
        {
#if (XAMARIN)
            Criteria.OrganizationQueryCriteriaCommon.IdCommonOfOrganization_2.NullableValueToCompare = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem != null ? MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static.DropDownContentsOfOrganization_2SelectedItem.Value : default(System.Int64);

#endif

            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM();
                vmData.Criteria = this.Criteria;
                vmData.QueryPagingSetting = this.QueryPagingSetting;
                vmData.QueryOrderBySettingCollection = this.QueryOrderBySettingCollection;

                var client = new MSBuildExtensionPack.WebApiClient.OrganizationApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPCommonOfOrganizationVMAsync(vmData)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfResult = result.StatusOfResult;
                    if (result.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        if (this.EntityCollectionDefault == null)
                        {
                            this.EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Organization.Default>();
                        }
                        if (isToClearExistingResult)
                        {
                            this.EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.Organization.Default>(result.Result.ToList());
                        }

                        foreach (var item in result.Result)
                        {
                            this.EntityCollectionDefault.Add(item);
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
            list.Add("Organization_2_Name~ASC", "Organization_2_Name A-Z");
                    list.Add("Organization_2_Name~DESC", "Organization_2_Name Z-A");
            return list;
        }
    }

}


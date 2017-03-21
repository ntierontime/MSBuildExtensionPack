using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.ViewModels
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
    public class WPCommonOfBuildLogVM
		: Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
    {
        #region fields and properties

        public const string EntityName_Static = "WPCommonOfBuildLogVM";
		
        #endregion fields and properties
		
        #region Implement abstract EntityName

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        #endregion Implement abstract EntityName

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ViewModelBuildLog class.
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
			string viewName = ViewName_SearchResult;
			Framework.UIAction uiAction = Framework.UIAction.ClearResult;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            this.m_EntityCollectionDefault.Clear();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        #endregion ClearSearchResult

#if WINDOWS_PHONE
        /// <summary>
        /// Set entity property value from Selected value which parse from selected item.
        /// </summary>
        /// <param name="entity">The entity.</param>
        private void AssignSelectedValueFromSelectedItemToEntity(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default entity)
        {
            entity.BuildEventCodeId = this.ParseDropDownContentsOfBuildEventCode_1SelectedItem();
            entity.Solution_1Id = this.ParseDropDownContentsOfSolution_1SelectedItem();
            entity.BuildId = this.ParseDropDownContentsOfBuild_1SelectedItem();

        }	
#endif
#if WINDOWS_PHONE
		private void AssignSelectedValueFromSelectedItemToCritieriaOfDefault()
        {
            this.m_Criteria.BuildLogQueryCriteriaCommon.IdCommonOfBuildEventCode_1.ValueToCompare = this.ParseDropDownContentsOfBuildEventCode_1SelectedItem();
            this.m_Criteria.BuildLogQueryCriteriaCommon.IdCommonOfSolution_1.ValueToCompare = this.ParseDropDownContentsOfSolution_1SelectedItem();
            this.m_Criteria.BuildLogQueryCriteriaCommon.IdCommonOfBuild_1.ValueToCompare = this.ParseDropDownContentsOfBuild_1SelectedItem();
			
        }
#endif

        #region Implement abstract Search

        protected override void Search()
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            #region Asyncronized wcf method call

            string viewName = ViewName_SearchResult;
            Framework.UIAction uiAction = Framework.UIAction.Search;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						var responseMessage = _Instance.EndGetCollectionOfDefaultOfCommon(result);
						MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection collection = responseMessage.Message;

						if (this.m_EntityCollectionDefault == null)
						{
							this.m_EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>();
						}
                        else
                        {
							if(this.m_EntityCollectionDefault.Count > 0)
								this.m_EntityCollectionDefault.Clear();
                        }

#if WINDOWS_PHONE
                        if (this.IsToClearExistingCollection)
                        {
							if(this.m_EntityCollectionDefault.Count > 0)
								this.m_EntityCollectionDefault.Clear();
                        }
#endif

						if (collection != null)
						{
							foreach (MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item in collection)
							{
								this.m_EntityCollectionDefault.Add(item);
						    }
						}


                        if (responseMessage.QueryPagingResult != null)
                        {
                            this.QueryPagingSetting = GetQueryPagingSettingFromQueryPagingResult(responseMessage.QueryPagingResult);

#if WINDOWS_PHONE
                            if (!this.IsToClearExistingCollection && this.QueryPagingSetting.CurrentPage <= this.QueryPagingSetting.CountOfPages)
                            {
                                this.QueryPagingSetting.CurrentPage++;
                            }
#endif
                        }

                        this.SearchStatus = Framework.EntityContracts.SearchStatus.SearchResultLoaded;

						Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
				}
                catch (Exception ex)
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
                    });
                }
            };

            try
            {
#if WINDOWS_PHONE
				this.AssignSelectedValueFromSelectedItemToCritieriaOfDefault();
#endif
                if (this.QueryPagingSetting != null && this.QueryPagingSetting.CurrentPage == 0)
                {
                    this.QueryPagingSetting.CurrentPage = 1;
                }
                MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon()
				{
					Critieria = this.Criteria,
					QueryPagingSetting = this.QueryPagingSetting,
					QueryOrderBySettingCollection = this.QueryOrderBySettingCollection,
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
				};

                _Instance.BeginGetCollectionOfDefaultOfCommon(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            if (this.m_EntityCollection == null)
            {
                this.m_EntityCollectionDefault = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>();
            }

            this.m_EntityCollectionDefault.Clear();

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection collection = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(m_CriteriaOfGetCollectionOfDefaultOfCommon, this.m_QueryPagingSetting, this.m_QueryOrderBySettingCollection);
            if(collection != null)
            {
                foreach (MSBuildExtensionPack.DataSourceEntities.BuildLog.Default item in collection)
                {
                    this.m_EntityCollectionDefault.Add(item);
                }
            }
            */
            #endregion Syncronized wcf method call -- not in use/WPF only
        }

#if WINDOWS_PHONE
        ///// <summary>
        ///// Assigns the selected value from selected item to critieria of get collection of default of common.
		///// -- Please Implement for Windows Phone 71.
        ///// </summary>
        ////private void AssignSelectedValueFromSelectedItemToCritieriaOfGetCollectionOfDefaultOfCommon()
        //{
		//	// this.m_CriteriaOfGetCollectionOfDefaultOfCommon
        //}
#endif

        #endregion Implement abstract Search

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Build_1_Name~ASC", "Build_1_Name A-Z");
					list.Add("Build_1_Name~DESC", "Build_1_Name Z-A");
            return list;
        }
    }


}



using System;
using System.Linq;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    public class WPxTabFullDetailsOfBuildVM
        : Framework.Xaml.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier, MSBuildExtensionPack.EntityContracts.IBuildIdentifier>
    {
        public const string EntityName_Static = "MSBuildExtensionPack.Build";
        public override string EntityName { get { return EntityName_Static; } }

        public const string ViewName_Static = "WPxTabFullDetailsOfBuildVM";
        public override string ViewName { get { return ViewName_Static; } }

        public WPxTabFullDetailsOfBuildVM()
        {
            this.CriteriaOfMasterEntity = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier();

            this.FK_BuildLog_Build = new ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation>();

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real": Connect to service, etc...
            ////}
        }

        public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier m_CriteriaOfSolution_1;
        public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier CriteriaOfSolution_1
        {
            get
            {
                return this.m_CriteriaOfSolution_1;
            }
            set
            {
                if (this.m_CriteriaOfSolution_1 != value)
                {
                    this.m_CriteriaOfSolution_1 = value;
                    RaisePropertyChanged("CriteriaOfSolution_1");
                }
            }
        }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus m_StatusOfSolution_1;
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1
        {
            get
            {
                return this.m_StatusOfSolution_1;
            }
            set
            {
                if (this.m_StatusOfSolution_1 != value)
                {
                    this.m_StatusOfSolution_1 = value;
                    RaisePropertyChanged("StatusOfSolution_1");
                }
            }
        }
        public string m_StatusMessageOfSolution_1;
        public string StatusMessageOfSolution_1
        {
            get
            {
                return this.m_StatusMessageOfSolution_1;
            }
            set
            {
                if (this.m_StatusMessageOfSolution_1 != value)
                {
                    this.m_StatusMessageOfSolution_1 = value;
                    RaisePropertyChanged("StatusMessageOfSolution_1");
                }
            }
        }
        public MSBuildExtensionPack.DataSourceEntities.Solution.Default m_Solution_1;
        public MSBuildExtensionPack.DataSourceEntities.Solution.Default Solution_1
        {
            get
            {
                return this.m_Solution_1;
            }
            set
            {
                if (this.m_Solution_1 != value)
                {
                    this.m_Solution_1 = value;
                    RaisePropertyChanged("Solution_1");
                }
            }
        }

        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier m_CriteriaOfOrganization_1;
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier CriteriaOfOrganization_1
        {
            get
            {
                return this.m_CriteriaOfOrganization_1;
            }
            set
            {
                if (this.m_CriteriaOfOrganization_1 != value)
                {
                    this.m_CriteriaOfOrganization_1 = value;
                    RaisePropertyChanged("CriteriaOfOrganization_1");
                }
            }
        }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus m_StatusOfOrganization_1;
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_1
        {
            get
            {
                return this.m_StatusOfOrganization_1;
            }
            set
            {
                if (this.m_StatusOfOrganization_1 != value)
                {
                    this.m_StatusOfOrganization_1 = value;
                    RaisePropertyChanged("StatusOfOrganization_1");
                }
            }
        }
        public string m_StatusMessageOfOrganization_1;
        public string StatusMessageOfOrganization_1
        {
            get
            {
                return this.m_StatusMessageOfOrganization_1;
            }
            set
            {
                if (this.m_StatusMessageOfOrganization_1 != value)
                {
                    this.m_StatusMessageOfOrganization_1 = value;
                    RaisePropertyChanged("StatusMessageOfOrganization_1");
                }
            }
        }
        public MSBuildExtensionPack.DataSourceEntities.Organization.Default m_Organization_1;
        public MSBuildExtensionPack.DataSourceEntities.Organization.Default Organization_1
        {
            get
            {
                return this.m_Organization_1;
            }
            set
            {
                if (this.m_Organization_1 != value)
                {
                    this.m_Organization_1 = value;
                    RaisePropertyChanged("Organization_1");
                }
            }
        }

        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier m_CriteriaOfOrganization_2;
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier CriteriaOfOrganization_2
        {
            get
            {
                return this.m_CriteriaOfOrganization_2;
            }
            set
            {
                if (this.m_CriteriaOfOrganization_2 != value)
                {
                    this.m_CriteriaOfOrganization_2 = value;
                    RaisePropertyChanged("CriteriaOfOrganization_2");
                }
            }
        }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus m_StatusOfOrganization_2;
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_2
        {
            get
            {
                return this.m_StatusOfOrganization_2;
            }
            set
            {
                if (this.m_StatusOfOrganization_2 != value)
                {
                    this.m_StatusOfOrganization_2 = value;
                    RaisePropertyChanged("StatusOfOrganization_2");
                }
            }
        }
        public string m_StatusMessageOfOrganization_2;
        public string StatusMessageOfOrganization_2
        {
            get
            {
                return this.m_StatusMessageOfOrganization_2;
            }
            set
            {
                if (this.m_StatusMessageOfOrganization_2 != value)
                {
                    this.m_StatusMessageOfOrganization_2 = value;
                    RaisePropertyChanged("StatusMessageOfOrganization_2");
                }
            }
        }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation m_Organization_2;
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_2
        {
            get
            {
                return this.m_Organization_2;
            }
            set
            {
                if (this.m_Organization_2 != value)
                {
                    this.m_Organization_2 = value;
                    RaisePropertyChanged("Organization_2");
                }
            }
        }

        public MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaFKOnly m_CriteriaOfFK_BuildLog_Build;
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaFKOnly CriteriaOfFK_BuildLog_Build
        {
            get
            {
                return this.m_CriteriaOfFK_BuildLog_Build;
            }
            set
            {
                if (this.m_CriteriaOfFK_BuildLog_Build != value)
                {
                    this.m_CriteriaOfFK_BuildLog_Build = value;
                    RaisePropertyChanged("CriteriaOfFK_BuildLog_Build");
                }
            }
        }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus m_StatusOfFK_BuildLog_Build;
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_Build
        {
            get
            {
                return this.m_StatusOfFK_BuildLog_Build;
            }
            set
            {
                if (this.m_StatusOfFK_BuildLog_Build != value)
                {
                    this.m_StatusOfFK_BuildLog_Build = value;
                    RaisePropertyChanged("StatusOfFK_BuildLog_Build");
                }
            }
        }
        public string m_StatusMessageOfFK_BuildLog_Build;
        public string StatusMessageOfFK_BuildLog_Build
        {
            get
            {
                return this.m_StatusMessageOfFK_BuildLog_Build;
            }
            set
            {
                if (this.m_StatusMessageOfFK_BuildLog_Build != value)
                {
                    this.m_StatusMessageOfFK_BuildLog_Build = value;
                    RaisePropertyChanged("StatusMessageOfFK_BuildLog_Build");
                }
            }
        }
        public ObservableCollection<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> FK_BuildLog_Build { get; private set; }

        protected override MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier GetCriteria(MSBuildExtensionPack.EntityContracts.IBuildIdentifier o)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier();
             criteria.Identifier.Id.NullableValueToCompare = (System.Int64)o.Id;
            return criteria;
        }

        protected override void DoSearch()
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            string viewName = ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Search;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            try
            {
                var vmData = new MSBuildExtensionPack.ViewModelData.WPxTabFullDetailsOfBuildVM();
                vmData.CriteriaOfMasterEntity = this.CriteriaOfMasterEntity;
                vmData.QueryPagingSetting = this.QueryPagingSetting;

                var client = new MSBuildExtensionPack.WebApiClient.BuildApiControllerClient(MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl);
                var result = Task.Run(() => client.GetWPxTabFullDetailsOfBuildVMAsync((System.Int64)vmData.CriteriaOfMasterEntity.Identifier.Id.ValueToCompare)).Result;

                var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                {
                    this.StatusOfMasterEntity = result.StatusOfMasterEntity;
                    this.StatusMessageOfMasterEntity = result.StatusMessageOfMasterEntity;
                    if (result.StatusOfMasterEntity == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
                    {
                        // 1. MasterEntity
                        this.MasterEntity = result.MasterEntity;
                        this.CriteriaOfMasterEntity = result.CriteriaOfMasterEntity;

                        // 2. Ancestors

                        this.CriteriaOfSolution_1 = result.CriteriaOfSolution_1;
                        this.StatusOfSolution_1 = result.StatusOfSolution_1;
                        this.StatusMessageOfSolution_1 = vmData.StatusMessageOfSolution_1;
                        this.Solution_1 = result.Solution_1;

                        this.CriteriaOfOrganization_1 = result.CriteriaOfOrganization_1;
                        this.StatusOfOrganization_1 = result.StatusOfOrganization_1;
                        this.StatusMessageOfOrganization_1 = vmData.StatusMessageOfOrganization_1;
                        this.Organization_1 = result.Organization_1;

                        this.CriteriaOfOrganization_2 = result.CriteriaOfOrganization_2;
                        this.StatusOfOrganization_2 = result.StatusOfOrganization_2;
                        this.StatusMessageOfOrganization_2 = vmData.StatusMessageOfOrganization_2;
                        this.Organization_2 = result.Organization_2;

                        // 3. Children

                        this.CriteriaOfFK_BuildLog_Build = result.CriteriaOfFK_BuildLog_Build;
                        this.StatusOfFK_BuildLog_Build = result.StatusOfFK_BuildLog_Build;
                        this.StatusMessageOfFK_BuildLog_Build = result.StatusMessageOfFK_BuildLog_Build;
                        this.FK_BuildLog_Build.Clear();
                        if (result.FK_BuildLog_Build != null &&
                        (result.StatusOfFK_BuildLog_Build == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK ||
                        result.StatusOfFK_BuildLog_Build == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady))
                        {
                            foreach (var _FK_BuildLog_BuildItem in result.FK_BuildLog_Build)
                            {
                                this.FK_BuildLog_Build.Add(_FK_BuildLog_BuildItem);
                            }
                        }

                    }
                    else
                    {
                    }
                });
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Framework.Xaml
{
    public abstract class ViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity, TIdentifier>
        : GalaSoft.MvvmLight.ViewModelBase, Framework.ViewModels.IViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity>
        where TMasterEntity : class, new()
        where TCriteriaOfMasterEntity : class, new()
    {
        #region properties

        public abstract string EntityName { get; }
        public abstract string ViewName { get; }

        public bool SuppressMVVMLightEventToCommandMessage { get; set; }

        public TCriteriaOfMasterEntity m_CriteriaOfMasterEntity;
        public TCriteriaOfMasterEntity CriteriaOfMasterEntity
        {
            get
            {
                return this.m_CriteriaOfMasterEntity;
            }
            set
            {
                if (this.m_CriteriaOfMasterEntity != value)
                {
                    this.m_CriteriaOfMasterEntity = value;
                    RaisePropertyChanged("CriteriaOfMasterEntity");
                }
            }
        }
        public TMasterEntity m_MasterEntity;
        public TMasterEntity MasterEntity
        {
            get
            {
                return this.m_MasterEntity;
            }
            set
            {
                if (this.m_MasterEntity != value)
                {
                    this.m_MasterEntity = value;
                    RaisePropertyChanged("MasterEntity");
                }
            }
        }
        public Framework.EntityContracts.QueryPagingSetting m_QueryPagingSetting;
        public Framework.EntityContracts.QueryPagingSetting QueryPagingSetting
        {
            get
            {
                return this.m_QueryPagingSetting;
            }
            set
            {
                if (this.m_QueryPagingSetting != value)
                {
                    this.m_QueryPagingSetting = value;
                    RaisePropertyChanged("QueryPagingSetting");
                }
            }
        }
        public Framework.EntityContracts.QueryPagingSetting m_QueryPagingSettingOneRecord;
        public Framework.EntityContracts.QueryPagingSetting QueryPagingSettingOneRecord
        {
            get
            {
                return this.m_QueryPagingSettingOneRecord;
            }
            set
            {
                if (this.m_QueryPagingSettingOneRecord != value)
                {
                    this.m_QueryPagingSettingOneRecord = value;
                    RaisePropertyChanged("QueryPagingSettingOneRecord");
                }
            }
        }
        public string m_StatusMessageOfMasterEntity;
        public string StatusMessageOfMasterEntity
        {
            get
            {
                return this.m_StatusMessageOfMasterEntity;
            }
            set
            {
                if (this.m_StatusMessageOfMasterEntity != value)
                {
                    this.m_StatusMessageOfMasterEntity = value;
                    RaisePropertyChanged("StatusMessageOfMasterEntity");
                }
            }
        }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus m_StatusOfMasterEntity;
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfMasterEntity
        {
            get
            {
                return this.m_StatusOfMasterEntity;
            }
            set
            {
                if (this.m_StatusOfMasterEntity != value)
                {
                    this.m_StatusOfMasterEntity = value;
                    RaisePropertyChanged("StatusOfMasterEntity");
                }
            }
        }

        public Framework.EntityContracts.SearchStatus m_SearchStatus;
        public Framework.EntityContracts.SearchStatus SearchStatus
        {
            get
            {
                return this.m_SearchStatus;
            }
            set
            {
                if (this.m_SearchStatus != value)
                {
                    this.m_SearchStatus = value;
                    RaisePropertyChanged("SearchStatus");
                }
            }
        }

        #endregion properties

        public ViewModelEntityRelatedBase()
            : base()
        {
            this.SuppressMVVMLightEventToCommandMessage = false;

            this.m_CriteriaOfMasterEntity =new TCriteriaOfMasterEntity();

            this.LaunchViewCommand = new RelayCommand<TIdentifier>(Launch, CanLaunch);
            this.RefreshViewCommand = new RelayCommand<TIdentifier>(Refresh, CanRefresh);
            this.CloseViewCommand = new RelayCommand(Close, CanClose);
        }

        public RelayCommand<TIdentifier> LaunchViewCommand { get; protected set; }
        protected virtual void Launch(TIdentifier o)
        {
            string viewName = this.ViewName;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            this.CriteriaOfMasterEntity = GetCriteria(o);

            DoSearch();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }
        protected virtual bool CanLaunch(TIdentifier o)
        {
            return true;
        }

        public RelayCommand<TIdentifier> RefreshViewCommand { get; protected set; }
        protected void Refresh(TIdentifier o)
        {
            this.CriteriaOfMasterEntity = GetCriteria(o);
            DoSearch();
        }
        protected virtual bool CanRefresh(TIdentifier o)
        {
            return true;
        }

        public RelayCommand CloseViewCommand { get; protected set; }
        protected void Close()
        {
            string viewName = this.ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Close;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }
        protected virtual bool CanClose()
        {
            return true;
        }

        protected abstract TCriteriaOfMasterEntity GetCriteria(TIdentifier o);
        protected abstract void DoSearch();

        public override void Cleanup()
        {
            base.Cleanup();
            this.m_MasterEntity = new TMasterEntity();
            this.m_CriteriaOfMasterEntity = new TCriteriaOfMasterEntity();
        }
    }
}


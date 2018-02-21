using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.CommonBLLEntities;
using Framework.EntityContracts;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Framework.Xaml
{
    public abstract class ViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity>
        : GalaSoft.MvvmLight.ViewModelBase, Framework.ViewModels.IViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity>
        where TMasterEntity : class, new()
        where TCriteriaOfMasterEntity : class, new()
    {
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
        public QueryPagingSetting m_QueryPagingSetting;
        public QueryPagingSetting QueryPagingSetting
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
        public QueryPagingSetting m_QueryPagingSettingOneRecord;
        public QueryPagingSetting QueryPagingSettingOneRecord
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
        public BusinessLogicLayerResponseStatus m_StatusOfMasterEntity;
        public BusinessLogicLayerResponseStatus StatusOfMasterEntity
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

        public RelayCommand<TCriteriaOfMasterEntity> LaunchDetailsViewCommand { get; protected set; }
        protected virtual void LaunchView(TCriteriaOfMasterEntity o)
        {
            string viewName = this.ViewName;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            this.CriteriaOfMasterEntity = o;

            DoSearch();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand<TCriteriaOfMasterEntity> RefreshViewCommand { get; protected set; }
        protected void Refresh(TCriteriaOfMasterEntity o)
        {
            this.CriteriaOfMasterEntity = o;
            DoSearch();
        }

        public RelayCommand CloseViewCommand { get; protected set; }
        protected void Close()
        {
            string viewName = this.ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Close;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        protected abstract void DoSearch();

        public override void Cleanup()
        {
            base.Cleanup();
            this.m_MasterEntity = new TMasterEntity();
            this.m_CriteriaOfMasterEntity = new TCriteriaOfMasterEntity();
        }
    }
}

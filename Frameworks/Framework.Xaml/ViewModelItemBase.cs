using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Framework.Xaml
{
    public abstract class ViewModelItemBase<TSearchCriteria, TIdentifierContract, TItem>
        : GalaSoft.MvvmLight.ViewModelBase, Framework.ViewModels.IViewModelItemBase<TSearchCriteria, TItem>
        where TSearchCriteria : class, TIdentifierContract, new()
        where TItem : class, TIdentifierContract, Framework.EntityContracts.IClone<TItem>, new()
    {
        public ViewModelItemBase()
            : base()
        {
            this.SuppressMVVMLightEventToCommandMessage = false;

            this.Item = new TItem();

            this.LaunchCopyViewCommand = new RelayCommand<TIdentifierContract>(LaunchCopyView);

            this.LaunchDetailsViewCommand = new RelayCommand<TIdentifierContract>(LaunchDetailsView);
            this.CloseDetailsViewCommand = new RelayCommand(CloseDetailsView);

            this.LaunchEditViewCommand = new RelayCommand<TIdentifierContract>(LaunchEditView);
            this.CloseEditViewCommand = new RelayCommand(CloseEditView);
            this.SaveCommand = new RelayCommand(Save, CanSave);

            this.LaunchCreateViewCommand = new RelayCommand(LaunchCreateView);
            this.CloseCreateViewCommand = new RelayCommand(CloseCreateView);
            this.AddCommand = new RelayCommand(Add, CanAdd);

            this.LaunchDeleteViewCommand = new RelayCommand<TIdentifierContract>(LaunchDeleteView);
            this.CloseDeleteViewCommand = new RelayCommand(CloseDeleteView);
            this.DeleteCommand = new RelayCommand(Delete, CanDelete);

            this.RefreshCurrentItemCommand = new RelayCommand(RefreshItem);

            this.LoadItemCommand = new RelayCommand(this.LoadItem);
            this.LoadItemCommandTyped = new RelayCommand<TSearchCriteria>(this.LoadItem);

            this.RaiseItemPropertyChangedEventCommand = new RelayCommand(this.RaiseItemPropertyChangedEvent);
        }

        #region override properties

        protected TSearchCriteria m_Criteria;
        public TSearchCriteria Criteria
        {
            get { return m_Criteria; }
            set
            {
                m_Criteria = value;
                RaisePropertyChanged("Criteria");
            }
        }

        protected TItem m_Item;
        public TItem Item
        {
            get { return m_Item; }
            set
            {
                m_Item = value != null ? value.GetAClone() : new TItem();
                RaisePropertyChanged("Item");
            }
        }

        protected Framework.EntityContracts.ContentData m_ContentData;
        public Framework.EntityContracts.ContentData ContentData
        {
            get { return m_ContentData; }
            set
            {
                m_ContentData = value;
                RaisePropertyChanged("ContentData");
            }
        }

        protected Framework.EntityContracts.SearchStatus m_SearchStatus;
        public Framework.EntityContracts.SearchStatus SearchStatus
        {
            get { return m_SearchStatus; }
            set
            {
                m_SearchStatus = value;
                RaisePropertyChanged("SearchStatus");
            }
        }

        protected string m_StatusMessageOfResult;
        public string StatusMessageOfResult
        {
            get { return m_StatusMessageOfResult; }
            set
            {
                m_StatusMessageOfResult = value;
                RaisePropertyChanged("StatusMessageOfResult");
            }
        }

        protected Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus m_StatusOfResult;
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfResult
        {
            get { return m_StatusOfResult; }
            set
            {
                m_StatusOfResult = value;
                RaisePropertyChanged("StatusOfResult");
            }
        }

        protected Framework.UIActionStatusMessage m_UIActionStatusMessage;
        public Framework.UIActionStatusMessage UIActionStatusMessage
        {
            get { return m_UIActionStatusMessage; }
            set
            {
                m_UIActionStatusMessage = value;
                RaisePropertyChanged("UIActionStatusMessage");
            }
        }

        #endregion override properties

        public bool SuppressMVVMLightEventToCommandMessage { get; set; }

        #region ViewDetails

        public RelayCommand<TIdentifierContract> LaunchDetailsViewCommand { get; protected set; }

        protected virtual void LaunchDetailsView(TIdentifierContract o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            LoadItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseDetailsViewCommand { get; protected set; }

        protected void CloseDetailsView()
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        #endregion ViewDetails

        #region Copy

        public RelayCommand<TIdentifierContract> LaunchCopyViewCommand { get; protected set; }

        protected virtual void LaunchCopyView(TIdentifierContract o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Copy;

            LoadItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        #endregion Copy

        #region Save

        public RelayCommand<TIdentifierContract> LaunchEditViewCommand { get; protected set; }

        protected virtual void LaunchEditView(TIdentifierContract o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            LoadItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));

            //this.RaiseItemPropertyChangedEvent();
        }

        public RelayCommand CloseEditViewCommand { get; protected set; }

        protected void CloseEditView()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Update;
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        public RelayCommand SaveCommand { get; protected set; }

        /// <summary>
        /// update an Entity
        /// </summary>
        protected abstract void Save();

        /// <summary>
        /// Determines whether you can save Entity
        /// </summary>
        /// <returns>
        ///     <c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool CanSave()
        {
            return this.Item != null;
        }

        #endregion Save

        #region Add

        public RelayCommand LaunchCreateViewCommand { get; protected set; }

        protected void LaunchCreateView()
        {
            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseCreateViewCommand { get; protected set; }

        protected void CloseCreateView()
        {
            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;
            this.Item = new TItem();
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        public RelayCommand AddCommand { get; protected set; }

        /// <summary>
        /// Adds a Entity to the list and repo.
        /// </summary>
        protected abstract void Add();

        /// <summary>
        /// Determines whether you can create
        /// </summary>
        /// <returns>
        ///     <c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected bool CanAdd()
        {
            return true;
        }

        #endregion Add

        #region Delete

        public RelayCommand<TIdentifierContract> LaunchDeleteViewCommand { get; protected set; }

        protected void LaunchDeleteView(TIdentifierContract o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            LoadItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseDeleteViewCommand { get; protected set; }

        protected void CloseDeleteView()
        {
            string viewName = ViewName_Delete;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        public RelayCommand DeleteCommand { get; protected set; }

        /// <summary>,
        /// delete
        /// </summary>
        protected abstract void Delete();

        /// <summary>
        /// Determines whether you can delete an Entity
        /// </summary>
        /// <returns>
        ///     <c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool CanDelete()
        {
            return this.Item != null;
        }

        #endregion Delete

        #region LoadItem

        public RelayCommand LoadItemCommand { get; protected set; }
        public RelayCommand<TSearchCriteria> LoadItemCommandTyped { get; protected set; }

        public virtual void LoadItem()
        {
            this.LoadItem(this.Criteria);
        }

        public abstract void LoadItem(TIdentifierContract identifier);

        public abstract void ReLoadItem(TIdentifierContract o);

        #endregion LoadItem

        #region RefreshCurrentItemCommand

        public RelayCommand RefreshCurrentItemCommand { get; protected set; }

        protected virtual void RefreshItem()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Refresh;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            RefreshItemNoMessage();

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        protected void RefreshItemNoMessage()
        {
            LoadItem();
        }

        #endregion RefreshCurrentItemCommand

        #region string EntityName

        public abstract string EntityName { get; }

        #endregion string EntityName

        public const string ViewName_Edit = "Edit";
        public const string ViewName_Create = "Create";
        public const string ViewName_Delete = "Delete";
        public const string ViewName_Details = "Details";

        public override void Cleanup()
        {
            base.Cleanup();
            this.m_Item = new TItem();
        }

        public RelayCommand RaiseItemPropertyChangedEventCommand { get; protected set; }

        public void RaiseItemPropertyChangedEvent()
        {
            this.RaisePropertyChanged("Item");
        }
    }
}


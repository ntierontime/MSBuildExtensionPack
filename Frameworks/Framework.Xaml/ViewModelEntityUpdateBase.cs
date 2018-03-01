using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Framework.Xaml
{
    public abstract class ViewModelEntityUpdateBase<TMasterEntity, TCriteriaOfMasterEntity, TIdentifier>
        : Framework.Xaml.ViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity, TIdentifier>
        where TMasterEntity : class, new()
        where TCriteriaOfMasterEntity : class, new()
    {

        public ViewModelEntityUpdateBase()
            : base()
        {
            this.UpdateCommand = new RelayCommand<TMasterEntity>(Update, CanUpdate);
        }

        public RelayCommand<TMasterEntity> UpdateCommand { get; protected set; }
        protected virtual void Update(TMasterEntity o)
        {
            string viewName = this.ViewName;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            DoUpdate();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
        }

        protected abstract void DoUpdate();

        protected virtual bool CanUpdate(TMasterEntity o)
        {
            return true;
        }
    }
}


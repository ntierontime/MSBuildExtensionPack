using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.ViewModels
{
    /// <summary>
    /// This class contains single item view model
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </summary>
    public partial class ItemVMBuildLog 
		: Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
    {
		#region override string EntityName
	    
        public const string EntityName_Static = "MSBuildExtensionPack.BuildLog";

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

		#endregion override string EntityName

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ItemVMBuildLog class.
        /// </summary>
        public ItemVMBuildLog()
			: base()
        {
        }

        #endregion Constructor

        protected override void Add()
        {
            #region Asyncronized wcf method call

            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndInsertEntity(result);

                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
                    });
                }
            };

            try
            {
#if WINDOWS_PHONE
                AssignSelectedValueFromSelectedItemToEntity(this.Item);
#endif

                MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn()
                {
                    Critieria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection(),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
                };
                _Request.Critieria.Add(MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog>(this.Item));
                _Instance.BeginInsertEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
                if (!this.SuppressMVVMLightEventToCommandMessage)
                    Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildExtensionPack.DataSourceEntities.BuildLog.Default _NewItem = new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default();
            this.m_EntityCollectionDefault.Add(_NewItem);
            MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.InsertEntity(_NewItemDefault);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

        protected override void Delete()
        {
            #region Asyncronized wcf method call

            string viewName = ViewName_Delete;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndDeleteEntity(result);

                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
                    });
                }
            };

            try
            {
#if WINDOWS_PHONE
                AssignSelectedValueFromSelectedItemToEntity(this.Item);
#endif

                MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn()
                {
                    Critieria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection(),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete,
                };
                _Request.Critieria.Add(MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog>(this.m_Item));
                _Instance.BeginDeleteEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
                if (!this.SuppressMVVMLightEventToCommandMessage)
                    Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteEntity(this.Item);//
            this.m_EntityCollectionDefault.Remove(this.Item);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

        protected override void RefreshItemNoMessage()
        {
            this.Item = this.OriginalItem.GetAClone();
        }

        protected override void Save()
        {
            #region Asyncronized wcf method call

            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndUpdateEntity(result);

                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
                    });
                }
            };

            try
            {
#if WINDOWS_PHONE
                AssignSelectedValueFromSelectedItemToEntity(this.Item);
#endif

                MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn()
                {
                    Critieria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection(),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update,
                };
                _Request.Critieria.Add(MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog>(this.Item));
                _Instance.BeginUpdateEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
                if (!this.SuppressMVVMLightEventToCommandMessage)
                    Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.UpdateEntity(this.Item);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

        public override void ReLoadItem(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildLogIdentifierHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
			if(identifier != null)
            {
                this.Criteria = identifier;
            }
            else
            {
                this.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier(this.Item);
            }

            #region Asyncronized wcf method call

            MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndGetSingleOfDefaultOfByIdentifier(result);
                        this.Item = responseMessage.Message[0];
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                    });
                }
            };


            try
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier()
                {
                    Critieria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier(true, this.Criteria.Id),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
                };
                _Instance.BeginGetSingleOfDefaultOfByIdentifier(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
            }

            #endregion Asyncronized wcf method call   
        }

        public  void Cleanup()
        {

        }
    }
}


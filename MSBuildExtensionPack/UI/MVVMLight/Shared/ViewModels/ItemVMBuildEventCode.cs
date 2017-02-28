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
    public partial class ItemVMBuildEventCode 
		: Framework.Xaml.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>
    {
		#region override string EntityName
	    
        public const string EntityName_Static = "MSBuildExtensionPack.BuildEventCode";

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
        /// Initializes a new instance of the ItemVMBuildEventCode class.
        /// </summary>
        public ItemVMBuildEventCode()
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

            MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

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

                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn()
                {
                    Critieria = new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection(),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
                };
                _Request.Critieria.Add(MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(this.Item));
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
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode _NewItem = new MSBuildExtensionPack.DataSourceEntities.BuildEventCode();
            this.m_EntityCollectionDefault.Add(_NewItem);
            MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.InsertEntity(_NewItemDefault);
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

            MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

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

                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn()
                {
                    Critieria = new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection(),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete,
                };
                _Request.Critieria.Add(MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(this.m_Item));
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
            MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.DeleteEntity(this.Item);//
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

            MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

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

                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn()
                {
                    Critieria = new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection(),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update,
                };
                _Request.Critieria.Add(MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(this.Item));
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
            MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.UpdateEntity(this.Item);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

        public override void ReLoadItem(MSBuildExtensionPack.DataSourceEntities.BuildEventCode o)
        {
            var identifier = MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifierHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier identifier)
        {
			if(identifier != null)
            {
                this.Criteria = identifier;
            }
            else
            {
                this.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier(this.Item);
            }

            #region Asyncronized wcf method call

            MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildExtensionPack.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndGetSingleOfEntityOfByIdentifier(result);
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
                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfByIdentifier()
                {
                    Critieria = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier(true, this.Criteria.Id),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
                };
                _Instance.BeginGetSingleOfEntityOfByIdentifier(_Request, asyncCallback, null);
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


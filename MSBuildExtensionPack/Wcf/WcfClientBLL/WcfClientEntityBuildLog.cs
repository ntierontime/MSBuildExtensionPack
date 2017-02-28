using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfClientBLL
{
    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// *4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// 5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public interface WcfClientEntityBuildLogChannel : MSBuildExtensionPack.WcfContracts.IBuildLogService, System.ServiceModel.IClientChannel {
    }

    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// 4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// *5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public partial class WcfClientEntityBuildLog : System.ServiceModel.ClientBase<MSBuildExtensionPack.WcfContracts.IBuildLogService>, MSBuildExtensionPack.WcfContracts.IBuildLogService {

		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildLog"/> class.
        /// </summary>
        public WcfClientEntityBuildLog() {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildLog"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public WcfClientEntityBuildLog(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildLog"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildLog(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildLog"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
		public WcfClientEntityBuildLog(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildLog"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildLog(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

		#endregion constructors
        
        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            return base.Channel.UpdateEntity(request);
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            return base.Channel.DeleteEntity(request);
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.DeleteByIdentifierEntity(id);
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            return base.Channel.BatchInsert(request);
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            return base.Channel.BatchUpdate(request);
        }		

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members





        #region Query Methods Of Entity of Common 

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCountOfEntityOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.ExistsOfEntityOfCommon(request);
		}

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetSingleOfEntityOfCommon(request);
		}

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Default of Common 

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCountOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.ExistsOfDefaultOfCommon(request);
		}

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetSingleOfDefaultOfCommon(request);
		}

        #endregion Query Methods Of Default of Common 




        #region Query Methods Of Entity of All 

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfEntityOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfEntityOfAll(request);
		}

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfEntityOfAll(request);
		}

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfNameValuePairOfAll(request);
		}

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfNameValuePairOfAll(request);
		}

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfRssItemOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfRssItemOfAll(request);
		}

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfRssItemOfAll(request);
		}

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByFKOnly 

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfEntityOfByFKOnly(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfEntityOfByFKOnly(request);
		}

        #endregion Query Methods Of Entity of ByFKOnly 




        #region Query Methods Of NameValuePair of ByFKOnly 

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfNameValuePairOfByFKOnly(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfNameValuePairOfByFKOnly(request);
		}

        #endregion Query Methods Of NameValuePair of ByFKOnly 




        #region Query Methods Of RssItem of ByFKOnly 

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfRssItemOfByFKOnly(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfRssItemOfByFKOnly(request);
		}

        #endregion Query Methods Of RssItem of ByFKOnly 




        #region Query Methods Of Default of ByFKOnly 

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfDefaultOfByFKOnly(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfDefaultOfByFKOnly(request);
		}

        #endregion Query Methods Of Default of ByFKOnly 




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfDefaultGroupedDataViewOfByFKOnly(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfDefaultGroupedDataViewOfByFKOnly(request);
		}

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




        #region Query Methods Of Entity of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfEntityOfByIdentifier(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfEntityOfByIdentifier(request);
		}

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of Default of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfDefaultOfByIdentifier(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfDefaultOfByIdentifier(request);
		}

        #endregion Query Methods Of Default of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>		
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfKeyInformationOfByIdentifier(request);
		}

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfKeyInformationOfByIdentifier(request);
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier 







		
#if WINDOWS_PHONE
        protected override MSBuildExtensionPack.WcfContracts.IBuildLogService CreateChannel()
        {
            throw new NotImplementedException();
        }
#else
#endif
	}
}
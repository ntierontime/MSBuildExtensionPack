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
    public interface WcfClientEntityBuildChannel : MSBuildExtensionPack.WcfContracts.IBuildService, System.ServiceModel.IClientChannel {
    }

    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// 4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// *5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public partial class WcfClientEntityBuild : System.ServiceModel.ClientBase<MSBuildExtensionPack.WcfContracts.IBuildService>, MSBuildExtensionPack.WcfContracts.IBuildService {

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuild"/> class.
        /// </summary>
        public WcfClientEntityBuild() {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuild"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public WcfClientEntityBuild(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuild"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuild(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuild"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuild(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuild"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuild(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        #endregion constructors

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildCollection,MSBuildExtensionPack.DataSourceEntities.Build,MSBuildExtensionPack.DataSourceEntities.BuildIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            return base.Channel.UpdateEntity(request);
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            return base.Channel.DeleteEntity(request);
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.DeleteByIdentifierEntity(id);
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            return base.Channel.BatchInsert(request);
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            return base.Channel.BatchUpdate(request);
        }

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildCollection,MSBuildExtensionPack.DataSourceEntities.Build,MSBuildExtensionPack.DataSourceEntities.BuildIdentifier> Members

        #region Query Methods Of Entity of Common

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCountOfEntityOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__ExistsOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCollectionOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetSingleOfEntityOfCommon(request);
        }

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCountOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__ExistsOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCollectionOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetSingleOfDefaultOfCommon(request);
        }

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCountOfEntityOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__ExistsOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCollectionOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetSingleOfEntityOfAll(request);
        }

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCountOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__ExistsOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCollectionOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetSingleOfNameValuePairOfAll(request);
        }

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCountOfRssItemOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__ExistsOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCollectionOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetSingleOfRssItemOfAll(request);
        }

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetSingleOfEntityOfByFKOnly(request);
        }

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetSingleOfNameValuePairOfByFKOnly(request);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetSingleOfRssItemOfByFKOnly(request);
        }

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetSingleOfDefaultOfByFKOnly(request);
        }

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetSingleOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetSingleOfEntityOfByIdentifier(request);
        }

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetSingleOfDefaultOfByIdentifier(request);
        }

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of UpdateNameRequest of ByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfUpdateNameRequestOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfUpdateNameRequestOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfUpdateNameRequestOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetSingleOfUpdateNameRequestOfByIdentifier(request);
        }

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetSingleOfKeyInformationOfByIdentifier(request);
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region EntityUpdateActionSetting - UpdateNameOnly

        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request)
        {
            return base.Channel.UpdateNameOnly(request);
        }

        #endregion EntityUpdateActionSetting - UpdateNameOnly

#if WINDOWS_PHONE
        protected override MSBuildExtensionPack.WcfContracts.IBuildService CreateChannel()
        {
            throw new NotImplementedException();
        }
#else
#endif
    }
}


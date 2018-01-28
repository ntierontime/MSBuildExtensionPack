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
    public interface WcfClientEntityOrganizationChannel : MSBuildExtensionPack.WcfContracts.IOrganizationService, System.ServiceModel.IClientChannel {
    }

    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// 4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// *5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public partial class WcfClientEntityOrganization : System.ServiceModel.ClientBase<MSBuildExtensionPack.WcfContracts.IOrganizationService>, MSBuildExtensionPack.WcfContracts.IOrganizationService {

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityOrganization"/> class.
        /// </summary>
        public WcfClientEntityOrganization() {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityOrganization"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public WcfClientEntityOrganization(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityOrganization"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityOrganization(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityOrganization"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityOrganization(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityOrganization"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityOrganization(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        #endregion constructors

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection,MSBuildExtensionPack.DataSourceEntities.Organization,MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            return base.Channel.UpdateEntity(request);
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            return base.Channel.DeleteEntity(request);
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.DeleteByIdentifierEntity(id);
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            return base.Channel.BatchInsert(request);
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            return base.Channel.BatchUpdate(request);
        }

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection,MSBuildExtensionPack.DataSourceEntities.Organization,MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier> Members

        #region Query Methods Of Entity of Common

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCountOfEntityOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__ExistsOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCollectionOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCountOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__ExistsOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.__GetCollectionOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCountOfEntityOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__ExistsOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCollectionOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCountOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__ExistsOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCollectionOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCountOfRssItemOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__ExistsOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.__GetCollectionOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCountOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__ExistsOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetSingleOfDefaultOfByIdentifier(request);
        }

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCountOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__ExistsOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetCollectionOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.__GetSingleOfKeyInformationOfByIdentifier(request);
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetCountOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__ExistsOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetCollectionOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the single of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetSingleOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetCountOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__ExistsOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the single of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetSingleOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the single of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        #region GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

        /// <summary>
        /// Get ascendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a message of <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(id);
        }

        /// <summary>
        /// Get descendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a message of <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetDescendantOfParentIdOfMSBuildExtensionPack_Organization (MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.GetDescendantOfParentIdOfMSBuildExtensionPack_Organization(id);
        }

        #endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

#if WINDOWS_PHONE
        protected override MSBuildExtensionPack.WcfContracts.IOrganizationService CreateChannel()
        {
            throw new NotImplementedException();
        }
#else
#endif
    }
}


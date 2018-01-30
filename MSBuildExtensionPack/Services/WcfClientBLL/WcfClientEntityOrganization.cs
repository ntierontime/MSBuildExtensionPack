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

        #region Query Methods Of EntityOfCommon

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCountOfEntityOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.ExistsOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfEntityOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetSingleOfEntityOfCommon(request);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        /// <summary>
        /// Gets the count of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCountOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Exists the of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.ExistsOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfDefaultOfCommon(request);
        }

        /// <summary>
        /// Gets the single of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetSingleOfDefaultOfCommon(request);
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfEntityOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfEntityOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfEntityOfAll(request);
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfNameValuePairOfAll(request);
        }

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        /// <summary>
        /// Gets the count of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCountOfRssItemOfAll(request);
        }

        /// <summary>
        /// Exists the of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.ExistsOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfRssItemOfAll(request);
        }

        /// <summary>
        /// Gets the single of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetSingleOfRssItemOfAll(request);
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfEntityOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfEntityOfByFKOnly(request);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfNameValuePairOfByFKOnly(request);
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfRssItemOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfRssItemOfByFKOnly(request);
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfDefaultOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfDefaultOfByFKOnly(request);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        /// <summary>
        /// Gets the count of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCountOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Exists the of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.ExistsOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByFKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            return base.Channel.GetSingleOfDefaultGroupedDataViewOfByFKOnly(request);
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfEntityOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfEntityOfByIdentifier(request);
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfDefaultOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfDefaultOfByIdentifier(request);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        /// <summary>
        /// Gets the count of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCountOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.ExistsOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetCollectionOfKeyInformationOfByIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "ByIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            return base.Channel.GetSingleOfKeyInformationOfByIdentifier(request);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueIdentifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            return base.Channel.GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(request);
        }

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Exists the of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the collection of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        /// <summary>
        /// Gets the single of entity of "UniqueConstraintOfUC_Organization_UniqueidentifierColumn".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            return base.Channel.GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(request);
        }

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of EntityOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCountOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.ExistsOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCollectionOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the single of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetSingleOfEntityOfIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of EntityOfIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCountOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.ExistsOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the single of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetSingleOfDefaultOfIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>the count</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the single of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

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


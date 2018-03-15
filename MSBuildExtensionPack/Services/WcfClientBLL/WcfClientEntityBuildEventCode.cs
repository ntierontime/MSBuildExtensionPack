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
    public interface WcfClientEntityBuildEventCodeChannel : MSBuildExtensionPack.WcfContracts.IBuildEventCodeService, System.ServiceModel.IClientChannel {
    }

    /// <summary>
    /// There are 5 classes/interfaces needed to consume a Wcf web service on client side:
    /// 1. Request Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 2. Response Message class for each method, defined in CommonBusinessLogicLayerEntities project
    /// 3. Contract definition interface, defined in WcfServiceContracts project
    /// 4. Channel definition interface, defined in WcfClientBusinessLogicLayer(this) project
    /// *5. WcfClient class, defined in WcfClientBusinessLogicLayer(this) project
    /// </summary>
    public partial class WcfClientEntityBuildEventCode : System.ServiceModel.ClientBase<MSBuildExtensionPack.WcfContracts.IBuildEventCodeService>, MSBuildExtensionPack.WcfContracts.IBuildEventCodeService {

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        public WcfClientEntityBuildEventCode() {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public WcfClientEntityBuildEventCode(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildEventCode(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildEventCode(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WcfClientEntityBuildEventCode"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public WcfClientEntityBuildEventCode(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        #endregion constructors

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection,MSBuildExtensionPack.DataSourceEntities.BuildEventCode,MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.UpdateEntity(request);
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.DeleteEntity(request);
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltInOfIdentifier id)
        {
            return base.Channel.DeleteByIdentifierEntity(id);
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.BatchInsert(request);
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.InsertEntity(request);
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn request)
        {
            return base.Channel.BatchUpdate(request);
        }

        #endregion Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection,MSBuildExtensionPack.DataSourceEntities.BuildEventCode,MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier> Members

            // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of EntityByCommon

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityByCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfEntityByCommon(request);
        }

        #endregion Query Methods Of EntityByCommon

        #region Query Methods Of NameValuePairByAll

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfNameValuePairByAll(request);
        }

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of RssItemByAll

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfRssItemByAll(request);
        }

        #endregion Query Methods Of RssItemByAll

        #region Query Methods Of EntityByIdentifier

        /// <summary>
        /// Exists the of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.ExistsOfEntityByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.GetCollectionOfEntityByIdentifier(request);
        }

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

        /// <summary>
        /// Exists the of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.ExistsOfKeyInformationByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.GetCollectionOfKeyInformationByIdentifier(request);
        }

        #endregion Query Methods Of KeyInformationByIdentifier

            // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

#if WINDOWS_PHONE
        protected override MSBuildExtensionPack.WcfContracts.IBuildEventCodeService CreateChannel()
        {
            throw new NotImplementedException();
        }
#else
#endif
    }
}


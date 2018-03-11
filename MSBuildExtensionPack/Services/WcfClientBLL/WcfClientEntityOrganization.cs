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

            // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of DefaultByCommon

        /// <summary>
        /// Gets the collection of entity of "Common".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            return base.Channel.GetCollectionOfDefaultByCommon(request);
        }

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of DefaultByFKOnly

        /// <summary>
        /// Gets the collection of entity of "FKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly request)
        {
            return base.Channel.GetCollectionOfDefaultByFKOnly(request);
        }

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultByIdentifier

        /// <summary>
        /// Exists the of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.ExistsOfDefaultByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.GetCollectionOfDefaultByIdentifier(request);
        }

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of DefaultByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.ExistsOfDefaultByIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCollectionOfDefaultByIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of DefaultByIdentifierAndUniqueConstraint

        #region Query Methods Of EntityByIdentifier

        /// <summary>
        /// Exists the of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.ExistsOfEntityByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.GetCollectionOfEntityByIdentifier(request);
        }

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of EntityByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.ExistsOfEntityByIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCollectionOfEntityByIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of EntityByIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationByIdentifier

        /// <summary>
        /// Exists the of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.ExistsOfKeyInformationByIdentifier(request);
        }

        /// <summary>
        /// Gets the collection of entity of "Identifier".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            return base.Channel.GetCollectionOfKeyInformationByIdentifier(request);
        }

        #endregion Query Methods Of KeyInformationByIdentifier

        #region Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>true if exists any, otherwise false</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.ExistsOfKeyInformationByIdentifierAndUniqueConstraint(request);
        }

        /// <summary>
        /// Gets the collection of entity of "IdentifierAndUniqueConstraint".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            return base.Channel.GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(request);
        }

        #endregion Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

        #region Query Methods Of NameValuePairByAll

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfNameValuePairByAll(request);
        }

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of NameValuePairByFKOnly

        /// <summary>
        /// Gets the collection of entity of "FKOnly".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly request)
        {
            return base.Channel.GetCollectionOfNameValuePairByFKOnly(request);
        }

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of RssItemByAll

        /// <summary>
        /// Gets the collection of entity of "All".
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            return base.Channel.GetCollectionOfRssItemByAll(request);
        }

        #endregion Query Methods Of RssItemByAll

            // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

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


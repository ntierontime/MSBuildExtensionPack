using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.IOrganizationService")]
#endif
    public interface IOrganizationService
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection,MSBuildExtensionPack.DataSourceEntities.Organization,MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier> Members

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchInsert",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchDelete",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchUpdate",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input);

        #endregion

        #region Query Methods Of Entity of Common

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request);

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request);

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request);

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request);

        #endregion Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        #region GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

        /// <summary>
        /// Get ascendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a collection of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection"/></returns>
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetAscendantOfParentIdOfMSBuildExtensionPack_Organization",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetAscendantOfParentIdOfMSBuildExtensionPack_OrganizationResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id);

        /// <summary>
        /// Get descendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a collection of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection"/></returns>
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetDescendantOfParentIdOfMSBuildExtensionPack_Organization",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetDescendantOfParentIdOfMSBuildExtensionPack_OrganizationResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetDescendantOfParentIdOfMSBuildExtensionPack_Organization (MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id);

        #endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.IBuildServiceAsyn")]
#endif
    public interface IBuildServiceAsyn
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildCollection,MSBuildExtensionPack.DataSourceEntities.Build,MSBuildExtensionPack.DataSourceEntities.BuildIdentifier> Members

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

        #endregion

        #region Query Methods Of DefaultByCommon

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetCollectionOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByCommon(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of RssItemByAll

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemByAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemByAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemByAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemByAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItemByAll

        #region Query Methods Of NameValuePairByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of DefaultByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetCollectionOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of EntityByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetCollectionOfEntityByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of DefaultByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation EndGetCollectionOfKeyInformationByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformationByIdentifier

        #region Query Methods Of AncestorAndKeyInfo

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfAncestorAndKeyInfo",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfAncestorAndKeyInfoResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfAncestorAndKeyInfo(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKStringContains request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfAncestorAndKeyInfo",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfAncestorAndKeyInfoResponse")]
#endif
        System.IAsyncResult BeginExistsOfAncestorAndKeyInfo(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKStringContains request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfAncestorAndKeyInfo(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfAncestorAndKeyInfo",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfAncestorAndKeyInfoResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetCollectionOfAncestorAndKeyInfo(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKStringContains request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfAncestorAndKeyInfo",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfAncestorAndKeyInfoResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfAncestorAndKeyInfo(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfFKStringContains request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation EndGetCollectionOfAncestorAndKeyInfo(System.IAsyncResult result);

        #endregion Query Methods Of AncestorAndKeyInfo

        #region Query Methods Of KeyInformationByID

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByID",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByIDResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByID(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByID",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationByIDResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationByID(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationByID(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByID",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByIDResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetCollectionOfKeyInformationByID(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByID",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationByIDResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationByID(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest EndGetCollectionOfKeyInformationByID(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformationByID

        #region Query Methods Of UpdateName

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateName",
           ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateName(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateName input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateName",
           ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameResponse")]
#endif
        System.IAsyncResult BeginUpdateName(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateName input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest EndUpdateName(System.IAsyncResult result);

        #endregion Query Methods Of UpdateName

        #region Query Methods Of InsertName

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertName",
           ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertNameResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest InsertName(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedInsertName input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertName",
           ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertNameResponse")]
#endif
        System.IAsyncResult BeginInsertName(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedInsertName input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest EndInsertName(System.IAsyncResult result);

        #endregion Query Methods Of InsertName

    }
}


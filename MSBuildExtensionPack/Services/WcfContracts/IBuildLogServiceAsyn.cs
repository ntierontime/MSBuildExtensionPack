using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn")]
#endif
    public interface IBuildLogServiceAsyn
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

        #endregion

        #region Query Methods Of DefaultByCommon

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByCommon(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of DefaultByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of DefaultGroupedDataViewByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultGroupedDataViewByFKOnly

        #region Query Methods Of EntityByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetCollectionOfEntityByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation EndGetCollectionOfKeyInformationByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformationByIdentifier

        #region Query Methods Of NameValuePairByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of RssItemByAll

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemByAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemByAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemByAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemByAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItemByAll

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.ISolutionServiceAsyn")]
#endif
    public interface ISolutionServiceAsyn
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.SolutionCollection,MSBuildExtensionPack.DataSourceEntities.Solution,MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier> Members

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

        #endregion

        #region Query Methods Of DefaultByCommon

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByCommon(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByCommon(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of RssItemByAll

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemByAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemByAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemByAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemByAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItemByAll

        #region Query Methods Of NameValuePairByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairByFKOnly(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of DefaultByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByFKOnly(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultGroupedDataViewByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultGroupedDataViewByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultGroupedDataViewByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultGroupedDataViewByFKOnly",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultGroupedDataViewByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewByFKOnly(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultGroupedDataViewByFKOnly

        #region Query Methods Of EntityByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetCollectionOfEntityByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of DefaultByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default EndGetCollectionOfDefaultByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request);
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation EndGetCollectionOfKeyInformationByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformationByIdentifier

    }
}


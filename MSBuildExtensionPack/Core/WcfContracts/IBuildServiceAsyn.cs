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
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsert",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDelete",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdate",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsert",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDelete",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdate",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

        #endregion

        #region Query Methods Of Entity of Common

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetCollectionOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetSingleOfDefaultOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetSingleOfEntityOfAll(System.IAsyncResult result);

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetCollectionOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetSingleOfEntityOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetCollectionOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetSingleOfDefaultOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView EndGetSingleOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetCollectionOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default EndGetSingleOfDefaultOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of UpdateNameRequest of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfUpdateNameRequestOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfUpdateNameRequestOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfUpdateNameRequestOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfUpdateNameRequestOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfUpdateNameRequestOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest EndGetCollectionOfUpdateNameRequestOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfUpdateNameRequestOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfUpdateNameRequestOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfUpdateNameRequestOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest EndGetSingleOfUpdateNameRequestOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region EntityUpdateActionSetting - UpdateNameOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameOnly",
           ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameOnly",
           ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameOnlyResponse")]
#endif
        System.IAsyncResult BeginUpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest EndUpdateNameOnly(System.IAsyncResult result);

        #endregion EntityUpdateActionSetting - UpdateNameOnly

    }
}


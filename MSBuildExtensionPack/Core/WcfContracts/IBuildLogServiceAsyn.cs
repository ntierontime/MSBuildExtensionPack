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

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsert", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDelete", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdate", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsert", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDelete", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdate", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

        #endregion





        #region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Default of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfCommon(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetCollectionOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetSingleOfDefaultOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Default of Common 




        #region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetSingleOfEntityOfAll(System.IAsyncResult result);

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByFKOnly(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetCollectionOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetSingleOfEntityOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByFKOnly 




        #region Query Methods Of NameValuePair of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfByFKOnly(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of ByFKOnly 




        #region Query Methods Of RssItem of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfByFKOnly(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of ByFKOnly 




        #region Query Methods Of Default of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByFKOnly(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetCollectionOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetSingleOfDefaultOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByFKOnly 




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView EndGetCollectionOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView EndGetSingleOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




        #region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of Default of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfDefaultOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetCollectionOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default EndGetSingleOfDefaultOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Default of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildLogService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}


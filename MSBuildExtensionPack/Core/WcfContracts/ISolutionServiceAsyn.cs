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

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsert", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDelete", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdate", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsert", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDelete", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdate", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

        #endregion





        #region Query Methods Of Entity of Common 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfCommon(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetSingleOfEntityOfCommon(System.IAsyncResult result);

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Entity of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfAllResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetSingleOfEntityOfAll(System.IAsyncResult result);

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfNameValuePairOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfNameValuePairOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection EndGetSingleOfNameValuePairOfAll(System.IAsyncResult result);

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfRssItemOfAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCountOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfRssItemOfAll(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginExistsOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfRssItemOfAll", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection EndGetSingleOfRssItemOfAll(System.IAsyncResult result);

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfEntityOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn EndGetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

#if SILVERLIGHT
#else

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#endif

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCountOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger EndGetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginExistsOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean EndExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetCollectionOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation EndGetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfKeyInformationOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult BeginGetSingleOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation EndGetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

        #endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}


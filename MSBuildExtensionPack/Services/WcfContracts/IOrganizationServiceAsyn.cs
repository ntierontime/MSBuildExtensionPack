using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.IOrganizationServiceAsyn")]
#endif
    public interface IOrganizationServiceAsyn
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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndDeleteEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/DeleteByIdentifierEntityResponse")]
#endif
        System.IAsyncResult BeginDeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndDeleteByIdentifierEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/InsertEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/InsertEntityResponse")]
#endif
        System.IAsyncResult BeginInsertEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndInsertEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/UpdateEntity",
            ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/UpdateEntityResponse")]
#endif
        System.IAsyncResult BeginUpdateEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndUpdateEntity(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchInsert",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchInsertResponse")]
#endif
        System.IAsyncResult BeginBatchInsert(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndBatchInsert(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchDelete",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchDeleteResponse")]
#endif
        System.IAsyncResult BeginBatchDelete(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn inpu, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndBatchDelete(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchUpdate",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/BatchUpdateResponse")]
#endif
        System.IAsyncResult BeginBatchUpdate(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn input, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn EndBatchUpdate(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfCommonResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfCommon(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetCollectionOfDefaultOfCommon(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfCommon",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfCommonResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultOfCommon(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetSingleOfDefaultOfCommon(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfAllResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfAll(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetCollectionOfNameValuePairOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfNameValuePairOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetSingleOfNameValuePairOfAll(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection End__GetCollectionOfRssItemOfAll(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfAll",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfAllResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfRssItemOfAll(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection End__GetSingleOfRssItemOfAll(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfByFKOnly(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetCollectionOfNameValuePairOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfNameValuePairOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetSingleOfNameValuePairOfByFKOnly(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection End__GetCollectionOfRssItemOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfRssItemOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection End__GetSingleOfRssItemOfByFKOnly(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetCollectionOfDefaultOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetSingleOfDefaultOfByFKOnly(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView End__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultGroupedDataViewOfByFKOnly",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultGroupedDataViewOfByFKOnly(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView End__GetSingleOfDefaultGroupedDataViewOfByFKOnly(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfByIdentifier(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetCollectionOfDefaultOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetSingleOfDefaultOfByIdentifier(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation End__GetCollectionOfKeyInformationOfByIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfByIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfByIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfKeyInformationOfByIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation End__GetSingleOfKeyInformationOfByIdentifier(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection End__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfEntityOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfEntityOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfEntityOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfEntityOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfEntityOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetCollectionOfEntityOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfEntityOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfEntityOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn End__GetSingleOfEntityOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfDefaultOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfDefaultOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfDefaultOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfDefaultOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfDefaultOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfDefaultOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default End__GetSingleOfDefaultOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

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

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCountOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger End__GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__ExistsOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean End__ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation End__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraintResponse")]
#endif
        System.IAsyncResult Begin__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation End__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(System.IAsyncResult result);

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

        /// <summary>
        /// Get ascendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a message of <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetAscendantOfParentIdOfMSBuildExtensionPack_Organization",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetAscendantOfParentIdOfMSBuildExtensionPack_OrganizationResponse")]
#endif
        System.IAsyncResult BeginGetAscendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath EndGetAscendantOfParentIdOfMSBuildExtensionPack_Organization(System.IAsyncResult result);

        /// <summary>
        /// Get descendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a message of <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetDescendantOfParentIdOfMSBuildExtensionPack_Organization",
            ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IOrganizationService/GetDescendantOfParentIdOfMSBuildExtensionPack_OrganizationResponse")]
#endif
        System.IAsyncResult BeginGetDescendantOfParentIdOfMSBuildExtensionPack_Organization (MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id, System.AsyncCallback callback, object asyncState);
        MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath EndGetDescendantOfParentIdOfMSBuildExtensionPack_Organization (System.IAsyncResult result);

        #endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

    }
}


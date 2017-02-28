using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.IBuildService")]
#endif
    public interface IBuildService
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

        #endregion Query Methods Of KeyInformation of ByIdentifier 







        #region EntityUpdateActionSetting - UpdateNameOnly

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameOnly",
           ReplyAction = "http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/IBuildService/UpdateNameOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request);
	
		#endregion EntityUpdateActionSetting - UpdateNameOnly



	}
}


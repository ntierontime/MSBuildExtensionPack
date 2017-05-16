using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.ISolutionService")]
#endif
    public interface ISolutionService
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.SolutionCollection,MSBuildExtensionPack.DataSourceEntities.Solution,MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier> Members

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

        #endregion





        #region Query Methods Of Entity of Common 

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

        #endregion Query Methods Of Entity of Common 




        #region Query Methods Of Default of Common 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultOfCommonResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultOfCommon", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultOfCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request);

        #endregion Query Methods Of Default of Common 




        #region Query Methods Of Entity of All 

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

        #endregion Query Methods Of Entity of All 




        #region Query Methods Of NameValuePair of All 

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

        #endregion Query Methods Of NameValuePair of All 




        #region Query Methods Of RssItem of All 

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

        #endregion Query Methods Of RssItem of All 




        #region Query Methods Of Entity of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfEntityOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfEntityOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of Entity of ByFKOnly 




        #region Query Methods Of NameValuePair of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfNameValuePairOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfNameValuePairOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of NameValuePair of ByFKOnly 




        #region Query Methods Of RssItem of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfRssItemOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfRssItemOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of RssItem of ByFKOnly 




        #region Query Methods Of Default of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of Default of ByFKOnly 




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultGroupedDataViewOfByFKOnly", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultGroupedDataViewOfByFKOnlyResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request);

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 




        #region Query Methods Of Entity of ByIdentifier 

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

        #endregion Query Methods Of Entity of ByIdentifier 




        #region Query Methods Of Default of ByIdentifier 

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCountOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);
		
#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/ExistsOfDefaultOfByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetCollectionOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultOfByIdentifier", 
			ReplyAction="http://www.NTIER ON TIME TECHNOLOGIES INC..com/MSBuildExtensionPack/WcfContracts/ISolutionService/GetSingleOfDefaultOfByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request);

        #endregion Query Methods Of Default of ByIdentifier 




        #region Query Methods Of KeyInformation of ByIdentifier 

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

        #endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}


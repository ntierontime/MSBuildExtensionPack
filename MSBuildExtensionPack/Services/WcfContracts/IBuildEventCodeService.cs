using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MSBuildExtensionPack.WcfContracts
{
#if (XAMARIN)
#else
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSBuildExtensionPack.WcfContracts.IBuildEventCodeService")]
#endif
    public interface IBuildEventCodeService
    {

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection,MSBuildExtensionPack.DataSourceEntities.BuildEventCode,MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier> Members

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/DeleteEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/DeleteEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/DeleteByIdentifierEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/DeleteByIdentifierEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltInOfIdentifier id);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/InsertEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/InsertEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/UpdateEntity",
            ReplyAction = "http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/UpdateEntityResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/BatchInsert",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/BatchInsertResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/BatchDelete",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/BatchDeleteResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn input);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/BatchUpdate",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/BatchUpdateResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageBuiltIn input);

        #endregion

        #region Query Methods Of EntityByCommon

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfEntityByCommon",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfEntityByCommonResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityByCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon request);

        #endregion Query Methods Of EntityByCommon

        #region Query Methods Of NameValuePairByAll

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfNameValuePairByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfNameValuePairByAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of RssItemByAll

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfRssItemByAll",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfRssItemByAllResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll request);

        #endregion Query Methods Of RssItemByAll

        #region Query Methods Of EntityByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/ExistsOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/ExistsOfEntityByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfEntityByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfEntityByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request);

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/ExistsOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/ExistsOfKeyInformationByIdentifierResponse")]
#endif
        Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request);

#if (XAMARIN)
#else
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfKeyInformationByIdentifier",
            ReplyAction="http://www.ntier.com/MSBuildExtensionPack/WcfContracts/IBuildEventCodeService/GetCollectionOfKeyInformationByIdentifierResponse")]
#endif
        MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfIdentifier request);

        #endregion Query Methods Of KeyInformationByIdentifier

    }
}


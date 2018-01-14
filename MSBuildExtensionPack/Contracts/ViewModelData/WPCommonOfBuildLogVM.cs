using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPCommonOfBuildLogVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>
    {
        public WPCommonOfBuildLogVM()
            : base()
        {
        }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Organization { get; set; }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_BuildEventCode { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }
}


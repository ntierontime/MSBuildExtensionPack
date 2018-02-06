using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPCommonOfBuildEventCodeVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection>
    {
        public WPCommonOfBuildEventCodeVM()
            : base()
        {
        }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }
}


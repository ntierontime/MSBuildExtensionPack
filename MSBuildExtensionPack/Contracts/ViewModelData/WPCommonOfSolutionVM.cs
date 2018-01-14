using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPCommonOfSolutionVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>
    {
        public WPCommonOfSolutionVM()
            : base()
        {
        }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Organization { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }
}


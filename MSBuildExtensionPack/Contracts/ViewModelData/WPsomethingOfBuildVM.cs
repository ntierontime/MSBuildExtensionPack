using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPsomethingOfBuildVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaFKStringContains, MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>
    {
        public WPsomethingOfBuildVM()
            : base()
        {
        }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Organization { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPsomethingOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }
}


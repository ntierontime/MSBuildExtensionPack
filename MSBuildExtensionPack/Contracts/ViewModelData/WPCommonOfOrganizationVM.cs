using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPCommonOfOrganizationVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>
    {
        public WPCommonOfOrganizationVM()
            : base()
        {
        }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Organization { get; set; }

        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfOrganizationVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }
}


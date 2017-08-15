using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{

    public partial class WPCommonOfBuildLogVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>
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

    public partial class WPEntityRelatedOfBuildLogVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier>
    {
        public WPEntityRelatedOfBuildLogVM()
            : base(null)
        { }

        public WPEntityRelatedOfBuildLogVM(MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
            this.CriteriaOfBuild_1 = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier();
            this.CriteriaOfSolution_1 = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier();
            this.CriteriaOfOrganization_1 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier();
            this.CriteriaOfOrganization_2 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier();
            this.CriteriaOfBuildEventCode_1 = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier();
        }

        //2. Build_1
        public MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier CriteriaOfBuild_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuild_1 { get; set; }
        public string StatusMessageOfBuild_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation Build_1 { get; set; }
        //3. Solution_1
        public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier CriteriaOfSolution_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1 { get; set; }
        public string StatusMessageOfSolution_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation Solution_1 { get; set; }
        //4. Organization_1
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier CriteriaOfOrganization_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_1 { get; set; }
        public string StatusMessageOfOrganization_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_1 { get; set; }
        //5. Organization_2
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier CriteriaOfOrganization_2 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_2 { get; set; }
        public string StatusMessageOfOrganization_2 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_2 { get; set; }
        //6. BuildEventCode_1
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier CriteriaOfBuildEventCode_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuildEventCode_1 { get; set; }
        public string StatusMessageOfBuildEventCode_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation BuildEventCode_1 { get; set; }
    }

}


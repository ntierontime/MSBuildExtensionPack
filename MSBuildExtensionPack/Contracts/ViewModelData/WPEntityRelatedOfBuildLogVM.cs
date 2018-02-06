using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPEntityRelatedOfBuildLogVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaIdentifier>
    {
        public WPEntityRelatedOfBuildLogVM()
            : base(null)
        { }

        public WPEntityRelatedOfBuildLogVM(MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
            this.CriteriaOfBuild_1 = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier();
            this.CriteriaOfSolution_1 = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier();
            this.CriteriaOfOrganization_1 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier();
            this.CriteriaOfOrganization_2 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier();
            this.CriteriaOfBuildEventCode_1 = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaIdentifier();
        }

        //2. Build_1
        public MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier CriteriaOfBuild_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuild_1 { get; set; }
        public string StatusMessageOfBuild_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation Build_1 { get; set; }
        //3. Solution_1
        public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier CriteriaOfSolution_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1 { get; set; }
        public string StatusMessageOfSolution_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation Solution_1 { get; set; }
        //4. Organization_1
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier CriteriaOfOrganization_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_1 { get; set; }
        public string StatusMessageOfOrganization_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_1 { get; set; }
        //5. Organization_2
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier CriteriaOfOrganization_2 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_2 { get; set; }
        public string StatusMessageOfOrganization_2 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_2 { get; set; }
        //6. BuildEventCode_1
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaIdentifier CriteriaOfBuildEventCode_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfBuildEventCode_1 { get; set; }
        public string StatusMessageOfBuildEventCode_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation BuildEventCode_1 { get; set; }
    }
}


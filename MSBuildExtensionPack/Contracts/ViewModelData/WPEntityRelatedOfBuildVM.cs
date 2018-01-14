using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPEntityRelatedOfBuildVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier>
    {
        public WPEntityRelatedOfBuildVM()
            : base(null)
        { }

        public WPEntityRelatedOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
            this.CriteriaOfFK_BuildLog_Build = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly();
            this.CriteriaOfSolution_1 = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier();
            this.CriteriaOfOrganization_1 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier();
            this.CriteriaOfOrganization_2 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier();
        }

        //1. FK_BuildLog_Build
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly CriteriaOfFK_BuildLog_Build { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_BuildLog_Build { get; set; }
        public string StatusMessageOfFK_BuildLog_Build { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection FK_BuildLog_Build { get; set; }
        //2. Solution_1
        public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier CriteriaOfSolution_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfSolution_1 { get; set; }
        public string StatusMessageOfSolution_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation Solution_1 { get; set; }
        //3. Organization_1
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier CriteriaOfOrganization_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_1 { get; set; }
        public string StatusMessageOfOrganization_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_1 { get; set; }
        //4. Organization_2
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier CriteriaOfOrganization_2 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_2 { get; set; }
        public string StatusMessageOfOrganization_2 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_2 { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPFullDetailsOfSolutionVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier>
    {
        public WPFullDetailsOfSolutionVM()
            : base(null)
        { }

        public WPFullDetailsOfSolutionVM(MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
            this.CriteriaOfFK_Build_Solution = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaFKOnly();
            this.CriteriaOfOrganization_1 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier();
            this.CriteriaOfOrganization_2 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier();
        }

        //1. FK_Build_Solution
        public MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaFKOnly CriteriaOfFK_Build_Solution { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_Build_Solution { get; set; }
        public string StatusMessageOfFK_Build_Solution { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection FK_Build_Solution { get; set; }
        //2. Organization_1
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier CriteriaOfOrganization_1 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_1 { get; set; }
        public string StatusMessageOfOrganization_1 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_1 { get; set; }
        //3. Organization_2
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier CriteriaOfOrganization_2 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_2 { get; set; }
        public string StatusMessageOfOrganization_2 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_2 { get; set; }
    }
}


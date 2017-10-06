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

    public partial class WPEntityRelatedOfOrganizationVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint>
    {
        public WPEntityRelatedOfOrganizationVM()
            : base(null)
        { }

        public WPEntityRelatedOfOrganizationVM(MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
            this.CriteriaOfFK_Organization_ParentId = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByFKOnly();
            this.CriteriaOfFK_Solution_OrganizationId = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByFKOnly();
            this.CriteriaOfOrganization_2 = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier();
        }

        //1. FK_Organization_ParentId
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByFKOnly CriteriaOfFK_Organization_ParentId { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_Organization_ParentId { get; set; }
        public string StatusMessageOfFK_Organization_ParentId { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection FK_Organization_ParentId { get; set; }
        //2. FK_Solution_OrganizationId
        public MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByFKOnly CriteriaOfFK_Solution_OrganizationId { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_Solution_OrganizationId { get; set; }
        public string StatusMessageOfFK_Solution_OrganizationId { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection FK_Solution_OrganizationId { get; set; }
        //2. Organization_2
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier CriteriaOfOrganization_2 { get; set; }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfOrganization_2 { get; set; }
        public string StatusMessageOfOrganization_2 { get; set; }
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation Organization_2 { get; set; }
    }

}


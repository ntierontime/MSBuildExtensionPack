using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{


    public partial class WPCommonOfBuildVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>
    {
        public WPCommonOfBuildVM()
            : base()
        {
        }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Solution { get; set; }


        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }




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
    }




    public partial class WPUpdateNameOnlyOfBuildVM 
		: Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier>
    {
		public WPUpdateNameOnlyOfBuildVM ()
            : base(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier())
        {
        }

        public WPUpdateNameOnlyOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
		}
    }


}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{


    public partial class WPCommonOfSolutionVM : Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>
    {
        public WPCommonOfSolutionVM()
            : base()
        {
        }



        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            return MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
        }
    }




    public partial class WPEntityRelatedOfSolutionVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier>
    {
        public WPEntityRelatedOfSolutionVM()
            : base(null)
        { }

        public WPEntityRelatedOfSolutionVM(MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
			this.CriteriaOfFK_Build_Solution = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly();
        }

		//1. FK_Build_Solution
		public MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly CriteriaOfFK_Build_Solution { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfFK_Build_Solution { get; set; }
		public string StatusMessageOfFK_Build_Solution { get; set; }
		public MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection FK_Build_Solution { get; set; }
    }




}



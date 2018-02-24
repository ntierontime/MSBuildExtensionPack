using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPelseA1AsomethingOfBuildVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier>
    {
        public WPelseA1AsomethingOfBuildVM()
            : base(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier())
        {
        }

        public WPelseA1AsomethingOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.ViewModelData
{
    public partial class WPUpdateNameOnlyOfBuildVM
        : Framework.ViewModels.ViewModelEntityRelatedBase<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier>
    {
        public WPUpdateNameOnlyOfBuildVM()
            : base(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier())
        {
        }

        public WPUpdateNameOnlyOfBuildVM(MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteriaOfMasterEntity)
            : base(criteriaOfMasterEntity)
        {
        }
    }
}


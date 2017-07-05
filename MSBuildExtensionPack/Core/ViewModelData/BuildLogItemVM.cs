using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MSBuildExtensionPack.ViewModelData
{
    public partial class BuildLogItemVM : Framework.ViewModels.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
    {
        #region log4net

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_Organization { get; set; }

            public Framework.NameValueCollection NameValueCollectionOfMSBuildExtensionPack_BuildEventCode { get; set; }

	}
}


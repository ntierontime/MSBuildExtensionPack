using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLL
{

    /// <summary>
    /// Build MS Chart of MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView
    /// </summary>
    public partial class OrganizationChartBuilderDefaultGroupedDataView: Framework.Charting.MSChartBuilder<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView>
    {
        #region 4.1. To Implement: Build X axis

        /// <summary>
        /// Builds the x Axis.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        protected override object BuildXAxis(MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView item)
        {
            return item.Name;
        }

        #endregion 4.1. Implement: Build X axis

        #region 4.2. Implement: Build Y axis

        /// <summary>
        /// Builds the y Axis.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        protected override double BuildYAxis(MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView item)
        {
            return item.CountPerFK;
        }

        #endregion 4.2. Implement: Build Y axis
    }

}

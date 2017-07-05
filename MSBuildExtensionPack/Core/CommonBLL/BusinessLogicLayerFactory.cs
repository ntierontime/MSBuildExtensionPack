using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLL
{
    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
	public partial class BusinessLogicLayerFactory : MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory
    {
        #region Entity related


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BuildService</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BuildService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BuildEventCodeService</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildEventCodeService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BuildEventCodeService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BuildLogService</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildLogService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BuildLogService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Organization"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of OrganizationService</returns>
        public MSBuildExtensionPack.WcfContracts.IOrganizationService CreateBLLInstanceOfEntityOrganization(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new OrganizationService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of SolutionService</returns>
        public MSBuildExtensionPack.WcfContracts.ISolutionService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new SolutionService(businessLogicLayerContext);
        }



        #endregion Entity related
    }

    /// <summary>
    /// Singleton of <see cref="BusinessLogicLayerFactory"/>
    /// </summary>
    public class BusinessLogicLayerFactorySingleton
        : Framework.Singleton<BusinessLogicLayerFactory>
    {
    }
}
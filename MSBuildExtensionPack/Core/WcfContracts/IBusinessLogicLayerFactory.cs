using System;
namespace MSBuildExtensionPack.WcfContracts
{
    public partial interface IBusinessLogicLayerFactory
    {

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildService</returns>
        IBuildService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildEventCodeService</returns>
        IBuildEventCodeService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildLogService</returns>
        IBuildLogService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Organization"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IOrganizationService</returns>
        IOrganizationService CreateBLLInstanceOfEntityOrganization(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of ISolutionService</returns>
        ISolutionService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

    }

    public partial interface IBusinessLogicLayerFactoryAsyn
    {

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildServiceAsyn</returns>
        IBuildServiceAsyn CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildEventCodeServiceAsyn</returns>
        IBuildEventCodeServiceAsyn CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildLogServiceAsyn</returns>
        IBuildLogServiceAsyn CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Organization"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IOrganizationServiceAsyn</returns>
        IOrganizationServiceAsyn CreateBLLInstanceOfEntityOrganization(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of ISolutionServiceAsyn</returns>
        ISolutionServiceAsyn CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);

    }
}
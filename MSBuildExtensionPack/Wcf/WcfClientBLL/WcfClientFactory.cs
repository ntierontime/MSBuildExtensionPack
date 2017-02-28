using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.WcfClientBLL
{
    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
    public class WcfClientFactory : MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory
    {
        #region Entity related


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.IBuildService</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityBuild();
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.IBuildEventCodeService</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildEventCodeService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityBuildEventCode();
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.IBuildLogService</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildLogService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityBuildLog();
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.ISolutionService</returns>
        public MSBuildExtensionPack.WcfContracts.ISolutionService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntitySolution();
		}




        #endregion Entity related
    }

    /// <summary>
    /// Singleton of <see cref="WcfClientFactory"/>
    /// </summary>
    public class WcfClientFactorySingleton
        : Framework.Singleton<WcfClientFactory>
    {
    }

    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
    public class WcfClientFactoryAsyn : MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn
    {

#if NETFX_CORE && DEBUG
//  for WinRT/NETFX_CORE debug, because no app.config file

        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuild = "http://localhost:10805/WcfMarkupBuild.svc";    


        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuildEventCode = "http://localhost:10805/WcfMarkupBuildEventCode.svc";    


        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuildLog = "http://localhost:10805/WcfMarkupBuildLog.svc";    


        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynSolution = "http://localhost:10805/WcfMarkupSolution.svc";    


#elif NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file

        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuild = "http://localhost:10805/WcfMarkupBuild.svc";    


        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuildEventCode = "http://localhost:10805/WcfMarkupBuildEventCode.svc";    


        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuildLog = "http://localhost:10805/WcfMarkupBuildLog.svc";    


        public const string Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynSolution = "http://localhost:10805/WcfMarkupSolution.svc";    

    
#endif

        #region Entity related

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.IBuildServiceAsyn</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildServiceAsyn CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynBuild(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuild));
#else
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynBuild();
#endif
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynBuildEventCode(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuildEventCode));
#else
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynBuildEventCode();
#endif
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn</returns>
        public MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynBuildLog(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynBuildLog));
#else
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynBuildLog();
#endif
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildExtensionPack.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildExtensionPack.WcfContracts.ISolutionServiceAsyn</returns>
        public MSBuildExtensionPack.WcfContracts.ISolutionServiceAsyn CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynSolution(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildExtensionPack_WcfClientBLL_WcfClientEntityAsynSolution));
#else
			return new MSBuildExtensionPack.WcfClientBLL.WcfClientEntityAsynSolution();
#endif
		}



        #endregion Entity related
    }

    /// <summary>
    /// Singleton of <see cref="WcfClientFactoryAsyn"/>
    /// </summary>
    public class WcfClientFactoryAsynSingleton
        : Framework.Singleton<WcfClientFactoryAsyn>
    {
    }
}
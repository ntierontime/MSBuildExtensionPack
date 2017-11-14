using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Microsoft.Practices.Unity;

namespace MSBuildExtensionPack.WcfContracts
{
    public static partial class WcfServiceResolver
    {

        public static MSBuildExtensionPack.WcfContracts.IBuildService ResolveWcfServiceBuild()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuild(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.IBuildEventCodeService ResolveWcfServiceBuildEventCode()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildExtensionPack.WcfContracts.IBuildEventCodeService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildEventCode(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.IBuildLogService ResolveWcfServiceBuildLog()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildLog(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.IOrganizationService ResolveWcfServiceOrganization()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityOrganization(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.ISolutionService ResolveWcfServiceSolution()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntitySolution(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

    }

    public static partial class WcfServiceResolverAsyn
    {

        public static MSBuildExtensionPack.WcfContracts.IBuildServiceAsyn ResolveWcfServiceBuild()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildExtensionPack.WcfContracts.IBuildServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuild(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn ResolveWcfServiceBuildEventCode()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildExtensionPack.WcfContracts.IBuildEventCodeServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildEventCode(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn ResolveWcfServiceBuildLog()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildExtensionPack.WcfContracts.IBuildLogServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildLog(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.IOrganizationServiceAsyn ResolveWcfServiceOrganization()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildExtensionPack.WcfContracts.IOrganizationServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityOrganization(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

        public static MSBuildExtensionPack.WcfContracts.ISolutionServiceAsyn ResolveWcfServiceSolution()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildExtensionPack.WcfContracts.ISolutionServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntitySolution(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }

    }
}


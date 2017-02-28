using System.Windows;
using GalaSoft.MvvmLight.Threading;


namespace MSBuildExtensionPack.WPF4App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer, Framework.CommonBLLEntities.BusinessLogicLayerContextContainerCommon>();

			#region Asyncronized wcf method call

            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn, MSBuildExtensionPack.WcfClientBLL.WcfClientFactoryAsyn>();
			
            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory, MSBuildExtensionPack.WcfClientBLL.WcfClientFactory>();
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only

            Framework.CommonBLLEntities.BusinessLogicLayerMemberShip _BusinessLogicLayerMemberShip = new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip();
            Framework.CommonBLLEntities.SessionVariablesCommon.BusinessLogicLayerContext = new Framework.CommonBLLEntities.BusinessLogicLayerContext(_BusinessLogicLayerMemberShip);

			DispatcherHelper.Initialize();
        }
    }
}
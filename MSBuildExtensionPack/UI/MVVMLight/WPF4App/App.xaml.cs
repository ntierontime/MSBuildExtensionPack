using System.Windows;
using GalaSoft.MvvmLight.Threading;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.WPF4App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
			Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.Xaml.IDispatcherHelperWrapper, MSBuildExtensionPack.WPF4App.DispatcherHelperWrapper>();
			MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl = System.Configuration.ConfigurationManager.AppSettings[Framework.ViewModels.ApiControllerHttpClientBase.WebApiRootUrlAppSettingName];
			DispatcherHelper.Initialize();

            if (true)
            {
                var task = Test_HeartBeat();
                task.Wait();
                var b = task.Result;
            }

            if (true)
            {
                var task = Test_GetBuildLogItem();
                task.Wait();
                var b = task.Result;
            }

            if (true)
            {
                var task = Test_GetWPCommonOfBuildLogVM();
                task.Wait();
                var b = task.Result;
            }

            if (true)
            {
                Test_GetWPCommonOfBuildLogVM_ViewModel_Search();
            }

            #region for async wcf calls -- to-be-removed
            //Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer, Framework.CommonBLLEntities.BusinessLogicLayerContextContainerCommon>();
            //Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn, MSBuildExtensionPack.WcfClientBLL.WcfClientFactoryAsyn>();
            //Framework.CommonBLLEntities.BusinessLogicLayerMemberShip _BusinessLogicLayerMemberShip = new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip();
            //Framework.CommonBLLEntities.SessionVariablesCommon.BusinessLogicLayerContext = new Framework.CommonBLLEntities.BusinessLogicLayerContext(_BusinessLogicLayerMemberShip);
            #endregion for async wcf calls -- to-be-removed

            #region Syncronized wcf method call -- not in use/WPF only -- to-be-removed

            /*
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactory, MSBuildExtensionPack.WcfClientBLL.WcfClientFactory>();
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only -- to-be-removed
        }

        public static async Task<bool> Test_HeartBeat()
        {
            HttpClient client = new HttpClient();
            string urlA = "http://localhost:10812/api/BuildLogApi/HeartBeat";
            var a = new Uri(urlA);
            //client.BaseAddress = a;

            var response = await client.GetAsync(urlA);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(response.Content.Headers.ContentLength);
                //JsonConvert
                bool realresult;
                if (Boolean.TryParse(result, out realresult))
                {
                    return realresult;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                Console.WriteLine("hijklmn");
                return false;
            }
        }

        public static async Task<bool> Test_GetBuildLogItem()
        {
            HttpClient client = new HttpClient();
            string urlA = "http://localhost:10812/api/BuildLogApi/GetBuildLogItemVM?id=1";
            var a = new Uri(urlA);
            //client.BaseAddress = a;

            var response = await client.GetAsync(urlA);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(response.Content.Headers.ContentLength);

                return true;

            }
            else
            {
                Console.WriteLine("hijklmn");
                return false;
            }
        }


        public static async Task<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM> Test_GetWPCommonOfBuildLogVM()
        {
            var vmData = new MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM();
            vmData.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten();
            vmData.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            vmData.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection();

            MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient client = new MSBuildExtensionPack.WebApiClient.BuildLogApiControllerClient("http://localhost:10812/api/");

            var resultVMData = await client.GetWPCommonOfBuildLogVMAsync(vmData);

            return resultVMData;
        }


        public static void Test_GetWPCommonOfBuildLogVM_ViewModel_Search()
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl = System.Configuration.ConfigurationManager.AppSettings[Framework.ViewModels.ApiControllerHttpClientBase.WebApiRootUrlAppSettingName];

            var vmData = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM();
            vmData.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon();
            vmData.QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(1, 10);
            vmData.QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection();

            vmData.SearchForUnitTest();

        }
    }
}



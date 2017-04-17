using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest_VM
    {
        public const string WebApiRootUrlAppSettingName = "WebApiRootUrl";

        [TestMethod]
        public void Test()
        {
            if (true)
            {
                MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM vm = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM();
                //vm.Search();
            }


        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl = System.Configuration.ConfigurationManager.AppSettings[Framework.ViewModels.ApiControllerHttpClientBase.WebApiRootUrlAppSettingName];
        }

        [TestInitialize()]
        public void Initialize()
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl = System.Configuration.ConfigurationManager.AppSettings[Framework.ViewModels.ApiControllerHttpClientBase.WebApiRootUrlAppSettingName];
        }
    }
}

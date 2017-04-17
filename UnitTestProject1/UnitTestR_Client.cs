using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestR_Client
    {
        [TestMethod]
        public void Test()
        {
            //if (true)
            //{
            //    var task = Test_HeartBeat();
            //    task.Wait();
            //    var b = task.Result;

            //}

            //if (true)
            //{
            //    var task = Test_GetBuildLogItem();
            //    task.Wait();
            //    var b = task.Result;
            //}

            //if (true)
            //{
            //    var task = Test_GetWPCommonOfBuildLogVM();
            //    task.Wait();
            //    var b = task.Result;
            //}

            if (true)
            {
                Test_GetWPCommonOfBuildLogVM_ViewModel_Search();
            }

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
                if(Boolean.TryParse(result, out realresult))
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

                return false;

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

        public static async Task<bool> Test_GetWPCommonOfBuildLogVM_HttpClient()
        {
            HttpClient client = new HttpClient();
            string urlA = "http://localhost:10812/api/BuildLogApi/GetWPCommonOfBuildLogVM";

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, urlA);
            
            httpRequestMessage.Content = new StringContent(Request, System.Text.Encoding.UTF8, "application/json");

            var response = await client.SendAsync(httpRequestMessage);

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

        public const string Request =
@"{
   ""criteria"":{
      ""isToCompareIdCommonOfBuild_1OfCommon"":true,
      ""valueToCompareIdCommonOfBuild_1OfCommon"":2,
      ""isToCompareIdCommonOfSolution_1OfCommon"":false,
      ""valueToCompareIdCommonOfSolution_1OfCommon"":0,
      ""isToCompareIdCommonOfBuildEventCode_1OfCommon"":false,
      ""valueToCompareIdCommonOfBuildEventCode_1OfCommon"":0,
      ""isToCompareEventTimeCommonOftOfCommon"":false,
      ""isToCompareLowerBoundEventTimeCommonOftOfCommon"":false,
      ""lowerBoundEventTimeCommonOftOfCommon"":""2017-03-16T14:17:40.4014188-04:00"",
      ""isToCompareUpperBoundEventTimeCommonOftOfCommon"":false,
      ""upperBoundEventTimeCommonOftOfCommon"":""2017-03-16T14:17:40.4014188-04:00"",
      ""isToCompareMessageCommonOftOfCommon"":false,
      ""valueToBeContainedMessageCommonOftOfCommon"":null
   },
   ""queryPagingSetting"":{
      ""currentPage"":1,
      ""currentIndex"":0,
      ""endIndex"":10,
      ""pageSize"":10,
      ""originalPageSize"":10,
      ""pageSizeChanged"":false,
      ""countOfRecords"":9686,
      ""countOfPages"":969,
      ""recordCountOfCurrentPage"":10,
      ""pageSizeSelectionList"":[
         {
            ""value"":""10"",
            ""name"":""10""
         },
         {
            ""value"":""20"",
            ""name"":""20""
         },
         {
            ""value"":""50"",
            ""name"":""50""
         },
         {
            ""value"":""100"",
            ""name"":""100""
         }
      ],
   },
   ""queryOrderBySettingCollecionInString"":null,
   ""originalQueryOrderBySettingCollecionInString"":null,
   ""listOfQueryOrderBySettingCollecionInString"":null,
   ""listOfDataExport"":null,
   ""queryOrderBySettingCollection"":null
}";
    }
}

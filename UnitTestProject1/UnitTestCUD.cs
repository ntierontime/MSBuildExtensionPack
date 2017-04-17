using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestCUD
    {
        [TestMethod]
        public void Test()
        {
            //if (true)
            //{
            //    var task = TestC_Post();
            //    task.Wait();
            //    var b = task.Result;
            //}

            if (true)
            {
                var task = TestU_Put();
                task.Wait();
                var b = task.Result;
            }

            //if (true)
            //{
            //    var task = Test3();
            //    task.Wait();
            //    var b = task.Result;
            //}
        }
        public static async Task<string> TestC_Post()
        {
            MSBuildExtensionPack.DataSourceEntities.BuildLog buildLog = new MSBuildExtensionPack.DataSourceEntities.BuildLog();
            HttpClient client = new HttpClient();
            string url = "http://localhost:10812/api/BuildLogApi/InsertEntity";


            string request = InsertEntityRequest;// JsonConvert.SerializeObject(buildLog);
            var httpContent = new StringContent(request, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, httpContent);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        static string InsertEntityRequest =
@"{  
      ""build_1_Name"":""NtierOnTimeTechnologies_20160713213841"",
      ""id"":1,
      ""solution_1Id"":1,
      ""solution_1_Name"":""NtierOnTimeTechnologies"",
      ""buildEventCode_1_Name"":""TimeElapsed"",
      ""buildId"":4,
      ""buildEventCodeId"":12,
      ""message"":""Build started."",
      ""eventTime"":""2016-07-13T00:00:00""
   }
";

        public static async Task<string> TestU_Put()
        {
            string request1 = string.Format(Format_UpdateEntityRequest, DateTime.Now.ToString("yyyyMMddHHmmss"));// JsonConvert.SerializeObject(buildLog);
            HttpClient client = new HttpClient();
            string url = "http://localhost:10812/api/BuildLogApi/UpdateEntity";


            string request = request1;
            var httpContent = new StringContent(request, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, httpContent);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        static string Format_UpdateEntityRequest =
@"{{  
      ""build_1_Name"":""NtierOnTimeTechnologies"",
      ""id"":1,
      ""solution_1Id"":1,
      ""solution_1_Name"":""NtierOnTimeTechnologies"",
      ""buildEventCode_1_Name"":""TimeElapsed"",
      ""buildId"":4,
      ""buildEventCodeId"":12,
      ""message"":""Build started. {0}."",
      ""eventTime"":""2016-07-13T00:00:00""
   }}
";


        public static async Task<string> TestD_Delete()
        {
            string request1 = string.Format(Format_UpdateEntityRequest, DateTime.Now.ToString("yyyyMMddHHmmss"));// JsonConvert.SerializeObject(buildLog);
            HttpClient client = new HttpClient();
            string url = "http://localhost:10812/api/BuildLogApi/DeleteByIdentifier?id=1000";

            var response = await client.DeleteAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}

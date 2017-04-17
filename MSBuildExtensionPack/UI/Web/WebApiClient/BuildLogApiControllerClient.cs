using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Framework.EntityContracts;
using Framework.ViewModels;
using System.Threading.Tasks;
using System.Net.Http;

namespace MSBuildExtensionPack.WebApiClient
{
    /// <summary>

    /// </summary>
    public partial class BuildLogApiControllerClient : Framework.ViewModels.ApiControllerHttpClientBase
    {
        #region fields and properties

        public const string ControllerNameString = "BuildLogApi";
        public override string ControllerName
        {
            get
            {
                return ControllerNameString;
            }
        }

        #endregion fields and properties

        #region contructors

        public BuildLogApiControllerClient(string rootPath) : base(rootPath)
        {
        }

        #endregion contructors

        #region insert, update and delete in an entity -- Async

        public const string ActionName_InsertEntity = "InsertEntity";
        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/InsertEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> InsertEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_UpdateEntity = "UpdateEntity";
        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/UpdateEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> UpdateEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Put<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_DeleteByIdentifierEntity = "DeleteByIdentifierEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier.
        /// http://[host]/api/BuildLogApi/DeleteByIdentifierEntity
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> DeleteByIdentifierEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifierEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, identifier);
        }

        public const string ActionName_DeleteEntity = "DeleteEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// http://[host]/api/BuildLogApi/DeleteEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> DeleteEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        #endregion insert, update and delete in an entity -- Async

        #region insert, update and delete in an entity -- Sync

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/InsertEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntitySync(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return Task.Run(() => Post<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input)).Result;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/UpdateEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntitySync(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return Task.Run(() => Put<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input)).Result;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier.
        /// http://[host]/api/BuildLogApi/DeleteByIdentifierEntity
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntitySync(
            MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifierEntity);

            return Task.Run(() => Post<MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, identifier)).Result;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// http://[host]/api/BuildLogApi/DeleteEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntitySync(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return Task.Run(() => Post<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input)).Result;
        }

        #endregion insert, update and delete in an entity -- Sync

        #region delete using .Net value types -- Async

        public const string ActionName_DeleteByIdentifier = "DeleteByIdentifier";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// http://[host]/api/BuildLogApi/DeleteByIdentifier
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> DeleteByIdentifierAsync(
            System.Int64 id
            )
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Delete<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url);
        }

        #endregion delete using .Net value types -- Async

        #region delete using .Net value types -- Sync

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// http://[host]/api/BuildLogApi/DeleteByIdentifier
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierSync(
            System.Int64 id
            )
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return Task.Run(() => Delete<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url)).Result;
        }

        #endregion delete using .Net value types -- Sync

        #region batch insert, update and delete in an entity collection - async

        public const string ActionName_BatchInsert = "BatchInsert";
        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/BatchInsert
        /// </summary>
        /// <param name="input">The input collection.</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchInsertAsync(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchInsert);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchUpdate = "BatchUpdate";
        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/BatchUpdate
        /// </summary>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchUpdateAsync(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchUpdate);

            return await Put<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchDelete = "BatchDelete";
        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/BatchDelete
        /// </summary>
        /// <param name="input">The input collection.</param>
        // [HttpDelete, ActionName("BatchDelete")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchDeleteAsync(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchDelete);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        #endregion batch insert, update and delete in an entity collection - async


        #region batch insert, update and delete in an entity collection - sync

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/BatchInsert
        /// </summary>
        /// <param name="input">The input collection.</param>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsertSync(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchInsert);

            return Task.Run(() => Post<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input)).Result;
        }

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/BatchUpdate
        /// </summary>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdateSync(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchUpdate);

            return Task.Run(() => Put<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input)).Result;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// http://[host]/api/BuildLogApi/BatchDelete
        /// </summary>
        /// <param name="input">The input collection.</param>
        // [HttpDelete, ActionName("BatchDelete")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDeleteSync(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchDelete);

            return Task.Run(() => Post<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input)).Result;
        }

        #endregion batch insert, update and delete in an entity collection - sync

        #region Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfAll = "GetCollectionOfNameValuePairOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfNameValuePairOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfAllAsync(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression.ToString());

			string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfAll, parameters);
            return await Get<Framework.NameValueCollection>(url);
		}

        public Framework.NameValueCollection GetCollectionOfNameValuePairOfAllSync(
    int currentIndex
    , int pageSize
    , string queryOrderByExpression
    )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression.ToString());

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfAll, parameters);

            return Task.Run(() => Get<Framework.NameValueCollection>(url)).Result;
        }

        #endregion Query Methods Of NameValuePair of All per value type




        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
			parameters.Add("isToCompareIdByFKOnlyOfBuild_1OfByFKOnly", isToCompareIdByFKOnlyOfBuild_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly", valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly.ToString());
			parameters.Add("isToCompareIdByFKOnlyOfSolution_1OfByFKOnly", isToCompareIdByFKOnlyOfSolution_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly", valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.ToString());
			parameters.Add("isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly", isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly", valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression.ToString());

			string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
		}

        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnlySync(
    bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
    , bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
    , bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
    , int currentIndex
    , int pageSize
    , string queryOrderByExpression
    )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("isToCompareIdByFKOnlyOfBuild_1OfByFKOnly", isToCompareIdByFKOnlyOfBuild_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly", valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly.ToString());
            parameters.Add("isToCompareIdByFKOnlyOfSolution_1OfByFKOnly", isToCompareIdByFKOnlyOfSolution_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly", valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.ToString());
            parameters.Add("isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly", isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly", valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression.ToString());

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);

            return Task.Run(() => Get<Framework.NameValueCollection>(url)).Result;
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type





        public const string ActionName_GetBuildLogItemVM = "GetBuildLogItemVM";
        /// <summary>
        /// Gets the build log item.
        /// http://[host]/api/BuildLogApi/GetBuildLogItemVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.BuildLogItemVM> GetBuildLogItemVMAsync(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetBuildLogItemVM, parameters);

            return await GetItemViewModel<MSBuildExtensionPack.ViewModelData.BuildLogItemVM>(url);
        }

        public MSBuildExtensionPack.ViewModelData.BuildLogItemVM GetBuildLogItemVMSync(
    System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetBuildLogItemVM, parameters);

            return Task.Run(() => GetItemViewModel<MSBuildExtensionPack.ViewModelData.BuildLogItemVM>(url)).Result;
        }

        public const string ActionName_GetWPCommonOfBuildLogVM = "GetWPCommonOfBuildLogVM";
        /// <summary>
        /// Gets the wp common of build log vm.
        /// http://[host]/api/BuildLogApi/GetWPCommonOfBuildLogVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM> GetWPCommonOfBuildLogVMAsync(
            MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_GetWPCommonOfBuildLogVM);

            return await Post<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM>(url, vm);
        }

        public MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM GetWPCommonOfBuildLogVMSync(
    MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_GetWPCommonOfBuildLogVM);

            return Task.Run(() => Post<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM>(url, vm)).Result;
        }
        

        public const string ActionName_GetWPEntityRelatedOfBuildLogVM = "GetWPEntityRelatedOfBuildLogVM";
        /// <summary>
        /// Gets the wp entity related of build log.
        /// http://[host]/api/BuildLogApi/GetWPEntityRelatedOfBuildLogVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildLogVM> GetWPEntityRelatedOfBuildLogVMAsync(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetWPEntityRelatedOfBuildLogVM, parameters);

            return await GetEntityRelated<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildLogVM>(url);
        }

        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildLogVM GetWPEntityRelatedOfBuildLogVMSync(
    System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetWPEntityRelatedOfBuildLogVM, parameters);

            return Task.Run(() => GetEntityRelated<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildLogVM>(url)).Result;
        }

        public const string ActionName_HeartBeat = "HeartBeat";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/BuildLogApi/HeartBeat
        /// </summary>
        /// <returns></returns>
        public async Task<HttpResponseMessage> HeartBeatAsync()
        {
            string url = GetHttpRequestUrl(ActionName_HeartBeat);
            var response = await Client.GetAsync(url);

            return response;
        }
        public HttpResponseMessage HeartBeatSync()
        {
            return Task.Run(() => {
                string url = GetHttpRequestUrl(ActionName_HeartBeat);
                var response = Client.GetAsync(url);

                return response;
            }).Result;
        }
    }
}


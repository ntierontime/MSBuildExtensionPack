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

        #region insert, update and delete in an entity

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
            string url = GetHttpRequestUrl(ActionName_UpdateEntity);

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
            string url = GetHttpRequestUrl(ActionName_DeleteEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

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
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifier);

            return await Delete<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url);
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

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

        #endregion batch insert, update and delete in an entity collection

        #region Query Methods Of NameValuePair of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName___GetCollectionOfNameValuePairOfAll = "__GetCollectionOfNameValuePairOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/__GetCollectionOfNameValuePairOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> __GetCollectionOfNameValuePairOfAllAsync(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName___GetCollectionOfNameValuePairOfAll, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of All per value type

        #region Query Methods Of NameValuePair of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName___GetCollectionOfNameValuePairOfByFKOnly = "__GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/__GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> __GetCollectionOfNameValuePairOfByFKOnlyAsync(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("buildId", buildId.ToString());
            parameters.Add("solution_1Id", solution_1Id.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("buildEventCodeId", buildEventCodeId.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName___GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
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
    }
}


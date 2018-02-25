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
    public partial class BuildEventCodeApiControllerClient : Framework.ViewModels.ApiControllerHttpClientBase
    {
        #region fields and properties

        public const string ControllerNameString = "BuildEventCodeApi";
        public override string ControllerName
        {
            get
            {
                return ControllerNameString;
            }
        }

        #endregion fields and properties

        #region contructors

        public BuildEventCodeApiControllerClient(string rootPath) : base(rootPath)
        {
        }

        #endregion contructors

        #region insert, update and delete in an entity

        public const string ActionName_InsertEntity = "InsertEntity";
        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// http://[host]/api/BuildEventCodeApi/InsertEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> InsertEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_UpdateEntity = "UpdateEntity";
        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// http://[host]/api/BuildEventCodeApi/UpdateEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> UpdateEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode input)
        {
            string url = GetHttpRequestUrl(ActionName_UpdateEntity);

            return await Put<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_DeleteByIdentifierEntity = "DeleteByIdentifierEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/> by identifier.
        /// http://[host]/api/BuildEventCodeApi/DeleteByIdentifierEntity
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> DeleteByIdentifierEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier identifier)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifierEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, identifier);
        }

        public const string ActionName_DeleteEntity = "DeleteEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/> using .net value types.
        /// http://[host]/api/BuildEventCodeApi/DeleteEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> DeleteEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode input)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildEventCode, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, input);
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        public const string ActionName_DeleteByIdentifier = "DeleteByIdentifier";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/> by identifier using .net value types.
        /// http://[host]/api/BuildEventCodeApi/DeleteByIdentifier
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> DeleteByIdentifierAsync(
            System.Int64 id
            )
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifier);

            return await Delete<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url);
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        public const string ActionName_BatchInsert = "BatchInsert";
        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// http://[host]/api/BuildEventCodeApi/BatchInsert
        /// </summary>
        /// <param name="input">The input collection.</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> BatchInsertAsync(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchInsert);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchUpdate = "BatchUpdate";
        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// http://[host]/api/BuildEventCodeApi/BatchUpdate
        /// </summary>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> BatchUpdateAsync(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchUpdate);

            return await Put<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchDelete = "BatchDelete";
        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// http://[host]/api/BuildEventCodeApi/BatchDelete
        /// </summary>
        /// <param name="input">The input collection.</param>
        // [HttpDelete, ActionName("BatchDelete")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> BatchDeleteAsync(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchDelete);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection, MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(url, input);
        }

        #endregion batch insert, update and delete in an entity collection

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of NameValuePairByAll

        public const string ActionName_GetCollectionOfNameValuePairByAll = "GetCollectionOfNameValuePairByAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildEventCodeApi/GetCollectionOfNameValuePairByAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairByAllAsync(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairByAll, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePairByAll

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        public const string ActionName_GetBuildEventCodeItemVM = "GetBuildEventCodeItemVM";
        /// <summary>
        /// Gets the build log item.
        /// http://[host]/api/BuildEventCodeApi/GetBuildEventCodeItemVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.BuildEventCodeItemVM> GetBuildEventCodeItemVMAsync(
            System.Int32 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetBuildEventCodeItemVM, parameters);

            return await GetItemViewModel<MSBuildExtensionPack.ViewModelData.BuildEventCodeItemVM>(url);
        }

            public const string ActionName_GetWPCommonOfBuildEventCodeVM = "GetWPCommonOfBuildEventCodeVM";
        /// <summary>
        /// Gets the wp common of build log vm.
        /// http://[host]/api/BuildEventCodeApi/GetWPCommonOfBuildEventCodeVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM> GetWPCommonOfBuildEventCodeVMAsync(
            MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_GetWPCommonOfBuildEventCodeVM);

            return await Post<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM>(url, vm);
        }

        public const string ActionName_HeartBeat = "HeartBeat";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/BuildEventCodeApi/HeartBeat
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


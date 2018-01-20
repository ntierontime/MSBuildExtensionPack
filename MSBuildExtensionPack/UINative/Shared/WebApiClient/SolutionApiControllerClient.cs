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
    public partial class SolutionApiControllerClient : Framework.ViewModels.ApiControllerHttpClientBase
    {
        #region fields and properties

        public const string ControllerNameString = "SolutionApi";
        public override string ControllerName
        {
            get
            {
                return ControllerNameString;
            }
        }

        #endregion fields and properties

        #region contructors

        public SolutionApiControllerClient(string rootPath) : base(rootPath)
        {
        }

        #endregion contructors

        #region insert, update and delete in an entity

        public const string ActionName_InsertEntity = "InsertEntity";
        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// http://[host]/api/SolutionApi/InsertEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> InsertEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_UpdateEntity = "UpdateEntity";
        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// http://[host]/api/SolutionApi/UpdateEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> UpdateEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            string url = GetHttpRequestUrl(ActionName_UpdateEntity);

            return await Put<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_DeleteByIdentifierEntity = "DeleteByIdentifierEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier.
        /// http://[host]/api/SolutionApi/DeleteByIdentifierEntity
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> DeleteByIdentifierEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier identifier)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifierEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, identifier);
        }

        public const string ActionName_DeleteEntity = "DeleteEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// http://[host]/api/SolutionApi/DeleteEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> DeleteEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, input);
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        public const string ActionName_DeleteByIdentifier = "DeleteByIdentifier";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier using .net value types.
        /// http://[host]/api/SolutionApi/DeleteByIdentifier
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> DeleteByIdentifierAsync(
            System.Int64 id
            )
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifier);

            return await Delete<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url);
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        public const string ActionName_BatchInsert = "BatchInsert";
        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// http://[host]/api/SolutionApi/BatchInsert
        /// </summary>
        /// <param name="input">The input collection.</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchInsertAsync(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchInsert);

            return await Post<MSBuildExtensionPack.DataSourceEntities.SolutionCollection, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchUpdate = "BatchUpdate";
        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// http://[host]/api/SolutionApi/BatchUpdate
        /// </summary>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchUpdateAsync(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchUpdate);

            return await Put<MSBuildExtensionPack.DataSourceEntities.SolutionCollection, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchDelete = "BatchDelete";
        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// http://[host]/api/SolutionApi/BatchDelete
        /// </summary>
        /// <param name="input">The input collection.</param>
        // [HttpDelete, ActionName("BatchDelete")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchDeleteAsync(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchDelete);

            return await Post<MSBuildExtensionPack.DataSourceEntities.SolutionCollection, MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(url, input);
        }

        #endregion batch insert, update and delete in an entity collection

        #region Query Methods Of NameValuePair of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfAll = "GetCollectionOfNameValuePairOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfNameValuePairOfAll
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
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfAll, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of All per value type

        #region Query Methods Of NameValuePair of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
            bool isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly", isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly", valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.ToString());
            parameters.Add("isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly", isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly", valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type

        public const string ActionName_GetSolutionItemVM = "GetSolutionItemVM";
        /// <summary>
        /// Gets the build log item.
        /// http://[host]/api/SolutionApi/GetSolutionItemVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.SolutionItemVM> GetSolutionItemVMAsync(
            System.Int32 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetSolutionItemVM, parameters);

            return await GetItemViewModel<MSBuildExtensionPack.ViewModelData.SolutionItemVM>(url);
        }

            public const string ActionName_GetWPCommonOfSolutionVM = "GetWPCommonOfSolutionVM";
        /// <summary>
        /// Gets the wp common of build log vm.
        /// http://[host]/api/SolutionApi/GetWPCommonOfSolutionVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM> GetWPCommonOfSolutionVMAsync(
            MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_GetWPCommonOfSolutionVM);

            return await Post<MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM>(url, vm);
        }

        public const string ActionName_GetWPEntityRelatedOfSolutionVM = "GetWPEntityRelatedOfSolutionVM";
        /// <summary>
        /// Gets the wp entity related of build log.
        /// http://[host]/api/SolutionApi/GetWPEntityRelatedOfSolutionVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfSolutionVM> GetWPEntityRelatedOfSolutionVMAsync(
            System.Int32 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetWPEntityRelatedOfSolutionVM, parameters);

            return await GetEntityRelated<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfSolutionVM>(url);
        }

        public const string ActionName_HeartBeat = "HeartBeat";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/SolutionApi/HeartBeat
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


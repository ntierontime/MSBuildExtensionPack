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
    public partial class BuildApiControllerClient : Framework.ViewModels.ApiControllerHttpClientBase
    {
        #region fields and properties

        public const string ControllerNameString = "BuildApi";
        public override string ControllerName
        {
            get
            {
                return ControllerNameString;
            }
        }

        #endregion fields and properties

        #region contructors

        public BuildApiControllerClient(string rootPath) : base(rootPath)
        {
        }

        #endregion contructors

        #region insert, update and delete in an entity

        public const string ActionName_InsertEntity = "InsertEntity";
        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// http://[host]/api/BuildApi/InsertEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> InsertEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_UpdateEntity = "UpdateEntity";
        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// http://[host]/api/BuildApi/UpdateEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> UpdateEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            string url = GetHttpRequestUrl(ActionName_UpdateEntity);

            return await Put<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_DeleteByIdentifierEntity = "DeleteByIdentifierEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier.
        /// http://[host]/api/BuildApi/DeleteByIdentifierEntity
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> DeleteByIdentifierEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.BuildIdentifier identifier)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifierEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildIdentifier, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, identifier);
        }

        public const string ActionName_DeleteEntity = "DeleteEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// http://[host]/api/BuildApi/DeleteEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> DeleteEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, input);
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        public const string ActionName_DeleteByIdentifier = "DeleteByIdentifier";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier using .net value types.
        /// http://[host]/api/BuildApi/DeleteByIdentifier
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> DeleteByIdentifierAsync(
            System.Int64 id
            )
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Delete<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url);
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        public const string ActionName_BatchInsert = "BatchInsert";
        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// http://[host]/api/BuildApi/BatchInsert
        /// </summary>
        /// <param name="input">The input collection.</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchInsertAsync(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchInsert);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildCollection, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchUpdate = "BatchUpdate";
        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// http://[host]/api/BuildApi/BatchUpdate
        /// </summary>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchUpdateAsync(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchUpdate);

            return await Put<MSBuildExtensionPack.DataSourceEntities.BuildCollection, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchDelete = "BatchDelete";
        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// http://[host]/api/BuildApi/BatchDelete
        /// </summary>
        /// <param name="input">The input collection.</param>
        // [HttpDelete, ActionName("BatchDelete")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchDeleteAsync(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchDelete);

            return await Post<MSBuildExtensionPack.DataSourceEntities.BuildCollection, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(url, input);
        }

        #endregion batch insert, update and delete in an entity collection

        #region Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfAll = "GetCollectionOfNameValuePairOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfNameValuePairOfAll
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

        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
            bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32? valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly
            , bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("isToCompareIdByFKOnlyOfSolution_1OfByFKOnly", isToCompareIdByFKOnlyOfSolution_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly", valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.ToString());
            parameters.Add("isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly", isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly", valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.ToString());
            parameters.Add("isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly", isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.ToString()); parameters.Add("valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly", valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type

        public const string ActionName_GetBuildItemVM = "GetBuildItemVM";
        /// <summary>
        /// Gets the build log item.
        /// http://[host]/api/BuildApi/GetBuildItemVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.BuildItemVM> GetBuildItemVMAsync(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetBuildItemVM, parameters);

            return await GetItemViewModel<MSBuildExtensionPack.ViewModelData.BuildItemVM>(url);
        }

            public const string ActionName_GetWPCommonOfBuildVM = "GetWPCommonOfBuildVM";
        /// <summary>
        /// Gets the wp common of build log vm.
        /// http://[host]/api/BuildApi/GetWPCommonOfBuildVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM> GetWPCommonOfBuildVMAsync(
            MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_GetWPCommonOfBuildVM);

            return await Post<MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM>(url, vm);
        }

        public const string ActionName_GetWPEntityRelatedOfBuildVM = "GetWPEntityRelatedOfBuildVM";
        /// <summary>
        /// Gets the wp entity related of build log.
        /// http://[host]/api/BuildApi/GetWPEntityRelatedOfBuildVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildVM> GetWPEntityRelatedOfBuildVMAsync(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetWPEntityRelatedOfBuildVM, parameters);

            return await GetEntityRelated<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildVM>(url);
        }

        #region EntityUpdateActionSetting - UpdateNameOnly

        public const string ActionName_GetWPUpdateNameOnlyOfBuildVM = "GetWPUpdateNameOnlyOfBuildVM";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/BuildApi/GetWPUpdateNameOnlyOfBuildVM
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM> GetWPUpdateNameOnlyOfBuildVM(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetWPUpdateNameOnlyOfBuildVM, parameters);

            return await GetEntityRelated<MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM>(url);
        }

        public const string ActionName_WPUpdateNameOnlyOfBuildVM = "WPUpdateNameOnlyOfBuildVM";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/BuildApi/WPUpdateNameOnlyOfBuildVM
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM> WPUpdateNameOnlyOfBuildVM(MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_WPUpdateNameOnlyOfBuildVM);

            return await PostIViewModelEntityRelatedBase<MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM>(url, vm);
        }

        #endregion EntityUpdateActionSetting - UpdateNameOnly

        public const string ActionName_HeartBeat = "HeartBeat";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/BuildApi/HeartBeat
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


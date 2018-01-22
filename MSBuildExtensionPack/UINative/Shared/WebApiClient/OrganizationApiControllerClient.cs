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
    public partial class OrganizationApiControllerClient : Framework.ViewModels.ApiControllerHttpClientBase
    {
        #region fields and properties

        public const string ControllerNameString = "OrganizationApi";
        public override string ControllerName
        {
            get
            {
                return ControllerNameString;
            }
        }

        #endregion fields and properties

        #region contructors

        public OrganizationApiControllerClient(string rootPath) : base(rootPath)
        {
        }

        #endregion contructors

        #region insert, update and delete in an entity

        public const string ActionName_InsertEntity = "InsertEntity";
        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// http://[host]/api/OrganizationApi/InsertEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> InsertEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            string url = GetHttpRequestUrl(ActionName_InsertEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_UpdateEntity = "UpdateEntity";
        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// http://[host]/api/OrganizationApi/UpdateEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> UpdateEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            string url = GetHttpRequestUrl(ActionName_UpdateEntity);

            return await Put<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_DeleteByIdentifierEntity = "DeleteByIdentifierEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier.
        /// http://[host]/api/OrganizationApi/DeleteByIdentifierEntity
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> DeleteByIdentifierEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier identifier)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifierEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, identifier);
        }

        public const string ActionName_DeleteEntity = "DeleteEntity";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// http://[host]/api/OrganizationApi/DeleteEntity
        /// </summary>
        /// <param name="input">input entity</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> DeleteEntityAsync(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            string url = GetHttpRequestUrl(ActionName_DeleteEntity);

            return await Post<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, input);
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        public const string ActionName_DeleteByIdentifier = "DeleteByIdentifier";
        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier using .net value types.
        /// http://[host]/api/OrganizationApi/DeleteByIdentifier
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> DeleteByIdentifierAsync(
            System.Int64 id
            )
        {
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifier);

            return await Delete<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url);
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        public const string ActionName_BatchInsert = "BatchInsert";
        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// http://[host]/api/OrganizationApi/BatchInsert
        /// </summary>
        /// <param name="input">The input collection.</param>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchInsertAsync(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchInsert);

            return await Post<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchUpdate = "BatchUpdate";
        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// http://[host]/api/OrganizationApi/BatchUpdate
        /// </summary>
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchUpdateAsync(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchUpdate);

            return await Put<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, input);
        }

        public const string ActionName_BatchDelete = "BatchDelete";
        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// http://[host]/api/OrganizationApi/BatchDelete
        /// </summary>
        /// <param name="input">The input collection.</param>
        // [HttpDelete, ActionName("BatchDelete")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchDeleteAsync(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            string url = GetHttpRequestUrl(ActionName_BatchDelete);

            return await Post<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(url, input);
        }

        #endregion batch insert, update and delete in an entity collection

        #region Query Methods Of NameValuePair of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfAll = "GetCollectionOfNameValuePairOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfAll
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
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("isToCompareParentId", isToCompareParentId.ToString()); parameters.Add("parentId", parentId.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier = "GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierAsync(
            bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("isToCompareUniqueIdentifier", isToCompareUniqueIdentifier.ToString()); parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier per value type

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn per criteria, queryPagingSetting and queryOrderBySettingCollection

        public const string ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn = "GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnAsync(
            bool isToCompareUniqueidentifierColumn, System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("isToCompareUniqueidentifierColumn", isToCompareUniqueidentifierColumn.ToString()); parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn per value type

        public const string ActionName_GetOrganizationItemVM = "GetOrganizationItemVM";
        /// <summary>
        /// Gets the build log item.
        /// http://[host]/api/OrganizationApi/GetOrganizationItemVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.OrganizationItemVM> GetOrganizationItemVMAsync(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetOrganizationItemVM, parameters);

            return await GetItemViewModel<MSBuildExtensionPack.ViewModelData.OrganizationItemVM>(url);
        }

            public const string ActionName_GetWPCommonOfOrganizationVM = "GetWPCommonOfOrganizationVM";
        /// <summary>
        /// Gets the wp common of build log vm.
        /// http://[host]/api/OrganizationApi/GetWPCommonOfOrganizationVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM> GetWPCommonOfOrganizationVMAsync(
            MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM vm)
        {
            string url = GetHttpRequestUrl(ActionName_GetWPCommonOfOrganizationVM);

            return await Post<MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM>(url, vm);
        }

        public const string ActionName_GetWPEntityRelatedOfOrganizationVM = "GetWPEntityRelatedOfOrganizationVM";
        /// <summary>
        /// Gets the wp entity related of build log.
        /// http://[host]/api/OrganizationApi/GetWPEntityRelatedOfOrganizationVM?id=1
        /// </summary>
        /// <returns></returns>
        public async Task<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfOrganizationVM> GetWPEntityRelatedOfOrganizationVMAsync(
            System.Int64 id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            string url = GetHttpRequestUrl(ActionName_GetWPEntityRelatedOfOrganizationVM, parameters);

            return await GetEntityRelated<MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfOrganizationVM>(url);
        }

        public const string ActionName_HeartBeat = "HeartBeat";
        /// <summary>
        /// Hearts the beat asynchronous.
        /// http://[host]/api/OrganizationApi/HeartBeat
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


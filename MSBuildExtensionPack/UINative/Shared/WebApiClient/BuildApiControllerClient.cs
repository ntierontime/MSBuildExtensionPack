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
            string url = GetHttpRequestUrl(ActionName_DeleteEntity);

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
            string url = GetHttpRequestUrl(ActionName_DeleteByIdentifier);

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

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of EntityOfCommon

        public const string ActionName_GetCollectionOfEntityOfCommon = "GetCollectionOfEntityOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfEntityOfCommon
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildStartTimeRangeLow">value of lower bound</param>
        /// <param name="buildStartTimeRangeHigh">upper bound</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildCollection> GetCollectionOfEntityOfCommonAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.DateTime? buildStartTimeRangeLow, System.DateTime? buildStartTimeRangeHigh
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("buildStartTimeRangeLow", buildStartTimeRangeLow.ToString()); parameters.Add("buildStartTimeRangeHigh", buildStartTimeRangeHigh.ToString());
            parameters.Add("name", name.ToString());
            parameters.Add("description", description.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(url);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        public const string ActionName_GetCollectionOfDefaultOfCommon = "GetCollectionOfDefaultOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfDefaultOfCommon
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildStartTimeRangeLow">value of lower bound</param>
        /// <param name="buildStartTimeRangeHigh">upper bound</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection> GetCollectionOfDefaultOfCommonAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.DateTime? buildStartTimeRangeLow, System.DateTime? buildStartTimeRangeHigh
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("buildStartTimeRangeLow", buildStartTimeRangeLow.ToString()); parameters.Add("buildStartTimeRangeHigh", buildStartTimeRangeHigh.ToString());
            parameters.Add("name", name.ToString());
            parameters.Add("description", description.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        public const string ActionName_GetCollectionOfEntityOfAll = "GetCollectionOfEntityOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfEntityOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildCollection> GetCollectionOfEntityOfAllAsync(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfAll, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(url);
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

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

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        public const string ActionName_GetCollectionOfRssItemOfAll = "GetCollectionOfRssItemOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfRssItemOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public async Task<Framework.RssItemCollection> GetCollectionOfRssItemOfAllAsync(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfRssItemOfAll, parameters);
            return await Get<Framework.RssItemCollection>(url);
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        public const string ActionName_GetCollectionOfEntityOfByFKOnly = "GetCollectionOfEntityOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfEntityOfByFKOnly
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildCollection> GetCollectionOfEntityOfByFKOnlyAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(url);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        public const string ActionName_GetCollectionOfRssItemOfByFKOnly = "GetCollectionOfRssItemOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfRssItemOfByFKOnly
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public async Task<Framework.RssItemCollection> GetCollectionOfRssItemOfByFKOnlyAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfRssItemOfByFKOnly, parameters);
            return await Get<Framework.RssItemCollection>(url);
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        public const string ActionName_GetCollectionOfDefaultOfByFKOnly = "GetCollectionOfDefaultOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfDefaultOfByFKOnly
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection> GetCollectionOfDefaultOfByFKOnlyAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        public const string ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly = "GetCollectionOfDefaultGroupedDataViewOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfDefaultGroupedDataViewOfByFKOnly
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection> GetCollectionOfDefaultGroupedDataViewOfByFKOnlyAsync(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("solutionId", solutionId.ToString());
            parameters.Add("organization_1Id", organization_1Id.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>(url);
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        public const string ActionName_GetCollectionOfEntityOfByIdentifier = "GetCollectionOfEntityOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfEntityOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildCollection> GetCollectionOfEntityOfByIdentifierAsync(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfByIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(url);
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        public const string ActionName_GetCollectionOfDefaultOfByIdentifier = "GetCollectionOfDefaultOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfDefaultOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection> GetCollectionOfDefaultOfByIdentifierAsync(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfByIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of UpdateNameRequestOfByIdentifier

        public const string ActionName_GetCollectionOfUpdateNameRequestOfByIdentifier = "GetCollectionOfUpdateNameRequestOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfUpdateNameRequestOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection> GetCollectionOfUpdateNameRequestOfByIdentifierAsync(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfUpdateNameRequestOfByIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(url);
        }

        #endregion Query Methods Of UpdateNameRequestOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        public const string ActionName_GetCollectionOfKeyInformationOfByIdentifier = "GetCollectionOfKeyInformationOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildApi/GetCollectionOfKeyInformationOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection> GetCollectionOfKeyInformationOfByIdentifierAsync(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfKeyInformationOfByIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>(url);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

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


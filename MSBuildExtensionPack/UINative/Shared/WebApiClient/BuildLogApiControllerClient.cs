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

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of EntityOfCommon

        public const string ActionName_GetCollectionOfEntityOfCommon = "GetCollectionOfEntityOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfEntityOfCommon
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="eventTimeRangeLow">value of lower bound</param>
        /// <param name="eventTimeRangeHigh">upper bound</param>
        /// <param name="message" > value to compare/filter with message property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection> GetCollectionOfEntityOfCommonAsync(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , System.DateTime? eventTimeRangeLow, System.DateTime? eventTimeRangeHigh
            , System.String message
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
            parameters.Add("eventTimeRangeLow", eventTimeRangeLow.ToString()); parameters.Add("eventTimeRangeHigh", eventTimeRangeHigh.ToString());
            parameters.Add("message", message.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(url);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        public const string ActionName_GetCollectionOfDefaultOfCommon = "GetCollectionOfDefaultOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfDefaultOfCommon
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="eventTimeRangeLow">value of lower bound</param>
        /// <param name="eventTimeRangeHigh">upper bound</param>
        /// <param name="message" > value to compare/filter with message property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection> GetCollectionOfDefaultOfCommonAsync(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , System.DateTime? eventTimeRangeLow, System.DateTime? eventTimeRangeHigh
            , System.String message
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
            parameters.Add("eventTimeRangeLow", eventTimeRangeLow.ToString()); parameters.Add("eventTimeRangeHigh", eventTimeRangeHigh.ToString());
            parameters.Add("message", message.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        public const string ActionName_GetCollectionOfEntityOfAll = "GetCollectionOfEntityOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfEntityOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection> GetCollectionOfEntityOfAllAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(url);
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

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
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfAll, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        public const string ActionName_GetCollectionOfRssItemOfAll = "GetCollectionOfRssItemOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfRssItemOfAll
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
        /// http://[host]/api/BuildLogApi/GetCollectionOfEntityOfByFKOnly
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection> GetCollectionOfEntityOfByFKOnlyAsync(
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

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(url);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfNameValuePairOfByFKOnly
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
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
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

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        public const string ActionName_GetCollectionOfRssItemOfByFKOnly = "GetCollectionOfRssItemOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfRssItemOfByFKOnly
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public async Task<Framework.RssItemCollection> GetCollectionOfRssItemOfByFKOnlyAsync(
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

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfRssItemOfByFKOnly, parameters);
            return await Get<Framework.RssItemCollection>(url);
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        public const string ActionName_GetCollectionOfDefaultOfByFKOnly = "GetCollectionOfDefaultOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfDefaultOfByFKOnly
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection> GetCollectionOfDefaultOfByFKOnlyAsync(
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

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        public const string ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly = "GetCollectionOfDefaultGroupedDataViewOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfDefaultGroupedDataViewOfByFKOnly
        /// </summary>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection> GetCollectionOfDefaultGroupedDataViewOfByFKOnlyAsync(
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

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>(url);
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        public const string ActionName_GetCollectionOfEntityOfByIdentifier = "GetCollectionOfEntityOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfEntityOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection> GetCollectionOfEntityOfByIdentifierAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(url);
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        public const string ActionName_GetCollectionOfDefaultOfByIdentifier = "GetCollectionOfDefaultOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfDefaultOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection> GetCollectionOfDefaultOfByIdentifierAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        public const string ActionName_GetCollectionOfKeyInformationOfByIdentifier = "GetCollectionOfKeyInformationOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/BuildLogApi/GetCollectionOfKeyInformationOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection> GetCollectionOfKeyInformationOfByIdentifierAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>(url);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

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


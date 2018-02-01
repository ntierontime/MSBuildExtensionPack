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

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of EntityOfCommon

        public const string ActionName_GetCollectionOfEntityOfCommon = "GetCollectionOfEntityOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfCommon
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfCommonAsync(
            System.Int64? parentId
            , System.Boolean? isSystemBuiltIn
            , System.DateTime? createdDateTimeRangeLow, System.DateTime? createdDateTimeRangeHigh
            , System.Boolean? bitColumn
            , System.DateTime? datetimeColumnRangeLow, System.DateTime? datetimeColumnRangeHigh
            , System.DateTime? datetime2ColumnRangeLow, System.DateTime? datetime2ColumnRangeHigh
            , System.DateTime? smalldatetimeColumnRangeLow, System.DateTime? smalldatetimeColumnRangeHigh
            , System.DateTime? dateColumnRangeLow, System.DateTime? dateColumnRangeHigh
            , System.String name
            , System.String charColumn
            , System.String varcharColumn
            , System.String textColumn
            , System.String ncharColumn
            , System.String nvarcharColumn
            , System.String ntextColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
            parameters.Add("isSystemBuiltIn", isSystemBuiltIn.ToString());
            parameters.Add("createdDateTimeRangeLow", createdDateTimeRangeLow.ToString()); parameters.Add("createdDateTimeRangeHigh", createdDateTimeRangeHigh.ToString());
            parameters.Add("bitColumn", bitColumn.ToString());
            parameters.Add("datetimeColumnRangeLow", datetimeColumnRangeLow.ToString()); parameters.Add("datetimeColumnRangeHigh", datetimeColumnRangeHigh.ToString());
            parameters.Add("datetime2ColumnRangeLow", datetime2ColumnRangeLow.ToString()); parameters.Add("datetime2ColumnRangeHigh", datetime2ColumnRangeHigh.ToString());
            parameters.Add("smalldatetimeColumnRangeLow", smalldatetimeColumnRangeLow.ToString()); parameters.Add("smalldatetimeColumnRangeHigh", smalldatetimeColumnRangeHigh.ToString());
            parameters.Add("dateColumnRangeLow", dateColumnRangeLow.ToString()); parameters.Add("dateColumnRangeHigh", dateColumnRangeHigh.ToString());
            parameters.Add("name", name.ToString());
            parameters.Add("charColumn", charColumn.ToString());
            parameters.Add("varcharColumn", varcharColumn.ToString());
            parameters.Add("textColumn", textColumn.ToString());
            parameters.Add("ncharColumn", ncharColumn.ToString());
            parameters.Add("nvarcharColumn", nvarcharColumn.ToString());
            parameters.Add("ntextColumn", ntextColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        public const string ActionName_GetCollectionOfDefaultOfCommon = "GetCollectionOfDefaultOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultOfCommon
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection> GetCollectionOfDefaultOfCommonAsync(
            System.Int64? parentId
            , System.Boolean? isSystemBuiltIn
            , System.DateTime? createdDateTimeRangeLow, System.DateTime? createdDateTimeRangeHigh
            , System.Boolean? bitColumn
            , System.DateTime? datetimeColumnRangeLow, System.DateTime? datetimeColumnRangeHigh
            , System.DateTime? datetime2ColumnRangeLow, System.DateTime? datetime2ColumnRangeHigh
            , System.DateTime? smalldatetimeColumnRangeLow, System.DateTime? smalldatetimeColumnRangeHigh
            , System.DateTime? dateColumnRangeLow, System.DateTime? dateColumnRangeHigh
            , System.String name
            , System.String charColumn
            , System.String varcharColumn
            , System.String textColumn
            , System.String ncharColumn
            , System.String nvarcharColumn
            , System.String ntextColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
            parameters.Add("isSystemBuiltIn", isSystemBuiltIn.ToString());
            parameters.Add("createdDateTimeRangeLow", createdDateTimeRangeLow.ToString()); parameters.Add("createdDateTimeRangeHigh", createdDateTimeRangeHigh.ToString());
            parameters.Add("bitColumn", bitColumn.ToString());
            parameters.Add("datetimeColumnRangeLow", datetimeColumnRangeLow.ToString()); parameters.Add("datetimeColumnRangeHigh", datetimeColumnRangeHigh.ToString());
            parameters.Add("datetime2ColumnRangeLow", datetime2ColumnRangeLow.ToString()); parameters.Add("datetime2ColumnRangeHigh", datetime2ColumnRangeHigh.ToString());
            parameters.Add("smalldatetimeColumnRangeLow", smalldatetimeColumnRangeLow.ToString()); parameters.Add("smalldatetimeColumnRangeHigh", smalldatetimeColumnRangeHigh.ToString());
            parameters.Add("dateColumnRangeLow", dateColumnRangeLow.ToString()); parameters.Add("dateColumnRangeHigh", dateColumnRangeHigh.ToString());
            parameters.Add("name", name.ToString());
            parameters.Add("charColumn", charColumn.ToString());
            parameters.Add("varcharColumn", varcharColumn.ToString());
            parameters.Add("textColumn", textColumn.ToString());
            parameters.Add("ncharColumn", ncharColumn.ToString());
            parameters.Add("nvarcharColumn", nvarcharColumn.ToString());
            parameters.Add("ntextColumn", ntextColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        public const string ActionName_GetCollectionOfEntityOfAll = "GetCollectionOfEntityOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfAllAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

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

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        public const string ActionName_GetCollectionOfRssItemOfAll = "GetCollectionOfRssItemOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfRssItemOfAll
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
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfByFKOnly
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfByFKOnlyAsync(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
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
        /// http://[host]/api/OrganizationApi/GetCollectionOfRssItemOfByFKOnly
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public async Task<Framework.RssItemCollection> GetCollectionOfRssItemOfByFKOnlyAsync(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
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
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultOfByFKOnly
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection> GetCollectionOfDefaultOfByFKOnlyAsync(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        public const string ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly = "GetCollectionOfDefaultGroupedDataViewOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultGroupedDataViewOfByFKOnly
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection> GetCollectionOfDefaultGroupedDataViewOfByFKOnlyAsync(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentId", parentId.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>(url);
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        public const string ActionName_GetCollectionOfEntityOfByIdentifier = "GetCollectionOfEntityOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfByIdentifierAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        public const string ActionName_GetCollectionOfDefaultOfByIdentifier = "GetCollectionOfDefaultOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection> GetCollectionOfDefaultOfByIdentifierAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of DefaultWithPathOfByIdentifier

        public const string ActionName_GetCollectionOfDefaultWithPathOfByIdentifier = "GetCollectionOfDefaultWithPathOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultWithPathOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection> GetCollectionOfDefaultWithPathOfByIdentifierAsync(
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

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultWithPathOfByIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection>(url);
        }

        #endregion Query Methods Of DefaultWithPathOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        public const string ActionName_GetCollectionOfKeyInformationOfByIdentifier = "GetCollectionOfKeyInformationOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfKeyInformationOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection> GetCollectionOfKeyInformationOfByIdentifierAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(url);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        public const string ActionName_GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier = "GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier
        /// </summary>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifierAsync(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        public const string ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier = "GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier
        /// </summary>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifierAsync(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        public const string ActionName_GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier = "GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier
        /// </summary>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection> GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifierAsync(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        public const string ActionName_GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn = "GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
        /// </summary>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnAsync(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        public const string ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn = "GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
        /// </summary>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnAsync(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, parameters);
            return await Get<Framework.NameValueCollection>(url);
        }

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        public const string ActionName_GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn = "GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
        /// </summary>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection> GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnAsync(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of EntityOfIdentifierAndUniqueConstraint

        public const string ActionName_GetCollectionOfEntityOfIdentifierAndUniqueConstraint = "GetCollectionOfEntityOfIdentifierAndUniqueConstraint";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfEntityOfIdentifierAndUniqueConstraint
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection> GetCollectionOfEntityOfIdentifierAndUniqueConstraintAsync(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfIdentifierAndUniqueConstraint, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(url);
        }

        #endregion Query Methods Of EntityOfIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        public const string ActionName_GetCollectionOfDefaultOfIdentifierAndUniqueConstraint = "GetCollectionOfDefaultOfIdentifierAndUniqueConstraint";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultOfIdentifierAndUniqueConstraint
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection> GetCollectionOfDefaultOfIdentifierAndUniqueConstraintAsync(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfIdentifierAndUniqueConstraint, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultWithPathOfIdentifierAndUniqueConstraint

        public const string ActionName_GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint = "GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection> GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraintAsync(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection>(url);
        }

        #endregion Query Methods Of DefaultWithPathOfIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

        public const string ActionName_GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint = "GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/OrganizationApi/GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection> GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraintAsync(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("uniqueIdentifier", uniqueIdentifier.ToString());
            parameters.Add("uniqueidentifierColumn", uniqueidentifierColumn.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(url);
        }

        #endregion Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

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


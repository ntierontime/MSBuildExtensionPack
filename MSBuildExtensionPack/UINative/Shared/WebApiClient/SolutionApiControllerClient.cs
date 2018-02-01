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

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of EntityOfCommon

        public const string ActionName_GetCollectionOfEntityOfCommon = "GetCollectionOfEntityOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfEntityOfCommon
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="externalParentId" > value to compare/filter with externalParentId property/field/column</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.SolutionCollection> GetCollectionOfEntityOfCommonAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , System.String externalParentId
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("externalParentId", externalParentId.ToString());
            parameters.Add("name", name.ToString());
            parameters.Add("description", description.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(url);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        public const string ActionName_GetCollectionOfDefaultOfCommon = "GetCollectionOfDefaultOfCommon";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfDefaultOfCommon
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="externalParentId" > value to compare/filter with externalParentId property/field/column</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection> GetCollectionOfDefaultOfCommonAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , System.String externalParentId
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("externalParentId", externalParentId.ToString());
            parameters.Add("name", name.ToString());
            parameters.Add("description", description.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfCommon, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        public const string ActionName_GetCollectionOfEntityOfAll = "GetCollectionOfEntityOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfEntityOfAll
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.SolutionCollection> GetCollectionOfEntityOfAllAsync(
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(url);
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

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

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        public const string ActionName_GetCollectionOfRssItemOfAll = "GetCollectionOfRssItemOfAll";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfRssItemOfAll
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
        /// http://[host]/api/SolutionApi/GetCollectionOfEntityOfByFKOnly
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.SolutionCollection> GetCollectionOfEntityOfByFKOnlyAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfEntityOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(url);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        public const string ActionName_GetCollectionOfNameValuePairOfByFKOnly = "GetCollectionOfNameValuePairOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfNameValuePairOfByFKOnly
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public async Task<Framework.NameValueCollection> GetCollectionOfNameValuePairOfByFKOnlyAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
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
        /// http://[host]/api/SolutionApi/GetCollectionOfRssItemOfByFKOnly
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public async Task<Framework.RssItemCollection> GetCollectionOfRssItemOfByFKOnlyAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
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
        /// http://[host]/api/SolutionApi/GetCollectionOfDefaultOfByFKOnly
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection> GetCollectionOfDefaultOfByFKOnlyAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        public const string ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly = "GetCollectionOfDefaultGroupedDataViewOfByFKOnly";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfDefaultGroupedDataViewOfByFKOnly
        /// </summary>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection> GetCollectionOfDefaultGroupedDataViewOfByFKOnlyAsync(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("organizationId", organizationId.ToString());
            parameters.Add("organization_2Id", organization_2Id.ToString());
            parameters.Add("currentIndex", currentIndex.ToString());
            parameters.Add("pageSize", pageSize.ToString());
            parameters.Add("queryOrderByExpression", queryOrderByExpression);

            string url = GetHttpRequestUrl(ActionName_GetCollectionOfDefaultGroupedDataViewOfByFKOnly, parameters);
            return await Get<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>(url);
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        public const string ActionName_GetCollectionOfEntityOfByIdentifier = "GetCollectionOfEntityOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfEntityOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.SolutionCollection> GetCollectionOfEntityOfByIdentifierAsync(
            System.Int32? id
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(url);
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        public const string ActionName_GetCollectionOfDefaultOfByIdentifier = "GetCollectionOfDefaultOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfDefaultOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection> GetCollectionOfDefaultOfByIdentifierAsync(
            System.Int32? id
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(url);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        public const string ActionName_GetCollectionOfKeyInformationOfByIdentifier = "GetCollectionOfKeyInformationOfByIdentifier";
        /// <summary>
        /// Gets the collection of entity of common.
        /// http://[host]/api/SolutionApi/GetCollectionOfKeyInformationOfByIdentifier
        /// </summary>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public async Task<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection> GetCollectionOfKeyInformationOfByIdentifierAsync(
            System.Int32? id
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
            return await Get<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>(url);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.AspNetMvc40ApiController.ApiControllers
{
    /// <summary>

    /// </summary>
    public partial class SolutionApiController : ApiController
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
        [HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifier(
            System.Int32 id
            )
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(
                id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchUpdate(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchInsert(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchDelete(input);

                return responseMessage;
            });
            return await resultTask;
        }

        #endregion batch insert, update and delete in an entity collection

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of EntityOfCommon

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareExternalParentId">will compare/filter externalParentId property/field/column if true, otherwise false</param>
        /// <param name="externalParentId" > value to compare/filter with externalParentId property/field/column</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfCommon(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , System.String externalParentId
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfEntityOfCommon(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , !string.IsNullOrEmpty(externalParentId), externalParentId
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(description), description
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareExternalParentId">will compare/filter externalParentId property/field/column if true, otherwise false</param>
        /// <param name="externalParentId" > value to compare/filter with externalParentId property/field/column</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , System.String externalParentId
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfCommon(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , !string.IsNullOrEmpty(externalParentId), externalParentId
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(description), description
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareExternalParentId">will compare/filter externalParentId property/field/column if true, otherwise false</param>
        /// <param name="externalParentId" > value to compare/filter with externalParentId property/field/column</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection GetCollectionOfDefaultOfCommon(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , System.String externalParentId
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfDefaultOfCommon(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , !string.IsNullOrEmpty(externalParentId), externalParentId
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(description), description
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareExternalParentId">will compare/filter externalParentId property/field/column if true, otherwise false</param>
        /// <param name="externalParentId" > value to compare/filter with externalParentId property/field/column</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , System.String externalParentId
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfCommon(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , !string.IsNullOrEmpty(externalParentId), externalParentId
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(description), description
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfAll")]
        public MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfEntityOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfAll")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfAll")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfNameValuePairOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfRssItemOfAll")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfRssItemOfAll")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfEntityOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfNameValuePairOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfRssItemOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfRssItemOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfDefaultOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareOrganizationId">will compare/filter organizationId property/field/column if true, otherwise false</param>
        /// <param name="organizationId">value to compare/filter with organizationId property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            System.Int64? organizationId
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultGroupedDataViewOfByFKOnly(
                organizationId.HasValue, organizationId
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfByIdentifier(
            System.Int32? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfEntityOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            System.Int32? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfEntityOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            System.Int32? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfDefaultOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            System.Int32? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            System.Int32? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfKeyInformationOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation"/></returns>
        [HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            System.Int32? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfKeyInformationOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Solution.
        /// http://[host]/api/SolutionApi/GetSolutionItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.SolutionItemVM GetSolutionItemVM(
System.Int32? id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM();
            retval.Load(id.HasValue, id, Framework.UIAction.ViewDetails);
            return retval;
        }

        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.Solution: WPCommonOfSolutionVM.
        /// http://[host]/api/SolutionApi/GetWPCommonOfSolutionVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfSolutionVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfSolutionVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM GetWPCommonOfSolutionVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfSolutionVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfSolutionVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.Solution: WPEntityRelatedOfSolutionVM.
        /// http://[host]/api/SolutionApi/GetWPEntityRelatedOfSolutionVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfSolutionVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfSolutionVM GetWPEntityRelatedOfSolutionVM(
System.Int32? id)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier();
            criteria.SolutionQueryCriteriaByIdentifier.Id.NullableValueToCompare = id;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM(criteria);
            retval.LoadData();
            return retval;
        }

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/SolutionApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


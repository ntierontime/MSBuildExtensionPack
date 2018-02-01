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
    public partial class BuildApiController : ApiController
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        [HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildIdentifier(
                id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchUpdate(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchInsert(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchDelete(input);

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
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildStartTimeRange" > will compare/filter buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareBuildStartTimeRangeLow" > will compare/filter to lower bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareBuildStartTimeRangeHigh">will compare/filter to upper bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.DateTime? buildStartTimeRangeLow, System.DateTime? buildStartTimeRangeHigh
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfCommon(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildStartTimeRangeLow.HasValue || buildStartTimeRangeHigh.HasValue, buildStartTimeRangeLow.HasValue, buildStartTimeRangeLow, buildStartTimeRangeHigh.HasValue, buildStartTimeRangeHigh
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(description), description
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildStartTimeRange" > will compare/filter buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareBuildStartTimeRangeLow" > will compare/filter to lower bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareBuildStartTimeRangeHigh">will compare/filter to upper bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.DateTime? buildStartTimeRangeLow, System.DateTime? buildStartTimeRangeHigh
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfCommon(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildStartTimeRangeLow.HasValue || buildStartTimeRangeHigh.HasValue, buildStartTimeRangeLow.HasValue, buildStartTimeRangeLow, buildStartTimeRangeHigh.HasValue, buildStartTimeRangeHigh
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
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildStartTimeRange" > will compare/filter buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareBuildStartTimeRangeLow" > will compare/filter to lower bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareBuildStartTimeRangeHigh">will compare/filter to upper bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.DateTime? buildStartTimeRangeLow, System.DateTime? buildStartTimeRangeHigh
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfCommon(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildStartTimeRangeLow.HasValue || buildStartTimeRangeHigh.HasValue, buildStartTimeRangeLow.HasValue, buildStartTimeRangeLow, buildStartTimeRangeHigh.HasValue, buildStartTimeRangeHigh
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(description), description
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildStartTimeRange" > will compare/filter buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareBuildStartTimeRangeLow" > will compare/filter to lower bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareBuildStartTimeRangeHigh">will compare/filter to upper bound of buildStartTimeRange property/field/column if true, otherwise false</param>
        /// <param name="buildStartTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareDescription">will compare/filter description property/field/column if true, otherwise false</param>
        /// <param name="description" > value to compare/filter with description property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.DateTime? buildStartTimeRangeLow, System.DateTime? buildStartTimeRangeHigh
            , System.String name
            , System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildStartTimeRangeLow.HasValue || buildStartTimeRangeHigh.HasValue, buildStartTimeRangeLow.HasValue, buildStartTimeRangeLow, buildStartTimeRangeHigh.HasValue, buildStartTimeRangeHigh
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfAll")]
        public MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfAll(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfRssItemOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
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
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
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
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfRssItemOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfRssItemOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
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
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
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
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultGroupedDataViewOfByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfEntityOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfEntityOfByIdentifier(
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfDefaultOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of UpdateNameRequestOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfUpdateNameRequestOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfUpdateNameRequestOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest"/></returns>
        [HttpGet, ActionName("GetMessageOfUpdateNameRequestOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfUpdateNameRequestOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of UpdateNameRequestOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfKeyInformationOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation"/></returns>
        [HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfKeyInformationOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Build.
        /// http://[host]/api/BuildApi/GetBuildItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.BuildItemVM GetBuildItemVM(
System.Int64? id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM();
            retval.Load(id.HasValue, id, Framework.UIAction.ViewDetails);
            return retval;
        }

        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.Build: WPCommonOfBuildVM.
        /// http://[host]/api/BuildApi/GetWPCommonOfBuildVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfBuildVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM GetWPCommonOfBuildVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.Build: WPEntityRelatedOfBuildVM.
        /// http://[host]/api/BuildApi/GetWPEntityRelatedOfBuildVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildVM GetWPEntityRelatedOfBuildVM(
System.Int64? id)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier();
            criteria.BuildQueryCriteriaByIdentifier.Id.NullableValueToCompare = id;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM(criteria);
            retval.LoadData();
            return retval;
        }

        #region EntityUpdateActionSetting - UpdateNameOnly

        /// <summary>
        /// Gets UpdateNameOnly view model of MSBuildExtensionPack.Build: WPUpdateNameOnlyOfBuild.
        /// http://[host]/api/BuildApi/WPUpdateNameOnlyOfBuildVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPUpdateNameOnlyOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM GetWPUpdateNameOnlyOfBuildVM(
System.Int64? id
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier();
            criteria.BuildQueryCriteriaByIdentifier.Id.NullableValueToCompare = id;

            var vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM();
            vm.CriteriaOfMasterEntity =  criteria;
            vm.LoadData();
            return vm;
        }

        /// <summary>
        /// Post method WPUpdateNameOnlyOfBuild.
        /// http://[host]/api/BuildApi/WPUpdateNameOnlyOfBuildVM
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost, ActionName("WPUpdateNameOnlyOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM WPUpdateNameOnlyOfBuildVM(MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM input)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM(input.CriteriaOfMasterEntity);
            vm.MasterEntity = input.MasterEntity;
            vm.SaveData();

            return vm;
        }

        #endregion EntityUpdateActionSetting - UpdateNameOnlyVM

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/BuildApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


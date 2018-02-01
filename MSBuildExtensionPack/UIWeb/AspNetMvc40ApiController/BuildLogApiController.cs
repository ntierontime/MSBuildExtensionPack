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
    public partial class BuildLogApiController : ApiController
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        [HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier(
                id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchUpdate(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchInsert(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchDelete(input);

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
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="isToCompareEventTimeRange" > will compare/filter eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareEventTimeRangeLow" > will compare/filter to lower bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareEventTimeRangeHigh">will compare/filter to upper bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareMessage">will compare/filter message property/field/column if true, otherwise false</param>
        /// <param name="message" > value to compare/filter with message property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , System.DateTime? eventTimeRangeLow, System.DateTime? eventTimeRangeHigh
            , System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfCommon(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , eventTimeRangeLow.HasValue || eventTimeRangeHigh.HasValue, eventTimeRangeLow.HasValue, eventTimeRangeLow, eventTimeRangeHigh.HasValue, eventTimeRangeHigh
                , !string.IsNullOrEmpty(message), message
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="isToCompareEventTimeRange" > will compare/filter eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareEventTimeRangeLow" > will compare/filter to lower bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareEventTimeRangeHigh">will compare/filter to upper bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareMessage">will compare/filter message property/field/column if true, otherwise false</param>
        /// <param name="message" > value to compare/filter with message property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , System.DateTime? eventTimeRangeLow, System.DateTime? eventTimeRangeHigh
            , System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfCommon(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , eventTimeRangeLow.HasValue || eventTimeRangeHigh.HasValue, eventTimeRangeLow.HasValue, eventTimeRangeLow, eventTimeRangeHigh.HasValue, eventTimeRangeHigh
                , !string.IsNullOrEmpty(message), message
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="isToCompareEventTimeRange" > will compare/filter eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareEventTimeRangeLow" > will compare/filter to lower bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareEventTimeRangeHigh">will compare/filter to upper bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareMessage">will compare/filter message property/field/column if true, otherwise false</param>
        /// <param name="message" > value to compare/filter with message property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , System.DateTime? eventTimeRangeLow, System.DateTime? eventTimeRangeHigh
            , System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , eventTimeRangeLow.HasValue || eventTimeRangeHigh.HasValue, eventTimeRangeLow.HasValue, eventTimeRangeLow, eventTimeRangeHigh.HasValue, eventTimeRangeHigh
                , !string.IsNullOrEmpty(message), message
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="isToCompareEventTimeRange" > will compare/filter eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareEventTimeRangeLow" > will compare/filter to lower bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareEventTimeRangeHigh">will compare/filter to upper bound of eventTimeRange property/field/column if true, otherwise false</param>
        /// <param name="eventTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareMessage">will compare/filter message property/field/column if true, otherwise false</param>
        /// <param name="message" > value to compare/filter with message property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , System.DateTime? eventTimeRangeLow, System.DateTime? eventTimeRangeHigh
            , System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , eventTimeRangeLow.HasValue || eventTimeRangeHigh.HasValue, eventTimeRangeLow.HasValue, eventTimeRangeLow, eventTimeRangeHigh.HasValue, eventTimeRangeHigh
                , !string.IsNullOrEmpty(message), message
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfAll")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfAll(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareBuildId">will compare/filter buildId property/field/column if true, otherwise false</param>
        /// <param name="buildId">value to compare/filter with buildId property/field/column</param>
        /// <param name="isToCompareSolution_1Id">will compare/filter solution_1Id property/field/column if true, otherwise false</param>
        /// <param name="solution_1Id">value to compare/filter with solution_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="isToCompareBuildEventCodeId">will compare/filter buildEventCodeId property/field/column if true, otherwise false</param>
        /// <param name="buildEventCodeId">value to compare/filter with buildEventCodeId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            System.Int64? buildId
            , System.Int32? solution_1Id
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(
                buildId.HasValue, buildId
                , solution_1Id.HasValue, solution_1Id
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , buildEventCodeId.HasValue, buildEventCodeId
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByIdentifier(
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfKeyInformationOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation"/></returns>
        [HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfKeyInformationOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.BuildLog.
        /// http://[host]/api/BuildLogApi/GetBuildLogItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.BuildLogItemVM GetBuildLogItemVM(
System.Int64? id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildLogItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildLogItemVM();
            retval.Load(id.HasValue, id, Framework.UIAction.ViewDetails);
            return retval;
        }

        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.BuildLog: WPCommonOfBuildLogVM.
        /// http://[host]/api/BuildLogApi/GetWPCommonOfBuildLogVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfBuildLogVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfBuildLogVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM GetWPCommonOfBuildLogVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildLogVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildLogVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.BuildLog: WPEntityRelatedOfBuildLogVM.
        /// http://[host]/api/BuildLogApi/GetWPEntityRelatedOfBuildLogVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfBuildLogVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildLogVM GetWPEntityRelatedOfBuildLogVM(
System.Int64? id)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier();
            criteria.BuildLogQueryCriteriaByIdentifier.Id.NullableValueToCompare = id;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM(criteria);
            retval.LoadData();
            return retval;
        }

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/BuildLogApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


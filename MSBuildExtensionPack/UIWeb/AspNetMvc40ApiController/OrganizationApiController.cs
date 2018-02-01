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
    public partial class OrganizationApiController : ApiController
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        [HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(
                id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchUpdate(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchInsert(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchDelete(input);

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
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfCommon(
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
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfCommon(
                parentId.HasValue, parentId
                , isSystemBuiltIn.HasValue, isSystemBuiltIn
                , createdDateTimeRangeLow.HasValue || createdDateTimeRangeHigh.HasValue, createdDateTimeRangeLow.HasValue, createdDateTimeRangeLow, createdDateTimeRangeHigh.HasValue, createdDateTimeRangeHigh
                , bitColumn.HasValue, bitColumn
                , datetimeColumnRangeLow.HasValue || datetimeColumnRangeHigh.HasValue, datetimeColumnRangeLow.HasValue, datetimeColumnRangeLow, datetimeColumnRangeHigh.HasValue, datetimeColumnRangeHigh
                , datetime2ColumnRangeLow.HasValue || datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeLow.HasValue, datetime2ColumnRangeLow, datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeHigh
                , smalldatetimeColumnRangeLow.HasValue || smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeLow.HasValue, smalldatetimeColumnRangeLow, smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeHigh
                , dateColumnRangeLow.HasValue || dateColumnRangeHigh.HasValue, dateColumnRangeLow.HasValue, dateColumnRangeLow, dateColumnRangeHigh.HasValue, dateColumnRangeHigh
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(charColumn), charColumn
                , !string.IsNullOrEmpty(varcharColumn), varcharColumn
                , !string.IsNullOrEmpty(textColumn), textColumn
                , !string.IsNullOrEmpty(ncharColumn), ncharColumn
                , !string.IsNullOrEmpty(nvarcharColumn), nvarcharColumn
                , !string.IsNullOrEmpty(ntextColumn), ntextColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfCommon(
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
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfCommon(
                parentId.HasValue, parentId
                , isSystemBuiltIn.HasValue, isSystemBuiltIn
                , createdDateTimeRangeLow.HasValue || createdDateTimeRangeHigh.HasValue, createdDateTimeRangeLow.HasValue, createdDateTimeRangeLow, createdDateTimeRangeHigh.HasValue, createdDateTimeRangeHigh
                , bitColumn.HasValue, bitColumn
                , datetimeColumnRangeLow.HasValue || datetimeColumnRangeHigh.HasValue, datetimeColumnRangeLow.HasValue, datetimeColumnRangeLow, datetimeColumnRangeHigh.HasValue, datetimeColumnRangeHigh
                , datetime2ColumnRangeLow.HasValue || datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeLow.HasValue, datetime2ColumnRangeLow, datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeHigh
                , smalldatetimeColumnRangeLow.HasValue || smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeLow.HasValue, smalldatetimeColumnRangeLow, smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeHigh
                , dateColumnRangeLow.HasValue || dateColumnRangeHigh.HasValue, dateColumnRangeLow.HasValue, dateColumnRangeLow, dateColumnRangeHigh.HasValue, dateColumnRangeHigh
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(charColumn), charColumn
                , !string.IsNullOrEmpty(varcharColumn), varcharColumn
                , !string.IsNullOrEmpty(textColumn), textColumn
                , !string.IsNullOrEmpty(ncharColumn), ncharColumn
                , !string.IsNullOrEmpty(nvarcharColumn), nvarcharColumn
                , !string.IsNullOrEmpty(ntextColumn), ntextColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultOfCommon(
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
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultOfCommon(
                parentId.HasValue, parentId
                , isSystemBuiltIn.HasValue, isSystemBuiltIn
                , createdDateTimeRangeLow.HasValue || createdDateTimeRangeHigh.HasValue, createdDateTimeRangeLow.HasValue, createdDateTimeRangeLow, createdDateTimeRangeHigh.HasValue, createdDateTimeRangeHigh
                , bitColumn.HasValue, bitColumn
                , datetimeColumnRangeLow.HasValue || datetimeColumnRangeHigh.HasValue, datetimeColumnRangeLow.HasValue, datetimeColumnRangeLow, datetimeColumnRangeHigh.HasValue, datetimeColumnRangeHigh
                , datetime2ColumnRangeLow.HasValue || datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeLow.HasValue, datetime2ColumnRangeLow, datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeHigh
                , smalldatetimeColumnRangeLow.HasValue || smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeLow.HasValue, smalldatetimeColumnRangeLow, smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeHigh
                , dateColumnRangeLow.HasValue || dateColumnRangeHigh.HasValue, dateColumnRangeLow.HasValue, dateColumnRangeLow, dateColumnRangeHigh.HasValue, dateColumnRangeHigh
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(charColumn), charColumn
                , !string.IsNullOrEmpty(varcharColumn), varcharColumn
                , !string.IsNullOrEmpty(textColumn), textColumn
                , !string.IsNullOrEmpty(ncharColumn), ncharColumn
                , !string.IsNullOrEmpty(nvarcharColumn), nvarcharColumn
                , !string.IsNullOrEmpty(ntextColumn), ntextColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
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
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfCommon(
                parentId.HasValue, parentId
                , isSystemBuiltIn.HasValue, isSystemBuiltIn
                , createdDateTimeRangeLow.HasValue || createdDateTimeRangeHigh.HasValue, createdDateTimeRangeLow.HasValue, createdDateTimeRangeLow, createdDateTimeRangeHigh.HasValue, createdDateTimeRangeHigh
                , bitColumn.HasValue, bitColumn
                , datetimeColumnRangeLow.HasValue || datetimeColumnRangeHigh.HasValue, datetimeColumnRangeLow.HasValue, datetimeColumnRangeLow, datetimeColumnRangeHigh.HasValue, datetimeColumnRangeHigh
                , datetime2ColumnRangeLow.HasValue || datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeLow.HasValue, datetime2ColumnRangeLow, datetime2ColumnRangeHigh.HasValue, datetime2ColumnRangeHigh
                , smalldatetimeColumnRangeLow.HasValue || smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeLow.HasValue, smalldatetimeColumnRangeLow, smalldatetimeColumnRangeHigh.HasValue, smalldatetimeColumnRangeHigh
                , dateColumnRangeLow.HasValue || dateColumnRangeHigh.HasValue, dateColumnRangeLow.HasValue, dateColumnRangeLow, dateColumnRangeHigh.HasValue, dateColumnRangeHigh
                , !string.IsNullOrEmpty(name), name
                , !string.IsNullOrEmpty(charColumn), charColumn
                , !string.IsNullOrEmpty(varcharColumn), varcharColumn
                , !string.IsNullOrEmpty(textColumn), textColumn
                , !string.IsNullOrEmpty(ncharColumn), ncharColumn
                , !string.IsNullOrEmpty(nvarcharColumn), nvarcharColumn
                , !string.IsNullOrEmpty(ntextColumn), ntextColumn
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfAll")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfAll(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfAll")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfRssItemOfAll(
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfRssItemOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfRssItemOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultGroupedDataViewOfByFKOnly(
                parentId.HasValue, parentId
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfByIdentifier(
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of DefaultWithPathOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultWithPathOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection GetCollectionOfDefaultWithPathOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultWithPathOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultWithPathOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetMessageOfDefaultWithPathOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultWithPathOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultWithPathOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfKeyInformationOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation"/></returns>
        [HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfKeyInformationOfByIdentifier(
                id.HasValue, id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier.HasValue, uniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier.HasValue, uniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier.HasValue, uniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier.HasValue, uniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier.HasValue, uniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier.HasValue, uniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of EntityOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfEntityOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        [HttpGet, ActionName("GetMessageOfEntityOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfEntityOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of EntityOfIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultWithPathOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfDefaultWithPathOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
        [HttpGet, ActionName("GetMessageOfDefaultWithPathOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetMessageOfDefaultWithPathOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultWithPathOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of DefaultWithPathOfIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="isToCompareUniqueidentifierColumn">will compare/filter uniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="uniqueidentifierColumn">value to compare/filter with uniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation"/></returns>
        [HttpGet, ActionName("GetMessageOfKeyInformationOfIdentifierAndUniqueConstraint")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfIdentifierAndUniqueConstraint(
            System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfKeyInformationOfIdentifierAndUniqueConstraint(
                id.HasValue, id
                , uniqueIdentifier.HasValue, uniqueIdentifier
                , uniqueidentifierColumn.HasValue, uniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Organization.
        /// http://[host]/api/OrganizationApi/GetOrganizationItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.OrganizationItemVM GetOrganizationItemVM(
System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM();
            retval.Load(id.HasValue, id, uniqueIdentifier.HasValue, uniqueIdentifier, uniqueidentifierColumn.HasValue, uniqueidentifierColumn, Framework.UIAction.ViewDetails);
            return retval;
        }

        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.Organization: WPCommonOfOrganizationVM.
        /// http://[host]/api/OrganizationApi/GetWPCommonOfOrganizationVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfOrganizationVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfOrganizationVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM GetWPCommonOfOrganizationVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfOrganizationVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfOrganizationVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfOrganizationVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.Organization: WPEntityRelatedOfOrganizationVM.
        /// http://[host]/api/OrganizationApi/GetWPEntityRelatedOfOrganizationVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfOrganizationVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfOrganizationVM GetWPEntityRelatedOfOrganizationVM(
System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint();
            criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id.NullableValueToCompare = id;
            criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier.NullableValueToCompare = uniqueIdentifier;
            criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn.NullableValueToCompare = uniqueidentifierColumn;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfOrganizationVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfOrganizationVM(criteria);
            retval.LoadData();
            return retval;
        }

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/OrganizationApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


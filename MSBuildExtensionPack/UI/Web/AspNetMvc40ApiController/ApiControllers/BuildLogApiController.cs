using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.AspNetMvc40ApiController.ApiControllers.ApiControllers
{
    /// <summary>
    /// Api Controller of  <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog"/>
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/16/how-webapi-does-parameter-binding.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/20/how-to-bind-to-custom-objects-in-action-signatures-in-mvc-webapi.aspx
	/// http://blogs.msdn.com/b/jmstall/archive/2012/04/18/mvc-style-parameter-binding-for-webapi.aspx
    /// </summary>
    public partial class BuildLogApiController : ApiController
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

        #region Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
		[HttpPost, ActionName("InsertEntity")]
        public void InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.InsertEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public void UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.UpdateEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpDelete, ActionName("DeleteByIdentifierEntity")]
        public void DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(identifier);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpDelete, ActionName("DeleteEntity")]
        public void DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteEntity(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

		/// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
		[HttpDelete, ActionName("DeleteByIdentifier")]
        public void DeleteByIdentifier(
			System.Int64 id
			)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier(
				id));

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public void BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchUpdate(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpPost, ActionName("BatchInsert")]
        public void BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchInsert(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpDelete, ActionName("BatchDelete")]
        public void BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchDelete(input);

            if (responseMessage.BusinessLogicLayerResponseStatus != Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        #endregion batch insert, update and delete in an entity collection

        #endregion



        #region Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfCommonVM")]
        public int[] GetPageNumberListOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfCommonVM")]
        public int GetPageCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfCommonVM")]
        public int GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfCommonVM")]
        public bool ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommonVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommonVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommonVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfCommon")]
        public int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfCommon")]
        public int GetPageCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfCommon")]
        public int GetCountOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfCommon")]
        public bool ExistsOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of Common per value type




        #region Query Methods Of Default of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfCommonVM")]
        public int[] GetPageNumberListOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfCommonVM")]
        public int GetPageCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultOfCommonVM")]
        public int GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfCommonVM")]
        public bool ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommonVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommonVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommonVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfCommon(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfCommon")]
        public int[] GetPageNumberListOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfCommon")]
        public int GetPageCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfCommon")]
        public int GetCountOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfCommon")]
        public bool ExistsOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfCommon")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdCommonOfBuild_1OfCommon">will compare/filter IdCommonOfBuild_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuild_1OfCommon">value to compare/filter with IdCommonOfBuild_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfSolution_1OfCommon">will compare/filter IdCommonOfSolution_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfSolution_1OfCommon">value to compare/filter with IdCommonOfSolution_1OfCommon property/field/column</param>
        /// <param name="isToCompareIdCommonOfBuildEventCode_1OfCommon">will compare/filter IdCommonOfBuildEventCode_1OfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdCommonOfBuildEventCode_1OfCommon">value to compare/filter with IdCommonOfBuildEventCode_1OfCommon property/field/column</param>
        /// <param name="isToCompareEventTimeCommonOftOfCommon">will compare/filter EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="isToCompareLowerBoundEventTimeCommonOftOfCommon">will compare/filter to lower bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="lowerBoundEventTimeCommonOftOfCommon">value of lower bound</param>
        /// <param name="isToCompareUpperBoundEventTimeCommonOftOfCommon">will compare/filter to upper bound of EventTimeCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="upperBoundEventTimeCommonOftOfCommon">upper bound</param>
        /// <param name="isToCompareMessageCommonOftOfCommon">will compare/filter MessageCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedMessageCommonOftOfCommon">value to compare/filter with MessageCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfCommon")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
			bool isToCompareIdCommonOfBuild_1OfCommon, System.Int64 valueToCompareIdCommonOfBuild_1OfCommon
			, bool isToCompareIdCommonOfSolution_1OfCommon, System.Int32 valueToCompareIdCommonOfSolution_1OfCommon
			, bool isToCompareIdCommonOfBuildEventCode_1OfCommon, System.Int32 valueToCompareIdCommonOfBuildEventCode_1OfCommon
			, bool isToCompareEventTimeCommonOftOfCommon, bool isToCompareLowerBoundEventTimeCommonOftOfCommon, System.DateTime lowerBoundEventTimeCommonOftOfCommon, bool isToCompareUpperBoundEventTimeCommonOftOfCommon, System.DateTime upperBoundEventTimeCommonOftOfCommon
			, bool isToCompareMessageCommonOftOfCommon, System.String valueToBeContainedMessageCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfCommon(				isToCompareIdCommonOfBuild_1OfCommon && valueToCompareIdCommonOfBuild_1OfCommon != default(System.Int64), valueToCompareIdCommonOfBuild_1OfCommon
				, isToCompareIdCommonOfSolution_1OfCommon && valueToCompareIdCommonOfSolution_1OfCommon != default(System.Int32), valueToCompareIdCommonOfSolution_1OfCommon
				, isToCompareIdCommonOfBuildEventCode_1OfCommon && valueToCompareIdCommonOfBuildEventCode_1OfCommon != default(System.Int32), valueToCompareIdCommonOfBuildEventCode_1OfCommon
				, isToCompareEventTimeCommonOftOfCommon && lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue && upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, isToCompareLowerBoundEventTimeCommonOftOfCommon & lowerBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, lowerBoundEventTimeCommonOftOfCommon, isToCompareUpperBoundEventTimeCommonOftOfCommon & upperBoundEventTimeCommonOftOfCommon != System.DateTime.MinValue, upperBoundEventTimeCommonOftOfCommon
				, isToCompareMessageCommonOftOfCommon && !string.IsNullOrWhiteSpace(valueToBeContainedMessageCommonOftOfCommon), valueToBeContainedMessageCommonOftOfCommon
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of Common per value type




        #region Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfAllVM")]
        public int[] GetPageNumberListOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfAllVM")]
        public int GetPageCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfAllVM")]
        public int GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfAllVM")]
        public bool ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfAllVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfAllVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfAllVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfAll")]
        public int[] GetPageNumberListOfEntityOfAll(
			int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfAll")]
        public int GetPageCountOfEntityOfAll(
			int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfAll")]
        public int GetCountOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfAll")]
        public bool ExistsOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

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
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfAll(				currentIndex
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
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfAll")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfAll(				queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of All per value type




        #region Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfAllVM")]
        public int[] GetPageNumberListOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfAllVM")]
        public int GetPageCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfNameValuePairOfAllVM")]
        public int GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfAllVM")]
        public bool ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfAllVM")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfAllVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfAllVM")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfAll")]
        public int[] GetPageNumberListOfNameValuePairOfAll(
			int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfAll")]
        public int GetPageCountOfNameValuePairOfAll(
			int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfNameValuePairOfAll")]
        public int GetCountOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfAll")]
        public bool ExistsOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

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
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfAll(				currentIndex
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
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfAll")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfAll(				queryOrderByExpression);
		}

        #endregion Query Methods Of NameValuePair of All per value type




        #region Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfAllVM")]
        public int[] GetPageNumberListOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfAllVM")]
        public int GetPageCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfRssItemOfAllVM")]
        public int GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfAllVM")]
        public bool ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfAllVM")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfAllVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfAllVM")]
        public Framework.RssItemCollection GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfAll(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfAll")]
        public int[] GetPageNumberListOfRssItemOfAll(
			int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfAll")]
        public int GetPageCountOfRssItemOfAll(
			int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfAll(				pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfRssItemOfAll")]
        public int GetCountOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfAll")]
        public bool ExistsOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

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
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfAll(				currentIndex
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
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfAll")]
        public Framework.RssItemCollection GetSingleOfRssItemOfAll(
			string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfAll(				queryOrderByExpression);
		}

        #endregion Query Methods Of RssItem of All per value type




        #region Query Methods Of Entity of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByFKOnlyVM")]
        public int[] GetPageNumberListOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByFKOnlyVM")]
        public int GetPageCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfByFKOnlyVM")]
        public int GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByFKOnlyVM")]
        public bool ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnlyVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnlyVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnlyVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByFKOnly")]
        public int[] GetPageNumberListOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByFKOnly")]
        public int GetPageCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfByFKOnly")]
        public int GetCountOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByFKOnly")]
        public bool ExistsOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of ByFKOnly per value type




        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfByFKOnlyVM")]
        public int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfByFKOnlyVM")]
        public int GetPageCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfNameValuePairOfByFKOnlyVM")]
        public int GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfByFKOnlyVM")]
        public bool ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnlyVM")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnlyVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfByFKOnlyVM")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfNameValuePairOfByFKOnly")]
        public int[] GetPageNumberListOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfNameValuePairOfByFKOnly")]
        public int GetPageCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfNameValuePairOfByFKOnly")]
        public int GetCountOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfNameValuePairOfByFKOnly")]
        public bool ExistsOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type




        #region Query Methods Of RssItem of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfByFKOnlyVM")]
        public int[] GetPageNumberListOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfByFKOnlyVM")]
        public int GetPageCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfRssItemOfByFKOnlyVM")]
        public int GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfByFKOnlyVM")]
        public bool ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnlyVM")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfByFKOnlyVM")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfByFKOnlyVM")]
        public Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of RssItem of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfRssItemOfByFKOnly")]
        public int[] GetPageNumberListOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfRssItemOfByFKOnly")]
        public int GetPageCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfRssItemOfByFKOnly")]
        public int GetCountOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfRssItemOfByFKOnly")]
        public bool ExistsOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfRssItemOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfRssItemOfByFKOnly")]
        public Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfRssItemOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of RssItem of ByFKOnly per value type




        #region Query Methods Of Default of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByFKOnlyVM")]
        public int[] GetPageNumberListOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByFKOnlyVM")]
        public int GetPageCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultOfByFKOnlyVM")]
        public int GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByFKOnlyVM")]
        public bool ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnlyVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnlyVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnlyVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByFKOnly")]
        public int GetPageCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfByFKOnly")]
        public int GetCountOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByFKOnly")]
        public bool ExistsOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of ByFKOnly per value type




        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public int GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnlyVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultGroupedDataViewOfByFKOnly(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly")]
        public int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultGroupedDataViewOfByFKOnly")]
        public int GetCountOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultGroupedDataViewOfByFKOnly")]
        public bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultGroupedDataViewOfByFKOnly")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultGroupedDataViewOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, queryOrderByExpression);
		}

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per value type




        #region Query Methods Of Entity of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByIdentifierVM")]
        public int[] GetPageNumberListOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByIdentifierVM")]
        public int GetPageCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfEntityOfByIdentifierVM")]
        public int GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByIdentifierVM")]
        public bool ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByIdentifierVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifierVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByIdentifierVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Entity of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfEntityOfByIdentifier")]
        public int[] GetPageNumberListOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfEntityOfByIdentifier")]
        public int GetPageCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfEntityOfByIdentifier")]
        public int GetCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfEntityOfByIdentifier")]
        public bool ExistsOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
		[HttpGet, ActionName("GetMessageOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfEntityOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfEntityOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Entity of ByIdentifier per value type




        #region Query Methods Of Default of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByIdentifierVM")]
        public int[] GetPageNumberListOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByIdentifierVM")]
        public int GetPageCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfDefaultOfByIdentifierVM")]
        public int GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByIdentifierVM")]
        public bool ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifierVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifierVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByIdentifierVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of Default of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfDefaultOfByIdentifier")]
        public int[] GetPageNumberListOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfDefaultOfByIdentifier")]
        public int GetPageCountOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfDefaultOfByIdentifier")]
        public int GetCountOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfDefaultOfByIdentifier")]
        public bool ExistsOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default"/></returns>
		[HttpGet, ActionName("GetMessageOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfDefaultOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfDefaultOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of Default of ByIdentifier per value type




        #region Query Methods Of KeyInformation of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfKeyInformationOfByIdentifierVM")]
        public int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfKeyInformationOfByIdentifierVM")]
        public int GetPageCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
		[HttpGet, ActionName("GetCountOfKeyInformationOfByIdentifierVM")]
        public int GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfKeyInformationOfByIdentifierVM")]
        public bool ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifierVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifierVM")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfKeyInformationOfByIdentifierVM")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfKeyInformationOfByIdentifier(criteria, queryPagingSetting, queryOrderBySettingCollection);
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of KeyInformation of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
		[HttpGet, ActionName("GetPageNumberListOfKeyInformationOfByIdentifier")]
        public int[] GetPageNumberListOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageNumberListOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
		[HttpGet, ActionName("GetPageCountOfKeyInformationOfByIdentifier")]
        public int GetPageCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetPageCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, pageSize);
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
		[HttpGet, ActionName("GetCountOfKeyInformationOfByIdentifier")]
        public int GetCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCountOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
		[HttpGet, ActionName("ExistsOfKeyInformationOfByIdentifier")]
        public bool ExistsOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.ExistsOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation"/></returns>
		[HttpGet, ActionName("GetMessageOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
		[HttpGet, ActionName("GetSingleOfKeyInformationOfByIdentifier")]
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetSingleOfKeyInformationOfByIdentifier(				isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier
				, queryOrderByExpression);
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





    }
}


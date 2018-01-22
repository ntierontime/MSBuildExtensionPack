using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Framework.EntityContracts;
using Framework;

namespace MSBuildExtensionPack.CommonBLLIoC
{
    /// <summary>
    /// provides static method wrappers of Business logic layer using IoC
    /// </summary>
    //[System.ComponentModel.DataObject], because of Silverlight and Windows Phone 7.1
    public static class IoCBuildLog
    {
        #region insert, update and delete in request message

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.InsertEntity(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.UpdateEntity(_Request);
        }

        /// <summary>
        /// Deletes By Identifier an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.DeleteByIdentifierEntity(_Request);
        }

        /// <summary>
        /// Deletes an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            return _BusinessLogicLayerInstance.DeleteEntity(_Request);
        }

        #endregion insert, update and delete in request message

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request =new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _Request.Criteria.Add(input);
            return InsertRequest(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _Request.Criteria.Add(input);
            return UpdateRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = identifier;
            return DeleteByIdentifierRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _Request.Criteria.Add(input);
            return DeleteRequest(_Request);
        }

        #endregion insert, update and delete in an entity

        #region insert, update and delete using .Net value types

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="buildId">property value of System.Int64</param>
        /// <param name="buildEventCodeId">property value of System.Int32</param>
        /// <param name="message">property value of System.String</param>
        /// <param name="eventTime">property value of System.DateTime</param>
        public static void Insert(
            System.Int64 id
            , System.Int64 buildId
            , System.Int32 buildEventCodeId
            , System.String message
            , System.DateTime eventTime
            )
        {
            InsertEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLog(
                id
                , buildId
                , buildEventCodeId
                , message
                , eventTime));
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="buildId">property value of System.Int64</param>
        /// <param name="buildEventCodeId">property value of System.Int32</param>
        /// <param name="message">property value of System.String</param>
        /// <param name="eventTime">property value of System.DateTime</param>
        public static void Update(
            System.Int64 id
            , System.Int64 buildId
            , System.Int32 buildEventCodeId
            , System.String message
            , System.DateTime eventTime            )
        {
            UpdateEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLog(
                id
                , buildId
                , buildEventCodeId
                , message
                , eventTime));
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="buildId">property value of System.Int64</param>
        /// <param name="buildEventCodeId">property value of System.Int32</param>
        /// <param name="message">property value of System.String</param>
        /// <param name="eventTime">property value of System.DateTime</param>
        public static void Delete(
            System.Int64 id
            , System.Int64 buildId
            , System.Int32 buildEventCodeId
            , System.String message
            , System.DateTime eventTime
            )
        {
            DeleteEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLog(
                id
                , buildId
                , buildEventCodeId
                , message
                , eventTime));
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            return DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier(
                id));
        }

        #endregion insert, update and delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchUpdate(_Request);
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchInsert(_Request);
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchDelete(_Request);
        }

        #endregion batch insert, update and delete in an entity collection

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
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon _GetBuildLogChainedQueryCriteriaCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon();
            criteria.BuildLogQueryCriteriaCommon.IdCommonOfBuild_1 = new QuerySystemInt64EqualsCriteria(isToCompareBuildId, buildId);
            criteria.BuildLogQueryCriteriaCommon.IdCommonOfSolution_1 = new QuerySystemInt32EqualsCriteria(isToCompareSolution_1Id, solution_1Id);
            criteria.BuildLogQueryCriteriaCommon.IdCommonOfOrganization_1 = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_1Id, organization_1Id);
            criteria.BuildLogQueryCriteriaCommon.IdCommonOfOrganization_2 = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_2Id, organization_2Id);
            criteria.BuildLogQueryCriteriaCommon.IdCommonOfBuildEventCode_1 = new QuerySystemInt32EqualsCriteria(isToCompareBuildEventCodeId, buildEventCodeId);
            criteria.BuildLogQueryCriteriaCommon.EventTimeCommonOft = new QuerySystemDateTimeRangeCriteria(isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh);
            criteria.BuildLogQueryCriteriaCommon.MessageCommonOft = new QuerySystemStringContainsCriteria(isToCompareMessage, message);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll _GetBuildLogChainedQueryCriteriaAll(

            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll();

            return criteria;
        }

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
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly _GetBuildLogChainedQueryCriteriaByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly();
            criteria.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuild_1 = new QuerySystemInt64EqualsCriteria(isToCompareBuildId, buildId);
            criteria.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfSolution_1 = new QuerySystemInt32EqualsCriteria(isToCompareSolution_1Id, solution_1Id);
            criteria.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_1 = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_1Id, organization_1Id);
            criteria.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfOrganization_2 = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_2Id, organization_2Id);
            criteria.BuildLogQueryCriteriaByFKOnly.IdByFKOnlyOfBuildEventCode_1 = new QuerySystemInt32EqualsCriteria(isToCompareBuildEventCodeId, buildEventCodeId);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier _GetBuildLogChainedQueryCriteriaByIdentifier(
            bool isToCompareId, System.Int64? id
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier();
            criteria.BuildLogQueryCriteriaByIdentifier.IdByIdentifierOft = new QuerySystemInt64EqualsCriteria(isToCompareId, id);
            return criteria;
        }

        #region Query Methods Of Entity of Common per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfEntityOfCommon(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of Common per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of Common per value type

        #region Query Methods Of Default of Common per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultOfCommon(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of Common per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfCommon(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , bool isToCompareEventTimeRange, bool isToCompareEventTimeRangeLow, System.DateTime? eventTimeRangeLow, bool isToCompareEventTimeRangeHigh, System.DateTime? eventTimeRangeHigh
            , bool isToCompareMessage, System.String message
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaCommon(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                , isToCompareEventTimeRange, isToCompareEventTimeRangeLow, eventTimeRangeLow, isToCompareEventTimeRangeHigh, eventTimeRangeHigh
                , isToCompareMessage, message
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of Common per value type

        #region Query Methods Of Entity of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfEntityOfAll(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of All per value type

        #region Query Methods Of NameValuePair of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfNameValuePairOfAll(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of All per value type

        #region Query Methods Of RssItem of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfRssItemOfAll(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of All per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of All per value type

        #region Query Methods Of Entity of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfEntityOfByFKOnly(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of ByFKOnly per value type

        #region Query Methods Of NameValuePair of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfNameValuePairOfByFKOnly(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type

        #region Query Methods Of RssItem of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfRssItemOfByFKOnly(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of ByFKOnly per value type

        #region Query Methods Of Default of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultOfByFKOnly(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of ByFKOnly per value type

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultGroupedDataViewOfByFKOnly(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("BuildId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int GetCountOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareBuildId, System.Int64? buildId
            , bool isToCompareSolution_1Id, System.Int32? solution_1Id
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildEventCodeId, System.Int32? buildEventCodeId
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByFKOnly(
                isToCompareBuildId, buildId
                , isToCompareSolution_1Id, solution_1Id
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildEventCodeId, buildEventCodeId
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        #region Query Methods Of Entity of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfEntityOfByIdentifier(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetCollectionOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLogCollection GetSingleOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of ByIdentifier per value type

        #region Query Methods Of Default of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultOfByIdentifier(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of ByIdentifier per value type

        #region Query Methods Of KeyInformation of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfKeyInformationOfByIdentifier(
                criteria
                , queryPagingSetting
                , queryOrderBySettingCollection
                , Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of KeyInformation of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                if (_PageCount > 0)
                {
                    List<int> _retval = new List<int>();
                    for (int i = 1; i <= _PageCount; i++)
                    {
                        _retval.Add(i);
                    }
                    //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuildLog();
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildLogChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuildLog", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type

    }
}


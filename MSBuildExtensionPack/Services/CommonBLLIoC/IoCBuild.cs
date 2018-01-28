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
    public static class IoCBuild
    {
        #region insert, update and delete in request message

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.InsertEntity(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.UpdateEntity(_Request);
        }

        /// <summary>
        /// Deletes By Identifier an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.DeleteByIdentifierEntity(_Request);
        }

        /// <summary>
        /// Deletes an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteRequest(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.DeleteEntity(_Request);
        }

        #endregion insert, update and delete in request message

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request =new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
            _Request.Criteria.Add(input);
            return InsertRequest(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
            _Request.Criteria.Add(input);
            return UpdateRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = identifier;
            return DeleteByIdentifierRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
            _Request.Criteria.Add(input);
            return DeleteRequest(_Request);
        }

        #endregion insert, update and delete in an entity

        #region insert, update and delete using .Net value types

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="solutionId">property value of System.Int32</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        /// <param name="buildStartTime">property value of System.DateTime</param>
        public static void Insert(
            System.Int64 id
            , System.Int32 solutionId
            , System.String name
            , System.String description
            , System.DateTime buildStartTime
            )
        {
            InsertEntity(new MSBuildExtensionPack.DataSourceEntities.Build(
                id
                , solutionId
                , name
                , description
                , buildStartTime));
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="solutionId">property value of System.Int32</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        /// <param name="buildStartTime">property value of System.DateTime</param>
        public static void Update(
            System.Int64 id
            , System.Int32 solutionId
            , System.String name
            , System.String description
            , System.DateTime buildStartTime            )
        {
            UpdateEntity(new MSBuildExtensionPack.DataSourceEntities.Build(
                id
                , solutionId
                , name
                , description
                , buildStartTime));
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="solutionId">property value of System.Int32</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        /// <param name="buildStartTime">property value of System.DateTime</param>
        public static void Delete(
            System.Int64 id
            , System.Int32 solutionId
            , System.String name
            , System.String description
            , System.DateTime buildStartTime
            )
        {
            DeleteEntity(new MSBuildExtensionPack.DataSourceEntities.Build(
                id
                , solutionId
                , name
                , description
                , buildStartTime));
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            return DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildIdentifier(
                id));
        }

        #endregion insert, update and delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchUpdate(_Request);
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchInsert(_Request);
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchDelete(_Request);
        }

        #endregion batch insert, update and delete in an entity collection

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
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon _GetBuildChainedQueryCriteriaCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon();
            criteria.BuildQueryCriteriaCommon.SolutionId = new QuerySystemInt32EqualsCriteria(isToCompareSolutionId, solutionId);
            criteria.BuildQueryCriteriaCommon.Organization_1Id = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_1Id, organization_1Id);
            criteria.BuildQueryCriteriaCommon.Organization_2Id = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_2Id, organization_2Id);
            criteria.BuildQueryCriteriaCommon.BuildStartTimeRange = new QuerySystemDateTimeRangeCriteria(isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh);
            criteria.BuildQueryCriteriaCommon.Name = new QuerySystemStringContainsCriteria(isToCompareName, name);
            criteria.BuildQueryCriteriaCommon.Description = new QuerySystemStringContainsCriteria(isToCompareDescription, description);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll _GetBuildChainedQueryCriteriaAll(

            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll();

            return criteria;
        }

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
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly _GetBuildChainedQueryCriteriaByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly();
            criteria.BuildQueryCriteriaByFKOnly.SolutionId = new QuerySystemInt32EqualsCriteria(isToCompareSolutionId, solutionId);
            criteria.BuildQueryCriteriaByFKOnly.Organization_1Id = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_1Id, organization_1Id);
            criteria.BuildQueryCriteriaByFKOnly.Organization_2Id = new QuerySystemInt64EqualsCriteria(isToCompareOrganization_2Id, organization_2Id);
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
        private static MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier _GetBuildChainedQueryCriteriaByIdentifier(
            bool isToCompareId, System.Int64? id
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier();
            criteria.BuildQueryCriteriaByIdentifier.Id = new QuerySystemInt64EqualsCriteria(isToCompareId, id);
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
        public static int[] __GetPageNumberListOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfCommon for __GetPageNumberListOfEntityOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfCommon(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfCommon for __GetPageCountOfEntityOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfCommon"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfEntityOfCommon(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfEntityOfCommon"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfCommon"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of Common per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfCommon for __GetPageNumberListOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfCommon(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfCommon for __GetPageCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfCommon for __GetPageNumberListOfDefaultOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfCommon(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfCommon for __GetPageCountOfDefaultOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultOfCommon"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfCommon"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfDefaultOfCommon(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfDefaultOfCommon"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultOfCommon"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of Common per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfCommon for __GetPageNumberListOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfCommon(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
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
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfCommon for __GetPageCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetCollectionOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetSingleOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultOfCommon"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaCommon(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                , isToCompareBuildStartTimeRange, isToCompareBuildStartTimeRangeLow, buildStartTimeRangeLow, isToCompareBuildStartTimeRangeHigh, buildStartTimeRangeHigh
                , isToCompareName, name
                , isToCompareDescription, description
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfAll for __GetPageNumberListOfEntityOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfAll(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfAll for __GetPageCountOfEntityOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfAll"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfEntityOfAll(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfEntityOfAll"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfAll"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfEntityOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfAll for __GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfAll(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfEntityOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfAll for __GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int __GetCountOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfAll for __GetPageNumberListOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfAll(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfAll for __GetPageCountOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.NameValueCollection __GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfNameValuePairOfAll(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection __GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfNameValuePairOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfNameValuePairOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfAll for __GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfAll(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfNameValuePairOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfAll for __GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int __GetCountOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.NameValueCollection __GetCollectionOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetMessageOfNameValuePairOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection __GetSingleOfNameValuePairOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfAll for __GetPageNumberListOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfAll(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfAll for __GetPageCountOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.RssItemCollection __GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfRssItemOfAll(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection __GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfRssItemOfAll"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfRssItemOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfAll for __GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfAll(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfRssItemOfAll(
            int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfAll for __GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int __GetCountOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.RssItemCollection __GetCollectionOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetMessageOfRssItemOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection __GetSingleOfRssItemOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByFKOnly for __GetPageNumberListOfEntityOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByFKOnly for __GetPageCountOfEntityOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfEntityOfByFKOnly(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfEntityOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByFKOnly for __GetPageNumberListOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByFKOnly for __GetPageCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfByFKOnly for __GetPageNumberListOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfByFKOnly for __GetPageCountOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.NameValueCollection __GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetMessageOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfNameValuePairOfByFKOnly(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetMessageOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection __GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfNameValuePairOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfByFKOnly for __GetPageNumberListOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfByFKOnly for __GetPageCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static Framework.NameValueCollection __GetCollectionOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetMessageOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfNameValuePairOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection __GetSingleOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfNameValuePairOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfByFKOnly for __GetPageNumberListOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfByFKOnly for __GetPageCountOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.RssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetMessageOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfRssItemOfByFKOnly(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetMessageOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection __GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfRssItemOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfByFKOnly for __GetPageNumberListOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfByFKOnly for __GetPageCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static Framework.RssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetMessageOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetCollectionOfRssItemOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection __GetSingleOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfRssItemOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.__GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByFKOnly for __GetPageNumberListOfDefaultOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByFKOnly for __GetPageCountOfDefaultOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfDefaultOfByFKOnly(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfDefaultOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Default of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByFKOnly for __GetPageNumberListOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByFKOnly for __GetPageCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetCollectionOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetSingleOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultGroupedDataViewOfByFKOnly for __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultGroupedDataViewOfByFKOnly for __GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfDefaultGroupedDataViewOfByFKOnly(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("SolutionId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultGroupedDataViewOfByFKOnly for __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int __GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultGroupedDataViewOfByFKOnly for __GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
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
        public static int __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
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
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareSolutionId">will compare/filter solutionId property/field/column if true, otherwise false</param>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="isToCompareOrganization_1Id">will compare/filter organization_1Id property/field/column if true, otherwise false</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="isToCompareOrganization_2Id">will compare/filter organization_2Id property/field/column if true, otherwise false</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultGroupedDataViewOfByFKOnly"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByFKOnly(
                isToCompareSolutionId, solutionId
                , isToCompareOrganization_1Id, organization_1Id
                , isToCompareOrganization_2Id, organization_2Id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByIdentifier for __GetPageNumberListOfEntityOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByIdentifier for __GetPageCountOfEntityOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfEntityOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfEntityOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByIdentifier for __GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByIdentifier for __GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetCollectionOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetMessageOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection __GetSingleOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.__GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByIdentifier for __GetPageNumberListOfDefaultOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByIdentifier for __GetPageCountOfDefaultOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfDefaultOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfDefaultOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByIdentifier for __GetPageNumberListOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByIdentifier for __GetPageCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetCollectionOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetMessageOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection __GetSingleOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.__GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Default of ByIdentifier per value type

        #region Query Methods Of UpdateNameRequest of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfUpdateNameRequestOfByIdentifier for __GetPageNumberListOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfUpdateNameRequestOfByIdentifier for __GetPageCountOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection __GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfUpdateNameRequestOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.__GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfUpdateNameRequestOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfUpdateNameRequestOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.__GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection __GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfUpdateNameRequestOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.__GetSingleOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of UpdateNameRequest of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfUpdateNameRequestOfByIdentifier for __GetPageNumberListOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfUpdateNameRequestOfByIdentifier for __GetPageCountOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection __GetCollectionOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.__GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetMessageOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.__GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection __GetSingleOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.__GetSingleOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier per value type

        #region Query Methods Of KeyInformation of ByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] __GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfKeyInformationOfByIdentifier for __GetPageNumberListOfKeyInformationOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfKeyInformationOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfKeyInformationOfByIdentifier for __GetPageCountOfKeyInformationOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfKeyInformationOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfKeyInformationOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfKeyInformationOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.__GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return __GetMessageOfKeyInformationOfByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: __GetMessageOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetMessageOfKeyInformationOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.__GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfKeyInformationOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.__GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int[] __GetPageNumberListOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfKeyInformationOfByIdentifier for __GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfKeyInformationOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: __GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int __GetPageCountOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: __GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfKeyInformationOfByIdentifier for __GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: __GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: __GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "__GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int __GetCountOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.__GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool __ExistsOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.__ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection __GetCollectionOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.__GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetMessageOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.__GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection __GetSingleOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "__GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.__GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "__GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type

        #region EntityUpdateActionSetting - UpdateNameOnly

        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.UpdateNameOnly(request);
        }

        #endregion EntityUpdateActionSetting - UpdateNameOnly

    }
}


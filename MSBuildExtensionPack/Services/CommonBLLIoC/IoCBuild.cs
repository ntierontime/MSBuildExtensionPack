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

        #region Query Methods Of EntityOfCommon per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfCommon per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of EntityOfCommon per value type

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
        public static int[] GetPageNumberListOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
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
                //.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
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
                //.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfEntityOfCommon(
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
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfEntityOfCommon(
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
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfCommon"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfCommon(
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
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfCommon"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfCommon(
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
                , "GetCollectionOfEntityOfCommon"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
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
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfCommon"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfCommon per value type

        #region Query Methods Of DefaultOfCommon per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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
                //.Process("IoCBuild", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultOfCommon per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultOfCommon per value type

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
        public static int[] GetPageNumberListOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageNumberListOfDefaultOfCommon"
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
                //.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon for GetPageCountOfDefaultOfCommon"
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
                //.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfDefaultOfCommon(
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
            //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfCommon"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfDefaultOfCommon(
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
            //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfCommon"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfCommon(
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
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfCommon"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfCommon(
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
                , "GetCollectionOfDefaultOfCommon"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfCommon(_Request);
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfCommon(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , bool isToCompareBuildStartTimeRange, bool isToCompareBuildStartTimeRangeLow, System.DateTime? buildStartTimeRangeLow, bool isToCompareBuildStartTimeRangeHigh, System.DateTime? buildStartTimeRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareDescription, System.String description
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfCommon"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultOfCommon per value type

        #region Query Methods Of EntityOfAll per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfAll per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of EntityOfAll per value type

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
                //.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
                //.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfAll(
            string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfAll per value type

        #region Query Methods Of NameValuePairOfAll per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePairOfAll per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePairOfAll per value type

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePairOfAll per value type

        #region Query Methods Of RssItemOfAll per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
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
                //.Process("IoCBuild", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItemOfAll per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItemOfAll per value type

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
                //.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
                //.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItemOfAll per value type

        #region Query Methods Of EntityOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of EntityOfByFKOnly per value type

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
        public static int[] GetPageNumberListOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageNumberListOfEntityOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly for GetPageCountOfEntityOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByFKOnly(
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
                , "GetCollectionOfEntityOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByFKOnly(_Request);
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
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfByFKOnly per value type

        #region Query Methods Of NameValuePairOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePairOfByFKOnly per value type

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
        public static int[] GetPageNumberListOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageNumberListOfNameValuePairOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly for GetPageCountOfNameValuePairOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
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
                , "GetCollectionOfNameValuePairOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfByFKOnly(_Request);
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
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfNameValuePairOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly per value type

        #region Query Methods Of RssItemOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItemOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItemOfByFKOnly per value type

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
        public static int[] GetPageNumberListOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageNumberListOfRssItemOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly for GetPageCountOfRssItemOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.RssItemCollection GetCollectionOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfByFKOnly(
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
                , "GetCollectionOfRssItemOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfByFKOnly(_Request);
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
        public static Framework.RssItemCollection GetSingleOfRssItemOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfRssItemOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItemOfByFKOnly per value type

        #region Query Methods Of DefaultOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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
                //.Process("IoCBuild", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultOfByFKOnly per value type

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
        public static int[] GetPageNumberListOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageNumberListOfDefaultOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly for GetPageCountOfDefaultOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByFKOnly(
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
                , "GetCollectionOfDefaultOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByFKOnly(_Request);
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultOfByFKOnly per value type

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultGroupedDataViewOfByFKOnly"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultGroupedDataViewOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly per value type

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
        public static int[] GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly for GetPageCountOfDefaultGroupedDataViewOfByFKOnly"
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
                //.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultGroupedDataViewOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultGroupedDataViewOfByFKOnly"
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
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewOfByFKOnly(
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
                , "GetCollectionOfDefaultGroupedDataViewOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(_Request);
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            bool isToCompareSolutionId, System.Int32? solutionId
            , bool isToCompareOrganization_1Id, System.Int64? organization_1Id
            , bool isToCompareOrganization_2Id, System.Int64? organization_2Id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultGroupedDataViewOfByFKOnly"
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
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultGroupedDataViewOfByFKOnly", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly per value type

        #region Query Methods Of EntityOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of EntityOfByIdentifier per value type

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetCollectionOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.BuildCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildCollection GetSingleOfEntityOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of EntityOfByIdentifier per value type

        #region Query Methods Of DefaultOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of DefaultOfByIdentifier per value type

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageNumberListOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier for GetPageCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "ExistsOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetCollectionOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default GetMessageOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection GetSingleOfDefaultOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfDefaultOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetSingleOfDefaultOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfDefaultOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of DefaultOfByIdentifier per value type

        #region Query Methods Of UpdateNameRequestOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier for GetPageNumberListOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier for GetPageCountOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfUpdateNameRequestOfByIdentifier"
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

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfUpdateNameRequestOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfUpdateNameRequestOfByIdentifier(
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfUpdateNameRequestOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfUpdateNameRequestOfByIdentifier"
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetSingleOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of UpdateNameRequestOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of UpdateNameRequestOfByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier for GetPageNumberListOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
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
                    //log.Info(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    return _retval.ToArray();
                }
                else
                {
                    //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                    return null;
                }
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                    //log.Error(string.Format("{0}: GetPageNumberListOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static int GetPageCountOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier for GetPageCountOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                int _PageCount = Framework.EntityContracts.QueryPagingSetting.GetPageCount(pageSize, _Response.Message);
                //log.Info(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _PageCount;
            }
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                //.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        public static int GetCountOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCountOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static bool ExistsOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "ExistsOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection GetCollectionOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest GetMessageOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetCollectionOfUpdateNameRequestOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection GetSingleOfUpdateNameRequestOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfUpdateNameRequestOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _Response = _BusinessLogicLayerInstance.GetSingleOfUpdateNameRequestOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfUpdateNameRequestOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of UpdateNameRequestOfByIdentifier per value type

        #region Query Methods Of KeyInformationOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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
                //.Process("IoCBuild", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
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

            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier per criteria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of KeyInformationOfByIdentifier per value type

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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , null
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
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
                //.Process("IoCBuild", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            bool isToCompareId, System.Int64? id
            , string queryOrderByExpression
            )

        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                , -1
                , -1
                , queryOrderByExpression
                );
            _Request.Criteria = _GetBuildChainedQueryCriteriaByIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCBuild", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier per value type

        #region EntityUpdateActionSetting - UpdateNameOnly

        public static MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request)
        {
            MSBuildExtensionPack.WcfContracts.IBuildService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceBuild();
            return _BusinessLogicLayerInstance.UpdateNameOnly(request);
        }

        #endregion EntityUpdateActionSetting - UpdateNameOnly

    }
}


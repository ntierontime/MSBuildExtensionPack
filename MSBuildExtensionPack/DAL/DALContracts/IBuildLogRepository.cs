using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace MSBuildExtensionPack.DALContracts
{
    /// <summary>
    /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
    /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
    /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
    /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
    /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
    /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
    /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
    /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
    /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
    /// </summary>
    /// <typeparam name="TCollection">collection class of entity</typeparam>
    /// <typeparam name="T">the entity class</typeparam>
    /// <typeparam name="TIdentifier">identifier class of entity</typeparam>
    public interface IBuildLogRepository<TCollection, T, TIdentifier, TCollectionMessage>
        : Framework.DAL.DataAccessLayerContractBase<TCollection, T, TIdentifier, TCollectionMessage>
        where TCollection : IList<T>, new()
        where T : MSBuildExtensionPack.EntityContracts.IBuildLog, new()
        where TIdentifier : MSBuildExtensionPack.EntityContracts.IBuildLogIdentifier, new()
    {

    }

    /// <summary>
    /// There is a DataAccessLayerEntityContract class for each entity, which inherits from <see cref="Framework.DAL.DataAccessLayerContractBase&lt;TCollection, T, TIdentifier&gt;"/> with 3 type arguments, entity class and its collection class, and identifier class.
    /// </summary>
    public interface IBuildLogRepository: IBuildLogRepository<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog>
    {

        #region Binary Columns

        #endregion Binary Columns

        #region Query Methods Of Entity of Common

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformation of ByIdentifier

    }
}


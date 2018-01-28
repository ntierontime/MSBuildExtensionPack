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
    public interface IBuildRepository<TCollection, T, TIdentifier, TCollectionMessage>
        : Framework.DAL.DataAccessLayerContractBase<TCollection, T, TIdentifier, TCollectionMessage>
        where TCollection : IList<T>, new()
        where T : MSBuildExtensionPack.EntityContracts.IBuild, new()
        where TIdentifier : MSBuildExtensionPack.EntityContracts.IBuildIdentifier, new()
    {

    }

    /// <summary>
    /// There is a DataAccessLayerEntityContract class for each entity, which inherits from <see cref="Framework.DAL.DataAccessLayerContractBase&lt;TCollection, T, TIdentifier&gt;"/> with 3 type arguments, entity class and its collection class, and identifier class.
    /// </summary>
    public interface IBuildRepository: IBuildRepository<MSBuildExtensionPack.DataSourceEntities.BuildCollection, MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildIdentifier, MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild>
    {

        #region Binary Columns

        #endregion Binary Columns

        #region Query Methods Of Entity of Common

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild __GetSingleOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild __GetCollectionOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria buildStartTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild __GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild __GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageRssItem __GetSingleOfRssItemOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection __GetCollectionOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild __GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild __GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageRssItem __GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataViewCollection __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria solutionId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild __GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild __GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of UpdateNameRequest of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfUpdateNameRequestOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfUpdateNameRequestOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfUpdateNameRequest __GetSingleOfUpdateNameRequestOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfUpdateNameRequestCollection __GetCollectionOfUpdateNameRequestOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformationCollection __GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region UpdateNameOnly

        /// <summary>
        /// UpdateNameOnly
        /// Description:
        /// </summary>
        /// <param name="input"></param>
        MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfUpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest input);

        #endregion UpdateNameOnly

    }
}


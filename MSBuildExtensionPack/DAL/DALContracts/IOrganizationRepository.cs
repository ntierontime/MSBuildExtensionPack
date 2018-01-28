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
    public interface IOrganizationRepository<TCollection, T, TIdentifier, TCollectionMessage>
        : Framework.DAL.DataAccessLayerContractBase<TCollection, T, TIdentifier, TCollectionMessage>
        where TCollection : IList<T>, new()
        where T : MSBuildExtensionPack.EntityContracts.IOrganization, new()
        where TIdentifier : MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, new()
    {

    }

    /// <summary>
    /// There is a DataAccessLayerEntityContract class for each entity, which inherits from <see cref="Framework.DAL.DataAccessLayerContractBase&lt;TCollection, T, TIdentifier&gt;"/> with 3 type arguments, entity class and its collection class, and identifier class.
    /// </summary>
    public interface IOrganizationRepository: IOrganizationRepository<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier, MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization>
    {

        #region Binary Columns

        #endregion Binary Columns

        #region Query Methods Of Entity of Common

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria isSystemBuiltIn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria createdDateTimeRange
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria bitColumn
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria datetime2ColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria smalldatetimeColumnRange
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria dateColumnRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria charColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria varcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria textColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ncharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria nvarcharColumn
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria ntextColumn
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

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfAll(
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageRssItem __GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
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

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfByIdentifier(
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

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByIdentifier

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

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection __GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        #region GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

        /// <summary>
        /// Get ascendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a collection of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection"/></returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier id);

        /// <summary>
        /// Get descendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a collection of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection"/></returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection GetDescendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier id);

        #endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

    }
}


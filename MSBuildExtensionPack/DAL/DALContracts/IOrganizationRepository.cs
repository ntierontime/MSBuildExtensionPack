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

        #region Query Methods Of EntityOfCommon

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfCommon(
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

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfCommon(
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

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfCommon(
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

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfCommon(
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

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfCommon(
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

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfCommon(
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

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfCommon(
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

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfCommon(
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

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

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

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

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

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

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

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

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

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

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

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

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

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformationOfByIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of EntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of EntityOfIdentifierAndUniqueConstraint

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of EntityOfIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultOfIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformationOfIdentifierAndUniqueConstraint

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


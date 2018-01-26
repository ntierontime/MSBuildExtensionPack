using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace MSBuildExtensionPack.DALContracts
{
    /// <summary>
    /// There is a DataAccessLayerEntityContract class for each entity, which inherits from <see cref="Framework.DAL.DataAccessLayerContractBase&lt;TCollection, T, TIdentifier&gt;"/> with 3 type arguments, entity class and its collection class, and identifier class.
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
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

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
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

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
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

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
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
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            );

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
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


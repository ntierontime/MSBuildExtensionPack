using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using LinqToLdap;
//using LinqToLdap.Mapping;
//using LinqToLdap.Mapping.PropertyMappings;
//using LinqToLdap.Mapping.PropertyMappingBuilders;
//using LINQtoCSV;
//using LinqToLdap.Collections;
//using System.DirectoryServices.Protocols;
//using System.Diagnostics;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// provides some common methods/actions/stubs.
    /// </summary>
    public static class BuildLogHelper
    {
        #region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog CreateEntity(
            System.Int64 id
            ,System.Int64 buildId
            ,System.Int32 buildEventCodeId
            ,System.String message
            ,System.DateTime eventTime
            )
        {
            MSBuildExtensionPack.DataSourceEntities.BuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.BuildLog(
                id
                ,buildId
                ,buildEventCodeId
                ,message
                ,eventTime
                );
            return _retval;
        }

        #endregion CreateEntity(...)

        #region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.BuildLog item)
        {
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.EventTime < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
                       item.EventTime = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
                    }

        }

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            for(int i = 0; i < input.Count; i ++)
            {
                MSBuildExtensionPack.DataSourceEntities.BuildLog _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

        #endregion ValidateValueBeforeSaveToDatabase(...)

        #region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void AssignEnityReferenceIDs(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input, System.Int64 buildId, System.Int32 buildEventCodeId)
        {
            for(int i = 0; i < input.Count; i ++)
            {
                MSBuildExtensionPack.DataSourceEntities.BuildLog _Item = input[i];
                _Item.BuildId = buildId;
                _Item.BuildEventCodeId = buildEventCodeId;
            }
        }

        #endregion AssignEnityReferenceIDs(...)

        #region CreateNameValuePair(...)

        /// <summary>
        /// Creates a new instance of view NameValuePair.
        /// </summary>
        /// <returns>an instance of <see cref="Framework.NameValuePair"/></returns>
        public static Framework.NameValuePair CreateNameValuePair(
System.String value, System.String name
            )
        {
            Framework.NameValuePair _retval = new Framework.NameValuePair();
                _retval.Value = value;
                _retval.Name = name;
            return _retval;
        }

        #endregion CreateNameValuePair(...)

        #region CreateRssItem(...)

        /// <summary>
        /// Creates a new instance of view RssItem.
        /// </summary>
        /// <returns>an instance of <see cref="Framework.RssItem"/></returns>
        public static Framework.RssItem CreateRssItem(
System.String identifierInString, System.String title, System.String description, System.DateTime pubDate
            )
        {
            Framework.RssItem _retval = new Framework.RssItem();
                _retval.IdentifierInString = identifierInString;
                _retval.Title = title;
                _retval.Description = description;
                _retval.PubDate = pubDate;
            return _retval;
        }

        #endregion CreateRssItem(...)

        #region CreateDefault(...)

        /// <summary>
        /// Creates a new instance of view Default.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.Default"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.Default CreateDefault(
System.Int64 id, System.Int64 buildId, System.Int32 buildEventCodeId, System.String message, System.DateTime eventTime, System.String build_1_Name, System.String solution_1_Name, System.Int32 solution_1Id, System.String organization_1_Name, System.Int64 organization_1Id, System.Guid organization_1_UniqueIdentifier, System.Guid organization_1_UniqueidentifierColumn, System.String organization_2_Name, System.Int64 organization_2Id, System.Guid organization_2_UniqueIdentifier, System.Guid organization_2_UniqueidentifierColumn, System.String buildEventCode_1_Name
            )
        {
            MSBuildExtensionPack.DataSourceEntities.BuildLog.Default _retval = new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default();
                _retval.Id = id;
                _retval.BuildId = buildId;
                _retval.BuildEventCodeId = buildEventCodeId;
                _retval.Message = message;
                _retval.EventTime = eventTime;
                _retval.Build_1_Name = build_1_Name;
                _retval.Solution_1_Name = solution_1_Name;
                _retval.Solution_1Id = solution_1Id;
                _retval.Organization_1_Name = organization_1_Name;
                _retval.Organization_1Id = organization_1Id;
                _retval.Organization_1_UniqueIdentifier = organization_1_UniqueIdentifier;
                _retval.Organization_1_UniqueidentifierColumn = organization_1_UniqueidentifierColumn;
                _retval.Organization_2_Name = organization_2_Name;
                _retval.Organization_2Id = organization_2Id;
                _retval.Organization_2_UniqueIdentifier = organization_2_UniqueIdentifier;
                _retval.Organization_2_UniqueidentifierColumn = organization_2_UniqueidentifierColumn;
                _retval.BuildEventCode_1_Name = buildEventCode_1_Name;
            return _retval;
        }

        #endregion CreateDefault(...)

        #region CreateDefaultGroupedDataView(...)

        /// <summary>
        /// Creates a new instance of view DefaultGroupedDataView.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView CreateDefaultGroupedDataView(
System.Int64 buildId, System.Int32 buildEventCodeId, System.Int32 solution_1Id, System.Int64 organization_1Id, System.Int64 organization_2Id, System.Int64 countPerFK, System.String name
            )
        {
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView _retval = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView();
                _retval.BuildId = buildId;
                _retval.BuildEventCodeId = buildEventCodeId;
                _retval.Solution_1Id = solution_1Id;
                _retval.Organization_1Id = organization_1Id;
                _retval.Organization_2Id = organization_2Id;
                _retval.CountPerFK = countPerFK;
                _retval.Name = name;
            return _retval;
        }

        #endregion CreateDefaultGroupedDataView(...)

        #region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation CreateKeyInformation(
System.Int64 id, System.Int32 buildEventCodeId
            )
        {
            MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation _retval = new MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation();
                _retval.Id = id;
                _retval.BuildEventCodeId = buildEventCodeId;
            return _retval;
        }

        #endregion CreateKeyInformation(...)

    }

}


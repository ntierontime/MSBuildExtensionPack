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
    public static class BuildHelper
    {
        #region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Build"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build CreateEntity(
            System.Int64 id
            ,System.Int32 solutionId
            ,System.String name
            ,System.String description
            ,System.DateTime buildStartTime
            )
        {
            MSBuildExtensionPack.DataSourceEntities.Build _retval = new MSBuildExtensionPack.DataSourceEntities.Build(
                id
                ,solutionId
                ,name
                ,description
                ,buildStartTime
                );
            return _retval;
        }

        #endregion CreateEntity(...)

        #region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.Build item)
        {
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.BuildStartTime < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
                       item.BuildStartTime = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
                    }

        }

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            for(int i = 0; i < input.Count; i ++)
            {
                MSBuildExtensionPack.DataSourceEntities.Build _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

        #endregion ValidateValueBeforeSaveToDatabase(...)

        #region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void AssignEnityReferenceIDs(MSBuildExtensionPack.DataSourceEntities.BuildCollection input, System.Int32 solutionId)
        {
            for(int i = 0; i < input.Count; i ++)
            {
                MSBuildExtensionPack.DataSourceEntities.Build _Item = input[i];
                _Item.SolutionId = solutionId;
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
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Build.Default"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.Default CreateDefault(
System.String solution_1_Name, System.Int64 id, System.Int64 organization_1Id, System.Guid organization_1_UniqueIdentifier, System.Guid organization_1_UniqueidentifierColumn, System.String organization_1_Name, System.Int64 organization_2Id, System.Guid organization_2_UniqueIdentifier, System.Guid organization_2_UniqueidentifierColumn, System.String organization_2_Name, System.Int32 solutionId, System.String name, System.String description, System.DateTime buildStartTime
            )
        {
            MSBuildExtensionPack.DataSourceEntities.Build.Default _retval = new MSBuildExtensionPack.DataSourceEntities.Build.Default();
                _retval.Solution_1_Name = solution_1_Name;
                _retval.Id = id;
                _retval.Organization_1Id = organization_1Id;
                _retval.Organization_1_UniqueIdentifier = organization_1_UniqueIdentifier;
                _retval.Organization_1_UniqueidentifierColumn = organization_1_UniqueidentifierColumn;
                _retval.Organization_1_Name = organization_1_Name;
                _retval.Organization_2Id = organization_2Id;
                _retval.Organization_2_UniqueIdentifier = organization_2_UniqueIdentifier;
                _retval.Organization_2_UniqueidentifierColumn = organization_2_UniqueidentifierColumn;
                _retval.Organization_2_Name = organization_2_Name;
                _retval.SolutionId = solutionId;
                _retval.Name = name;
                _retval.Description = description;
                _retval.BuildStartTime = buildStartTime;
            return _retval;
        }

        #endregion CreateDefault(...)

        #region CreateDefaultGroupedDataView(...)

        /// <summary>
        /// Creates a new instance of view DefaultGroupedDataView.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView CreateDefaultGroupedDataView(
System.Int32 solutionId, System.Int64 organization_1Id, System.Int64 organization_2Id, System.Int64 countPerFK, System.String name
            )
        {
            MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView _retval = new MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView();
                _retval.SolutionId = solutionId;
                _retval.Organization_1Id = organization_1Id;
                _retval.Organization_2Id = organization_2Id;
                _retval.CountPerFK = countPerFK;
                _retval.Name = name;
            return _retval;
        }

        #endregion CreateDefaultGroupedDataView(...)

        #region CreateUpdateNameRequest(...)

        /// <summary>
        /// Creates a new instance of view UpdateNameRequest.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest CreateUpdateNameRequest(
System.Int64 id, System.String name
            )
        {
            MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest _retval = new MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest();
                _retval.Id = id;
                _retval.Name = name;
            return _retval;
        }

        #endregion CreateUpdateNameRequest(...)

        #region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation CreateKeyInformation(
System.Int64 id, System.String name
            )
        {
            MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation _retval = new MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation();
                _retval.Id = id;
                _retval.Name = name;
            return _retval;
        }

        #endregion CreateKeyInformation(...)

    }

}


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
    public static class OrganizationHelper
    {
		#region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization CreateEntity(
			System.Int64 id
			,System.Int64 parentId
			,System.String name
			,System.Boolean isSystemBuiltIn
			,System.Guid uniqueIdentifier
			,System.DateTime createdDateTime
			,System.String charColumn
			,System.String varcharColumn
			,System.String textColumn
			,System.String ncharColumn
			,System.String nvarcharColumn
			,System.String ntextColumn
			,System.Boolean bitColumn
			,System.Byte[] binaryColumn
			,System.Byte[] varbinaryColumn
			,System.Byte[] imageColumn
			,System.Byte tinyintColumn
			,System.Int16 smallintColumn
			,System.Int32 intColumn
			,System.Int64 bigintColumn
			,System.Decimal decimalColumn
			,System.Decimal numericColumn
			,System.Decimal smallmoneyColumn
			,System.Decimal moneyColumn
			,System.Single floatColumn
			,System.Single realColumn
			,System.DateTime datetimeColumn
			,System.DateTime datetime2Column
			,System.DateTime smalldatetimeColumn
			,System.DateTime dateColumn
			,System.TimeSpan timeColumn
			,System.Guid uniqueidentifierColumn
			)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization _retval = new MSBuildExtensionPack.DataSourceEntities.Organization(
				id
				,parentId
				,name
				,isSystemBuiltIn
				,uniqueIdentifier
				,createdDateTime
				,charColumn
				,varcharColumn
				,textColumn
				,ncharColumn
				,nvarcharColumn
				,ntextColumn
				,bitColumn
				,binaryColumn
				,varbinaryColumn
				,imageColumn
				,tinyintColumn
				,smallintColumn
				,intColumn
				,bigintColumn
				,decimalColumn
				,numericColumn
				,smallmoneyColumn
				,moneyColumn
				,floatColumn
				,realColumn
				,datetimeColumn
				,datetime2Column
				,smalldatetimeColumn
				,dateColumn
				,timeColumn
				,uniqueidentifierColumn
				);
            return _retval;
        }

		#endregion CreateEntity(...)

		#region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.Organization item)
        {
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.CreatedDateTime < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.CreatedDateTime = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.DatetimeColumn < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.DatetimeColumn = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.Datetime2Column < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.Datetime2Column = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.SmalldatetimeColumn < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.SmalldatetimeColumn = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}
                    // DateTimePropertiesToMinValueOfDateTimeInSQL
                    if (item.DateColumn < Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL)
                    {
	                   item.DateColumn = Framework.DateTimePeriodHelper.MinValueOfDateTimeInSQL;
					}

        }


        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildExtensionPack.DataSourceEntities.Organization _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

		#endregion ValidateValueBeforeSaveToDatabase(...)

		#region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void AssignEnityReferenceIDs(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input, System.Int64 parentId)
		{
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildExtensionPack.DataSourceEntities.Organization _Item = input[i];
				_Item.ParentId = parentId;
            }
		}

		#endregion AssignEnityReferenceIDs(...)


		#region CreateNameValuePair(...)

        /// <summary>
        /// Creates a new instance of view NameValuePair.
        /// </summary>
        /// <returns>an instance of <see cref="Framework.NameValuePair"/></returns>
        public static Framework.NameValuePair CreateNameValuePair(
System.String name, System.String value
			)
        {
            Framework.NameValuePair _retval = new Framework.NameValuePair();
				_retval.Name = name;
				_retval.Value = value;
            return _retval;
        }

		#endregion CreateNameValuePair(...)


		#region CreateRssItem(...)

        /// <summary>
        /// Creates a new instance of view RssItem.
        /// </summary>
        /// <returns>an instance of <see cref="Framework.RssItem"/></returns>
        public static Framework.RssItem CreateRssItem(
System.String title, System.String description, System.DateTime pubDate, System.String identifierInString
			)
        {
            Framework.RssItem _retval = new Framework.RssItem();
				_retval.Title = title;
				_retval.Description = description;
				_retval.PubDate = pubDate;
				_retval.IdentifierInString = identifierInString;
            return _retval;
        }

		#endregion CreateRssItem(...)


		#region CreateDefault(...)

        /// <summary>
        /// Creates a new instance of view Default.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.Default"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.Default CreateDefault(
System.Int64 id, System.Int64 parentId, System.String name, System.Boolean isSystemBuiltIn, System.Guid uniqueIdentifier, System.DateTime createdDateTime, System.String charColumn, System.String varcharColumn, System.String textColumn, System.String ncharColumn, System.String nvarcharColumn, System.String ntextColumn, System.Boolean bitColumn, System.Byte[] binaryColumn, System.Byte[] varbinaryColumn, System.Byte[] imageColumn, System.Byte tinyintColumn, System.Int16 smallintColumn, System.Int32 intColumn, System.Int64 bigintColumn, System.Decimal decimalColumn, System.Decimal numericColumn, System.Decimal smallmoneyColumn, System.Decimal moneyColumn, System.Single floatColumn, System.Single realColumn, System.DateTime datetimeColumn, System.DateTime datetime2Column, System.DateTime smalldatetimeColumn, System.DateTime dateColumn, System.TimeSpan timeColumn, System.Guid uniqueidentifierColumn, System.String organization_2_Name, System.Guid organization_2_UniqueIdentifier, System.Guid organization_2_UniqueidentifierColumn
			)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = new MSBuildExtensionPack.DataSourceEntities.Organization.Default();
				_retval.Id = id;
				_retval.ParentId = parentId;
				_retval.Name = name;
				_retval.IsSystemBuiltIn = isSystemBuiltIn;
				_retval.UniqueIdentifier = uniqueIdentifier;
				_retval.CreatedDateTime = createdDateTime;
				_retval.CharColumn = charColumn;
				_retval.VarcharColumn = varcharColumn;
				_retval.TextColumn = textColumn;
				_retval.NcharColumn = ncharColumn;
				_retval.NvarcharColumn = nvarcharColumn;
				_retval.NtextColumn = ntextColumn;
				_retval.BitColumn = bitColumn;
				_retval.BinaryColumn = binaryColumn;
				_retval.VarbinaryColumn = varbinaryColumn;
				_retval.ImageColumn = imageColumn;
				_retval.TinyintColumn = tinyintColumn;
				_retval.SmallintColumn = smallintColumn;
				_retval.IntColumn = intColumn;
				_retval.BigintColumn = bigintColumn;
				_retval.DecimalColumn = decimalColumn;
				_retval.NumericColumn = numericColumn;
				_retval.SmallmoneyColumn = smallmoneyColumn;
				_retval.MoneyColumn = moneyColumn;
				_retval.FloatColumn = floatColumn;
				_retval.RealColumn = realColumn;
				_retval.DatetimeColumn = datetimeColumn;
				_retval.Datetime2Column = datetime2Column;
				_retval.SmalldatetimeColumn = smalldatetimeColumn;
				_retval.DateColumn = dateColumn;
				_retval.TimeColumn = timeColumn;
				_retval.UniqueidentifierColumn = uniqueidentifierColumn;
				_retval.Organization_2_Name = organization_2_Name;
				_retval.Organization_2_UniqueIdentifier = organization_2_UniqueIdentifier;
				_retval.Organization_2_UniqueidentifierColumn = organization_2_UniqueidentifierColumn;
            return _retval;
        }

		#endregion CreateDefault(...)


		#region CreateDefaultWithPath(...)

        /// <summary>
        /// Creates a new instance of view DefaultWithPath.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath CreateDefaultWithPath(
System.Int64 t_Id, System.Int64 t_ParentId, System.String t_Name, System.Boolean t_IsSystemBuiltIn, System.Guid t_UniqueIdentifier, System.DateTime t_CreatedDateTime, System.String t_CharColumn, System.String t_VarcharColumn, System.String t_TextColumn, System.String t_NcharColumn, System.String t_NvarcharColumn, System.String t_NtextColumn, System.Boolean t_BitColumn, System.Byte[] t_BinaryColumn, System.Byte[] t_VarbinaryColumn, System.Byte[] t_ImageColumn, System.Byte t_TinyintColumn, System.Int16 t_SmallintColumn, System.Int32 t_IntColumn, System.Int64 t_BigintColumn, System.Decimal t_DecimalColumn, System.Decimal t_NumericColumn, System.Decimal t_SmallmoneyColumn, System.Decimal t_MoneyColumn, System.Single t_FloatColumn, System.Single t_RealColumn, System.DateTime t_DatetimeColumn, System.DateTime t_Datetime2Column, System.DateTime t_SmalldatetimeColumn, System.DateTime t_DateColumn, System.TimeSpan t_TimeColumn, System.Guid t_UniqueidentifierColumn, System.String t_RecursivePath__
			)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath _retval = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath();
				_retval.Id = t_Id;
				_retval.ParentId = t_ParentId;
				_retval.Name = t_Name;
				_retval.IsSystemBuiltIn = t_IsSystemBuiltIn;
				_retval.UniqueIdentifier = t_UniqueIdentifier;
				_retval.CreatedDateTime = t_CreatedDateTime;
				_retval.CharColumn = t_CharColumn;
				_retval.VarcharColumn = t_VarcharColumn;
				_retval.TextColumn = t_TextColumn;
				_retval.NcharColumn = t_NcharColumn;
				_retval.NvarcharColumn = t_NvarcharColumn;
				_retval.NtextColumn = t_NtextColumn;
				_retval.BitColumn = t_BitColumn;
				_retval.BinaryColumn = t_BinaryColumn;
				_retval.VarbinaryColumn = t_VarbinaryColumn;
				_retval.ImageColumn = t_ImageColumn;
				_retval.TinyintColumn = t_TinyintColumn;
				_retval.SmallintColumn = t_SmallintColumn;
				_retval.IntColumn = t_IntColumn;
				_retval.BigintColumn = t_BigintColumn;
				_retval.DecimalColumn = t_DecimalColumn;
				_retval.NumericColumn = t_NumericColumn;
				_retval.SmallmoneyColumn = t_SmallmoneyColumn;
				_retval.MoneyColumn = t_MoneyColumn;
				_retval.FloatColumn = t_FloatColumn;
				_retval.RealColumn = t_RealColumn;
				_retval.DatetimeColumn = t_DatetimeColumn;
				_retval.Datetime2Column = t_Datetime2Column;
				_retval.SmalldatetimeColumn = t_SmalldatetimeColumn;
				_retval.DateColumn = t_DateColumn;
				_retval.TimeColumn = t_TimeColumn;
				_retval.UniqueidentifierColumn = t_UniqueidentifierColumn;
				_retval.RecursivePath__ = t_RecursivePath__;
            return _retval;
        }

		#endregion CreateDefaultWithPath(...)


		#region CreateDefaultGroupedDataView(...)

        /// <summary>
        /// Creates a new instance of view DefaultGroupedDataView.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView CreateDefaultGroupedDataView(
System.Int64 parentId, System.Int64 countPerFK, System.String name
			)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView _retval = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView();
				_retval.ParentId = parentId;
				_retval.CountPerFK = countPerFK;
				_retval.Name = name;
            return _retval;
        }

		#endregion CreateDefaultGroupedDataView(...)


		#region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation CreateKeyInformation(
System.Int64 id, System.String name, System.Boolean isSystemBuiltIn, System.Boolean bitColumn, System.Guid uniqueIdentifier, System.Guid uniqueidentifierColumn
			)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation _retval = new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation();
				_retval.Id = id;
				_retval.Name = name;
				_retval.IsSystemBuiltIn = isSystemBuiltIn;
				_retval.BitColumn = bitColumn;
				_retval.UniqueIdentifier = uniqueIdentifier;
				_retval.UniqueidentifierColumn = uniqueidentifierColumn;
            return _retval;
        }

		#endregion CreateKeyInformation(...)







	

	}

}



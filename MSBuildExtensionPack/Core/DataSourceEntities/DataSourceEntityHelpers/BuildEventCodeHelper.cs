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
    public static class BuildEventCodeHelper
    {
		#region CreateEntity(...)

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildEventCode CreateEntity(
			System.Int32 id
			,System.String eventCode
			,System.String description
			)
        {
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode _retval = new MSBuildExtensionPack.DataSourceEntities.BuildEventCode(
				id
				,eventCode
				,description
				);
            return _retval;
        }

		#endregion CreateEntity(...)

		#region ValidateValueBeforeSaveToDatabase(...)

        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.BuildEventCode item)
        {

        }


        /// <summary>
        /// Validates the value before save to database.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void ValidateValueBeforeSaveToDatabase(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildExtensionPack.DataSourceEntities.BuildEventCode _Item = input[i];
                ValidateValueBeforeSaveToDatabase(_Item);
            }
        }

		#endregion ValidateValueBeforeSaveToDatabase(...)

		#region AssignEnityReferenceIDs(...)

        /// <summary>
        /// Assigns the enity reference Ids.
        /// </summary>
        /// <param name="input">The input.</param>
		public static void AssignEnityReferenceIDs(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
		{
			for(int i = 0; i < input.Count; i ++)
            {
				MSBuildExtensionPack.DataSourceEntities.BuildEventCode _Item = input[i];

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
System.String title, System.String description, System.String identifierInString
			)
        {
            Framework.RssItem _retval = new Framework.RssItem();
				_retval.Title = title;
				_retval.Description = description;
				_retval.IdentifierInString = identifierInString;
            return _retval;
        }

		#endregion CreateRssItem(...)


		#region CreateKeyInformation(...)

        /// <summary>
        /// Creates a new instance of view KeyInformation.
        /// </summary>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation CreateKeyInformation(
System.Int32 id, System.String eventCode
			)
        {
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation _retval = new MSBuildExtensionPack.DataSourceEntities.BuildEventCode.KeyInformation();
				_retval.Id = id;
				_retval.EventCode = eventCode;
            return _retval;
        }

		#endregion CreateKeyInformation(...)







	

	}

}



using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// provides common methods/actions/stubs on an entity. 
    /// </summary>
	public static partial class IOrganizationHelper
	{

		#region Copy<...>(...), Equals<...>(...), Clone<...>(...), ToString<...>(...), 

        /// <summary>
        /// Copies the specified from.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static void Copy<T1, T2>(T1 from, T2 to)
            where T1 : IOrganization
            where T2 : IOrganization
        {
			to.Id = from.Id;
			to.ParentId = from.ParentId;
			to.Name = from.Name;
			to.IsSystemBuiltIn = from.IsSystemBuiltIn;
			to.UniqueIdentifier = from.UniqueIdentifier;
			to.CreatedDateTime = from.CreatedDateTime;
			to.CharColumn = from.CharColumn;
			to.VarcharColumn = from.VarcharColumn;
			to.TextColumn = from.TextColumn;
			to.NcharColumn = from.NcharColumn;
			to.NvarcharColumn = from.NvarcharColumn;
			to.NtextColumn = from.NtextColumn;
			to.BitColumn = from.BitColumn;
			to.BinaryColumn = from.BinaryColumn;
			to.VarbinaryColumn = from.VarbinaryColumn;
			to.ImageColumn = from.ImageColumn;
			to.TinyintColumn = from.TinyintColumn;
			to.SmallintColumn = from.SmallintColumn;
			to.IntColumn = from.IntColumn;
			to.BigintColumn = from.BigintColumn;
			to.DecimalColumn = from.DecimalColumn;
			to.NumericColumn = from.NumericColumn;
			to.SmallmoneyColumn = from.SmallmoneyColumn;
			to.MoneyColumn = from.MoneyColumn;
			to.FloatColumn = from.FloatColumn;
			to.RealColumn = from.RealColumn;
			to.DatetimeColumn = from.DatetimeColumn;
			to.Datetime2Column = from.Datetime2Column;
			to.SmalldatetimeColumn = from.SmalldatetimeColumn;
			to.DateColumn = from.DateColumn;
			to.TimeColumn = from.TimeColumn;
			to.UniqueidentifierColumn = from.UniqueidentifierColumn;
        } 


		#region special copy




		#endregion special copy

        /// <summary>
        /// Equals the specified from.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns>true if with same values, otherwise false</returns>
        public static bool Equals<T1, T2>(T1 from, T2 to)
            where T1 : IOrganization
            where T2 : IOrganization
        {
			bool _retval = true;
			_retval = _retval && to.Id == from.Id;
			_retval = _retval && to.ParentId == from.ParentId;
			_retval = _retval && to.Name == from.Name;
			_retval = _retval && to.IsSystemBuiltIn == from.IsSystemBuiltIn;
			_retval = _retval && to.UniqueIdentifier == from.UniqueIdentifier;
			_retval = _retval && to.CreatedDateTime == from.CreatedDateTime;
			_retval = _retval && to.CharColumn == from.CharColumn;
			_retval = _retval && to.VarcharColumn == from.VarcharColumn;
			_retval = _retval && to.TextColumn == from.TextColumn;
			_retval = _retval && to.NcharColumn == from.NcharColumn;
			_retval = _retval && to.NvarcharColumn == from.NvarcharColumn;
			_retval = _retval && to.NtextColumn == from.NtextColumn;
			_retval = _retval && to.BitColumn == from.BitColumn;
			_retval = _retval && to.BinaryColumn == from.BinaryColumn;
			_retval = _retval && to.VarbinaryColumn == from.VarbinaryColumn;
			_retval = _retval && to.ImageColumn == from.ImageColumn;
			_retval = _retval && to.TinyintColumn == from.TinyintColumn;
			_retval = _retval && to.SmallintColumn == from.SmallintColumn;
			_retval = _retval && to.IntColumn == from.IntColumn;
			_retval = _retval && to.BigintColumn == from.BigintColumn;
			_retval = _retval && to.DecimalColumn == from.DecimalColumn;
			_retval = _retval && to.NumericColumn == from.NumericColumn;
			_retval = _retval && to.SmallmoneyColumn == from.SmallmoneyColumn;
			_retval = _retval && to.MoneyColumn == from.MoneyColumn;
			_retval = _retval && to.FloatColumn == from.FloatColumn;
			_retval = _retval && to.RealColumn == from.RealColumn;
			_retval = _retval && to.DatetimeColumn == from.DatetimeColumn;
			_retval = _retval && to.Datetime2Column == from.Datetime2Column;
			_retval = _retval && to.SmalldatetimeColumn == from.SmalldatetimeColumn;
			_retval = _retval && to.DateColumn == from.DateColumn;
			_retval = _retval && to.TimeColumn == from.TimeColumn;
			_retval = _retval && to.UniqueidentifierColumn == from.UniqueidentifierColumn;
			return _retval;
        }

        /// <summary>
        /// Clones the specified from.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        public static T2 Clone<T1, T2>(T1 from)
            where T1 : IOrganization
            where T2 : IOrganization, new()
        {
            T2 _retval = new T2();
            Copy<T1, T2>(from, _retval);
            return _retval;
        }


		static string m_Format = "Id:{0};ParentId:{1};Name:{2};IsSystemBuiltIn:{3};UniqueIdentifier:{4};CreatedDateTime:{5};CharColumn:{6};VarcharColumn:{7};TextColumn:{8};NcharColumn:{9};NvarcharColumn:{10};NtextColumn:{11};BitColumn:{12};BinaryColumn:{13};VarbinaryColumn:{14};ImageColumn:{15};TinyintColumn:{16};SmallintColumn:{17};IntColumn:{18};BigintColumn:{19};DecimalColumn:{20};NumericColumn:{21};SmallmoneyColumn:{22};MoneyColumn:{23};FloatColumn:{24};RealColumn:{25};DatetimeColumn:{26};Datetime2Column:{27};SmalldatetimeColumn:{28};DateColumn:{29};TimeColumn:{30};UniqueidentifierColumn:{31};";
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <typeparam name="T">type inheritfrom <see cref="IAspNet_SqlCacheTablesForChangeNotification"/></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public static string ToString<T>(T input)
            where T : IOrganization
        {
            return string.Format(m_Format
				, input.Id
				, input.ParentId
				, input.Name
				, input.IsSystemBuiltIn
				, input.UniqueIdentifier
				, input.CreatedDateTime
				, input.CharColumn
				, input.VarcharColumn
				, input.TextColumn
				, input.NcharColumn
				, input.NvarcharColumn
				, input.NtextColumn
				, input.BitColumn
				, input.BinaryColumn
				, input.VarbinaryColumn
				, input.ImageColumn
				, input.TinyintColumn
				, input.SmallintColumn
				, input.IntColumn
				, input.BigintColumn
				, input.DecimalColumn
				, input.NumericColumn
				, input.SmallmoneyColumn
				, input.MoneyColumn
				, input.FloatColumn
				, input.RealColumn
				, input.DatetimeColumn
				, input.Datetime2Column
				, input.SmalldatetimeColumn
				, input.DateColumn
				, input.TimeColumn
				, input.UniqueidentifierColumn
				);
        }

		#endregion Copy<...>(...), Equals<...>(...), Clone<...>(...), ToString<...>(...), 

		#region CopyCollection<...>(...), CloneCollection<...>(...)

        /// <summary>
        /// Copies the collection.
        /// </summary>
        /// <typeparam name="T1Collection">The type of the 1 collection.</typeparam>
        /// <typeparam name="T2Collection">The type of the 2 collection.</typeparam>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static void CopyCollection<T1Collection, T2Collection, T1, T2>(T1Collection from, T2Collection to)
            where T1Collection : IEnumerable<T1>
            where T2Collection : IList<T2>
            where T1 : IOrganization
            where T2 : IOrganization, new()
        {
            foreach (T1 _Item in from)
            {
                T2 _Cloned = Clone<T1, T2>(_Item);
                to.Add(_Cloned);
            }
        }

        /// <summary>
        /// Clones the collection.
        /// </summary>
        /// <typeparam name="T1Collection">The type of the 1 collection.</typeparam>
        /// <typeparam name="T2Collection">The type of the 2 collection.</typeparam>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <returns>a new instance of target collection type T2Collection</returns>
        public static T2Collection CloneCollection<T1Collection, T2Collection, T1, T2>(T1Collection from)
            where T1Collection : IEnumerable<T1>
            where T2Collection : IList<T2>, new()
            where T1 : IOrganization
            where T2 : IOrganization, new()
        {
            T2Collection _retval = new T2Collection();
            CopyCollection<T1Collection, T2Collection, T1, T2>(from, _retval);
            return _retval;
        } 

		#endregion CopyCollection<...>(...), CloneCollection<...>(...)

        #region GetDefaultValue<T>()

        /// <summary>
        /// Gets the default value.
        /// </summary>
        /// <typeparam name="T">type name inherit from <see cref="IOrganization"/></typeparam>
        /// <returns>a new instance with default value</returns>
        public static T GetDefaultValue<T>()
            where T : IOrganization, new()
        {
            T _retval = new T();




            _retval.ParentId = 1;


            return _retval;
        }

        #endregion GetDefaultValue<T>()

        #region NameValuePair related method



        /// <summary>
        /// Builds the name of name value pair.
        /// </summary>
        /// <typeparam name="T">type name inherit from <see cref="IOrganization"/></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>name of Name value pair</returns>
        public static string BuildNameOfNameValuePair<T>(T input)
            where T : IOrganization, new()
        {
            return string.Format("{0}", input.Name);
        }


        /// <summary>
        /// Builds the name value pair.
        /// </summary>
        /// <typeparam name="T">type name inherit from <see cref="IOrganization"/></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>a new instance of <see cref="Framework.NameValuePair"/></returns>
        public static Framework.NameValuePair BuildNameValuePair<T>(T input)
            where T : IOrganization, IOrganizationIdentifier, new()
        {
            Framework.NameValuePair _retval = new Framework.NameValuePair(input.Id, BuildNameOfNameValuePair<T>(input));
            return _retval;
        }



        #endregion NameValuePair related method

		#region Binary In File System,  BuildPhysicalFileFullPathOfProperty...<T>(T input)


		#endregion Binary In File System,  BuildPhysicalFileFullPathOfProperty...<T>(T input)

	}
}


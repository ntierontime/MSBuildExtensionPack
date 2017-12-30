using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text;
using LinqKit;
//using MathNet.Numerics.LinqExtensions;
using System.Data.SqlClient;
using System.Data;

namespace MSBuildExtensionPack.EntityFrameworkDAL
{
    /// <summary>
    /// Linq data access layer of entity <see cref="MSBuildExtensionPack.DataSourceEntities.Organization"/>, with following methods:
    /// 1. Insert, Update and Delete
    /// 2. Batch Insert, Update and Delete
    /// 3. Queries
    /// </summary>
    public class OrganizationRepository
        : MSBuildExtensionPack.DALContracts.IOrganizationRepository//<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier>
    {
        #region for log4net

        /// <summary>
        /// for log4net
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion for log4net

        #region LinqContext

        /// <summary>
        /// DataContext for EF Linq
        /// </summary>
        public MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities LinqContext { get; set; }

        #endregion LinqContext

        #region constructors

        /// <summary>
        /// default constructor, developer should assign LinqConext after.
        /// </summary>
        public OrganizationRepository()
        {
        }

        /// <summary>
        /// constructor with Linq DataContext parameter
        /// </summary>
        /// <param name="linqContext">see<see cref="MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities"/></param>
        public OrganizationRepository(MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities linqContext)
        {
            this.LinqContext = linqContext;
        }

        #endregion constructors

        #region IDataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection,MSBuildExtensionPack.DataSourceEntities.Organization,MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier> Members

        /// <summary>
        /// single item insert with entity input
        /// </summary>
        /// <param name="input">to-be-inserted instance of entity class</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization Insert(MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Organization _LinqItem = MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.EntityFrameworkContext.Organization>(input);
                this.LinqContext.Organizations.Add(_LinqItem);
                this.LinqContext.SaveChanges();
                MSBuildExtensionPack.DataSourceEntities.Organization _Result = new MSBuildExtensionPack.DataSourceEntities.Organization();
                MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.Organization, MSBuildExtensionPack.DataSourceEntities.Organization>(_LinqItem, _Result);
                _retval.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                _retval.Result.Add(_Result);
            }

            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item update with entity input
        /// </summary>
        /// <param name="input">to-be-updated instance of entity class</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization Update(MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Organization _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.EntityFrameworkContext.Organization>(input, _LinqItem);
                    this.LinqContext.SaveChanges();
                    MSBuildExtensionPack.DataSourceEntities.Organization _Result = new MSBuildExtensionPack.DataSourceEntities.Organization();
                    MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.Organization, MSBuildExtensionPack.DataSourceEntities.Organization>(_LinqItem, _Result);
                    _retval.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retval.Result.Add(_Result);
                }
            }
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item deletion with entity input
        /// </summary>
        /// <param name="input">item to be deleted</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization Delete(MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Organization _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    this.LinqContext.Organizations.Remove(_LinqItem);
                    this.LinqContext.SaveChanges();
                }
            }
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item delete by identifier with entity identifier input
        /// </summary>
        /// <param name="id">delete the item if its identifier equals to this parameter</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization DeleteByIdentifier(MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier id)
        {
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();

            if (id != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Organization _LinqItem = GetLinqObjectByIdentifier(id);
                if (_LinqItem != null)
                {
                    MSBuildExtensionPack.DataSourceEntities.Organization _Original = new MSBuildExtensionPack.DataSourceEntities.Organization();
                    MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.Organization, MSBuildExtensionPack.DataSourceEntities.Organization>(_LinqItem, _Original);

                    _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retval.OriginalValue.Add(_Original);

                    this.LinqContext.Organizations.Remove(_LinqItem);
                    this.LinqContext.SaveChanges();
                }
            }
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches insert with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization BatchInsert(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            _retval.OriginalValue = input;

            if (input != null && input.Count > 0)
            {
                try
                {
                    DataTable _DataTable = new DataTable();
                _DataTable.Columns.Add("Id", typeof(System.Int64));
                _DataTable.Columns.Add("ParentId", typeof(System.Int64));
                _DataTable.Columns.Add("Name", typeof(System.String));
                _DataTable.Columns.Add("IsSystemBuiltIn", typeof(System.Boolean));
                _DataTable.Columns.Add("UniqueIdentifier", typeof(System.Guid));
                _DataTable.Columns.Add("CreatedDateTime", typeof(System.DateTime));
                _DataTable.Columns.Add("CharColumn", typeof(System.String));
                _DataTable.Columns.Add("VarcharColumn", typeof(System.String));
                _DataTable.Columns.Add("TextColumn", typeof(System.String));
                _DataTable.Columns.Add("NcharColumn", typeof(System.String));
                _DataTable.Columns.Add("NvarcharColumn", typeof(System.String));
                _DataTable.Columns.Add("NtextColumn", typeof(System.String));
                _DataTable.Columns.Add("BitColumn", typeof(System.Boolean));
                _DataTable.Columns.Add("BinaryColumn", typeof(System.Byte[]));
                _DataTable.Columns.Add("VarbinaryColumn", typeof(System.Byte[]));
                _DataTable.Columns.Add("ImageColumn", typeof(System.Byte[]));
                _DataTable.Columns.Add("TinyintColumn", typeof(System.Byte));
                _DataTable.Columns.Add("SmallintColumn", typeof(System.Int16));
                _DataTable.Columns.Add("IntColumn", typeof(System.Int32));
                _DataTable.Columns.Add("BigintColumn", typeof(System.Int64));
                _DataTable.Columns.Add("DecimalColumn", typeof(System.Decimal));
                _DataTable.Columns.Add("NumericColumn", typeof(System.Decimal));
                _DataTable.Columns.Add("SmallmoneyColumn", typeof(System.Decimal));
                _DataTable.Columns.Add("MoneyColumn", typeof(System.Decimal));
                _DataTable.Columns.Add("FloatColumn", typeof(System.Single));
                _DataTable.Columns.Add("RealColumn", typeof(System.Single));
                _DataTable.Columns.Add("DatetimeColumn", typeof(System.DateTime));
                _DataTable.Columns.Add("Datetime2Column", typeof(System.DateTime));
                _DataTable.Columns.Add("SmalldatetimeColumn", typeof(System.DateTime));
                _DataTable.Columns.Add("DateColumn", typeof(System.DateTime));
                _DataTable.Columns.Add("TimeColumn", typeof(System.TimeSpan));
                _DataTable.Columns.Add("UniqueidentifierColumn", typeof(System.Guid));

                    foreach (MSBuildExtensionPack.DataSourceEntities.Organization _Item in input)
                    {
                        _DataTable.Rows.Add(new object[] { _Item.Id, _Item.ParentId, _Item.Name, _Item.IsSystemBuiltIn, _Item.UniqueIdentifier, _Item.CreatedDateTime, _Item.CharColumn, _Item.VarcharColumn, _Item.TextColumn, _Item.NcharColumn, _Item.NvarcharColumn, _Item.NtextColumn, _Item.BitColumn, _Item.BinaryColumn, _Item.VarbinaryColumn, _Item.ImageColumn, _Item.TinyintColumn, _Item.SmallintColumn, _Item.IntColumn, _Item.BigintColumn, _Item.DecimalColumn, _Item.NumericColumn, _Item.SmallmoneyColumn, _Item.MoneyColumn, _Item.FloatColumn, _Item.RealColumn, _Item.DatetimeColumn, _Item.Datetime2Column, _Item.SmalldatetimeColumn, _Item.DateColumn, _Item.TimeColumn, _Item.UniqueidentifierColumn });
                    }

                    using (SqlBulkCopy s = new SqlBulkCopy(this.LinqContext.Database.Connection.ConnectionString))
                    {
                        s.DestinationTableName = "dbo.Organization";

                    s.ColumnMappings.Add("Id", "Id");
                    s.ColumnMappings.Add("ParentId", "ParentId");
                    s.ColumnMappings.Add("Name", "Name");
                    s.ColumnMappings.Add("IsSystemBuiltIn", "IsSystemBuiltIn");
                    s.ColumnMappings.Add("UniqueIdentifier", "UniqueIdentifier");
                    s.ColumnMappings.Add("CreatedDateTime", "CreatedDateTime");
                    s.ColumnMappings.Add("CharColumn", "CharColumn");
                    s.ColumnMappings.Add("VarcharColumn", "VarcharColumn");
                    s.ColumnMappings.Add("TextColumn", "TextColumn");
                    s.ColumnMappings.Add("NcharColumn", "NcharColumn");
                    s.ColumnMappings.Add("NvarcharColumn", "NvarcharColumn");
                    s.ColumnMappings.Add("NtextColumn", "NtextColumn");
                    s.ColumnMappings.Add("BitColumn", "BitColumn");
                    s.ColumnMappings.Add("BinaryColumn", "BinaryColumn");
                    s.ColumnMappings.Add("VarbinaryColumn", "VarbinaryColumn");
                    s.ColumnMappings.Add("ImageColumn", "ImageColumn");
                    s.ColumnMappings.Add("TinyintColumn", "TinyintColumn");
                    s.ColumnMappings.Add("SmallintColumn", "SmallintColumn");
                    s.ColumnMappings.Add("IntColumn", "IntColumn");
                    s.ColumnMappings.Add("BigintColumn", "BigintColumn");
                    s.ColumnMappings.Add("DecimalColumn", "DecimalColumn");
                    s.ColumnMappings.Add("NumericColumn", "NumericColumn");
                    s.ColumnMappings.Add("SmallmoneyColumn", "SmallmoneyColumn");
                    s.ColumnMappings.Add("MoneyColumn", "MoneyColumn");
                    s.ColumnMappings.Add("FloatColumn", "FloatColumn");
                    s.ColumnMappings.Add("RealColumn", "RealColumn");
                    s.ColumnMappings.Add("DatetimeColumn", "DatetimeColumn");
                    s.ColumnMappings.Add("Datetime2Column", "Datetime2Column");
                    s.ColumnMappings.Add("SmalldatetimeColumn", "SmalldatetimeColumn");
                    s.ColumnMappings.Add("DateColumn", "DateColumn");
                    s.ColumnMappings.Add("TimeColumn", "TimeColumn");
                    s.ColumnMappings.Add("UniqueidentifierColumn", "UniqueidentifierColumn");

                        s.NotifyAfter = 10000;
                        s.WriteToServer(_DataTable);
                        s.Close();
                    }
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()), ex);
                }
            }
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches the delete with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization BatchDelete(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildExtensionPack.EntityFrameworkContext.Organization> _ListOfLinq = new List<MSBuildExtensionPack.EntityFrameworkContext.Organization>();
                foreach (MSBuildExtensionPack.DataSourceEntities.Organization _ItemOfInput in input)
                {
                    MSBuildExtensionPack.EntityFrameworkContext.Organization _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    this.LinqContext.Organizations.Remove(_LinqItem);
                }
                this.LinqContext.SaveChanges();
            }
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches the update with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization BatchUpdate(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildExtensionPack.EntityFrameworkContext.Organization> _ListOfLinq = new List<MSBuildExtensionPack.EntityFrameworkContext.Organization>();
                foreach (MSBuildExtensionPack.DataSourceEntities.Organization _ItemOfInput in input)
                {
                    MSBuildExtensionPack.EntityFrameworkContext.Organization _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.EntityFrameworkContext.Organization>(_ItemOfInput, _LinqItem);
                    _ListOfLinq.Add(_LinqItem);
                }
                this.LinqContext.SaveChanges();

                for (int i = 0; i < input.Count; i++)
                {
                    MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy
                        <
                            MSBuildExtensionPack.EntityFrameworkContext.Organization, MSBuildExtensionPack.DataSourceEntities.Organization
                        >(_ListOfLinq[i], input[i]);
                }
            }
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets an entity instance by input identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier"/> class, with same identifier.</returns>
        public MSBuildExtensionPack.DataSourceEntities.Organization GetByIdentifier(MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier id)
        {
            MSBuildExtensionPack.EntityFrameworkContext.Organization _Only = GetLinqObjectByIdentifier(id);
            if (_Only != null)
            {
                return new MSBuildExtensionPack.DataSourceEntities.Organization(_Only);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the linq object by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>an instance of <see cref="MSBuildExtensionPack.EntityFrameworkContext.Organization"/> class, with same identifier, which is a IQueryable.</returns>
        private MSBuildExtensionPack.EntityFrameworkContext.Organization GetLinqObjectByIdentifier(MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier id)
        {
            Func<MSBuildExtensionPack.EntityFrameworkContext.Organization, bool> m_Predicate = (MSBuildExtensionPack.EntityFrameworkContext.Organization t) =>
            {
                return MSBuildExtensionPack.EntityContracts.IOrganizationIdentifierHelper.Equals<MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, MSBuildExtensionPack.EntityFrameworkContext.Organization>(id, t);
            };

            return this.LinqContext.Organizations.SingleOrDefault<MSBuildExtensionPack.EntityFrameworkContext.Organization>(m_Predicate);
        }

        #endregion

        #region Binary Columns

        #endregion Binary Columns

        #region Query Methods Of Entity of Common

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon.IsToCompare && t.IsSystemBuiltIn == criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.CreatedDateTime > criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.CreatedDateTime <= criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfBitColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfBitColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.BitColumn == criteriaOfBitColumnOftOfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.DatetimeColumn > criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.DatetimeColumn <= criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.Datetime2Column > criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.Datetime2Column <= criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.SmalldatetimeColumn > criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.SmalldatetimeColumn <= criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.DateColumn > criteriaOfDateColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.DateColumn <= criteriaOfDateColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            )
                        &&
                            (
                            (criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfCharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfCharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.CharColumn.Contains(criteriaOfCharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.VarcharColumn.Contains(criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfTextColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfTextColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.TextColumn.Contains(criteriaOfTextColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfNcharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNcharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.NcharColumn.Contains(criteriaOfNcharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.NvarcharColumn.Contains(criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfNtextColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNtextColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.NtextColumn.Contains(criteriaOfNtextColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon.IsToCompare && t.IsSystemBuiltIn == criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.CreatedDateTime > criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.CreatedDateTime <= criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfBitColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfBitColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.BitColumn == criteriaOfBitColumnOftOfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.DatetimeColumn > criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.DatetimeColumn <= criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.Datetime2Column > criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.Datetime2Column <= criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.SmalldatetimeColumn > criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.SmalldatetimeColumn <= criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            &&
                            (criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.DateColumn > criteriaOfDateColumnOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfDateColumnOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.DateColumn <= criteriaOfDateColumnOftOfCommonOfCommonOfCommon.UpperBound))
                            )
                        &&
                            (
                            (criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfCharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfCharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.CharColumn.Contains(criteriaOfCharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.VarcharColumn.Contains(criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfTextColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfTextColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.TextColumn.Contains(criteriaOfTextColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfNcharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNcharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.NcharColumn.Contains(criteriaOfNcharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.NvarcharColumn.Contains(criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            &&
                            (criteriaOfNtextColumnOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNtextColumnOftOfCommonOfCommonOfCommon.IsToCompare && t.NtextColumn.Contains(criteriaOfNtextColumnOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfCommon(
                criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                ,criteriaOfIsSystemBuiltInOftOfCommonOfCommonOfCommon
                ,criteriaOfCreatedDateTimeOftOfCommonOfCommonOfCommon
                ,criteriaOfBitColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDatetime2ColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfSmalldatetimeColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfDateColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNameOftOfCommonOfCommonOfCommon
                ,criteriaOfCharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfVarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfTextColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNvarcharColumnOftOfCommonOfCommonOfCommon
                ,criteriaOfNtextColumnOftOfCommonOfCommonOfCommon
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Name } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<Framework.NameValuePair> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfNameValuePairOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfAll(
                queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfAll(
                queryOrderBySettingCollection
            );

                    Framework.NameValuePair _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfAll(
                queryOrderBySettingCollection
            );

                    IEnumerable<Framework.NameValuePair> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new Framework.NameValueCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> _GetQueryOfRssItemOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Name, Description = t.Name, PubDate = t.CreatedDateTime } into vD1
                    select vD1
                );
            var _retval = _ResultFromDataSource;
            IQueryable<Framework.RssItem> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfRssItemOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfAll(
                queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = _ExistsOfRssItemOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfAll(
                queryOrderBySettingCollection
            );

                    Framework.RssItem _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfAll(
                queryOrderBySettingCollection
            );

                    IEnumerable<Framework.RssItem> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new Framework.RssItemCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Name } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<Framework.NameValuePair> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    Framework.NameValuePair _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    IEnumerable<Framework.NameValuePair> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new Framework.NameValueCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> _GetQueryOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Name, Description = t.Name, PubDate = t.CreatedDateTime } into vD1
                    select vD1
                );
            var _retval = _ResultFromDataSource;
            IQueryable<Framework.RssItem> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    Framework.RssItem _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    IEnumerable<Framework.RssItem> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new Framework.RssItemCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    group t by new { ParentId = t.ParentId, Name = string.Concat(new string[] { Organization_2.Name }) } into tG
                    let _CountPerFK = tG.Count()
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView { ParentId = tG.Key.ParentId, CountPerFK = _CountPerFK, Name = tG.Key.Name } into vD4
                    select vD4
                );
            var _retval = _ResultFromDataSource;
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _GetQueryOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation { Id = t.Id, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, BitColumn = t.BitColumn, UniqueIdentifier = t.UniqueIdentifier, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD5
                    select vD5
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.IsToCompare == false || criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.IsToCompare && t.UniqueIdentifier == criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.IsToCompare == false || criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.IsToCompare && t.UniqueIdentifier == criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.ValueToCompare)
                            )
                        )
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Name } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<Framework.NameValuePair> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );

                    Framework.NameValuePair _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );

                    IEnumerable<Framework.NameValuePair> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new Framework.NameValueCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.IsToCompare == false || criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.IsToCompare && t.UniqueIdentifier == criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                criteriaOfUniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifierOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.IsToCompare == false || criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.IsToCompare == false || criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.ValueToCompare)
                            )
                        )
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Name } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<Framework.NameValuePair> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );

                    Framework.NameValuePair _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );

                    IEnumerable<Framework.NameValuePair> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new Framework.NameValueCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.IsToCompare == false || criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                criteriaOfUniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumnOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.Id == criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            &&
                            (criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.UniqueIdentifier == criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            &&
                            (criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.Id == criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            &&
                            (criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.UniqueIdentifier == criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            &&
                            (criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.Id == criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            &&
                            (criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.UniqueIdentifier == criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            &&
                            (criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare == false || criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.IsToCompare && t.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation { Id = t.Id, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, BitColumn = t.BitColumn, UniqueIdentifier = t.UniqueIdentifier, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD5
                    select vD5
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
                criteriaOfIdOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueIdentifierOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,criteriaOfUniqueidentifierColumnOftOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraintOfIdentifierAndUniqueConstraint
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        #region Query Methods Of Entity of UniqueConstraintsWithCommon

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && Organization_2.UniqueIdentifier == criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && Organization_2.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.IsSystemBuiltIn == criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.CreatedDateTime > criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.CreatedDateTime <= criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.BitColumn == criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.DatetimeColumn > criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.DatetimeColumn <= criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.Datetime2Column > criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.Datetime2Column <= criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.SmalldatetimeColumn > criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.SmalldatetimeColumn <= criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.DateColumn > criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.DateColumn <= criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            )
                        &&
                            (
                            (criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.CharColumn.Contains(criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.VarcharColumn.Contains(criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.TextColumn.Contains(criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.NcharColumn.Contains(criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.NvarcharColumn.Contains(criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.NtextColumn.Contains(criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization GetSingleOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of UniqueConstraintsWithCommon

        #region Query Methods Of Default of UniqueConstraintsWithCommon

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && Organization_2.UniqueIdentifier == criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && Organization_2.UniqueidentifierColumn == criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.IsSystemBuiltIn == criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.CreatedDateTime > criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.CreatedDateTime <= criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.BitColumn == criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToCompare)
                            &&
                            (criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.DatetimeColumn > criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.DatetimeColumn <= criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.Datetime2Column > criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.Datetime2Column <= criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.SmalldatetimeColumn > criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.SmalldatetimeColumn <= criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            &&
                            (criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && (criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound == false || criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareLowerBound && t.DateColumn > criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.LowerBound) && (criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound == false || criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompareUpperBound && t.DateColumn <= criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.UpperBound))
                            )
                        &&
                            (
                            (criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.CharColumn.Contains(criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.VarcharColumn.Contains(criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.TextColumn.Contains(criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.NcharColumn.Contains(criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.NvarcharColumn.Contains(criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            &&
                            (criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare == false || criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.IsToCompare && t.NtextColumn.Contains(criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common.
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,queryOrderBySettingCollection
            );
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
            return _Count;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Organization.Default _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

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
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfUniqueConstraintsWithCommon(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemBooleanEqualsCriteria criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultOfUniqueConstraintsWithCommon(
                criteriaOfUniqueIdentifierOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfUniqueidentifierColumnOfOrganization_2OfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfIsSystemBuiltInOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCreatedDateTimeOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfBitColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDatetime2ColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfSmalldatetimeColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfDateColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNameOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfCharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfVarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfTextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNvarcharColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,criteriaOfNtextColumnOftOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommonOfUniqueConstraintsWithCommon
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _retval;

                    if (currentIndex == -1 || pageSize == -1)
                    {
                        _retval = _Query;
                    }
                    else
                    {
                        _retval = _Query.Skip(currentIndex).Take(pageSize);
                    }
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult();
                    _retMessage.QueryPagingResult.PageSize = pageSize;
                    _retMessage.QueryPagingResult.RecordCountOfCurrentPage = _retval.Count();
                    _retMessage.QueryPagingResult.CurrentIndexOfStartRecord = currentIndex;
                    _retMessage.QueryPagingResult.CountOfRecords = _Query.Count();
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection();
                    _retMessage.Result.AddRange(_retval);
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfUniqueConstraintsWithCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of UniqueConstraintsWithCommon

        #region GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

        /// <summary>
        /// Get ascendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a collection of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection"/></returns>
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier id)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection _retval;
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath> _Query =
                (
                    from t in this.LinqContext.GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(id.Id)
                    select MSBuildExtensionPack.DataSourceEntities.OrganizationHelper.CreateDefaultWithPath(
                        (System.Int64)t.Id, (System.Int64)t.ParentId, (System.String)t.Name, (System.Boolean)t.IsSystemBuiltIn, (System.Guid)t.UniqueIdentifier, (System.DateTime)t.CreatedDateTime, (System.String)t.CharColumn, (System.String)t.VarcharColumn, (System.String)t.TextColumn, (System.String)t.NcharColumn, (System.String)t.NvarcharColumn, (System.String)t.NtextColumn, (System.Boolean)t.BitColumn, (System.Byte[])t.BinaryColumn, (System.Byte[])t.VarbinaryColumn, (System.Byte[])t.ImageColumn, (System.Byte)t.TinyintColumn, (System.Int16)t.SmallintColumn, (System.Int32)t.IntColumn, (System.Int64)t.BigintColumn, (System.Decimal)t.DecimalColumn, (System.Decimal)t.NumericColumn, (System.Decimal)t.SmallmoneyColumn, (System.Decimal)t.MoneyColumn, (System.Single)t.FloatColumn, (System.Single)t.RealColumn, (System.DateTime)t.DatetimeColumn, (System.DateTime)t.Datetime2Column, (System.DateTime)t.SmalldatetimeColumn, (System.DateTime)t.DateColumn, (System.TimeSpan)t.TimeColumn, (System.Guid)t.UniqueidentifierColumn, (System.String)t.RecursivePath__) into x
                    select x
                );
            _retval = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection();
            _retval.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection();
            _retval.Result.AddRange(_Query);
            return _retval;
        }

        /// <summary>
        /// Get descendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a collection of <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection"/></returns>
        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection GetDescendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier id)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection _retval;
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath> _Query =
                (
                    from t in this.LinqContext.GetDescendantOfParentIdOfMSBuildExtensionPack_Organization(id.Id)
                    select MSBuildExtensionPack.DataSourceEntities.OrganizationHelper.CreateDefaultWithPath(
                        (System.Int64)t.Id, (System.Int64)t.ParentId, (System.String)t.Name, (System.Boolean)t.IsSystemBuiltIn, (System.Guid)t.UniqueIdentifier, (System.DateTime)t.CreatedDateTime, (System.String)t.CharColumn, (System.String)t.VarcharColumn, (System.String)t.TextColumn, (System.String)t.NcharColumn, (System.String)t.NvarcharColumn, (System.String)t.NtextColumn, (System.Boolean)t.BitColumn, (System.Byte[])t.BinaryColumn, (System.Byte[])t.VarbinaryColumn, (System.Byte[])t.ImageColumn, (System.Byte)t.TinyintColumn, (System.Int16)t.SmallintColumn, (System.Int32)t.IntColumn, (System.Int64)t.BigintColumn, (System.Decimal)t.DecimalColumn, (System.Decimal)t.NumericColumn, (System.Decimal)t.SmallmoneyColumn, (System.Decimal)t.MoneyColumn, (System.Single)t.FloatColumn, (System.Single)t.RealColumn, (System.DateTime)t.DatetimeColumn, (System.DateTime)t.Datetime2Column, (System.DateTime)t.SmalldatetimeColumn, (System.DateTime)t.DateColumn, (System.TimeSpan)t.TimeColumn, (System.Guid)t.UniqueidentifierColumn, (System.String)t.RecursivePath__) into x
                    select x
                );
            _retval = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection();
            _retval.Result = new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection();
            _retval.Result.AddRange(_Query);
            return _retval;
        }

        #endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

    }
}


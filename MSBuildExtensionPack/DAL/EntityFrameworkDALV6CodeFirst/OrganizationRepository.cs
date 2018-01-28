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
    /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
    /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
    /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
    /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
    /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
    /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
    /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
    /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
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

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfCommon(
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
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
                            &&
                            (isSystemBuiltIn.IsToCompare == false || isSystemBuiltIn.IsToCompare && t.IsSystemBuiltIn == isSystemBuiltIn.ValueToCompare)
                            &&
                            (createdDateTimeRange.IsToCompare == false || createdDateTimeRange.IsToCompare && (createdDateTimeRange.IsToCompareLowerBound == false || createdDateTimeRange.IsToCompareLowerBound && t.CreatedDateTime > createdDateTimeRange.LowerBound) && (createdDateTimeRange.IsToCompareUpperBound == false || createdDateTimeRange.IsToCompareUpperBound && t.CreatedDateTime <= createdDateTimeRange.UpperBound))
                            &&
                            (bitColumn.IsToCompare == false || bitColumn.IsToCompare && t.BitColumn == bitColumn.ValueToCompare)
                            &&
                            (datetimeColumnRange.IsToCompare == false || datetimeColumnRange.IsToCompare && (datetimeColumnRange.IsToCompareLowerBound == false || datetimeColumnRange.IsToCompareLowerBound && t.DatetimeColumn > datetimeColumnRange.LowerBound) && (datetimeColumnRange.IsToCompareUpperBound == false || datetimeColumnRange.IsToCompareUpperBound && t.DatetimeColumn <= datetimeColumnRange.UpperBound))
                            &&
                            (datetime2ColumnRange.IsToCompare == false || datetime2ColumnRange.IsToCompare && (datetime2ColumnRange.IsToCompareLowerBound == false || datetime2ColumnRange.IsToCompareLowerBound && t.Datetime2Column > datetime2ColumnRange.LowerBound) && (datetime2ColumnRange.IsToCompareUpperBound == false || datetime2ColumnRange.IsToCompareUpperBound && t.Datetime2Column <= datetime2ColumnRange.UpperBound))
                            &&
                            (smalldatetimeColumnRange.IsToCompare == false || smalldatetimeColumnRange.IsToCompare && (smalldatetimeColumnRange.IsToCompareLowerBound == false || smalldatetimeColumnRange.IsToCompareLowerBound && t.SmalldatetimeColumn > smalldatetimeColumnRange.LowerBound) && (smalldatetimeColumnRange.IsToCompareUpperBound == false || smalldatetimeColumnRange.IsToCompareUpperBound && t.SmalldatetimeColumn <= smalldatetimeColumnRange.UpperBound))
                            &&
                            (dateColumnRange.IsToCompare == false || dateColumnRange.IsToCompare && (dateColumnRange.IsToCompareLowerBound == false || dateColumnRange.IsToCompareLowerBound && t.DateColumn > dateColumnRange.LowerBound) && (dateColumnRange.IsToCompareUpperBound == false || dateColumnRange.IsToCompareUpperBound && t.DateColumn <= dateColumnRange.UpperBound))
                            )
                        &&
                            (
                            (name.IsToCompare == false || name.IsToCompare && t.Name.Contains(name.ValueToBeContained))
                            &&
                            (charColumn.IsToCompare == false || charColumn.IsToCompare && t.CharColumn.Contains(charColumn.ValueToBeContained))
                            &&
                            (varcharColumn.IsToCompare == false || varcharColumn.IsToCompare && t.VarcharColumn.Contains(varcharColumn.ValueToBeContained))
                            &&
                            (textColumn.IsToCompare == false || textColumn.IsToCompare && t.TextColumn.Contains(textColumn.ValueToBeContained))
                            &&
                            (ncharColumn.IsToCompare == false || ncharColumn.IsToCompare && t.NcharColumn.Contains(ncharColumn.ValueToBeContained))
                            &&
                            (nvarcharColumn.IsToCompare == false || nvarcharColumn.IsToCompare && t.NvarcharColumn.Contains(nvarcharColumn.ValueToBeContained))
                            &&
                            (ntextColumn.IsToCompare == false || ntextColumn.IsToCompare && t.NtextColumn.Contains(ntextColumn.ValueToBeContained))
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

        private bool ___ExistsOfEntityOfCommon(
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
            )
        {
            int _Count = ___GetCountOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfCommon(
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
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> ___GetQueryOfDefaultOfCommon(
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
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
                            &&
                            (isSystemBuiltIn.IsToCompare == false || isSystemBuiltIn.IsToCompare && t.IsSystemBuiltIn == isSystemBuiltIn.ValueToCompare)
                            &&
                            (createdDateTimeRange.IsToCompare == false || createdDateTimeRange.IsToCompare && (createdDateTimeRange.IsToCompareLowerBound == false || createdDateTimeRange.IsToCompareLowerBound && t.CreatedDateTime > createdDateTimeRange.LowerBound) && (createdDateTimeRange.IsToCompareUpperBound == false || createdDateTimeRange.IsToCompareUpperBound && t.CreatedDateTime <= createdDateTimeRange.UpperBound))
                            &&
                            (bitColumn.IsToCompare == false || bitColumn.IsToCompare && t.BitColumn == bitColumn.ValueToCompare)
                            &&
                            (datetimeColumnRange.IsToCompare == false || datetimeColumnRange.IsToCompare && (datetimeColumnRange.IsToCompareLowerBound == false || datetimeColumnRange.IsToCompareLowerBound && t.DatetimeColumn > datetimeColumnRange.LowerBound) && (datetimeColumnRange.IsToCompareUpperBound == false || datetimeColumnRange.IsToCompareUpperBound && t.DatetimeColumn <= datetimeColumnRange.UpperBound))
                            &&
                            (datetime2ColumnRange.IsToCompare == false || datetime2ColumnRange.IsToCompare && (datetime2ColumnRange.IsToCompareLowerBound == false || datetime2ColumnRange.IsToCompareLowerBound && t.Datetime2Column > datetime2ColumnRange.LowerBound) && (datetime2ColumnRange.IsToCompareUpperBound == false || datetime2ColumnRange.IsToCompareUpperBound && t.Datetime2Column <= datetime2ColumnRange.UpperBound))
                            &&
                            (smalldatetimeColumnRange.IsToCompare == false || smalldatetimeColumnRange.IsToCompare && (smalldatetimeColumnRange.IsToCompareLowerBound == false || smalldatetimeColumnRange.IsToCompareLowerBound && t.SmalldatetimeColumn > smalldatetimeColumnRange.LowerBound) && (smalldatetimeColumnRange.IsToCompareUpperBound == false || smalldatetimeColumnRange.IsToCompareUpperBound && t.SmalldatetimeColumn <= smalldatetimeColumnRange.UpperBound))
                            &&
                            (dateColumnRange.IsToCompare == false || dateColumnRange.IsToCompare && (dateColumnRange.IsToCompareLowerBound == false || dateColumnRange.IsToCompareLowerBound && t.DateColumn > dateColumnRange.LowerBound) && (dateColumnRange.IsToCompareUpperBound == false || dateColumnRange.IsToCompareUpperBound && t.DateColumn <= dateColumnRange.UpperBound))
                            )
                        &&
                            (
                            (name.IsToCompare == false || name.IsToCompare && t.Name.Contains(name.ValueToBeContained))
                            &&
                            (charColumn.IsToCompare == false || charColumn.IsToCompare && t.CharColumn.Contains(charColumn.ValueToBeContained))
                            &&
                            (varcharColumn.IsToCompare == false || varcharColumn.IsToCompare && t.VarcharColumn.Contains(varcharColumn.ValueToBeContained))
                            &&
                            (textColumn.IsToCompare == false || textColumn.IsToCompare && t.TextColumn.Contains(textColumn.ValueToBeContained))
                            &&
                            (ncharColumn.IsToCompare == false || ncharColumn.IsToCompare && t.NcharColumn.Contains(ncharColumn.ValueToBeContained))
                            &&
                            (nvarcharColumn.IsToCompare == false || nvarcharColumn.IsToCompare && t.NvarcharColumn.Contains(nvarcharColumn.ValueToBeContained))
                            &&
                            (ntextColumn.IsToCompare == false || ntextColumn.IsToCompare && t.NtextColumn.Contains(ntextColumn.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool ___ExistsOfDefaultOfCommon(
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
            )
        {
            int _Count = ___GetCountOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfCommon(
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
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfCommon(
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
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfCommon(
                parentId
                ,isSystemBuiltIn
                ,createdDateTimeRange
                ,bitColumn
                ,datetimeColumnRange
                ,datetime2ColumnRange
                ,smalldatetimeColumnRange
                ,dateColumnRange
                ,name
                ,charColumn
                ,varcharColumn
                ,textColumn
                ,ncharColumn
                ,nvarcharColumn
                ,ntextColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfAll(
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

        private bool ___ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfAll(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfAll(
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfAll(
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfAll(
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfAll(
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> ___GetQueryOfNameValuePairOfAll(
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

        private bool ___ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfNameValuePairOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfAll(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfNameValuePairOfAll(
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
                log.Error(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfNameValuePairOfAll(
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
                log.Error(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfAll(
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
                log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfAll(
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
                log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> ___GetQueryOfRssItemOfAll(
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

        private bool ___ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfRssItemOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfAll(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfRssItemOfAll(
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
                log.Error(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfRssItemOfAll(
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
                log.Error(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem __GetSingleOfRssItemOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = ___ExistsOfRssItemOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfAll(
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
                log.Error(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection __GetCollectionOfRssItemOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = ___ExistsOfRssItemOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfAll(
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
                log.Error(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
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
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
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

        private bool ___ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfByFKOnly(
                parentId
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfByFKOnly(
                parentId
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> ___GetQueryOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
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
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
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

        private bool ___ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfNameValuePairOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfByFKOnly(
                parentId
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfNameValuePairOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfNameValuePairOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfByFKOnly(
                parentId
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> ___GetQueryOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
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
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
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

        private bool ___ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfRssItemOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfByFKOnly(
                parentId
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfRssItemOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfRssItemOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem __GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = ___ExistsOfRssItemOfByFKOnly(
                parentId
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = ___ExistsOfRssItemOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> ___GetQueryOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
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
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool ___ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfByFKOnly(
                parentId
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfByFKOnly(
                parentId
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
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
                            (parentId.IsToCompare == false || parentId.IsToCompare && Organization_2.Id == parentId.ValueToCompare)
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

        private bool ___ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultGroupedDataViewOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                parentId
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultGroupedDataViewOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultGroupedDataViewOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView();
            try
            {
                bool _Exists = ___ExistsOfDefaultGroupedDataViewOfByFKOnly(
                parentId
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultGroupedDataViewOfByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                parentId
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
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

        private bool ___ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfByIdentifier(
                id
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfByIdentifier(
                id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> ___GetQueryOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool ___ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultOfByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfByIdentifier(
                id
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfByIdentifier(
                id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> ___GetQueryOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation { Id = t.Id, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, BitColumn = t.BitColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD5
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

        private bool ___ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfKeyInformationOfByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = ___GetQueryOfKeyInformationOfByIdentifier(
                id
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfKeyInformationOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfKeyInformationOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation();
            try
            {
                bool _Exists = ___ExistsOfKeyInformationOfByIdentifier(
                id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = ___GetQueryOfKeyInformationOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection __GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = ___ExistsOfKeyInformationOfByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = ___GetQueryOfKeyInformationOfByIdentifier(
                id
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
                log.Error(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
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
                            (uniqueIdentifier.IsToCompare == false || uniqueIdentifier.IsToCompare && t.UniqueIdentifier == uniqueIdentifier.ValueToCompare)
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

        private bool ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
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
                            (uniqueIdentifier.IsToCompare == false || uniqueIdentifier.IsToCompare && t.UniqueIdentifier == uniqueIdentifier.ValueToCompare)
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

        private bool ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
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
                            (uniqueIdentifier.IsToCompare == false || uniqueIdentifier.IsToCompare && t.UniqueIdentifier == uniqueIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                uniqueIdentifier
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
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
                            (uniqueidentifierColumn.IsToCompare == false || uniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == uniqueidentifierColumn.ValueToCompare)
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

        private bool ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
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
                            (uniqueidentifierColumn.IsToCompare == false || uniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == uniqueidentifierColumn.ValueToCompare)
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

        private bool ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
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
                            (uniqueidentifierColumn.IsToCompare == false || uniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == uniqueidentifierColumn.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> ___GetQueryOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            &&
                            (uniqueIdentifier.IsToCompare == false || uniqueIdentifier.IsToCompare && t.UniqueIdentifier == uniqueIdentifier.ValueToCompare)
                            &&
                            (uniqueidentifierColumn.IsToCompare == false || uniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == uniqueidentifierColumn.ValueToCompare)
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

        private bool ___ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization __GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization __GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = ___ExistsOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = ___GetQueryOfEntityOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> ___GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            &&
                            (uniqueIdentifier.IsToCompare == false || uniqueIdentifier.IsToCompare && t.UniqueIdentifier == uniqueIdentifier.ValueToCompare)
                            &&
                            (uniqueidentifierColumn.IsToCompare == false || uniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == uniqueidentifierColumn.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool ___ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = ___GetQueryOfDefaultOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> ___GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            &&
                            (uniqueIdentifier.IsToCompare == false || uniqueIdentifier.IsToCompare && t.UniqueIdentifier == uniqueIdentifier.ValueToCompare)
                            &&
                            (uniqueidentifierColumn.IsToCompare == false || uniqueidentifierColumn.IsToCompare && t.UniqueidentifierColumn == uniqueidentifierColumn.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation { Id = t.Id, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, BitColumn = t.BitColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD5
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

        private bool ___ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = ___GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation();
            try
            {
                bool _Exists = ___ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = ___GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueidentifierColumn
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = ___ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = ___GetQueryOfKeyInformationOfIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,uniqueidentifierColumn
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
                log.Error(string.Format("{0}: __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

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
                        (System.Int64)t.Id, (System.String)t.RecursivePath__, (System.Int64)t.ParentId, (System.String)t.Name, (System.Boolean)t.IsSystemBuiltIn, (System.Guid)t.UniqueIdentifier, (System.DateTime)t.CreatedDateTime, (System.String)t.CharColumn, (System.String)t.VarcharColumn, (System.String)t.TextColumn, (System.String)t.NcharColumn, (System.String)t.NvarcharColumn, (System.String)t.NtextColumn, (System.Boolean)t.BitColumn, (System.Byte[])t.BinaryColumn, (System.Byte[])t.VarbinaryColumn, (System.Byte[])t.ImageColumn, (System.Byte)t.TinyintColumn, (System.Int16)t.SmallintColumn, (System.Int32)t.IntColumn, (System.Int64)t.BigintColumn, (System.Decimal)t.DecimalColumn, (System.Decimal)t.NumericColumn, (System.Decimal)t.SmallmoneyColumn, (System.Decimal)t.MoneyColumn, (System.Single)t.FloatColumn, (System.Single)t.RealColumn, (System.DateTime)t.DatetimeColumn, (System.DateTime)t.Datetime2Column, (System.DateTime)t.SmalldatetimeColumn, (System.DateTime)t.DateColumn, (System.TimeSpan)t.TimeColumn, (System.Guid)t.UniqueidentifierColumn) into x
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
                        (System.Int64)t.Id, (System.String)t.RecursivePath__, (System.Int64)t.ParentId, (System.String)t.Name, (System.Boolean)t.IsSystemBuiltIn, (System.Guid)t.UniqueIdentifier, (System.DateTime)t.CreatedDateTime, (System.String)t.CharColumn, (System.String)t.VarcharColumn, (System.String)t.TextColumn, (System.String)t.NcharColumn, (System.String)t.NvarcharColumn, (System.String)t.NtextColumn, (System.Boolean)t.BitColumn, (System.Byte[])t.BinaryColumn, (System.Byte[])t.VarbinaryColumn, (System.Byte[])t.ImageColumn, (System.Byte)t.TinyintColumn, (System.Int16)t.SmallintColumn, (System.Int32)t.IntColumn, (System.Int64)t.BigintColumn, (System.Decimal)t.DecimalColumn, (System.Decimal)t.NumericColumn, (System.Decimal)t.SmallmoneyColumn, (System.Decimal)t.MoneyColumn, (System.Single)t.FloatColumn, (System.Single)t.RealColumn, (System.DateTime)t.DatetimeColumn, (System.DateTime)t.Datetime2Column, (System.DateTime)t.SmalldatetimeColumn, (System.DateTime)t.DateColumn, (System.TimeSpan)t.TimeColumn, (System.Guid)t.UniqueidentifierColumn) into x
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


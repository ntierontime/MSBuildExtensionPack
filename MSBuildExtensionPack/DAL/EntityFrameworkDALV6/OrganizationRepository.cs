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

        #region Query Methods Of DefaultByCommon

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultByCommon(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool _ExistsOfDefaultByCommon(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByCommon(
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
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfDefaultByCommon(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByCommon(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultByCommon(
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
            log.Info(string.Format("{0}: GetCountOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultByCommon(
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
                log.Error(string.Format("{0}: GetCountOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultByCommon(
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
            log.Info(string.Format("{0}: ExistsOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultByCommon(
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
                log.Error(string.Format("{0}: ExistsOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByCommon(
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
            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByCommon(
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByCommon(
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of NameValuePairByAll

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairByAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    select new Framework.NameValuePair { Value = t.Id.ToString().ToString(), Name = t.Name } into vD0
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

        private bool _ExistsOfNameValuePairByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByAll(
                queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfNameValuePairByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByAll(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairByAll(
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
                log.Error(string.Format("{0}: GetCountOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairByAll(
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
                log.Error(string.Format("{0}: ExistsOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairByAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByAll(
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
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of RssItemByAll

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> _GetQueryOfRssItemByAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Organizations
                    join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString().ToString(), Title = t.Name, Description = t.Name, PubDate = t.CreatedDateTime } into vD1
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

        private bool _ExistsOfRssItemByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemByAll(
                queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfRssItemByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemByAll(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemByAll(
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
                log.Error(string.Format("{0}: GetCountOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemByAll(
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
                log.Error(string.Format("{0}: ExistsOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemByAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemByAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemByAll(
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
                log.Error(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of RssItemByAll

        #region Query Methods Of NameValuePairByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairByFKOnly(
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
                    select new Framework.NameValuePair { Value = t.Id.ToString().ToString(), Name = t.Name } into vD0
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

        private bool _ExistsOfNameValuePairByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                parentId
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfNameValuePairByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairByFKOnly(
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
                log.Error(string.Format("{0}: GetCountOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairByFKOnly(
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
                log.Error(string.Format("{0}: ExistsOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
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
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of DefaultByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultByFKOnly(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool _ExistsOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByFKOnly(
                parentId
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultByFKOnly(
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
                log.Error(string.Format("{0}: GetCountOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultByFKOnly(
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
                log.Error(string.Format("{0}: ExistsOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByFKOnly(
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultGroupedDataViewByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewByFKOnly(
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
                    group t by new { ParentId = t.ParentId } into tG
                    let _CountPerFK = tG.Count()
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView { ParentId = tG.Key.ParentId, CountPerFK = _CountPerFK } into vD4
                    select vD4
                );
            var _ResultFromDataSourceWithName =
                from t in _ResultFromDataSource
            join Organization_2 in this.LinqContext.Organizations on t.ParentId equals Organization_2.Id
            let _Name = string.Concat(new string[] { Organization_2.Name })
            select new MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView { ParentId = t.ParentId, CountPerFK = t.CountPerFK, Name = _Name };
            var _retval = _ResultFromDataSourceWithName;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _retval1;
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

        private bool _ExistsOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                parentId
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultGroupedDataViewByFKOnly(
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
                log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultGroupedDataViewByFKOnly(
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
                log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria parentId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewByFKOnly(
                parentId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultGroupedDataViewByFKOnly

        #region Query Methods Of EntityByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityByIdentifier(
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

        private bool _ExistsOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityByIdentifier(
                id
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityByIdentifier(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityByIdentifier(
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
                log.Error(string.Format("{0}: GetCountOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityByIdentifier(
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
                log.Error(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityByIdentifier(
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
                log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of DefaultByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultByIdentifier(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool _ExistsOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByIdentifier(
                id
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByIdentifier(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultByIdentifier(
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
                log.Error(string.Format("{0}: GetCountOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultByIdentifier(
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
                log.Error(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByIdentifier(
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _GetQueryOfKeyInformationByIdentifier(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation { Id = t.Id, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, BitColumn = t.BitColumn } into vD5
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

        private bool _ExistsOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
                id
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfKeyInformationByIdentifier(
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
                log.Error(string.Format("{0}: GetCountOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfKeyInformationByIdentifier(
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
                log.Error(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = _ExistsOfKeyInformationByIdentifier(
                id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
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
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of KeyInformationByIdentifier

        #region Query Methods Of EntityByIdentifierAndUniqueConstraint

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _GetQueryOfEntityByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
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

        private bool _ExistsOfEntityByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfEntityByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: GetCountOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization GetCollectionOfEntityByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization();
            try
            {
                bool _Exists = _ExistsOfEntityByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization> _Query = _GetQueryOfEntityByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of EntityByIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultByIdentifierAndUniqueConstraint

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _GetQueryOfDefaultByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
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
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.Default { Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, Id = t.Id, ParentId = t.ParentId, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, CreatedDateTime = t.CreatedDateTime, CharColumn = t.CharColumn, VarcharColumn = t.VarcharColumn, TextColumn = t.TextColumn, NcharColumn = t.NcharColumn, NvarcharColumn = t.NvarcharColumn, NtextColumn = t.NtextColumn, BitColumn = t.BitColumn, BinaryColumn = t.BinaryColumn, VarbinaryColumn = t.VarbinaryColumn, ImageColumn = t.ImageColumn, TinyintColumn = t.TinyintColumn, SmallintColumn = t.SmallintColumn, IntColumn = t.IntColumn, BigintColumn = t.BigintColumn, DecimalColumn = t.DecimalColumn, NumericColumn = t.NumericColumn, SmallmoneyColumn = t.SmallmoneyColumn, MoneyColumn = t.MoneyColumn, FloatColumn = t.FloatColumn, RealColumn = t.RealColumn, DatetimeColumn = t.DatetimeColumn, Datetime2Column = t.Datetime2Column, SmalldatetimeColumn = t.SmalldatetimeColumn, DateColumn = t.DateColumn, TimeColumn = t.TimeColumn, UniqueidentifierColumn = t.UniqueidentifierColumn } into vD2
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

        private bool _ExistsOfDefaultByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfDefaultByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: GetCountOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.Default> _Query = _GetQueryOfDefaultByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _GetQueryOfKeyInformationByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
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
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation { Id = t.Id, Name = t.Name, IsSystemBuiltIn = t.IsSystemBuiltIn, UniqueIdentifier = t.UniqueIdentifier, BitColumn = t.BitColumn } into vD5
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

        private bool _ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,queryOrderBySettingCollection
            );
            bool result;
            if (currentIndex == -1 || pageSize == -1)
            {
                result = _Query.Any();
            }
            else
            {
                result = _Query.Skip(currentIndex).Take(pageSize).Any();
            }
            return result;
        }

        private int _GetCountOfKeyInformationByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfKeyInformationByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: GetCountOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QuerySystemGuidEqualsCriteria uniqueIdentifier
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = _ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifierAndUniqueConstraint(
                id
                ,uniqueIdentifier
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
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

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


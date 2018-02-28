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
    /// Linq data access layer of entity <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLog"/>, with following methods:
    /// 1. Insert, Update and Delete
    /// 2. Batch Insert, Update and Delete
    /// 3. Queries
    /// </summary>
    public class BuildLogRepository
        : MSBuildExtensionPack.DALContracts.IBuildLogRepository//<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier>
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
        public BuildLogRepository()
        {
        }

        /// <summary>
        /// constructor with Linq DataContext parameter
        /// </summary>
        /// <param name="linqContext">see<see cref="MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities"/></param>
        public BuildLogRepository(MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities linqContext)
        {
            this.LinqContext = linqContext;
        }

        #endregion constructors

        #region IDataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members

        /// <summary>
        /// single item insert with entity input
        /// </summary>
        /// <param name="input">to-be-inserted instance of entity class</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog Insert(MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.BuildLog _LinqItem = MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.EntityFrameworkContext.BuildLog>(input);
                this.LinqContext.BuildLogs.Add(_LinqItem);
                this.LinqContext.SaveChanges();
                MSBuildExtensionPack.DataSourceEntities.BuildLog _Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog();
                MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLog>(_LinqItem, _Result);
                _retval.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
                _retval.Result.Add(_Result);
            }

            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item update with entity input
        /// </summary>
        /// <param name="input">to-be-updated instance of entity class</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog Update(MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.BuildLog _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.EntityFrameworkContext.BuildLog>(input, _LinqItem);
                    this.LinqContext.SaveChanges();
                    MSBuildExtensionPack.DataSourceEntities.BuildLog _Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog();
                    MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLog>(_LinqItem, _Result);
                    _retval.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog Delete(MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.BuildLog _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    this.LinqContext.BuildLogs.Remove(_LinqItem);
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog DeleteByIdentifier(MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier id)
        {
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();

            if (id != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.BuildLog _LinqItem = GetLinqObjectByIdentifier(id);
                if (_LinqItem != null)
                {
                    MSBuildExtensionPack.DataSourceEntities.BuildLog _Original = new MSBuildExtensionPack.DataSourceEntities.BuildLog();
                    MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLog>(_LinqItem, _Original);

                    _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
                    _retval.OriginalValue.Add(_Original);

                    this.LinqContext.BuildLogs.Remove(_LinqItem);
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            _retval.OriginalValue = input;

            if (input != null && input.Count > 0)
            {
                try
                {
                    DataTable _DataTable = new DataTable();
                    _DataTable.Columns.Add("Id", typeof(System.Int64));
                    _DataTable.Columns.Add("BuildId", typeof(System.Int64));
                    _DataTable.Columns.Add("BuildEventCodeId", typeof(System.Int32));
                    _DataTable.Columns.Add("Message", typeof(System.String));
                    _DataTable.Columns.Add("EventTime", typeof(System.DateTime));

                    foreach (MSBuildExtensionPack.DataSourceEntities.BuildLog _Item in input)
                    {
                        _DataTable.Rows.Add(new object[] { _Item.Id, _Item.BuildId, _Item.BuildEventCodeId, _Item.Message, _Item.EventTime });
                    }

                    using (SqlBulkCopy s = new SqlBulkCopy(this.LinqContext.Database.Connection.ConnectionString))
                    {
                        s.DestinationTableName = "dbo.BuildLog";

                        s.ColumnMappings.Add("Id", "Id");
                        s.ColumnMappings.Add("BuildId", "BuildId");
                        s.ColumnMappings.Add("BuildEventCodeId", "BuildEventCodeId");
                        s.ColumnMappings.Add("Message", "Message");
                        s.ColumnMappings.Add("EventTime", "EventTime");

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildExtensionPack.EntityFrameworkContext.BuildLog> _ListOfLinq = new List<MSBuildExtensionPack.EntityFrameworkContext.BuildLog>();
                foreach (MSBuildExtensionPack.DataSourceEntities.BuildLog _ItemOfInput in input)
                {
                    MSBuildExtensionPack.EntityFrameworkContext.BuildLog _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    this.LinqContext.BuildLogs.Remove(_LinqItem);
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildExtensionPack.EntityFrameworkContext.BuildLog> _ListOfLinq = new List<MSBuildExtensionPack.EntityFrameworkContext.BuildLog>();
                foreach (MSBuildExtensionPack.DataSourceEntities.BuildLog _ItemOfInput in input)
                {
                    MSBuildExtensionPack.EntityFrameworkContext.BuildLog _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.EntityFrameworkContext.BuildLog>(_ItemOfInput, _LinqItem);
                    _ListOfLinq.Add(_LinqItem);
                }
                this.LinqContext.SaveChanges();

                for (int i = 0; i < input.Count; i++)
                {
                    MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy
                        <
                            MSBuildExtensionPack.EntityFrameworkContext.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLog
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
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier"/> class, with same identifier.</returns>
        public MSBuildExtensionPack.DataSourceEntities.BuildLog GetByIdentifier(MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier id)
        {
            MSBuildExtensionPack.EntityFrameworkContext.BuildLog _Only = GetLinqObjectByIdentifier(id);
            if (_Only != null)
            {
                return new MSBuildExtensionPack.DataSourceEntities.BuildLog(_Only);
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
        /// <returns>an instance of <see cref="MSBuildExtensionPack.EntityFrameworkContext.BuildLog"/> class, with same identifier, which is a IQueryable.</returns>
        private MSBuildExtensionPack.EntityFrameworkContext.BuildLog GetLinqObjectByIdentifier(MSBuildExtensionPack.EntityContracts.IBuildLogIdentifier id)
        {
            Func<MSBuildExtensionPack.EntityFrameworkContext.BuildLog, bool> m_Predicate = (MSBuildExtensionPack.EntityFrameworkContext.BuildLog t) =>
            {
                return MSBuildExtensionPack.EntityContracts.IBuildLogIdentifierHelper.Equals<MSBuildExtensionPack.EntityContracts.IBuildLogIdentifier, MSBuildExtensionPack.EntityFrameworkContext.BuildLog>(id, t);
            };

            return this.LinqContext.BuildLogs.SingleOrDefault<MSBuildExtensionPack.EntityFrameworkContext.BuildLog>(m_Predicate);
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _GetQueryOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.EventTime > criteriaOfEventTimeOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.EventTime <= criteriaOfEventTimeOftOfCommonOfCommonOfCommon.UpperBound))
                            )
                        &&
                            (
                            (criteriaOfMessageOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfMessageOftOfCommonOfCommonOfCommon.IsToCompare && t.Message.Contains(criteriaOfMessageOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog { Id = t.Id, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _GetQueryOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon.ValueToCompare)
                            &&
                            (criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.EventTime > criteriaOfEventTimeOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfEventTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.EventTime <= criteriaOfEventTimeOftOfCommonOfCommonOfCommon.UpperBound))
                            )
                        &&
                            (
                            (criteriaOfMessageOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfMessageOftOfCommonOfCommonOfCommon.IsToCompare && t.Message.Contains(criteriaOfMessageOftOfCommonOfCommonOfCommon.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default { Build_1_Name = Build_1.Name, Id = t.Id, Solution_1Id = Solution_1.Id, Solution_1_Name = Solution_1.Name, Organization_1Id = Organization_1.Id, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_1_Name = Organization_1.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, BuildEventCode_1_Name = BuildEventCode_1.EventCode, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog.Default _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfEventTimeOftOfCommonOfCommonOfCommon
            , Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfMessageOftOfCommonOfCommonOfCommon
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfCommon(
                criteriaOfIdOfBuild_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfSolution_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
                , criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
                , criteriaOfIdOfBuildEventCode_1OfCommonOfCommonOfCommon
                , criteriaOfEventTimeOftOfCommonOfCommonOfCommon
                , criteriaOfMessageOftOfCommonOfCommonOfCommon
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _GetQueryOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog { Id = t.Id, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval1;
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfAll(
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
                -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfAll(
            int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
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
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Message } into vD0
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfNameValuePairOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
                , -1
                , queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Message, Description = t.Message, PubDate = t.EventTime } into vD1
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
                , -1
                , queryOrderBySettingCollection
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
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemOfAll(
                currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _GetQueryOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog { Id = t.Id, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Message } into vD0
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Message, Description = t.Message, PubDate = t.EventTime } into vD1
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _GetQueryOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default { Build_1_Name = Build_1.Name, Id = t.Id, Solution_1Id = Solution_1.Id, Solution_1_Name = Solution_1.Name, Organization_1Id = Organization_1.Id, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_1_Name = Organization_1.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, BuildEventCode_1_Name = BuildEventCode_1.EventCode, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog.Default _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection();
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
        internal IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Build_1.Id == criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_1.Id == criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            &&
                            (criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && BuildEventCode_1.Id == criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
                            )
                        )
                    group t by new { BuildEventCodeId = t.BuildEventCodeId } into tG
                    let _CountPerFK = tG.Count()
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView { BuildEventCodeId = tG.Key.BuildEventCodeId, CountPerFK = _CountPerFK } into vD3
                    select vD3
                );
            var _retval = _ResultFromDataSource;
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataView _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataView();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
            , Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                criteriaOfIdOfBuild_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfSolution_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
                , criteriaOfIdOfBuildEventCode_1OfByFKOnlyOfByFKOnlyOfByFKOnly
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _GetQueryOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog { Id = t.Id, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval1;
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
            try
            {
                bool _Exists = _ExistsOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLogCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _GetQueryOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default { Build_1_Name = Build_1.Name, Id = t.Id, Solution_1Id = Solution_1.Id, Solution_1_Name = Solution_1.Name, Organization_1Id = Organization_1.Id, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_1_Name = Organization_1.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, BuildEventCode_1_Name = BuildEventCode_1.EventCode, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _retval1;
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog.Default _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _GetQueryOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.BuildLogs
                    join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
                    join Solution_1 in this.LinqContext.Solutions on Build_1.SolutionId equals Solution_1.Id
                    join Organization_1 in this.LinqContext.Organizations on Solution_1.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
                    where
                        (
                            (
                            (criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation { Id = t.Id, BuildEventCodeId = t.BuildEventCodeId } into vD4
                    select vD4
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _retval1;
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = _GetCountOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
                    );
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
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
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformation();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , -1
                , -1
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation _retval = _Query.SingleOrDefault();

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
        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
            , int currentIndex
            , int pageSize
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , currentIndex
                , pageSize
                , queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
                criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
                , queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection();
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

    }
}


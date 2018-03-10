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
    /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
    /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query
    /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
    /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
    /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
    /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
    /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
    /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
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
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();

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

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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

        #region Query Methods Of DefaultByCommon

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _GetQueryOfDefaultByCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (buildId.IsToCompare == false || buildId.IsToCompare && Build_1.Id == buildId.ValueToCompare)
                            &&
                            (solution_1Id.IsToCompare == false || solution_1Id.IsToCompare && Solution_1.Id == solution_1Id.ValueToCompare)
                            &&
                            (organization_1Id.IsToCompare == false || organization_1Id.IsToCompare && Organization_1.Id == organization_1Id.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            &&
                            (buildEventCodeId.IsToCompare == false || buildEventCodeId.IsToCompare && BuildEventCode_1.Id == buildEventCodeId.ValueToCompare)
                            &&
                            (eventTimeRange.IsToCompare == false || eventTimeRange.IsToCompare && (eventTimeRange.IsToCompareLowerBound == false || eventTimeRange.IsToCompareLowerBound && t.EventTime > eventTimeRange.LowerBound) && (eventTimeRange.IsToCompareUpperBound == false || eventTimeRange.IsToCompareUpperBound && t.EventTime <= eventTimeRange.UpperBound))
                            )
                        &&
                            (
                            (message.IsToCompare == false || message.IsToCompare && t.Message.Contains(message.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default { Build_1_Name = Build_1.Name, Id = t.Id, Solution_1Id = Solution_1.Id, Solution_1_Name = Solution_1.Name, Organization_1Id = Organization_1.Id, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_Name = Organization_1.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, BuildEventCode_1_Name = BuildEventCode_1.EventCode, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into vD0
                    select vD0
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

        private bool _ExistsOfDefaultByCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByCommon(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,eventTimeRange
                ,message
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByCommon(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,eventTimeRange
                ,message
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,eventTimeRange
                ,message
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,eventTimeRange
                ,message
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

        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria eventTimeRange
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria message
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByCommon(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,eventTimeRange
                ,message
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByCommon(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,eventTimeRange
                ,message
                ,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of RssItemByAll

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> _GetQueryOfRssItemByAll(
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
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Message, Description = t.Message, PubDate = t.EventTime } into vD4
                    select vD4
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

        #region Query Methods Of DefaultByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _GetQueryOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (buildId.IsToCompare == false || buildId.IsToCompare && Build_1.Id == buildId.ValueToCompare)
                            &&
                            (solution_1Id.IsToCompare == false || solution_1Id.IsToCompare && Solution_1.Id == solution_1Id.ValueToCompare)
                            &&
                            (organization_1Id.IsToCompare == false || organization_1Id.IsToCompare && Organization_1.Id == organization_1Id.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            &&
                            (buildEventCodeId.IsToCompare == false || buildEventCodeId.IsToCompare && BuildEventCode_1.Id == buildEventCodeId.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default { Build_1_Name = Build_1.Name, Id = t.Id, Solution_1Id = Solution_1.Id, Solution_1_Name = Solution_1.Name, Organization_1Id = Organization_1.Id, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_Name = Organization_1.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, BuildEventCode_1_Name = BuildEventCode_1.EventCode, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into vD0
                    select vD0
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

        private bool _ExistsOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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

        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultGroupedDataViewByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (buildId.IsToCompare == false || buildId.IsToCompare && Build_1.Id == buildId.ValueToCompare)
                            &&
                            (solution_1Id.IsToCompare == false || solution_1Id.IsToCompare && Solution_1.Id == solution_1Id.ValueToCompare)
                            &&
                            (organization_1Id.IsToCompare == false || organization_1Id.IsToCompare && Organization_1.Id == organization_1Id.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            &&
                            (buildEventCodeId.IsToCompare == false || buildEventCodeId.IsToCompare && BuildEventCode_1.Id == buildEventCodeId.ValueToCompare)
                            )
                        )
                    group t by new { BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId } into tG
                    let _CountPerFK = tG.Count()
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView { BuildId = tG.Key.BuildId, BuildEventCodeId = tG.Key.BuildEventCodeId, CountPerFK = _CountPerFK } into vD1
                    select vD1
                );
            var _ResultFromDataSourceWithName =
                from t in _ResultFromDataSource
            join Build_1 in this.LinqContext.Builds on t.BuildId equals Build_1.Id
            join BuildEventCode_1 in this.LinqContext.BuildEventCodes on t.BuildEventCodeId equals BuildEventCode_1.Id
            let _Name = string.Concat(new string[] { Build_1.Name," - ",BuildEventCode_1.EventCode })
            select new MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView { BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, CountPerFK = t.CountPerFK, Name = _Name };
            var _retval = _ResultFromDataSourceWithName;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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

        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultGroupedDataViewByFKOnly

        #region Query Methods Of NameValuePairByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (buildId.IsToCompare == false || buildId.IsToCompare && Build_1.Id == buildId.ValueToCompare)
                            &&
                            (solution_1Id.IsToCompare == false || solution_1Id.IsToCompare && Solution_1.Id == solution_1Id.ValueToCompare)
                            &&
                            (organization_1Id.IsToCompare == false || organization_1Id.IsToCompare && Organization_1.Id == organization_1Id.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            &&
                            (buildEventCodeId.IsToCompare == false || buildEventCodeId.IsToCompare && BuildEventCode_1.Id == buildEventCodeId.ValueToCompare)
                            )
                        )
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Message } into vD3
                    select vD3
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria buildId
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria solution_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_1Id
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemInt32EqualsCriteria buildEventCodeId
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
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                buildId
                ,solution_1Id
                ,organization_1Id
                ,organization_2Id
                ,buildEventCodeId
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

        #region Query Methods Of EntityByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _GetQueryOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
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

        private bool _ExistsOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityByIdentifier(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityByIdentifier(
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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog GetCollectionOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog> _Query = _GetQueryOfEntityByIdentifier(
                id
                ,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of DefaultByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _GetQueryOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.Default { Build_1_Name = Build_1.Name, Id = t.Id, Solution_1Id = Solution_1.Id, Solution_1_Name = Solution_1.Name, Organization_1Id = Organization_1.Id, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_Name = Organization_1.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, BuildEventCode_1_Name = BuildEventCode_1.EventCode, BuildId = t.BuildId, BuildEventCodeId = t.BuildEventCodeId, Message = t.Message, EventTime = t.EventTime } into vD0
                    select vD0
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

        private bool _ExistsOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByIdentifier(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByIdentifier(
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

        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default> _Query = _GetQueryOfDefaultByIdentifier(
                id
                ,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _GetQueryOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
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
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation { Id = t.Id, BuildEventCodeId = t.BuildEventCodeId } into vD2
                    select vD2
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

        private bool _ExistsOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
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

        public MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
                id
                ,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        #endregion Query Methods Of KeyInformationByIdentifier

    }
}


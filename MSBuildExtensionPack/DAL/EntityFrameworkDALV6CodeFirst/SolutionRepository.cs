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
    /// Linq data access layer of entity <see cref="MSBuildExtensionPack.DataSourceEntities.Solution"/>, with following methods:
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
    public class SolutionRepository
        : MSBuildExtensionPack.DALContracts.ISolutionRepository//<MSBuildExtensionPack.DataSourceEntities.SolutionCollection, MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier>
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
        public SolutionRepository()
        {
        }

        /// <summary>
        /// constructor with Linq DataContext parameter
        /// </summary>
        /// <param name="linqContext">see<see cref="MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities"/></param>
        public SolutionRepository(MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities linqContext)
        {
            this.LinqContext = linqContext;
        }

        #endregion constructors

        #region IDataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.SolutionCollection,MSBuildExtensionPack.DataSourceEntities.Solution,MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier> Members

        /// <summary>
        /// single item insert with entity input
        /// </summary>
        /// <param name="input">to-be-inserted instance of entity class</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution Insert(MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Solution _LinqItem = MSBuildExtensionPack.EntityContracts.ISolutionHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.EntityFrameworkContext.Solution>(input);
                this.LinqContext.Solutions.Add(_LinqItem);
                this.LinqContext.SaveChanges();
                MSBuildExtensionPack.DataSourceEntities.Solution _Result = new MSBuildExtensionPack.DataSourceEntities.Solution();
                MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.Solution, MSBuildExtensionPack.DataSourceEntities.Solution>(_LinqItem, _Result);
                _retval.Result = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
                _retval.Result.Add(_Result);
            }

            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item update with entity input
        /// </summary>
        /// <param name="input">to-be-updated instance of entity class</param>
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution Update(MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Solution _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.EntityFrameworkContext.Solution>(input, _LinqItem);
                    this.LinqContext.SaveChanges();
                    MSBuildExtensionPack.DataSourceEntities.Solution _Result = new MSBuildExtensionPack.DataSourceEntities.Solution();
                    MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.Solution, MSBuildExtensionPack.DataSourceEntities.Solution>(_LinqItem, _Result);
                    _retval.Result = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution Delete(MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Solution _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    this.LinqContext.Solutions.Remove(_LinqItem);
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution DeleteByIdentifier(MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier id)
        {
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();

            if (id != null)
            {
                MSBuildExtensionPack.EntityFrameworkContext.Solution _LinqItem = GetLinqObjectByIdentifier(id);
                if (_LinqItem != null)
                {
                    MSBuildExtensionPack.DataSourceEntities.Solution _Original = new MSBuildExtensionPack.DataSourceEntities.Solution();
                    MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityFrameworkContext.Solution, MSBuildExtensionPack.DataSourceEntities.Solution>(_LinqItem, _Original);

                    _retval.OriginalValue = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
                    _retval.OriginalValue.Add(_Original);

                    this.LinqContext.Solutions.Remove(_LinqItem);
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution BatchInsert(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = input;

            if (input != null && input.Count > 0)
            {
                try
                {
                    DataTable _DataTable = new DataTable();
                _DataTable.Columns.Add("Id", typeof(System.Int32));
                _DataTable.Columns.Add("ExternalParentId", typeof(System.String));
                _DataTable.Columns.Add("Name", typeof(System.String));
                _DataTable.Columns.Add("Description", typeof(System.String));
                _DataTable.Columns.Add("OrganizationId", typeof(System.Int64));

                    foreach (MSBuildExtensionPack.DataSourceEntities.Solution _Item in input)
                    {
                        _DataTable.Rows.Add(new object[] { _Item.Id, _Item.ExternalParentId, _Item.Name, _Item.Description, _Item.OrganizationId });
                    }

                    using (SqlBulkCopy s = new SqlBulkCopy(this.LinqContext.Database.Connection.ConnectionString))
                    {
                        s.DestinationTableName = "dbo.Solution";

                    s.ColumnMappings.Add("Id", "Id");
                    s.ColumnMappings.Add("ExternalParentId", "ExternalParentId");
                    s.ColumnMappings.Add("Name", "Name");
                    s.ColumnMappings.Add("Description", "Description");
                    s.ColumnMappings.Add("OrganizationId", "OrganizationId");

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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution BatchDelete(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildExtensionPack.EntityFrameworkContext.Solution> _ListOfLinq = new List<MSBuildExtensionPack.EntityFrameworkContext.Solution>();
                foreach (MSBuildExtensionPack.DataSourceEntities.Solution _ItemOfInput in input)
                {
                    MSBuildExtensionPack.EntityFrameworkContext.Solution _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    this.LinqContext.Solutions.Remove(_LinqItem);
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution BatchUpdate(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildExtensionPack.EntityFrameworkContext.Solution> _ListOfLinq = new List<MSBuildExtensionPack.EntityFrameworkContext.Solution>();
                foreach (MSBuildExtensionPack.DataSourceEntities.Solution _ItemOfInput in input)
                {
                    MSBuildExtensionPack.EntityFrameworkContext.Solution _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.EntityFrameworkContext.Solution>(_ItemOfInput, _LinqItem);
                    _ListOfLinq.Add(_LinqItem);
                }
                this.LinqContext.SaveChanges();

                for (int i = 0; i < input.Count; i++)
                {
                    MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy
                        <
                            MSBuildExtensionPack.EntityFrameworkContext.Solution, MSBuildExtensionPack.DataSourceEntities.Solution
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
        /// <returns>an instance of <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier"/> class, with same identifier.</returns>
        public MSBuildExtensionPack.DataSourceEntities.Solution GetByIdentifier(MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier id)
        {
            MSBuildExtensionPack.EntityFrameworkContext.Solution _Only = GetLinqObjectByIdentifier(id);
            if (_Only != null)
            {
                return new MSBuildExtensionPack.DataSourceEntities.Solution(_Only);
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
        /// <returns>an instance of <see cref="MSBuildExtensionPack.EntityFrameworkContext.Solution"/> class, with same identifier, which is a IQueryable.</returns>
        private MSBuildExtensionPack.EntityFrameworkContext.Solution GetLinqObjectByIdentifier(MSBuildExtensionPack.EntityContracts.ISolutionIdentifier id)
        {
            Func<MSBuildExtensionPack.EntityFrameworkContext.Solution, bool> m_Predicate = (MSBuildExtensionPack.EntityFrameworkContext.Solution t) =>
            {
                return MSBuildExtensionPack.EntityContracts.ISolutionIdentifierHelper.Equals<MSBuildExtensionPack.EntityContracts.ISolutionIdentifier, MSBuildExtensionPack.EntityFrameworkContext.Solution>(id, t);
            };

            return this.LinqContext.Solutions.SingleOrDefault<MSBuildExtensionPack.EntityFrameworkContext.Solution>(m_Predicate);
        }

        #endregion

        #region Binary Columns

        #endregion Binary Columns

        #region Query Methods Of DefaultByCommon

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _GetQueryOfDefaultByCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (organizationId.IsToCompare == false || organizationId.IsToCompare && Organization_1.Id == organizationId.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            )
                        &&
                            (
                            (externalParentId.IsToCompare == false || externalParentId.IsToCompare && t.ExternalParentId.Contains(externalParentId.ValueToBeContained))
                            &&
                            (name.IsToCompare == false || name.IsToCompare && t.Name.Contains(name.ValueToBeContained))
                            &&
                            (description.IsToCompare == false || description.IsToCompare && t.Description.Contains(description.ValueToBeContained))
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_Name = Organization_1.Name, Id = t.Id, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
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
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
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
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection();
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
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Name, Description = t.ExternalParentId } into vD4
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _GetQueryOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (organizationId.IsToCompare == false || organizationId.IsToCompare && Organization_1.Id == organizationId.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_Name = Organization_1.Name, Id = t.Id, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByFKOnly(
                organizationId
                ,organization_2Id
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (organizationId.IsToCompare == false || organizationId.IsToCompare && Organization_1.Id == organizationId.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            )
                        )
                    group t by new { OrganizationId = t.OrganizationId } into tG
                    let _CountPerFK = tG.Count()
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView { OrganizationId = tG.Key.OrganizationId, CountPerFK = _CountPerFK } into vD1
                    select vD1
                );
            var _ResultFromDataSourceWithName =
                from t in _ResultFromDataSource
            join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
            let _Name = string.Concat(new string[] { Organization_1.Name })
            select new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView { OrganizationId = t.OrganizationId, CountPerFK = t.CountPerFK, Name = _Name };
            var _retval = _ResultFromDataSourceWithName;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewByFKOnly(
                organizationId
                ,organization_2Id
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection();
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (organizationId.IsToCompare == false || organizationId.IsToCompare && Organization_1.Id == organizationId.ValueToCompare)
                            &&
                            (organization_2Id.IsToCompare == false || organization_2Id.IsToCompare && Organization_2.Id == organization_2Id.ValueToCompare)
                            )
                        )
                    select new Framework.NameValuePair { Value = t.Id.ToString(), Name = t.Name } into vD3
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairByFKOnly(
                organizationId
                ,organization_2Id
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _GetQueryOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Solution { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into x
                    select x
                );
            var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _retval1;
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityByIdentifier(
                id
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _GetQueryOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_Name = Organization_1.Name, Id = t.Id, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_Name = Organization_2.Name, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into vD0
                    select vD0
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _retval1;
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultByIdentifier(
                id
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection();
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _GetQueryOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    where
                        (
                            (
                            (id.IsToCompare == false || id.IsToCompare && t.Id == id.ValueToCompare)
                            )
                        )
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation { Id = t.Id, Name = t.Name } into vD2
                    select vD2
                );
            var _retval = _ResultFromDataSource;
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _retval1;
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationByIdentifier(
                id
                ,queryOrderBySettingCollection
            );

                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _retval;

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
                    _retMessage.Result = new MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection();
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


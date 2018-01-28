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

        #region Query Methods Of Entity of Common

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> ___GetQueryOfEntityOfCommon(
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

        private bool ___ExistsOfEntityOfCommon(
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
            int _Count = ___GetCountOfEntityOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfCommon(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfCommon(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfCommon(
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
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfEntityOfCommon(
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfCommon(
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
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfEntityOfCommon(
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution __GetSingleOfEntityOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = ___ExistsOfEntityOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution __GetCollectionOfEntityOfCommon(
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
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = ___ExistsOfEntityOfCommon(
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> ___GetQueryOfDefaultOfCommon(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_1_Name = Organization_1.Name, Id = t.Id, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into vD2
                    select vD2
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

        private bool ___ExistsOfDefaultOfCommon(
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
            int _Count = ___GetCountOfDefaultOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfCommon(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfCommon(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfCommon(
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
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = ___GetCountOfDefaultOfCommon(
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfCommon(
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
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = ___ExistsOfDefaultOfCommon(
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfCommon(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria externalParentId
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria name
            ,Framework.EntityContracts.QuerySystemStringContainsCriteria description
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfCommon(
                organizationId
                ,organization_2Id
                ,externalParentId
                ,name
                ,description
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution.Default _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfCommon(
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
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfCommon(
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfCommon(
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> ___GetQueryOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            var _ResultFromDataSource =
                (
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfAll(
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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution __GetSingleOfEntityOfAll(
            Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = ___ExistsOfEntityOfAll(
                -1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution __GetCollectionOfEntityOfAll(
            int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = ___ExistsOfEntityOfAll(
                currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfAll(
                queryOrderBySettingCollection
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
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
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
                    from t in this.LinqContext.Solutions
                    join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
                    join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Name, Description = t.ExternalParentId } into vD1
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> ___GetQueryOfEntityOfByFKOnly(
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

        private bool ___ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfEntityOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution __GetSingleOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = ___ExistsOfEntityOfByFKOnly(
                organizationId
                ,organization_2Id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfByFKOnly(
                organizationId
                ,organization_2Id
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution __GetCollectionOfEntityOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = ___ExistsOfEntityOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfNameValuePairOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity __GetSingleOfNameValuePairOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = ___ExistsOfNameValuePairOfByFKOnly(
                organizationId
                ,organization_2Id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = ___GetQueryOfNameValuePairOfByFKOnly(
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
                    select new Framework.RssItem { IdentifierInString = t.Id.ToString(), Title = t.Name, Description = t.ExternalParentId } into vD1
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfRssItemOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem __GetSingleOfRssItemOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = ___ExistsOfRssItemOfByFKOnly(
                organizationId
                ,organization_2Id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfByFKOnly(
                organizationId
                ,organization_2Id
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = ___GetQueryOfRssItemOfByFKOnly(
                organizationId
                ,organization_2Id
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> ___GetQueryOfDefaultOfByFKOnly(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_1_Name = Organization_1.Name, Id = t.Id, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into vD2
                    select vD2
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

        private bool ___ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfByFKOnly(
                organizationId
                ,organization_2Id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfByFKOnly(
                organizationId
                ,organization_2Id
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution.Default _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfByFKOnly(
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
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
                    group t by new { OrganizationId = t.OrganizationId, Organization_2Id = Organization_2.Id, Name = string.Concat(new string[] { Organization_1.Name," - ",Organization_2.Name }) } into tG
                    let _CountPerFK = tG.Count()
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView { OrganizationId = tG.Key.OrganizationId, Organization_2Id = tG.Key.Organization_2Id, CountPerFK = _CountPerFK, Name = tG.Key.Name } into vD3
                    select vD3
                );
            var _retval = _ResultFromDataSource;
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _retval1;
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
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            int _Count = ___GetCountOfDefaultGroupedDataViewOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );
            return _Count > 0;
        }

        private int ___GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
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

        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
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
                log.Error(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView();
            try
            {
                bool _Exists = ___ExistsOfDefaultGroupedDataViewOfByFKOnly(
                organizationId
                ,organization_2Id
                ,-1
                ,-1
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
                organizationId
                ,organization_2Id
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            Framework.EntityContracts.QuerySystemInt64EqualsCriteria organizationId
            ,Framework.EntityContracts.QuerySystemInt64EqualsCriteria organization_2Id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = ___ExistsOfDefaultGroupedDataViewOfByFKOnly(
                organizationId
                ,organization_2Id
                ,currentIndex
                ,pageSize
                ,queryOrderBySettingCollection
            );

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = ___GetQueryOfDefaultGroupedDataViewOfByFKOnly(
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> ___GetQueryOfEntityOfByIdentifier(
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

        private bool ___ExistsOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution __GetSingleOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfByIdentifier(
                id
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution __GetCollectionOfEntityOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = ___GetQueryOfEntityOfByIdentifier(
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
                log.Error(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> ___GetQueryOfDefaultOfByIdentifier(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_1_Name = Organization_1.Name, Id = t.Id, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId } into vD2
                    select vD2
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

        private bool ___ExistsOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault __GetSingleOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfByIdentifier(
                id
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution.Default _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection __GetCollectionOfDefaultOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = ___GetQueryOfDefaultOfByIdentifier(
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
                log.Error(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> ___GetQueryOfKeyInformationOfByIdentifier(
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
                    select new MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation { Id = t.Id, Name = t.Name } into vD4
                    select vD4
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

        private bool ___ExistsOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = ___GetQueryOfKeyInformationOfByIdentifier(
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = ___GetQueryOfKeyInformationOfByIdentifier(
                id
                ,queryOrderBySettingCollection
            );

                    MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation _retval = _Query.SingleOrDefault();

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

        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection __GetCollectionOfKeyInformationOfByIdentifier(
            Framework.EntityContracts.QuerySystemInt32EqualsCriteria id
            ,int currentIndex
            ,int pageSize
            ,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            )
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = ___GetQueryOfKeyInformationOfByIdentifier(
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
                log.Error(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of ByIdentifier

    }
}


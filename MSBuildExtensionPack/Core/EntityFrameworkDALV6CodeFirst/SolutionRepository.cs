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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _GetQueryOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
							(criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.ValueToCompare)
							)
						&&
							(
							(criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.IsToCompare && t.ExternalParentId.Contains(criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.ValueToBeContained))
							&&
							(criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
							&&
							(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare && t.Description.Contains(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.ValueToBeContained))
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _GetQueryOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
							(criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon.ValueToCompare)
							)
						&&
							(
							(criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.IsToCompare && t.ExternalParentId.Contains(criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.ValueToBeContained))
							&&
							(criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
							&&
							(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare && t.Description.Contains(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.ValueToBeContained))
							)
						)
					select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId, Organization_1_Name = Organization_1.Name, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfCommon(
				criteriaOfIdOfOrganization_1OfCommonOfCommonOfCommon
				,criteriaOfIdOfOrganization_2OfCommonOfCommonOfCommon
				,criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _GetQueryOfEntityOfAll(
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
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfAll(
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
				-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfAll(
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfAll(
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
					from t in this.LinqContext.Solutions
					join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
					join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
					let _Value = System.Data.Entity.SqlServer.SqlFunctions.StringConvert((double)t.Id).Trim()
					select new Framework.NameValuePair { Name = t.Name, Value = _Value } into vD0
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
					from t in this.LinqContext.Solutions
					join Organization_1 in this.LinqContext.Organizations on t.OrganizationId equals Organization_1.Id
					join Organization_2 in this.LinqContext.Organizations on Organization_1.ParentId equals Organization_2.Id
					let _IdentifierInString = System.Data.Entity.SqlServer.SqlFunctions.StringConvert((double)t.Id).Trim()
					select new Framework.RssItem { Title = t.Name, Description = t.ExternalParentId, IdentifierInString = _IdentifierInString } into vD1
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _GetQueryOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
							(criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
							(criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					let _Value = System.Data.Entity.SqlServer.SqlFunctions.StringConvert((double)t.Id).Trim()
					select new Framework.NameValuePair { Name = t.Name, Value = _Value } into vD0
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfNameValuePairOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
							(criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					let _IdentifierInString = System.Data.Entity.SqlServer.SqlFunctions.StringConvert((double)t.Id).Trim()
					select new Framework.RssItem { Title = t.Name, Description = t.ExternalParentId, IdentifierInString = _IdentifierInString } into vD1
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfRssItemOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _GetQueryOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
							(criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId, Organization_1_Name = Organization_1.Name, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        internal IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
							(criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_1.Id == criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							&&
							(criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Organization_2.Id == criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					group t by new { OrganizationId = t.OrganizationId, Organization_2Id = Organization_2.Id, Name = string.Format("{0} - {1}", Organization_1.Name, Organization_2.Name) } into tG
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IEnumerable<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfOrganization_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,criteriaOfIdOfOrganization_2OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _GetQueryOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByIdentifier(
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _GetQueryOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
							)
						)
					select new MSBuildExtensionPack.DataSourceEntities.Solution.Default { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description, OrganizationId = t.OrganizationId, Organization_1_Name = Organization_1.Name, Organization_1_UniqueIdentifier = Organization_1.UniqueIdentifier, Organization_1_UniqueidentifierColumn = Organization_1.UniqueidentifierColumn, Organization_2_Name = Organization_2.Name, Organization_2Id = Organization_2.Id, Organization_2_UniqueIdentifier = Organization_2.UniqueIdentifier, Organization_2_UniqueidentifierColumn = Organization_2.UniqueidentifierColumn } into vD2
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        internal IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _GetQueryOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection();
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
                    IQueryable<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of ByIdentifier 







	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLL
{
    /// <summary>
    ///  inherit WcfService contract which will take advantage of .Net Wcf,
    ///  consume BusinessLogicLayerMemberShip -- should be removed
    ///  provides Single/Batch Insert/Update/Delete
    ///  query methods based on BusinessLogicLayerRequestMessage, convert data access message to business logic layer response message
    ///  this BLL class targets at entity <see cref="MSBuildExtensionPack.Solution"/>
    /// </summary>
    public partial class SolutionService
        : MSBuildExtensionPack.WcfContracts.ISolutionService
    {
        #region logger of Log4Net

        /// <summary>
        /// logger of Log4Net
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion logger of Log4Net

        #region DALClassInstance && BusinessLogicLayerMemberShip

        /// <summary>
        /// Gets or sets the DAL class instance.
        /// </summary>
        /// <value>
        /// The DAL class instance.
        /// </value>
        MSBuildExtensionPack.DALContracts.ISolutionRepository DALClassInstance { get; set; }

        /// <summary>
        /// Gets or sets the business logic layer member ship.
        /// </summary>
        /// <value>
        /// The business logic layer member ship.
        /// </value>
        public Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract BusinessLogicLayerMemberShip { get; set; }

        #endregion DALClassInstance && BusinessLogicLayerMemberShip

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionService"/> class.
        /// </summary>
        public SolutionService()
            : this(new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        public SolutionService(
            Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
            : this(businessLogicLayerContext.BusinessLogicLayerMemberShip)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public SolutionService(
            Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract _DataAccessLayerFactoryContract = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract>();
            this.DALClassInstance = _DataAccessLayerFactoryContract.CreateDALInstanceOfSolution();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionService"/> class.
        /// </summary>
        /// <param name="dalClassInstance">The dal class instance.</param>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public SolutionService(
            MSBuildExtensionPack.DALContracts.ISolutionRepository dalClassInstance
            , Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            this.DALClassInstance = dalClassInstance;
            this.BusinessLogicLayerMemberShip = businessLogicLayerMemberShip;
        }

        #endregion constructors

        #region InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.SolutionCollection,MSBuildExtensionPack.DataSourceEntities.Solution,MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
                _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.Insert(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                    log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }

            return _retval;
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.Update(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                    log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }

            return _retval;
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.Delete(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                    log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }

            return _retval;
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier id)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;

            if (id != null && id.Criteria != null)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.DeleteByIdentifier(id.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                    log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            return _retval;
        }

        /// <summary>
        /// Batches the insert.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.BatchInsert(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                    log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches the delete.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Batches the update.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
                }
                catch(Exception ex)
                {
                    _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                    _retval.ServerErrorMessage = ex.Message;
                }
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.SolutionCollection,MSBuildExtensionPack.DataSourceEntities.Solution,MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier> Members

        #region Binary Columns

        #endregion Binary Columns

        #region Query Methods Of EntityOfCommon

        /// <summary>
        /// Gets the count of entity of EntityOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId
                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id
                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId
                , request.Criteria.SolutionQueryCriteriaCommon.Name
                , request.Criteria.SolutionQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of EntityOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId
                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id
                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId
                , request.Criteria.SolutionQueryCriteriaCommon.Name
                , request.Criteria.SolutionQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId
                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id
                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId
                , request.Criteria.SolutionQueryCriteriaCommon.Name
                , request.Criteria.SolutionQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId                , request.Criteria.SolutionQueryCriteriaCommon.Name                , request.Criteria.SolutionQueryCriteriaCommon.Description                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of EntityOfCommon

        #region Query Methods Of DefaultOfCommon

        /// <summary>
        /// Gets the count of entity of DefaultOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfDefaultOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId
                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id
                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId
                , request.Criteria.SolutionQueryCriteriaCommon.Name
                , request.Criteria.SolutionQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of DefaultOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfDefaultOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId
                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id
                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId
                , request.Criteria.SolutionQueryCriteriaCommon.Name
                , request.Criteria.SolutionQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId
                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id
                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId
                , request.Criteria.SolutionQueryCriteriaCommon.Name
                , request.Criteria.SolutionQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default());
            }

            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultOfCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.GetSingleOfDefaultOfCommon(
                request.Criteria.SolutionQueryCriteriaCommon.OrganizationId                , request.Criteria.SolutionQueryCriteriaCommon.Organization_2Id                , request.Criteria.SolutionQueryCriteriaCommon.ExternalParentId                , request.Criteria.SolutionQueryCriteriaCommon.Name                , request.Criteria.SolutionQueryCriteriaCommon.Description                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default());
            }

            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultOfCommon

        #region Query Methods Of EntityOfAll

        /// <summary>
        /// Gets the count of entity of EntityOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of EntityOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfAll(
                request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of EntityOfAll

        #region Query Methods Of NameValuePairOfAll

        /// <summary>
        /// Gets the count of entity of NameValuePairOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfNameValuePairOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePairOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfNameValuePairOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePairOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfNameValuePairOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValueCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePairOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.GetSingleOfNameValuePairOfAll(
                request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePairOfAll

        #region Query Methods Of RssItemOfAll

        /// <summary>
        /// Gets the count of entity of RssItemOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfRssItemOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of RssItemOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfRssItemOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItemOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfRssItemOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItemCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItemOfAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.GetSingleOfRssItemOfAll(
                request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of RssItemOfAll

        #region Query Methods Of EntityOfByFKOnly

        /// <summary>
        /// Gets the count of entity of EntityOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of EntityOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of EntityOfByFKOnly

        #region Query Methods Of NameValuePairOfByFKOnly

        /// <summary>
        /// Gets the count of entity of NameValuePairOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfNameValuePairOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePairOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfNameValuePairOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePairOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfNameValuePairOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValueCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePairOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.GetSingleOfNameValuePairOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePairOfByFKOnly

        #region Query Methods Of RssItemOfByFKOnly

        /// <summary>
        /// Gets the count of entity of RssItemOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfRssItemOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of RssItemOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfRssItemOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItemOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfRssItemOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItemCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItemOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.GetSingleOfRssItemOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of RssItemOfByFKOnly

        #region Query Methods Of DefaultOfByFKOnly

        /// <summary>
        /// Gets the count of entity of DefaultOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfDefaultOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of DefaultOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfDefaultOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default());
            }

            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.GetSingleOfDefaultOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default());
            }

            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultOfByFKOnly

        #region Query Methods Of DefaultGroupedDataViewOfByFKOnly

        /// <summary>
        /// Gets the count of entity of DefaultGroupedDataViewOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of DefaultGroupedDataViewOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultGroupedDataViewOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId
                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.DefaultGroupedDataView());
            }

            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultGroupedDataViewOfByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultGroupedDataView _resultFromDAL = this.DALClassInstance.GetSingleOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.SolutionQueryCriteriaByFKOnly.OrganizationId                , request.Criteria.SolutionQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.DefaultGroupedDataView());
            }

            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultGroupedDataViewOfByFKOnly

        #region Query Methods Of EntityOfByIdentifier

        /// <summary>
        /// Gets the count of entity of EntityOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfEntityOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of EntityOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _resultFromDAL = this.DALClassInstance.GetSingleOfEntityOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution, MSBuildExtensionPack.DataSourceEntities.SolutionCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService());
            }

            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of EntityOfByIdentifier

        #region Query Methods Of DefaultOfByIdentifier

        /// <summary>
        /// Gets the count of entity of DefaultOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfDefaultOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of DefaultOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfDefaultOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default());
            }

            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.GetSingleOfDefaultOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default());
            }

            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultOfByIdentifier

        #region Query Methods Of KeyInformationOfByIdentifier

        /// <summary>
        /// Gets the count of entity of KeyInformationOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.GetCountOfKeyInformationOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of KeyInformationOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfKeyInformationOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformationOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfKeyInformationOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformationOfByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.GetSingleOfKeyInformationOfByIdentifier(
                request.Criteria.SolutionQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformationOfByIdentifier

        #region GetAscendantAndDescendant

        #endregion GetAscendantAndDescendant

    }
}


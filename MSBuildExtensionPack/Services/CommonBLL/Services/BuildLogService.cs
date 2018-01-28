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
    ///  this BLL class targets at entity <see cref="MSBuildExtensionPack.BuildLog"/>
    /// </summary>
    public partial class BuildLogService
        : MSBuildExtensionPack.WcfContracts.IBuildLogService
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
        MSBuildExtensionPack.DALContracts.IBuildLogRepository DALClassInstance { get; set; }

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
        /// Initializes a new instance of the <see cref="BuildLogService"/> class.
        /// </summary>
        public BuildLogService()
            : this(new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        public BuildLogService(
            Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
            : this(businessLogicLayerContext.BusinessLogicLayerMemberShip)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BuildLogService(
            Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract _DataAccessLayerFactoryContract = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract>();
            this.DALClassInstance = _DataAccessLayerFactoryContract.CreateDALInstanceOfBuildLog();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogService"/> class.
        /// </summary>
        /// <param name="dalClassInstance">The dal class instance.</param>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BuildLogService(
            MSBuildExtensionPack.DALContracts.IBuildLogRepository dalClassInstance
            , Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            this.DALClassInstance = dalClassInstance;
            this.BusinessLogicLayerMemberShip = businessLogicLayerMemberShip;
        }

        #endregion constructors

        #region InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
                _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.Insert(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.Update(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.Delete(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltInOfIdentifier id)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;

            if (id != null && id.Criteria != null)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.DeleteByIdentifier(id.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.BatchInsert(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
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

        #endregion InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection,MSBuildExtensionPack.DataSourceEntities.BuildLog,MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier> Members

        #region Binary Columns

        #endregion Binary Columns

        #region DataQueryPerQuerySettingCollection

        #region Query Methods Of Entity of Common

        /// <summary>
        /// Gets the count of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId
                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId
                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange
                , request.Criteria.BuildLogQueryCriteriaCommon.Message
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId
                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId
                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange
                , request.Criteria.BuildLogQueryCriteriaCommon.Message
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId
                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId
                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange
                , request.Criteria.BuildLogQueryCriteriaCommon.Message
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange                , request.Criteria.BuildLogQueryCriteriaCommon.Message                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of Common

        #region Query Methods Of Default of Common

        /// <summary>
        /// Gets the count of entity of Default of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId
                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId
                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange
                , request.Criteria.BuildLogQueryCriteriaCommon.Message
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Default of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId
                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId
                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange
                , request.Criteria.BuildLogQueryCriteriaCommon.Message
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId
                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId
                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange
                , request.Criteria.BuildLogQueryCriteriaCommon.Message
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfCommon(
                request.Criteria.BuildLogQueryCriteriaCommon.BuildId                , request.Criteria.BuildLogQueryCriteriaCommon.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaCommon.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaCommon.BuildEventCodeId                , request.Criteria.BuildLogQueryCriteriaCommon.EventTimeRange                , request.Criteria.BuildLogQueryCriteriaCommon.Message                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of Common

        #region Query Methods Of Entity of All

        /// <summary>
        /// Gets the count of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfAll(
                request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of All

        #region Query Methods Of NameValuePair of All

        /// <summary>
        /// Gets the count of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfNameValuePairOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfNameValuePairOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfNameValuePairOfAll(
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.__GetSingleOfNameValuePairOfAll(
                request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePair of All

        #region Query Methods Of RssItem of All

        /// <summary>
        /// Gets the count of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfRssItemOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfRssItemOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfRssItemOfAll(
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItem of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.__GetSingleOfRssItemOfAll(
                request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: __GetSingleOfRssItemOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of RssItem of All

        #region Query Methods Of Entity of ByFKOnly

        /// <summary>
        /// Gets the count of entity of Entity of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of ByFKOnly

        #region Query Methods Of NameValuePair of ByFKOnly

        /// <summary>
        /// Gets the count of entity of NameValuePair of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfNameValuePairOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePair of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfNameValuePairOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfNameValuePairOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.__GetSingleOfNameValuePairOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly

        #region Query Methods Of RssItem of ByFKOnly

        /// <summary>
        /// Gets the count of entity of RssItem of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfRssItemOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of RssItem of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfRssItemOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItem of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetCollectionOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfRssItemOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of RssItem of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection __GetSingleOfRssItemOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.__GetSingleOfRssItemOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.RssItem());
            }

            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of RssItem of ByFKOnly

        #region Query Methods Of Default of ByFKOnly

        /// <summary>
        /// Gets the count of entity of Default of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Default of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of ByFKOnly

        #region Query Methods Of DefaultGroupedDataView of ByFKOnly

        /// <summary>
        /// Gets the count of entity of DefaultGroupedDataView of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of DefaultGroupedDataView of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultGroupedDataView of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id
                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.DefaultGroupedDataView());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultGroupedDataView of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultGroupedDataView _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildId                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Solution_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.Organization_2Id                , request.Criteria.BuildLogQueryCriteriaByFKOnly.BuildEventCodeId                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.DefaultGroupedDataView());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly

        #region Query Methods Of Entity of ByIdentifier

        /// <summary>
        /// Gets the count of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuildLog _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuildLog _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog, MSBuildExtensionPack.DataSourceEntities.BuildLogCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of ByIdentifier

        #region Query Methods Of Default of ByIdentifier

        /// <summary>
        /// Gets the count of entity of Default of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Default of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.Default, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <summary>
        /// Gets the count of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfKeyInformationOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfKeyInformationOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfKeyInformationOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation, MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.BuildLog.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.__GetSingleOfKeyInformationOfByIdentifier(
                request.Criteria.BuildLogQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation, MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation, MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildLogDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #endregion DataQueryPerQuerySettingCollection

        #region GetAscendantAndDescendant

        #endregion GetAscendantAndDescendant

    }
}


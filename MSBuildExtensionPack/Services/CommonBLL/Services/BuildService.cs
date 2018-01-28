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
    ///  this BLL class targets at entity <see cref="MSBuildExtensionPack.Build"/>
    /// </summary>
    public partial class BuildService
        : MSBuildExtensionPack.WcfContracts.IBuildService
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
        MSBuildExtensionPack.DALContracts.IBuildRepository DALClassInstance { get; set; }

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
        /// Initializes a new instance of the <see cref="BuildService"/> class.
        /// </summary>
        public BuildService()
            : this(new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        public BuildService(
            Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
            : this(businessLogicLayerContext.BusinessLogicLayerMemberShip)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BuildService(
            Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract _DataAccessLayerFactoryContract = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract>();
            this.DALClassInstance = _DataAccessLayerFactoryContract.CreateDALInstanceOfBuild();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildService"/> class.
        /// </summary>
        /// <param name="dalClassInstance">The dal class instance.</param>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public BuildService(
            MSBuildExtensionPack.DALContracts.IBuildRepository dalClassInstance
            , Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            this.DALClassInstance = dalClassInstance;
            this.BusinessLogicLayerMemberShip = businessLogicLayerMemberShip;
        }

        #endregion constructors

        #region InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildCollection,MSBuildExtensionPack.DataSourceEntities.Build,MSBuildExtensionPack.DataSourceEntities.BuildIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
                _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            InsertEntity_Pre(request, _retval);

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.Insert(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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
            InsertEntity_Post(request, _retval);
            return _retval;
        }

        partial void InsertEntity_Pre(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn response);
        partial void InsertEntity_Post(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn response);

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.Update(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            DeleteEntity_Pre(request, _retval);

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.Delete(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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

        partial void DeleteEntity_Pre(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn response);

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltInOfIdentifier id)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;

            if (id != null && id.Criteria != null)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.DeleteByIdentifier(id.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.BatchInsert(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
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

        #endregion InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.BuildCollection,MSBuildExtensionPack.DataSourceEntities.Build,MSBuildExtensionPack.DataSourceEntities.BuildIdentifier> Members

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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId
                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange
                , request.Criteria.BuildQueryCriteriaCommon.Name
                , request.Criteria.BuildQueryCriteriaCommon.Description
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId
                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange
                , request.Criteria.BuildQueryCriteriaCommon.Name
                , request.Criteria.BuildQueryCriteriaCommon.Description
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId
                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange
                , request.Criteria.BuildQueryCriteriaCommon.Name
                , request.Criteria.BuildQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange                , request.Criteria.BuildQueryCriteriaCommon.Name                , request.Criteria.BuildQueryCriteriaCommon.Description                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId
                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange
                , request.Criteria.BuildQueryCriteriaCommon.Name
                , request.Criteria.BuildQueryCriteriaCommon.Description
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId
                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange
                , request.Criteria.BuildQueryCriteriaCommon.Name
                , request.Criteria.BuildQueryCriteriaCommon.Description
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId
                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id
                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id
                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange
                , request.Criteria.BuildQueryCriteriaCommon.Name
                , request.Criteria.BuildQueryCriteriaCommon.Description
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfCommon(
                request.Criteria.BuildQueryCriteriaCommon.SolutionId                , request.Criteria.BuildQueryCriteriaCommon.Organization_1Id                , request.Criteria.BuildQueryCriteriaCommon.Organization_2Id                , request.Criteria.BuildQueryCriteriaCommon.BuildStartTimeRange                , request.Criteria.BuildQueryCriteriaCommon.Name                , request.Criteria.BuildQueryCriteriaCommon.Description                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfAll(
                request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfNameValuePairOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfNameValuePairOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfNameValuePairOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.__GetSingleOfNameValuePairOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfRssItemOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfRssItemOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfRssItemOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.__GetSingleOfRssItemOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id
                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.DefaultGroupedDataView());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultGroupedDataView of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataView _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.BuildQueryCriteriaByFKOnly.SolutionId                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_1Id                , request.Criteria.BuildQueryCriteriaByFKOnly.Organization_2Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Build.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.DefaultGroupedDataView());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build, MSBuildExtensionPack.DataSourceEntities.BuildCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of ByIdentifier

        #region Query Methods Of UpdateNameRequest of ByIdentifier

        /// <summary>
        /// Gets the count of entity of UpdateNameRequest of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfUpdateNameRequestOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of UpdateNameRequest of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfUpdateNameRequestOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of UpdateNameRequest of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetCollectionOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfUpdateNameRequestCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfUpdateNameRequestOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.UpdateNameRequest());
            }

            log.Info(string.Format("{0}: __GetCollectionOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of UpdateNameRequest of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest __GetSingleOfUpdateNameRequestOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfUpdateNameRequest _resultFromDAL = this.DALClassInstance.__GetSingleOfUpdateNameRequestOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.UpdateNameRequest());
            }

            log.Info(string.Format("{0}: __GetSingleOfUpdateNameRequestOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of UpdateNameRequest of ByIdentifier

        #region Query Methods Of KeyInformation of ByIdentifier

        /// <summary>
        /// Gets the count of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfKeyInformationOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
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
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfKeyInformationOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfKeyInformationOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.__GetSingleOfKeyInformationOfByIdentifier(
                request.Criteria.BuildQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Build.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #endregion DataQueryPerQuerySettingCollection

        #region GetAscendantAndDescendant

        #endregion GetAscendantAndDescendant

        #region EntityUpdateActionSetting - UpdateNameOnly

        /// <summary>
        /// UpdateNameOnly
        /// Description:
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest UpdateNameOnly(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest _retval = new MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            UpdateNameOnly_Pre(request, _retval);

            if (request != null)
            {
                log.Info(string.Format("{0}: UpdateNameOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                MSBuildExtensionPack.DataSourceEntities.Build.DataAccessLayerMessageOfUpdateNameRequest _resultFromDAL = this.DALClassInstance.UpdateNameOnly(request.Criteria);
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequest, MSBuildExtensionPack.DataSourceEntities.Build.UpdateNameRequestCollection>(_resultFromDAL, _retval);
                log.Info(string.Format("{0}: UpdateNameOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            }
            else
            {
                _retval.BusinessLogicLayerResponseStatus = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.RequestError;
            }

            return _retval;
        }

        partial void UpdateNameOnly_Pre(MSBuildExtensionPack.CommonBLLEntities.BuildRequestMessageUserDefinedUpdateNameOnly request, MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.UpdateNameRequest response);

        #endregion EntityUpdateActionSetting - UpdateNameOnly

    }
}


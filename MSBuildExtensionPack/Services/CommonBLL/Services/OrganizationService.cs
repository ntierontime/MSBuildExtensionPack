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
    ///  this BLL class targets at entity <see cref="MSBuildExtensionPack.Organization"/>
    /// </summary>
    public partial class OrganizationService
        : MSBuildExtensionPack.WcfContracts.IOrganizationService
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
        MSBuildExtensionPack.DALContracts.IOrganizationRepository DALClassInstance { get; set; }

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
        /// Initializes a new instance of the <see cref="OrganizationService"/> class.
        /// </summary>
        public OrganizationService()
            : this(new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        public OrganizationService(
            Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
            : this(businessLogicLayerContext.BusinessLogicLayerMemberShip)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationService"/> class.
        /// </summary>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public OrganizationService(
            Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract _DataAccessLayerFactoryContract = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract>();
            this.DALClassInstance = _DataAccessLayerFactoryContract.CreateDALInstanceOfOrganization();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationService"/> class.
        /// </summary>
        /// <param name="dalClassInstance">The dal class instance.</param>
        /// <param name="businessLogicLayerMemberShip">The business logic layer member ship.</param>
        public OrganizationService(
            MSBuildExtensionPack.DALContracts.IOrganizationRepository dalClassInstance
            , Framework.CommonBLLEntities.BusinessLogicLayerMemberShipContract businessLogicLayerMemberShip)
        {
            this.DALClassInstance = dalClassInstance;
            this.BusinessLogicLayerMemberShip = businessLogicLayerMemberShip;
        }

        #endregion constructors

        #region InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection,MSBuildExtensionPack.DataSourceEntities.Organization,MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier> Members

        /// <summary>
        /// Inserts the specified input.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>a message with action result</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
                _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: InsertEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.Insert(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: UpdateEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.Update(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null && request.Criteria.Count == 1)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.Delete(request.Criteria[0]);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierEntity(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;

            if (id != null && id.Criteria != null)
            {
                try
                {
                    log.Info(string.Format("{0}: DeleteByIdentifierEntity", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.DeleteByIdentifier(id.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.BatchInsert(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn request)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request != null)
            {
                try
                {
                    MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.BatchDelete(request.Criteria);

                    Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
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

        #endregion InsertEntity/UpdateEntity/DeleteEntity/BatchInsert/BatchUpdate/BatchDelete Framework.DAL.DataAccessLayerContractBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection,MSBuildExtensionPack.DataSourceEntities.Organization,MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier> Members

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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId
                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn
                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange
                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Name
                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId
                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn
                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange
                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Name
                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId
                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn
                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange
                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Name
                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.Name                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId
                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn
                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange
                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Name
                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId
                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn
                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange
                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Name
                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId
                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn
                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange
                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange
                , request.Criteria.OrganizationQueryCriteriaCommon.Name
                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn
                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of Common .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfCommon(
                request.Criteria.OrganizationQueryCriteriaCommon.ParentId                , request.Criteria.OrganizationQueryCriteriaCommon.IsSystemBuiltIn                , request.Criteria.OrganizationQueryCriteriaCommon.CreatedDateTimeRange                , request.Criteria.OrganizationQueryCriteriaCommon.BitColumn                , request.Criteria.OrganizationQueryCriteriaCommon.DatetimeColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.Datetime2ColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.SmalldatetimeColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.DateColumnRange                , request.Criteria.OrganizationQueryCriteriaCommon.Name                , request.Criteria.OrganizationQueryCriteriaCommon.CharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.VarcharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.TextColumn                , request.Criteria.OrganizationQueryCriteriaCommon.NcharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.NvarcharColumn                , request.Criteria.OrganizationQueryCriteriaCommon.NtextColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfAll(
                request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of All .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfAll(
                request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfNameValuePairOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfNameValuePairOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfNameValuePairOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.__GetSingleOfNameValuePairOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfRssItemOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfRssItemOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfRssItemOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _resultFromDAL = this.DALClassInstance.__GetSingleOfRssItemOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.RssItem, Framework.RssItemCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.RssItem());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView __GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.DefaultGroupedDataView());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultGroupedDataView of ByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView __GetSingleOfDefaultGroupedDataViewOfByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByFKOnly request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultGroupedDataView _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultGroupedDataViewOfByFKOnly(
                request.Criteria.OrganizationQueryCriteriaByFKOnly.ParentId                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.DefaultGroupedDataView());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfKeyInformationOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
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
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfKeyInformationOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
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
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfKeyInformationOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of ByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfByIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.__GetSingleOfKeyInformationOfByIdentifier(
                request.Criteria.OrganizationQueryCriteriaByIdentifier.Id                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        /// <summary>
        /// Gets the count of entity of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueIdentifier request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueIdentifier.UniqueIdentifier                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueIdentifier

        #region Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
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
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _resultFromDAL = this.DALClassInstance.__GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval);
            }
            else
            {
                //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<Framework.NameValuePair, Framework.NameValueCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.NameValuePair());
            }

            log.Info(string.Format("{0}: __GetSingleOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        /// <summary>
        /// Gets the count of entity of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
                request.Criteria.OrganizationQueryCriteriaUniqueConstraintOfUC_Organization_UniqueidentifierColumn.UniqueidentifierColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of UniqueConstraintOfUC_Organization_UniqueidentifierColumn

        #region Query Methods Of Entity of IdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of Entity of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfEntityOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Entity of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfEntityOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.__GetCollectionOfEntityOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetCollectionOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Entity of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn __GetSingleOfEntityOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityOrganization _resultFromDAL = this.DALClassInstance.__GetSingleOfEntityOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService());
            }

            log.Info(string.Format("{0}: __GetSingleOfEntityOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Entity of IdentifierAndUniqueConstraint

        #region Query Methods Of Default of IdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of Default of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfDefaultOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of Default of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfDefaultOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfDefaultOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetCollectionOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of Default of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default __GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefault _resultFromDAL = this.DALClassInstance.__GetSingleOfDefaultOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default());
            }

            log.Info(string.Format("{0}: __GetSingleOfDefaultOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of Default of IdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        /// <summary>
        /// Gets the count of entity of KeyInformation of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of integer wrapper: <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger"/></returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _resultFromDAL = this.DALClassInstance.__GetCountOfKeyInformationOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<int>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __GetCountOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Exists the of entity of KeyInformation of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.__ExistsOfKeyInformationOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: __ExistsOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.__GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier
                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            //Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval);

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetCollectionOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformation of IdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformation _resultFromDAL = this.DALClassInstance.__GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint(
                request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.Id                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifier                , request.Criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumn                , request.QueryOrderBySettingCollection);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation();
            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;

            if (request.DataServiceType == Framework.DataServiceTypes.DataSourceResult)
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval);
            }
            else
            {
                Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection>(_resultFromDAL, _retval, request.DataServiceType, new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.KeyInformation());
            }

            log.Info(string.Format("{0}: __GetSingleOfKeyInformationOfIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformation of IdentifierAndUniqueConstraint

        #endregion DataQueryPerQuerySettingCollection

        #region GetAscendantAndDescendant

        #region GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

        /// <summary>
        /// Get ascendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a message of <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id)
        {
            log.Info(string.Format("{0}: GetAscendantOfParentIdOfMSBuildExtensionPack_Organization", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection _resultFromDAL = this.DALClassInstance.GetAscendantOfParentIdOfMSBuildExtensionPack_Organization(id.Criteria);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath();

            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetAscendantOfParentIdOfMSBuildExtensionPack_Organization", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Get descendant of item with input identifier;
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>a message of <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath"/></returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath GetDescendantOfParentIdOfMSBuildExtensionPack_Organization (MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier id)
        {
            log.Info(string.Format("{0}: GetAscendantOfParentIdOfMSBuildExtensionPack_Organization", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultWithPathCollection _resultFromDAL = this.DALClassInstance.GetDescendantOfParentIdOfMSBuildExtensionPack_Organization(id.Criteria);
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath _retval = new MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultWithPath();

            _retval.BusinessLogicLayerRequestID = id.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: GetDescendantOfParentIdOfMSBuildExtensionPack_Organization", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion GetAscendantOfParentIdOfMSBuildExtensionPack_Organization && GetDescendantOfParentIdOfMSBuildExtensionPack_Organization

        #endregion GetAscendantAndDescendant

    }
}


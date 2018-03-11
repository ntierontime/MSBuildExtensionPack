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

        #region Query Methods Of DefaultByCommon

        /// <summary>
        /// Gets the collection of entity of DefaultByCommon .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultByCommon(
                request.Criteria.Common.ParentId
                , request.Criteria.Common.IsSystemBuiltIn
                , request.Criteria.Common.CreatedDateTimeRange
                , request.Criteria.Common.BitColumn
                , request.Criteria.Common.DatetimeColumnRange
                , request.Criteria.Common.Datetime2ColumnRange
                , request.Criteria.Common.SmalldatetimeColumnRange
                , request.Criteria.Common.DateColumnRange
                , request.Criteria.Common.Name
                , request.Criteria.Common.CharColumn
                , request.Criteria.Common.VarcharColumn
                , request.Criteria.Common.TextColumn
                , request.Criteria.Common.NcharColumn
                , request.Criteria.Common.NvarcharColumn
                , request.Criteria.Common.NtextColumn
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

            log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of DefaultByFKOnly

        /// <summary>
        /// Gets the collection of entity of DefaultByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultByFKOnly(
                request.Criteria.FKOnly.ParentId
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

            log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultByIdentifier

        /// <summary>
        /// Exists the of entity of DefaultByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfDefaultByIdentifier(
                request.Criteria.Identifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultByIdentifier(
                request.Criteria.Identifier.Id
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

            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of DefaultByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of DefaultByIdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfDefaultByIdentifierAndUniqueConstraint(
                request.Criteria.IdentifierAndUniqueConstraint.Id
                , request.Criteria.IdentifierAndUniqueConstraint.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of DefaultByIdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetCollectionOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfDefaultCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfDefaultByIdentifierAndUniqueConstraint(
                request.Criteria.IdentifierAndUniqueConstraint.Id
                , request.Criteria.IdentifierAndUniqueConstraint.UniqueIdentifier
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

            log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of DefaultByIdentifierAndUniqueConstraint

        #region Query Methods Of EntityByIdentifier

        /// <summary>
        /// Exists the of entity of EntityByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityByIdentifier(
                request.Criteria.Identifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityByIdentifier(
                request.Criteria.Identifier.Id
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

            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of EntityByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of EntityByIdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfEntityByIdentifierAndUniqueConstraint(
                request.Criteria.IdentifierAndUniqueConstraint.Id
                , request.Criteria.IdentifierAndUniqueConstraint.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of EntityByIdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetCollectionOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionOrganization _resultFromDAL = this.DALClassInstance.GetCollectionOfEntityByIdentifierAndUniqueConstraint(
                request.Criteria.IdentifierAndUniqueConstraint.Id
                , request.Criteria.IdentifierAndUniqueConstraint.UniqueIdentifier
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

            log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of EntityByIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationByIdentifier

        /// <summary>
        /// Exists the of entity of KeyInformationByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfKeyInformationByIdentifier(
                request.Criteria.Identifier.Id
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformationByIdentifier .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier request)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfKeyInformationByIdentifier(
                request.Criteria.Identifier.Id
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

            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformationByIdentifier

        #region Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of KeyInformationByIdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns> Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _resultFromDAL = this.DALClassInstance.ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
                request.Criteria.IdentifierAndUniqueConstraint.Id
                , request.Criteria.IdentifierAndUniqueConstraint.UniqueIdentifier
                , request.QueryPagingSetting.CurrentIndex
                , request.QueryPagingSetting.PageSize
                , request.QueryOrderBySettingCollection);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _retval = new Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean();

            _retval.BusinessLogicLayerRequestID = request.BusinessLogicLayerRequestID;
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBaseHelper.MapDataAccessLayerMessageToBusinessLogicLayerResponseMessage<bool>(_resultFromDAL, _retval);
            log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// Gets the collection of entity of KeyInformationByIdentifierAndUniqueConstraint .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation if any</returns>
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint request)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            MSBuildExtensionPack.DataSourceEntities.Organization.DataAccessLayerMessageOfKeyInformationCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(
                request.Criteria.IdentifierAndUniqueConstraint.Id
                , request.Criteria.IdentifierAndUniqueConstraint.UniqueIdentifier
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

            log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

        #region Query Methods Of NameValuePairByAll

        /// <summary>
        /// Gets the collection of entity of NameValuePairByAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfNameValuePairByAll(
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

            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of NameValuePairByFKOnly

        /// <summary>
        /// Gets the collection of entity of NameValuePairByFKOnly .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetCollectionOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly request)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfNameValuePairByFKOnly(
                request.Criteria.FKOnly.ParentId
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

            log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of RssItemByAll

        /// <summary>
        /// Gets the collection of entity of RssItemByAll .
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>an instance of Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection if any</returns>
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll request)
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _resultFromDAL = this.DALClassInstance.GetCollectionOfRssItemByAll(
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

            log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.Business_Logic_Layer_Process_Ended.ToString()));
            return _retval;
        }

        #endregion Query Methods Of RssItemByAll

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


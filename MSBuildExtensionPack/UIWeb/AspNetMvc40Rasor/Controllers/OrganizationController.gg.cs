using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MSBuildExtensionPack.AspNetMvc40ViewModel;
using Framework.EntityContracts;
using Framework.Mvc;
using UrlStringsAlias = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.UrlStrings;

namespace MSBuildExtensionPack.AspNetMvc40Rasor.Controllers
{
    /// <summary>
    /// Mvc Controller of  <see cref="MSBuildExtensionPack.DataSourceEntities.Organization"/>
    /// </summary>
    public partial class OrganizationController : Controller
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region Workspace Controller Methods : there are 1 workspace(s)

        public const string TempDataKey_WPCommonOfOrganization = "TempDataKey_WPCommonOfOrganization";
        /// <summary>
        /// Controller Method of View WPCommonOfOrganization : Description Of Common of MSBuildExtensionPack.Organization
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_WPCommonOfOrganization)]
        public ActionResult WPCommonOfOrganization(int currentPage = 1, WPCommonOfOrganizationVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfOrganization", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfOrganization))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon>)TempData[TempDataKey_WPCommonOfOrganization];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

            viewModel.LoadData(true);

            if (viewModel.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_WPCommonOfOrganization] = viewModel.GetPrimaryInformationEntity();
                TempData.Keep(TempDataKey_WPCommonOfOrganization);
            }
//            else
//            {
//                viewModel.StatusMessageOfResult = searchResult.GetStatusMessage();
//#if DEBUG
//                viewModel.StatusMessageOfResult = string.Format("{0} {1}", viewModel.StatusMessageOfResult, searchResult.ServerErrorMessage);
//#endif
//            }

            if (viewModel.Result != null)
            {
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildExtensionPack.DataSourceEntities.Organization.Default>(viewModel.Result, viewModel.QueryPagingSetting.CurrentPage, viewModel.QueryPagingSetting.PageSize, viewModel.QueryPagingSetting.CountOfRecords);
            }

            viewModel.ContentData.Title = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Organization;
            viewModel.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Description;

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_WPCommonOfOrganization)]
        public ActionResult WPCommonOfOrganization_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfOrganization_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfOrganization))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon>)TempData[TempDataKey_WPCommonOfOrganization];

                var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfCommon(
                    vmFromTempData.Criteria
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
                    , dataServiceType);

                var result = searchResult.DataStreamServiceResult;

                TempData[TempDataKey_WPCommonOfOrganization] = vmFromTempData.GetPrimaryInformationEntity();
                TempData.Keep(TempDataKey_WPCommonOfOrganization);

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfOrganization_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }

        #endregion Workspace Controller Methods : there are 1 workspace(s)

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_WPEntityRelatedOfOrganization)]
        public ActionResult WPEntityRelatedOfOrganization(System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint();
            criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.IdIdentifierAndUniqueConstraintOft.NullableValueToCompare = valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint;
            criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueIdentifierIdentifierAndUniqueConstraintOft.NullableValueToCompare = valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint;
            criteria.OrganizationQueryCriteriaIdentifierAndUniqueConstraint.UniqueidentifierColumnIdentifierAndUniqueConstraintOft.NullableValueToCompare = valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfOrganizationVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfOrganizationVM(criteria);
            vm.LoadData();

            return View(vm);
        }

        #region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
            ViewBag.FileFormat = "Organization_2_UniqueIdentifier,Organization_2_UniqueidentifierColumn,Organization_2_Name,Id,ParentId,Name,IsSystemBuiltIn,UniqueIdentifier,CreatedDateTime,CharColumn,VarcharColumn,TextColumn,NcharColumn,NvarcharColumn,NtextColumn,BitColumn,BinaryColumn,VarbinaryColumn,ImageColumn,TinyintColumn,SmallintColumn,IntColumn,BigintColumn,DecimalColumn,NumericColumn,SmallmoneyColumn,MoneyColumn,FloatColumn,RealColumn,DatetimeColumn,Datetime2Column,SmalldatetimeColumn,DateColumn,TimeColumn,UniqueidentifierColumn";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default dataStreamServiceProvider = new MSBuildExtensionPack.CommonBLL.OrganizationDataStreamService.Default();
                MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
                    MSBuildExtensionPack.DataSourceEntities.OrganizationCollection resultCollection = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
                    MSBuildExtensionPack.EntityContracts.IOrganizationHelper.CopyCollection<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(collection, resultCollection);
                    var result = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchInsert(resultCollection);
                    ViewBag.Message = Framework.Resx.UIStringResource.Data_Import_Success;
                }
                else
                {
                    ViewBag.Message = Framework.Resx.UIStringResource.Data_Import_NoRecordInSourceFile;
                }

                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return View();
            }
            else
            {
                ViewBag.Message = "";
                return View();
            }
        }

        #endregion Import()

        #region Index()

        /// <summary>
        /// default page, redirect to "WPCommonOrganization".
        /// </summary>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfOrganization");
        }

        #endregion Index()

        #region ActionResult Details()

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /Organization/Details/5
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Details)]
        public ActionResult Details(System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM();
            vm.Load(valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, uiAction);
            vm.ContentData.Title = Framework.Resx.UIStringResource.Details;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Details_Organization;

            return View(vm);
        }

        #endregion ActionResult Details()

        #region ActionResult AddNew()

        /// <summary>
        /// GET method of Adds the new <see cref="MSBuildExtensionPack.Organization"/>.
        /// GET: /Organization/AddNew
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_AddNew)]
        public ActionResult AddNew()
        {
            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_OrganizationController_Copy);

            Framework.UIAction uiAction = Framework.UIAction.Create;
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM.CreateNewViewModel(entity);
            vm.LoadExtraData(uiAction);

            return View(vm);
        }

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildExtensionPack.Organization"/>.
        /// POST: /Organization/AddNew
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_AddNew)]
        public ActionResult AddNew(MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm)
        {
            try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildExtensionPack.DataSourceEntities.Organization entity = MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(vm.Item);

                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.InsertEntity(entity);

                TempData[TempDataKey_OrganizationController_Copy] = null;
                TempData.Remove(TempDataKey_OrganizationController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_Organization_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Create;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_OrganizationController_Copy);
                vm = MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }

        public const string TempDataKey_OrganizationController_Copy = "TempDataKey_OrganizationController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildExtensionPack.Organization"/>, without identifier
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Copy)]
        public ActionResult Copy(System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response =
                MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfDefaultOfIdentifierAndUniqueConstraint(valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_OrganizationController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_OrganizationController_Copy);
            }

            return RedirectToAction("AddNew");
        }

        #endregion ActionResult AddNew()

        #region ActionResult Edit()

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildExtensionPack.Organization"/>.
        /// GET: /Organization/Edit/5
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Edit)]
        public ActionResult Edit(System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
        {
            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM();
            vm.Load(valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, uiAction);
            vm.ContentData.Title = Framework.Resx.UIStringResource.Edit;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Edit_Organization;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildExtensionPack.Organization"/>.
        /// POST: /Organization/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Edit)]
        public ActionResult Edit(MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm)
        {
            try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildExtensionPack.DataSourceEntities.Organization entity = MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(vm.Item);
                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.UpdateEntity(entity);

                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_Organization_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resx.UIStringResource.Edit;
                vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Edit_Organization;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

        #endregion ActionResult Edit()

        #region ActionResult Delete()

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildExtensionPack.Organization"/>
        /// GET: /Organization/Delete/5
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Delete)]
        public ActionResult Delete(System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM();
            vm.Load(valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, uiAction);
            vm.ContentData.Title = Framework.Resx.UIStringResource.Delete;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Delete_Organization;
            return View(vm);
        }

        /// <summary>
        /// POST method of delete page of <see cref="MSBuildExtensionPack.Organization"/>
        /// POST: /Organization/Delete/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Organization_Delete)]
        public ActionResult Delete(System.Int64? valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint
            , System.Guid? valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.ExistsOfDefaultOfIdentifierAndUniqueConstraint(valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareIdIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueIdentifierIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint.HasValue, valueToCompareUniqueidentifierColumnIdentifierAndUniqueConstraintOftOfIdentifierAndUniqueConstraint, -1, -1, null);
                if (_Response)
                {
                    MSBuildExtensionPack.DataSourceEntities.Organization entity = MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Organization.Default, MSBuildExtensionPack.DataSourceEntities.Organization>(vm.Item);
                    MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteEntity(entity);
                    log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
                else
                {
                    log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }

                return RedirectToAction("UrlStringsAlias.ActionName_Organization_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resx.UIStringResource.Delete;
                vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Delete_Organization;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

        #endregion ActionResult Delete()

        #region Binary Columns

        #endregion Binary Columns

        #region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction(UrlStringsAlias.ActionName_Organization_Index);
        }

        #endregion GoBackList()

        private MSBuildExtensionPack.DataSourceEntities.Organization.Default CreateEmptyEntityOrGetFromTempData(string tempDataKey_OrganizationController_Copy)
        {
            MSBuildExtensionPack.DataSourceEntities.Organization.Default entity;
            if (TempData.ContainsKey(tempDataKey_OrganizationController_Copy) && TempData[tempDataKey_OrganizationController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildExtensionPack.DataSourceEntities.Organization.Default)TempData[tempDataKey_OrganizationController_Copy];
                    TempData.Keep(tempDataKey_OrganizationController_Copy);
                }
                catch
                {
                    entity = new MSBuildExtensionPack.DataSourceEntities.Organization.Default();
                }
            }
            else
            {
                entity = new MSBuildExtensionPack.DataSourceEntities.Organization.Default();
            }

            return entity;
        }
    }
}


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
    /// Mvc Controller of  <see cref="MSBuildExtensionPack.DataSourceEntities.Solution"/>
    /// </summary>
    public partial class SolutionController : Controller
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region Workspace Controller Methods : there are 1 workspace(s)

        public const string TempDataKey_WPCommonOfSolution = "TempDataKey_WPCommonOfSolution";
        /// <summary>
        /// Controller Method of View WPCommonOfSolution
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_WPCommonOfSolution)]
        public ActionResult WPCommonOfSolution(int currentPage = 1, WPCommonOfSolutionVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfSolution", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfSolution))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon>)TempData[TempDataKey_WPCommonOfSolution];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

            viewModel.LoadData(true);

            if (viewModel.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_WPCommonOfSolution] = viewModel.GetPrimaryInformationEntity();
                TempData.Keep(TempDataKey_WPCommonOfSolution);
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
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildExtensionPack.DataSourceEntities.Solution.Default>(viewModel.Result, viewModel.QueryPagingSetting.CurrentPage, viewModel.QueryPagingSetting.PageSize, viewModel.QueryPagingSetting.CountOfRecords);
            }

            viewModel.ContentData.Title = MSBuildExtensionPack.Resx.UIStringResourcePerApp.MSBuildExtensionPack_Solution_Common_Title;
            viewModel.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerApp.MSBuildExtensionPack_Solution_Common_Summary;

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_WPCommonOfSolution)]
        public ActionResult WPCommonOfSolution_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfSolution_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfSolution))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon>)TempData[TempDataKey_WPCommonOfSolution];

                var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultByCommon(
                    vmFromTempData.Criteria
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
                    , dataServiceType);

                var result = searchResult.DataStreamServiceResult;

                TempData[TempDataKey_WPCommonOfSolution] = vmFromTempData.GetPrimaryInformationEntity();
                TempData.Keep(TempDataKey_WPCommonOfSolution);

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfSolution_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }

        #endregion Workspace Controller Methods : there are 1 workspace(s)

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_WPFullDetailsOfSolution)]
        public ActionResult WPFullDetailsOfSolution(System.Int32? id)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaIdentifier();
            criteria.Identifier.Id.NullableValueToCompare = id;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPFullDetailsOfSolutionVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPFullDetailsOfSolutionVM(criteria);
            vm.LoadData();

            return View(vm);
        }

        #region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
            ViewBag.FileFormat = "Organization_1_UniqueIdentifier,Organization_1_Name,Id,Organization_2Id,Organization_2_UniqueIdentifier,Organization_2_Name,ExternalParentId,Name,Description,OrganizationId";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default dataStreamServiceProvider = new MSBuildExtensionPack.CommonBLL.SolutionDataStreamService.Default();
                MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
                    MSBuildExtensionPack.DataSourceEntities.SolutionCollection resultCollection = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
                    MSBuildExtensionPack.EntityContracts.ISolutionHelper.CopyCollection<MSBuildExtensionPack.DataSourceEntities.Solution.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.SolutionCollection, MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution>(collection, resultCollection);
                    var result = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchInsert(resultCollection);
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
        /// default page, redirect to "WPCommonSolution".
        /// </summary>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfSolution");
        }

        #endregion Index()

        #region ActionResult Details(System.Int32? id)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /Solution/Details/5
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Details)]
        public ActionResult Details(System.Int32? id)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM();
            vm.Load(id.HasValue, id, uiAction);
            vm.ContentData.Title = Framework.Resx.UIStringResource.Details;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.Details_Solution;

            return View(vm);
        }

        #endregion ActionResult Details(System.Int32? id)

        #region ActionResult AddNew()

        /// <summary>
        /// GET method of Adds the new <see cref="MSBuildExtensionPack.Solution"/>.
        /// GET: /Solution/AddNew
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_AddNew)]
        public ActionResult AddNew()
        {
            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_SolutionController_Copy);

            Framework.UIAction uiAction = Framework.UIAction.Create;
            MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM.CreateNewViewModel(entity);
            vm.LoadExtraData(uiAction);

            return View(vm);
        }

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildExtensionPack.Solution"/>.
        /// POST: /Solution/AddNew
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_AddNew)]
        public ActionResult AddNew(MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm)
        {
            try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildExtensionPack.DataSourceEntities.Solution entity = MSBuildExtensionPack.EntityContracts.ISolutionHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution>(vm.Item);

                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.InsertEntity(entity);

                TempData[TempDataKey_SolutionController_Copy] = null;
                TempData.Remove(TempDataKey_SolutionController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_Solution_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Create;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_SolutionController_Copy);
                vm = MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }

        public const string TempDataKey_SolutionController_Copy = "TempDataKey_SolutionController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildExtensionPack.Solution"/>, without identifier
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Copy)]
        public ActionResult Copy(System.Int32? id)
        {
            var _Response =
                MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultByIdentifier(id.HasValue, id, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_SolutionController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_SolutionController_Copy);
            }

            return RedirectToAction("AddNew");
        }

        #endregion ActionResult AddNew()

        #region ActionResult Edit(System.Int32? id)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildExtensionPack.Solution"/>.
        /// GET: /Solution/Edit/5
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Edit)]
        public ActionResult Edit(System.Int32? id)
        {
            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM();
            vm.Load(id.HasValue, id, uiAction);
            vm.ContentData.Title = Framework.Resx.UIStringResource.Edit;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.Edit_Solution;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildExtensionPack.Solution"/>.
        /// POST: /Solution/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Edit)]
        public ActionResult Edit(MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm)
        {
            try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildExtensionPack.DataSourceEntities.Solution entity = MSBuildExtensionPack.EntityContracts.ISolutionHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution>(vm.Item);
                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.UpdateEntity(entity);

                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_Solution_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resx.UIStringResource.Edit;
                vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.Edit_Solution;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

        #endregion ActionResult Edit(System.Int32? id)

        #region ActionResult Delete(System.Int32? id)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildExtensionPack.Solution"/>
        /// GET: /Solution/Delete/5
        /// </summary>
        /// <returns></returns>
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Delete)]
        public ActionResult Delete(System.Int32? id)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM();
            vm.Load(id.HasValue, id, uiAction);
            vm.ContentData.Title = Framework.Resx.UIStringResource.Delete;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.Delete_Solution;
            return View(vm);
        }

        /// <summary>
        /// POST method of delete page of <see cref="MSBuildExtensionPack.Solution"/>
        /// POST: /Solution/Delete/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Solution_Delete)]
        public ActionResult Delete(System.Int32? id, MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.ExistsOfDefaultByIdentifier(id.HasValue, id, -1, -1, null);
                if (_Response)
                {
                    MSBuildExtensionPack.DataSourceEntities.Solution entity = MSBuildExtensionPack.EntityContracts.ISolutionHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Solution.Default, MSBuildExtensionPack.DataSourceEntities.Solution>(vm.Item);
                    MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteEntity(entity);
                    log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
                else
                {
                    log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }

                return RedirectToAction("UrlStringsAlias.ActionName_Solution_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resx.UIStringResource.Delete;
                vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.Delete_Solution;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

        #endregion ActionResult Delete(System.Int32? id)

        #region Binary Columns

        #endregion Binary Columns

        #region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction(UrlStringsAlias.ActionName_Solution_Index);
        }

        #endregion GoBackList()

        private MSBuildExtensionPack.DataSourceEntities.Solution.Default CreateEmptyEntityOrGetFromTempData(string tempDataKey_SolutionController_Copy)
        {
            MSBuildExtensionPack.DataSourceEntities.Solution.Default entity;
            if (TempData.ContainsKey(tempDataKey_SolutionController_Copy) && TempData[tempDataKey_SolutionController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildExtensionPack.DataSourceEntities.Solution.Default)TempData[tempDataKey_SolutionController_Copy];
                    TempData.Keep(tempDataKey_SolutionController_Copy);
                }
                catch
                {
                    entity = new MSBuildExtensionPack.DataSourceEntities.Solution.Default();
                }
            }
            else
            {
                entity = new MSBuildExtensionPack.DataSourceEntities.Solution.Default();
            }

            return entity;
        }
    }
}


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
    /// Mvc Controller of  <see cref="MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>
    /// </summary>
    public partial class BuildEventCodeController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuildEventCode = "TempDataKey_WPCommonOfBuildEventCode";
        /// <summary>
        /// Controller Method of View WPCommonOfBuildEventCode : Description Of Common of MSBuildExtensionPack.BuildEventCode
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_WPCommonOfBuildEventCode)]
		public ActionResult WPCommonOfBuildEventCode(int currentPage = 1 , WPCommonOfBuildEventCodeVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildEventCode", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildEventCode))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildEventCode];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);


            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

			viewModel.LoadData(true);

            if (viewModel.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				TempData[TempDataKey_WPCommonOfBuildEventCode] = viewModel.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuildEventCode); 
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
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildExtensionPack.DataSourceEntities.BuildEventCode>(viewModel.Result, viewModel.QueryPagingSetting.CurrentPage, viewModel.QueryPagingSetting.PageSize, viewModel.QueryPagingSetting.CountOfRecords);
            }

			viewModel.ContentData.Title = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.BuildEventCode;
            viewModel.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Description;

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_WPCommonOfBuildEventCode)]
        public ActionResult WPCommonOfBuildEventCode_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuildEventCode_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuildEventCode))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuildEventCode];

	            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfCommon(
		            new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon(vmFromTempData.Criteria)
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
					, dataServiceType);

                var result = searchResult.DataStreamServiceResult;

				TempData[TempDataKey_WPCommonOfBuildEventCode] = vmFromTempData.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuildEventCode); 

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfBuildEventCode_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }





		#endregion Workspace Controller Methods : there are 1 workspace(s)
		

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_WPEntityRelatedOfBuildEventCode)]
        public ActionResult WPEntityRelatedOfBuildEventCode(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM(new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }






		#region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Id,EventCode,Description";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildExtensionPack.CommonBLL.BuildEventCodeDataStreamService dataStreamServiceProvider = new MSBuildExtensionPack.CommonBLL.BuildEventCodeDataStreamService();
                MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection resultCollection = collection;
                    var result = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.BatchInsert(resultCollection);
					ViewBag.Message = Framework.Resources.UIStringResource.Data_Import_Success;
                }
                else
                {
                    ViewBag.Message = Framework.Resources.UIStringResource.Data_Import_NoRecordInSourceFile;
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
        /// default page, redirect to "WPCommonBuildEventCode".
        /// </summary>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuildEventCode");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /BuildEventCode/Details/5
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Details)]
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM();
			vm.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DetailsAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Details_BuildEventCode;

            return View(vm);
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

		/// <summary>
        /// GET method of Adds the new <see cref="MSBuildExtensionPack.BuildEventCode"/>.
        /// GET: /BuildEventCode/AddNew 
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_AddNew)]
        public ActionResult AddNew()
        {
            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildEventCodeController_Copy);

			Framework.UIAction uiAction = Framework.UIAction.Create;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM.CreateNewViewModel(entity);
            vm.LoadExtraData(uiAction);

            return View(vm);
        } 

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildExtensionPack.BuildEventCode"/>.
        /// POST: /BuildEventCode/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_AddNew)]
        public ActionResult AddNew(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm)
        {
			try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildExtensionPack.DataSourceEntities.BuildEventCode entity = vm.Item;

                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.InsertEntity(entity);



				TempData[TempDataKey_BuildEventCodeController_Copy] = null;
                TempData.Remove(TempDataKey_BuildEventCodeController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_BuildEventCode_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Create;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildEventCodeController_Copy);
                vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }
        
        public const string TempDataKey_BuildEventCodeController_Copy = "TempDataKey_BuildEventCodeController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildExtensionPack.BuildEventCode"/>, without identifier
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Copy)]
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn _Response =
                MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildEventCodeController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildEventCodeController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildExtensionPack.BuildEventCode"/>.
        /// GET: /BuildEventCode/Edit/5
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM();
			vm.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Edit_BuildEventCode;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildExtensionPack.BuildEventCode"/>.
        /// POST: /BuildEventCode/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Edit)]
        public ActionResult Edit(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm)
        {
		    try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildExtensionPack.DataSourceEntities.BuildEventCode entity = vm.Item;
                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.UpdateEntity(entity);


                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_BuildEventCode_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
                vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Edit_BuildEventCode;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildExtensionPack.BuildEventCode"/>
        /// GET: /BuildEventCode/Delete/5
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM();
			vm.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Delete_BuildEventCode;
            return View(vm);
        }
		
        /// <summary>
        /// POST method of delete page of <see cref="MSBuildExtensionPack.BuildEventCode"/>
        /// POST: /BuildEventCode/Delete/5
        /// </summary>
        /// <returns></returns>
		[HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_BuildEventCode_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.ExistsOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response)
                {
					MSBuildExtensionPack.DataSourceEntities.BuildEventCode entity = vm.Item;
                    MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.DeleteEntity(entity);
					log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("UrlStringsAlias.ActionName_BuildEventCode_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
                vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Delete_BuildEventCode;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            } 
        }

		#endregion ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier)
		
		#region Binary Columns



        #endregion Binary Columns

		#region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction(UrlStringsAlias.ActionName_BuildEventCode_Index);
        }

		#endregion GoBackList()

        private MSBuildExtensionPack.DataSourceEntities.BuildEventCode CreateEmptyEntityOrGetFromTempData(string tempDataKey_BuildEventCodeController_Copy)
        {
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode entity;
            if (TempData.ContainsKey(tempDataKey_BuildEventCodeController_Copy) && TempData[tempDataKey_BuildEventCodeController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildExtensionPack.DataSourceEntities.BuildEventCode)TempData[tempDataKey_BuildEventCodeController_Copy];
                    TempData.Keep(tempDataKey_BuildEventCodeController_Copy);
                }
                catch
                {
                    entity = new MSBuildExtensionPack.DataSourceEntities.BuildEventCode();
                }
            }
            else
            {
                entity = new MSBuildExtensionPack.DataSourceEntities.BuildEventCode();
            }

            return entity;
        }
    }
}


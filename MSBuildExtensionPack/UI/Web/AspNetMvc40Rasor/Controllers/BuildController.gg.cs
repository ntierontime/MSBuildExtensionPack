using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MSBuildExtensionPack.AspNetMvc40ViewModel;
using Framework.EntityContracts;
using UrlStringsAlias = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.UrlStrings;

namespace MSBuildExtensionPack.AspNetMvc40Rasor.Controllers
{
    /// <summary>
    /// Mvc Controller of  <see cref="MSBuildExtensionPack.DataSourceEntities.Build"/>
    /// </summary>
    public partial class BuildController : Controller
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

		#region Workspace Controller Methods : there are 1 workspace(s)


		
		public const string TempDataKey_WPCommonOfBuild = "TempDataKey_WPCommonOfBuild";
        /// <summary>
        /// Controller Method of View WPCommonOfBuild : Description Of Common of MSBuildExtensionPack.Build
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPCommonOfBuild)]
		public ActionResult WPCommonOfBuild(int currentPage = 1 ,string lowerBoundBuildStartTimeCommonOftOfCommon = null, string upperBoundBuildStartTimeCommonOftOfCommon = null, WPCommonOfBuildVM viewModel = null)
        {
            log.Info(string.Format("{0}: WPCommonOfBuild", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuild))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuild];
            }
            else
            {
                vmFromTempData = null;
            }

            viewModel.PopulateAllUIElements(vmFromTempData, currentPage);

			viewModel.Criteria.LowerBoundBuildStartTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundBuildStartTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundBuildStartTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundBuildStartTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundBuildStartTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundBuildStartTimeCommonOftOfCommon);
            //viewModel.Criteria.LowerBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(lowerBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(lowerBoundCreatedDateTimeCommonOftOfCommon); viewModel.Criteria.UpperBoundCreatedDateTimeCommonOftOfCommon = string.IsNullOrWhiteSpace(upperBoundCreatedDateTimeCommonOftOfCommon) ? DateTime.MinValue : Framework.DateTimePeriodHelper.ParseDateTime(upperBoundCreatedDateTimeCommonOftOfCommon);

            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(
                new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon(viewModel.Criteria)
                , viewModel.QueryPagingSetting
                , viewModel.QueryOrderBySettingCollection);


            viewModel.StatusOfResult = searchResult.BusinessLogicLayerResponseStatus;

            if (viewModel.StatusOfResult == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				viewModel.Result = searchResult.Message;

				if (searchResult.QueryPagingResult != null)
				{
					viewModel.QueryPagingSetting.CountOfRecords = searchResult.QueryPagingResult.CountOfRecords;
					viewModel.QueryPagingSetting.RecordCountOfCurrentPage = searchResult.QueryPagingResult.RecordCountOfCurrentPage;
				}

				TempData[TempDataKey_WPCommonOfBuild] = viewModel.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuild); 
			}
            else
            {
                viewModel.StatusMessageOfResult = searchResult.GetStatusMessage();
#if DEBUG
                viewModel.StatusMessageOfResult = string.Format("{0} {1}", viewModel.StatusMessageOfResult, searchResult.ServerErrorMessage);
#endif
            }

			if (viewModel.Result != null)
            {
                ViewBag.StaticPagedResult = new PagedList.StaticPagedList<MSBuildExtensionPack.DataSourceEntities.Build.Default>(viewModel.Result, viewModel.QueryPagingSetting.CurrentPage, viewModel.QueryPagingSetting.PageSize, viewModel.QueryPagingSetting.CountOfRecords);
            }

			viewModel.ContentData.Title = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Build;
            viewModel.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Description;

            return View(viewModel);
        }

        /// <summary>
        /// Export current search result.
        /// </summary>
        /// <param name="dataServiceType">Type of the data service.</param>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPCommonOfBuild)]
        public ActionResult WPCommonOfBuild_Export(Framework.DataServiceTypes dataServiceType)
        {
            log.Info(string.Format("{0}: WPCommonOfBuild_Export", Framework.LoggingOptions.UI_Process_Started.ToString()));

            Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten> vmFromTempData;
            if (TempData.ContainsKey(TempDataKey_WPCommonOfBuild))
            {
                vmFromTempData = (Framework.ViewModels.ViewModelBase<MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten>)TempData[TempDataKey_WPCommonOfBuild];

	            var searchResult = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfCommon(
		            new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon(vmFromTempData.Criteria)
                    , new Framework.EntityContracts.QueryPagingSetting(-1, -1)
                    , new Framework.EntityContracts.QueryOrderBySettingCollection(vmFromTempData.QueryOrderBySettingCollecionInString)
					, dataServiceType);

                var result = searchResult.DataStreamServiceResult;

				TempData[TempDataKey_WPCommonOfBuild] = vmFromTempData.GetPrimaryInformationEntity();
				TempData.Keep(TempDataKey_WPCommonOfBuild); 

                return File(result.Result, result.MIMEType, string.Format("WPCommonOfBuild_Export{0}{1}", result.DataServiceType, result.FileExtension));
            }

            return null;
        }





		#endregion Workspace Controller Methods : there are 1 workspace(s)
		

        /// <summary>
        /// Display one entity and all related entities if any, either single item or a list, based on foreign keys
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPEntityRelatedOfBuild)]
        public ActionResult WPEntityRelatedOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }




		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPUpdateNameOnlyOfBuild)]
        public ActionResult WPUpdateNameOnlyOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {

            MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            vm.LoadData();

            return View(vm);
        }

        // POST: /Build/WPUpdateNameOnlyOfBuild/5
        [HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_WPUpdateNameOnlyOfBuild)]
        public ActionResult WPUpdateNameOnlyOfBuild(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm)
        {

            if (vm != null)
            {
                vm.SaveData();
            }

            return View(vm);
        }




		#region Import()

        /// <summary>
        /// Imports a list of entity from csv or excel file
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Import)]
        public ActionResult Import(HttpPostedFileBase file)
        {
			ViewBag.FileFormat = "Solution_1_Name,Id,SolutionId,Name,Description,BuildStartTime";
            if (file != null && file.ContentLength > 0 && !string.IsNullOrWhiteSpace(file.FileName))
            {
                log.Info(string.Format("{0}: Import", Framework.LoggingOptions.UI_Process_Started.ToString()));

                Framework.DataStreamServiceResult dataStreamServiceResult = new Framework.DataStreamServiceResult(file.FileName, file.ContentType, file.ContentLength, file.InputStream);
                dataStreamServiceResult.TempFilePath = Framework.Web.WebFormApplicationApplicationVariables.FileStorageRootFolder;
                MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default dataStreamServiceProvider = new MSBuildExtensionPack.CommonBLL.BuildDataStreamService.Default();
                MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection collection = dataStreamServiceProvider.GetCollectionFromStream(dataStreamServiceResult);

                if (collection != null)
                {
					MSBuildExtensionPack.DataSourceEntities.BuildCollection resultCollection = new MSBuildExtensionPack.DataSourceEntities.BuildCollection();
					MSBuildExtensionPack.EntityContracts.IBuildHelper.CopyCollection<MSBuildExtensionPack.DataSourceEntities.Build.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.BuildCollection, MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(collection, resultCollection);
                    var result = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchInsert(resultCollection);
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
        /// default page, redirect to "WPCommonBuild".
        /// </summary>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Index)]
        public ActionResult Index()
        {
            return RedirectToAction("WPCommonOfBuild");
        }

		#endregion Index()

		#region ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of details page, based on identifier or unique constraint, this entity only, no related entities.
        /// GET: /Build/Details/5
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Details)]
        public ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DetailsAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Details_Build;

            return View(vm);
        }

		#endregion ActionResult Details(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult AddNew()

		/// <summary>
        /// GET method of Adds the new <see cref="MSBuildExtensionPack.Build"/>.
        /// GET: /Build/AddNew 
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_AddNew)]
        public ActionResult AddNew()
        {
            Framework.NameValueCollection nameValueCollectionOfMSBuildExtensionPack_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildExtensionPack_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildExtensionPack_Solution);


            var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildController_Copy);

            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM.CreateNewViewModel(entity);

            return View(vm);
        } 

        /// <summary>
        /// Post method of Adds the new <see cref="MSBuildExtensionPack.Build"/>.
        /// POST: /Build/AddNew 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_AddNew)]
        public ActionResult AddNew(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm)
        {
			try
            {
                log.Info(string.Format("{0}: AddNew", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildExtensionPack.DataSourceEntities.Build entity = MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(vm.Item);

                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.InsertEntity(entity);



				TempData[TempDataKey_BuildController_Copy] = null;
                TempData.Remove(TempDataKey_BuildController_Copy);
                log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.UI_Process_Ended.ToString()));

                return RedirectToAction(UrlStringsAlias.ActionName_Build_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.ViewDetails;
                var entity = CreateEmptyEntityOrGetFromTempData(TempDataKey_BuildController_Copy);
                vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM.CreateNewViewModel(entity);
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: AddNew: {1}", Framework.LoggingOptions.Business_Logic_Layer_Process_Failed.ToString(), ex.Message));
                return View(vm);
            }
        }
        
        public const string TempDataKey_BuildController_Copy = "TempDataKey_BuildController_Copy";
        /// <summary>
        /// Copies current <see cref="MSBuildExtensionPack.Build"/>, without identifier
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Copy)]
        public ActionResult Copy(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn.Default _Response =
                MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                TempData[TempDataKey_BuildController_Copy] = _Response.Message[0];
                TempData.Keep(TempDataKey_BuildController_Copy);
            }

            return RedirectToAction("AddNew");
        } 

		#endregion ActionResult AddNew()

		#region ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of editing page of <see cref="MSBuildExtensionPack.Build"/>.
        /// GET: /Build/Edit/5
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Edit)]
        public ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.NameValueCollection nameValueCollectionOfMSBuildExtensionPack_Solution = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
			ViewBag.SelectListOfMSBuildExtensionPack_Solution = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(nameValueCollectionOfMSBuildExtensionPack_Solution);


            Framework.UIAction uiAction = Framework.UIAction.Update;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Edit_Build;

            return View(vm);
        }

        /// <summary>
        /// POST method of editing page of <see cref="MSBuildExtensionPack.Build"/>.
        /// POST: /Build/Edit/5
        /// </summary>
        /// <returns></returns>
        [HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Edit)]
        public ActionResult Edit(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm)
        {
		    try
            {
                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Started.ToString()));

				MSBuildExtensionPack.DataSourceEntities.Build entity = MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(vm.Item);
                var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.UpdateEntity(entity);


                log.Info(string.Format("{0}: Edit", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                return RedirectToAction(UrlStringsAlias.ActionName_Build_Index);
            }
            catch(Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Update;
                vm.ContentData.Title = Framework.Resources.UIStringResource.EditAlternativeText;
                vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Edit_Build;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            }
        }

		#endregion ActionResult Edit(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

		#region ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)

        /// <summary>
        /// GET method of delete page of <see cref="MSBuildExtensionPack.Build"/>
        /// GET: /Build/Delete/5
        /// </summary>
        /// <returns></returns>
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
        {
            Framework.UIAction uiAction = Framework.UIAction.Delete;
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm = MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM.Load(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, uiAction);
            vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Delete_Build;
            return View(vm);
        }
		
        /// <summary>
        /// POST method of delete page of <see cref="MSBuildExtensionPack.Build"/>
        /// POST: /Build/Delete/5
        /// </summary>
        /// <returns></returns>
		[HttpPost]
		[MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.WebAuthorizationAttribute(Permissions = MSBuildExtensionPack.AspNetMvc40Rasor.Helpers.PermissionVariables.PermissionName_Build_Delete)]
        public ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier, MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM vm, FormCollection collection)
        {
            try
            {
                log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Started.ToString()));
				var _Response = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.ExistsOfEntityOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);
				if (_Response)
                {
					MSBuildExtensionPack.DataSourceEntities.Build entity = MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<MSBuildExtensionPack.DataSourceEntities.Build.Default, MSBuildExtensionPack.DataSourceEntities.Build>(vm.Item);
                    MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteEntity(entity);
					log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.UI_Process_Ended.ToString()));
                }
				else
				{
					log.Warn(string.Format("{0}: Delete, Entity not exists",  Framework.LoggingOptions.UI_Process_Ended.ToString()));
				}

                return RedirectToAction("UrlStringsAlias.ActionName_Build_Index");
            }
            catch (Exception ex)
            {
                Framework.UIAction uiAction = Framework.UIAction.Delete;
                vm.ContentData.Title = Framework.Resources.UIStringResource.DeleteAlternativeText;
                vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Delete_Build;
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));

                return View(vm);
            } 
        }

		#endregion ActionResult Delete(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier)
		
		#region Binary Columns



        #endregion Binary Columns

		#region GoBackList()

        public ActionResult GoBackList()
        {
            return RedirectToAction(UrlStringsAlias.ActionName_Build_Index);
        }

		#endregion GoBackList()

        private MSBuildExtensionPack.DataSourceEntities.Build.Default CreateEmptyEntityOrGetFromTempData(string tempDataKey_BuildController_Copy)
        {
            MSBuildExtensionPack.DataSourceEntities.Build.Default entity;
            if (TempData.ContainsKey(tempDataKey_BuildController_Copy) && TempData[tempDataKey_BuildController_Copy] != null)
            {
                try
                {
                    entity = (MSBuildExtensionPack.DataSourceEntities.Build.Default)TempData[tempDataKey_BuildController_Copy];
                    TempData.Keep(tempDataKey_BuildController_Copy);
                }
                catch
                {
                    entity = new MSBuildExtensionPack.DataSourceEntities.Build.Default();
                }
            }
            else
            {
                entity = new MSBuildExtensionPack.DataSourceEntities.Build.Default();
            }

            return entity;
        }
    }
}


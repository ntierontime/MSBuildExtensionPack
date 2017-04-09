using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.AspNetMvc40ApiController.ApiControllers.ApiControllers
{
    /// <summary>

    /// </summary>
    public partial class BuildLogApiController : ApiController
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
		[HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpDelete, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpDelete, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildLog input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

		/// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
		[HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn DeleteByIdentifier(
			System.Int64 id
			)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier(
				id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchUpdate(input);

				return responseMessage;
            });
            return await resultTask;
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchInsert(input);

				return responseMessage;
            });
            return await resultTask;
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildLog"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildLogCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.BatchDelete(input);

				return responseMessage;
            });
            return await resultTask;
        }

        #endregion batch insert, update and delete in an entity collection



        #region Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfAll")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfAll")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of All per value type




        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetCollectionOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfBuild_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuild_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuild_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">will compare/filter IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfBuildEventCode_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfBuild_1OfByFKOnly, System.Int64 valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, bool isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfBuild_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly
				, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly && valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type





        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.BuildLog.
        /// http://[host]/api/BuildLogApi/GetBuildLogItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
		public MSBuildExtensionPack.ViewModelData.BuildLogItemVM GetBuildLogItemVM(
            System.Int64 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildLogItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildLogItemVM();
            retval.Load(true, id, Framework.UIAction.ViewDetails);
            return retval;
        }




        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.BuildLog: WPCommonOfBuildLogVM.
        /// http://[host]/api/BuildLogApi/GetWPCommonOfBuildLogVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfBuildLogVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfBuildLogVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM GetWPCommonOfBuildLogVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfBuildLogVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildLogVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildLogVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaCommonFlatten();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }




        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.BuildLog: WPEntityRelatedOfBuildLogVM.
        /// http://[host]/api/BuildLogApi/GetWPEntityRelatedOfBuildLogVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfBuildLogVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildLogVM GetWPEntityRelatedOfBuildLogVM(
            System.Int64 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildLogVM(new MSBuildExtensionPack.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier(true, id));
            retval.LoadData();
            return retval;
        }





    }
}


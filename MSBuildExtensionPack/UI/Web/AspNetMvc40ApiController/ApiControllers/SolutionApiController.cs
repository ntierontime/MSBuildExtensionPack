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
    public partial class SolutionApiController : ApiController
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">input entity</param>
		[HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpDelete, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpDelete, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

		/// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
		[HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifier(
			System.Int32 id
			)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(
				id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchUpdate(input);

				return responseMessage;
            });
            return await resultTask;
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchInsert(input);

				return responseMessage;
            });
            return await resultTask;
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCSolution.BatchDelete(input);

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
			return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetCollectionOfNameValuePairOfAll(				currentIndex
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
			return MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of All per value type





        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Solution.
        /// http://[host]/api/SolutionApi/GetSolutionItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
		public MSBuildExtensionPack.ViewModelData.SolutionItemVM GetSolutionItemVM(
            System.Int32 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.SolutionItemVM();
            retval.Load(true, true, id, Framework.UIAction.ViewDetails);
            return retval;
        }




        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.Solution: WPCommonOfSolutionVM.
        /// http://[host]/api/SolutionApi/GetWPCommonOfSolutionVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfSolutionVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfSolutionVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM GetWPCommonOfSolutionVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfSolutionVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfSolutionVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfSolutionVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommonFlatten();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }




        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.Solution: WPEntityRelatedOfSolutionVM.
        /// http://[host]/api/SolutionApi/GetWPEntityRelatedOfSolutionVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfSolutionVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfSolutionVM GetWPEntityRelatedOfSolutionVM(
            System.Int32 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfSolutionVM(new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(true, id));
            retval.LoadData();
            return retval;
        }





    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.AspNetMvc40ApiController.ApiControllers
{
    /// <summary>

    /// </summary>
    public partial class BuildApiController : ApiController
    {
		#region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
		[HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpDelete, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpDelete, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Build input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

		/// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
		[HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn DeleteByIdentifier(
			System.Int64 id
			)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildIdentifier(
				id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchUpdate(input);

				return responseMessage;
            });
            return await resultTask;
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchInsert(input);

				return responseMessage;
            });
            return await resultTask;
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Build"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
		[HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn>(() =>
            {
				MSBuildExtensionPack.CommonBLLEntities.BuildResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuild.BatchDelete(input);

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
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfAll(				currentIndex
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
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfAll(				currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of All per value type




        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
		[HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfSolution_1OfByFKOnly">will compare/filter IdByFKOnlyOfSolution_1OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly">value to compare/filter with IdByFKOnlyOfSolution_1OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
		[HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
			bool isToCompareIdByFKOnlyOfSolution_1OfByFKOnly, System.Int32 valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairOfByFKOnly(				isToCompareIdByFKOnlyOfSolution_1OfByFKOnly && valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly != default(System.Int32), valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly
				, currentIndex
				, pageSize
				, queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type





        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Build.
        /// http://[host]/api/BuildApi/GetBuildItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
		public MSBuildExtensionPack.ViewModelData.BuildItemVM GetBuildItemVM(
            System.Int64 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM();
            retval.Load(true, id, Framework.UIAction.ViewDetails);
            return retval;
        }




        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.Build: WPCommonOfBuildVM.
        /// http://[host]/api/BuildApi/GetWPCommonOfBuildVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfBuildVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM GetWPCommonOfBuildVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfBuildVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommonFlatten();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }




        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.Build: WPEntityRelatedOfBuildVM.
        /// http://[host]/api/BuildApi/GetWPEntityRelatedOfBuildVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildVM GetWPEntityRelatedOfBuildVM(
            System.Int64 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildVM(new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(true, id));
            retval.LoadData();
            return retval;
        }




		#region EntityUpdateActionSetting - UpdateNameOnly

        /// <summary>
        /// Gets UpdateNameOnly view model of MSBuildExtensionPack.Build: WPUpdateNameOnlyOfBuild.
        /// http://[host]/api/BuildApi/WPUpdateNameOnlyOfBuildVM?
        /// </summary>
        /// <returns></returns>
		[HttpGet, ActionName("GetWPUpdateNameOnlyOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM GetWPUpdateNameOnlyOfBuildVM(
            System.Int64 id
            )
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM();
            vm.CriteriaOfMasterEntity = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier(true, id);
            vm.LoadData();
            return vm;
        }

        /// <summary>
        /// Post method WPUpdateNameOnlyOfBuild.
        /// http://[host]/api/BuildApi/WPUpdateNameOnlyOfBuildVM
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost, ActionName("WPUpdateNameOnlyOfBuildVM")]
        public MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM WPUpdateNameOnlyOfBuildVM(MSBuildExtensionPack.ViewModelData.WPUpdateNameOnlyOfBuildVM input)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM vm = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPUpdateNameOnlyOfBuildVM(input.CriteriaOfMasterEntity);
            vm.MasterEntity = input.MasterEntity;
            vm.SaveData();

            return vm;
        }

        #endregion EntityUpdateActionSetting - UpdateNameOnlyVM



    }
}


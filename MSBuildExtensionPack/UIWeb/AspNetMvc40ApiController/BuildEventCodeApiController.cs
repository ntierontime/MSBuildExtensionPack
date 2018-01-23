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
    public partial class BuildEventCodeApiController : ApiController
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.BuildEventCode input)
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
        [HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn DeleteByIdentifier(
            System.Int32 id
            )
        {
            MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.BuildEventCodeIdentifier(
                id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.BatchUpdate(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.BatchInsert(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.BuildEventCode"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.BuildEventCodeCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.BatchDelete(input);

                return responseMessage;
            });
            return await resultTask;
        }

        #endregion batch insert, update and delete in an entity collection

        #region Query Methods Of NameValuePair of All per criteria, queryPagingSetting and queryOrderBySettingCollection

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
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfNameValuePairOfAll(                currentIndex
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
            , string queryOrderByExpression        )

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetMessageOfNameValuePairOfAll(                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of All per value type

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.BuildEventCode.
        /// http://[host]/api/BuildEventCodeApi/GetBuildEventCodeItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.BuildEventCodeItemVM GetBuildEventCodeItemVM(
System.Int32? id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildEventCodeItemVM();
            retval.Load(id.HasValue, id, Framework.UIAction.ViewDetails);
            return retval;
        }

        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.BuildEventCode: WPCommonOfBuildEventCodeVM.
        /// http://[host]/api/BuildEventCodeApi/GetWPCommonOfBuildEventCodeVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfBuildEventCodeVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfBuildEventCodeVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM GetWPCommonOfBuildEventCodeVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfBuildEventCodeVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildEventCodeVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfBuildEventCodeVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.BuildEventCode: WPEntityRelatedOfBuildEventCodeVM.
        /// http://[host]/api/BuildEventCodeApi/GetWPEntityRelatedOfBuildEventCodeVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfBuildEventCodeVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfBuildEventCodeVM GetWPEntityRelatedOfBuildEventCodeVM(
System.Int32? id)
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier();
            criteria.BuildEventCodeQueryCriteriaByIdentifier.Id.NullableValueToCompare = id;
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfBuildEventCodeVM(criteria);
            retval.LoadData();
            return retval;
        }

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/BuildEventCodeApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


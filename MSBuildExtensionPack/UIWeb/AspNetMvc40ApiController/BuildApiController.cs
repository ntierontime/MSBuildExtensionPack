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
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
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
        [HttpPut, ActionName("DeleteEntity")]
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

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of NameValuePairByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetCollectionOfNameValuePairByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="solutionId">value to compare/filter with solutionId property/field/column</param>
        /// <param name="organization_1Id">value to compare/filter with organization_1Id property/field/column</param>
        /// <param name="organization_2Id">value to compare/filter with organization_2Id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByFKOnly(
            System.Int32? solutionId
            , System.Int64? organization_1Id
            , System.Int64? organization_2Id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCBuild.GetMessageOfNameValuePairByFKOnly(
                solutionId.HasValue, solutionId
                , organization_1Id.HasValue, organization_1Id
                , organization_2Id.HasValue, organization_2Id
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairByFKOnly

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Build.
        /// http://[host]/api/BuildApi/GetBuildItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.BuildItemVM GetBuildItemVM(
System.Int64? id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.BuildItemVM();
            retval.Load(id.HasValue, id, Framework.UIAction.ViewDetails);
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
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/BuildApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


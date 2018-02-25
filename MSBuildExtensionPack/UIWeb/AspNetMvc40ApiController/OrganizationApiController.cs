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
    public partial class OrganizationApiController : ApiController
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPost, ActionName("InsertEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.InsertEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("UpdateEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.UpdateEntity(input);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        [HttpPut, ActionName("DeleteByIdentifierEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteByIdentifierEntity(identifier);

            return responseMessage;
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        [HttpPut, ActionName("DeleteEntity")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteEntity(input);

            return responseMessage;
        }

        #endregion insert, update and delete in an entity

        #region delete using .Net value types

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        [HttpDelete, ActionName("DeleteByIdentifier")]
        public MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(
                id));

            return responseMessage;
        }

        #endregion delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        [HttpPut, ActionName("BatchUpdate")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchUpdate(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchUpdate(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpPost, ActionName("BatchInsert")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchInsert(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchInsert(input);

                return responseMessage;
            });
            return await resultTask;
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        [HttpDelete, ActionName("BatchDelete")]
        public async Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> BatchDelete(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            Task<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn> resultTask = Task.Factory.StartNew<MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn>(() =>
            {
                MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn responseMessage = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.BatchDelete(input);

                return responseMessage;
            });
            return await resultTask;
        }

        #endregion batch insert, update and delete in an entity collection

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- Start

        #region Query Methods Of NameValuePairByAll

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairByAll")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairByAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairByAll(
                currentIndex
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
        [HttpGet, ActionName("GetMessageOfNameValuePairByAll")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairByAll(
                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of NameValuePairByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByFKOnly(
            System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression)

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairByFKOnly(
                parentId.HasValue, parentId
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePairByFKOnly

        // DataQueryPerQuerySettingCollection -- MethodDataQuery -- End

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Organization.
        /// http://[host]/api/OrganizationApi/GetOrganizationItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.OrganizationItemVM GetOrganizationItemVM(
System.Int64? id
            , System.Guid? uniqueIdentifier
            , System.Guid? uniqueidentifierColumn)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM();
            retval.Load(id.HasValue, id, uniqueIdentifier.HasValue, uniqueIdentifier, uniqueidentifierColumn.HasValue, uniqueidentifierColumn, Framework.UIAction.ViewDetails);
            return retval;
        }

        /// <summary>
        /// Gets the Wrapper View Model of MSBuildExtensionPack.Organization: WPCommonOfOrganizationVM.
        /// http://[host]/api/OrganizationApi/GetWPCommonOfOrganizationVM
        /// Content-Type: application/json; charset=utf-8
        /// </summary>
        /// <param name="vm">The vm.</param>
        /// <returns></returns>
        // [HttpGet, ActionName("GetWPCommonOfOrganizationVM")] //although JSON allowed in Http Delete request body, but not allowed in HttpClient
        [HttpPost, ActionName("GetWPCommonOfOrganizationVM")]
        public MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM GetWPCommonOfOrganizationVM(
            [FromBody]MSBuildExtensionPack.ViewModelData.WPCommonOfOrganizationVM vm)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfOrganizationVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPCommonOfOrganizationVM();
            if (vm != null)
            {
                retval.Criteria = vm.Criteria;
                retval.QueryPagingSetting = vm.QueryPagingSetting;
                retval.QueryOrderBySettingCollecionInString = vm.QueryOrderBySettingCollecionInString;
            }
            else
            {
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfOrganizationVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// HearBeat.
        /// http://[host]/api/OrganizationApi/HearBeat
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("HeartBeat")]
        public bool HeartBeat()
        {
            return true;
        }

    }
}


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
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfAll(                currentIndex
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
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfAll(                currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of All per value type

        #region Query Methods Of NameValuePair of ByFKOnly per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfByFKOnly")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfByFKOnly(
            bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfByFKOnly(                isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly && valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">will compare/filter IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly">value to compare/filter with IdByFKOnlyOfOrganization_2OfByFKOnly property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfByFKOnly")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfByFKOnly(
            bool isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly, System.Int64? valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfByFKOnly(                isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly && valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly != default(System.Int64), valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of ByFKOnly per value type

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">will compare/filter UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">value to compare/filter with UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(                isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier && valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier != default(System.Guid), valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">will compare/filter UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier">value to compare/filter with UniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(
            bool isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier, System.Guid? valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueIdentifier(                isToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier && valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier != default(System.Guid), valueToCompareUniqueIdentifierUniqueConstraintOfUC_Organization_UniqueIdentifierOftOfUniqueConstraintOfUC_Organization_UniqueIdentifier
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueIdentifier per value type

        #region Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">will compare/filter UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">value to compare/filter with UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        [HttpGet, ActionName("GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public Framework.NameValueCollection GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(                isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn && valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn != default(System.Guid), valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">will compare/filter UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn">value to compare/filter with UniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        [HttpGet, ActionName("GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn")]
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(
            bool isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn, System.Guid? valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            return MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetMessageOfNameValuePairOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn(                isToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn && valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn != default(System.Guid), valueToCompareUniqueidentifierColumnUniqueConstraintOfUC_Organization_UniqueidentifierColumnOftOfUniqueConstraintOfUC_Organization_UniqueidentifierColumn
                , currentIndex
                , pageSize
                , queryOrderByExpression);
        }

        #endregion Query Methods Of NameValuePair of UniqueConstraintOfUC_Organization_UniqueidentifierColumn per value type

        /// <summary>
        /// Gets the Item View Model of MSBuildExtensionPack.Organization.
        /// http://[host]/api/OrganizationApi/GetOrganizationItemVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MSBuildExtensionPack.ViewModelData.OrganizationItemVM GetOrganizationItemVM(
            System.Int64 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.OrganizationItemVM();
            retval.Load(true, id, false, default(System.Guid), false, default(System.Guid), Framework.UIAction.ViewDetails);
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
                retval.Criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommonFlatten();
                retval.QueryPagingSetting = Framework.EntityContracts.QueryPagingSetting.GetDefault();
                //retval.QueryOrderBySettingCollecionInString = MSBuildExtensionPack.ViewModelData.OrderByLists.WPCommonOfOrganizationVM_GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
            retval.LoadData(true);
            return retval;
        }

        /// <summary>
        /// Gets entity related view model of MSBuildExtensionPack.Organization: WPEntityRelatedOfOrganizationVM.
        /// http://[host]/api/OrganizationApi/GetWPEntityRelatedOfOrganizationVM?
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("GetWPEntityRelatedOfOrganizationVM")]
        public MSBuildExtensionPack.ViewModelData.WPEntityRelatedOfOrganizationVM GetWPEntityRelatedOfOrganizationVM(
            System.Int64 id)
        {
            MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfOrganizationVM retval = new MSBuildExtensionPack.AspNetMvc40ViewModel.WPEntityRelatedOfOrganizationVM(new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(true, id, false, default(System.Guid), false, default(System.Guid)));
            retval.LoadData();
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


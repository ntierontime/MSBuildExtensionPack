using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Framework.EntityContracts;
using Framework;

namespace MSBuildExtensionPack.CommonBLLIoC
{
    /// <summary>
    /// provides static method wrappers of Business logic layer using IoC
    /// </summary>
	//[System.ComponentModel.DataObject], because of Silverlight and Windows Phone 7.1
    public static class IoCSolution
    {
        #region insert, update and delete in request message

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertRequest(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            return _BusinessLogicLayerInstance.InsertEntity(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateRequest(
			MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            return _BusinessLogicLayerInstance.UpdateEntity(_Request);
        }

        /// <summary>
        /// Deletes By Identifier an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierRequest(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier _Request)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            return _BusinessLogicLayerInstance.DeleteByIdentifierEntity(_Request);
        }

        /// <summary>
        /// Deletes an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteRequest(
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            return _BusinessLogicLayerInstance.DeleteEntity(_Request);
        }

        #endregion insert, update and delete in request message
		
        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request =new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _Request.Critieria.Add(input);
            return InsertRequest(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _Request.Critieria.Add(input);
            return UpdateRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltInOfIdentifier(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = identifier;
            return DeleteByIdentifierRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Solution input)
        {
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _Request.Critieria.Add(input);
            return DeleteRequest(_Request);
        }

        #endregion insert, update and delete in an entity

        #region insert, update and delete using .Net value types

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
        /// <param name="externalParentId">property value of System.String</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        public static void Insert(
			System.Int32 id
			, System.String externalParentId
			, System.String name
			, System.String description
			)
        {
            InsertEntity(new MSBuildExtensionPack.DataSourceEntities.Solution(
				id
				, externalParentId
				, name
				, description));
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
        /// <param name="externalParentId">property value of System.String</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        public static void Update(
			System.Int32 id
			, System.String externalParentId
			, System.String name
			, System.String description			)
        {
            UpdateEntity(new MSBuildExtensionPack.DataSourceEntities.Solution(
				id
				, externalParentId
				, name
				, description));
        }


		/// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
        /// <param name="externalParentId">property value of System.String</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="description">property value of System.String</param>
        public static void Delete(
			System.Int32 id
			, System.String externalParentId
			, System.String name
			, System.String description
			)
        {
            DeleteEntity(new MSBuildExtensionPack.DataSourceEntities.Solution(
				id
				, externalParentId
				, name
				, description));
        }

		/// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int32</param>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn DeleteByIdentifier(
			System.Int32 id
			)
        {
            return DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.SolutionIdentifier(
				id));
        }

        #endregion insert, update and delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchUpdate(_Request);
        }

		/// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchInsert(_Request);
        }

		/// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Solution"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.DataSourceEntities.SolutionCollection input)
        {
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Critieria = new MSBuildExtensionPack.DataSourceEntities.SolutionCollection();
            _Request.Critieria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchDelete(_Request);
        }

        #endregion batch insert, update and delete in an entity collection
		


        #region Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfCommon(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetSingleOfEntityOfCommon(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of Common per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of Common per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageNumberListOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon for GetPageCountOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon));

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfCommon(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareExternalParentIdCommonOftOfCommon">will compare/filter ExternalParentIdCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedExternalParentIdCommonOftOfCommon">value to compare/filter with ExternalParentIdCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareNameCommonOftOfCommon">will compare/filter NameCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedNameCommonOftOfCommon">value to compare/filter with NameCommonOftOfCommon property/field/column</param>
        /// <param name="isToCompareDescriptionCommonOftOfCommon">will compare/filter DescriptionCommonOftOfCommon property/field/column if true, otherwise false</param>
        /// <param name="valueToBeContainedDescriptionCommonOftOfCommon">value to compare/filter with DescriptionCommonOftOfCommon property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetSingleOfEntityOfCommon(
			bool isToCompareExternalParentIdCommonOftOfCommon, System.String valueToBeContainedExternalParentIdCommonOftOfCommon
			, bool isToCompareNameCommonOftOfCommon, System.String valueToBeContainedNameCommonOftOfCommon
			, bool isToCompareDescriptionCommonOftOfCommon, System.String valueToBeContainedDescriptionCommonOftOfCommon
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfCommon(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfCommon"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaCommon(
				new QuerySystemStringContainsCriteria(isToCompareExternalParentIdCommonOftOfCommon, valueToBeContainedExternalParentIdCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareNameCommonOftOfCommon, valueToBeContainedNameCommonOftOfCommon)
				, new QuerySystemStringContainsCriteria(isToCompareDescriptionCommonOftOfCommon, valueToBeContainedDescriptionCommonOftOfCommon)
				);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfEntityOfCommon", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of Entity of Common per value type




        #region Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfAll(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetSingleOfEntityOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageNumberListOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll for GetPageCountOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetSingleOfEntityOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(

				);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfEntityOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of Entity of All per value type




        #region Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfNameValuePairOfAll(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfNameValuePairOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Value", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of NameValuePair of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of NameValuePair of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfNameValuePairOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageNumberListOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfNameValuePairOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll for GetPageCountOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetSingleOfNameValuePairOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfNameValuePairOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(

				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetSingleOfNameValuePairOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfNameValuePairOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of NameValuePair of All per value type




        #region Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfRssItemOfAll(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfAll(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfRssItemOfAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("IdentifierInString", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of RssItem of All per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of RssItem of All per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfRssItemOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageNumberListOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>

        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfRssItemOfAll(
			int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll for GetPageCountOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemOfAll(
			int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(
);

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemOfAll(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>

        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetSingleOfRssItemOfAll(
			string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfRssItemOfAll"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaAll(

				);
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetSingleOfRssItemOfAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfRssItemOfAll", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of RssItem of All per value type




        #region Query Methods Of Entity of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfEntityOfByIdentifier(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetSingleOfEntityOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfEntityOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of Entity of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of Entity of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageNumberListOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier for GetPageCountOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetCollectionOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn GetMessageOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.SolutionCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.SolutionCollection GetSingleOfEntityOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfEntityOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetSingleOfEntityOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfEntityOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of Entity of ByIdentifier per value type




        #region Query Methods Of KeyInformation of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }
        
        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			int pageSize = queryPagingSetting == null ? 0 : queryPagingSetting.PageSize;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns></returns>
        public static int GetCountOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
			return GetMessageOfKeyInformationOfByIdentifier(
				criteria
				, queryPagingSetting
				, queryOrderBySettingCollection
				, Framework.DataServiceTypes.DataSourceResult);
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			, Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
			_Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetSingleOfKeyInformationOfByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Critieria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
#if (NETFX_CORE || XAMARIN)
				_Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
#else
				_Request.QueryOrderBySettingCollection.Add("Id", System.ComponentModel.ListSortDirection.Ascending);
#endif
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        #endregion Query Methods Of KeyInformation of ByIdentifier per critieria, queryPagingSetting and queryOrderBySettingCollection

        #region Query Methods Of KeyInformation of ByIdentifier per value type

        /// <summary>
        /// Gets the page number list of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>an array with all available page numbers</returns>
        public static int[] GetPageNumberListOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageNumberListOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
				if (_PageCount > 0)
				{
					List<int> _retval = new List<int>();
					for (int i = 1; i <= _PageCount; i++)
					{
						_retval.Add(i);
					}
		            //log.Info(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
					return _retval.ToArray();
				}
				else
				{
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
					return null;
				}
			}
            else
            {
                //.Process("IoCSolution", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
		            //log.Error(string.Format("{0}: GetPageNumberListOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets the page count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>total pages</returns>
        public static int GetPageCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int pageSize
            )
        {
            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier for GetPageCountOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, null
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
				int _RecordCount = _Response.Message;

				int _PageCount;
				if (pageSize > 0)
				{
					_PageCount = _RecordCount / pageSize + _RecordCount % pageSize > 0 ? 1 : 0;
				}
				else
				{
					_PageCount = 0;
				}
	            //log.Info(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
				return _PageCount;
			}
            else
            {
                //log.Error(string.Format("{0}: GetPageCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
	            //.Process("IoCSolution", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                return 0;
            }
        }

        /// <summary>
        /// Gets the count of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        public static int GetCountOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCountOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex				  
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageInteger _Response = _BusinessLogicLayerInstance.GetCountOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
	            return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCountOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
                //log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return 0;
            }
        }


        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "ExistsOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "ExistsOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
		}

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression
			)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetCollectionOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, int currentIndex
			, int pageSize
			, string queryOrderByExpression		)

        {
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetCollectionOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, currentIndex
				, pageSize
				, queryOrderByExpression				
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier));

            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationOfByIdentifier(_Request);
            return _Response;
        }

        /// <summary>
        /// Gets the single of entity of common.
        /// </summary>
        /// <param name="isToCompareIdByIdentifierOftOfByIdentifier">will compare/filter IdByIdentifierOftOfByIdentifier property/field/column if true, otherwise false</param>
        /// <param name="valueToCompareIdByIdentifierOftOfByIdentifier">value to compare/filter with IdByIdentifierOftOfByIdentifier property/field/column</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformationCollection GetSingleOfKeyInformationOfByIdentifier(
			bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32 valueToCompareIdByIdentifierOftOfByIdentifier
			, string queryOrderByExpression
			)

        {
            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
			MSBuildExtensionPack.WcfContracts.ISolutionService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceSolution();
            MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.SolutionRequestMessageUserDefinedOfByIdentifier(
				Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
				, "GetSingleOfKeyInformationOfByIdentifier"
				, Guid.NewGuid().ToString()
				, -1
				, -1
				, queryOrderByExpression
				);
            _Request.Critieria = new MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier(
				new QuerySystemInt32EqualsCriteria(isToCompareIdByIdentifierOftOfByIdentifier, valueToCompareIdByIdentifierOftOfByIdentifier)
				);
            MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetSingleOfKeyInformationOfByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
	            //log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //.Process("IoCSolution", "GetSingleOfKeyInformationOfByIdentifier", _Response.BusinessLogicLayerResponseStatus.ToString(), _Response.ServerErrorMessage);
	            //log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
		}

        #endregion Query Methods Of KeyInformation of ByIdentifier per value type





    }
}


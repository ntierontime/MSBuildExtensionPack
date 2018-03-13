using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Framework;
using Framework.EntityContracts;

namespace MSBuildExtensionPack.CommonBLLIoC
{
    /// <summary>
    /// provides static method wrappers of Business logic layer using IoC
    /// </summary>
    //[System.ComponentModel.DataObject], because of Silverlight and Windows Phone 7.1
    public static class IoCOrganization
    {
        #region insert, update and delete in request message

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertRequest(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            return _BusinessLogicLayerInstance.InsertEntity(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateRequest(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            return _BusinessLogicLayerInstance.UpdateEntity(_Request);
        }

        /// <summary>
        /// Deletes By Identifier an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierRequest(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier _Request)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            return _BusinessLogicLayerInstance.DeleteByIdentifierEntity(_Request);
        }

        /// <summary>
        /// Deletes an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> in a request message.
        /// </summary>
        /// <param name="_Request">the request message</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteRequest(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            return _BusinessLogicLayerInstance.DeleteEntity(_Request);
        }

        #endregion insert, update and delete in request message

        #region insert, update and delete in an entity

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn InsertEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request =new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _Request.Criteria.Add(input);
            return InsertRequest(_Request);
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn UpdateEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _Request.Criteria.Add(input);
            return UpdateRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier.
        /// </summary>
        /// <param name="identifier">input identifier of an entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifierEntity(
            MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier identifier)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltInOfIdentifier(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = identifier;
            return DeleteByIdentifierRequest(_Request);
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// </summary>
        /// <param name="input">input entity</param>
        /// <returns>a message with action result</returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteEntity(
            MSBuildExtensionPack.DataSourceEntities.Organization input)
        {
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _Request.Criteria.Add(input);
            return DeleteRequest(_Request);
        }

        #endregion insert, update and delete in an entity

        #region insert, update and delete using .Net value types

        /// <summary>
        /// Inserts an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="parentId">property value of System.Int64</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="isSystemBuiltIn">property value of System.Boolean</param>
        /// <param name="uniqueIdentifier">property value of System.Guid</param>
        /// <param name="createdDateTime">property value of System.DateTime</param>
        /// <param name="charColumn">property value of System.String</param>
        /// <param name="varcharColumn">property value of System.String</param>
        /// <param name="textColumn">property value of System.String</param>
        /// <param name="ncharColumn">property value of System.String</param>
        /// <param name="nvarcharColumn">property value of System.String</param>
        /// <param name="ntextColumn">property value of System.String</param>
        /// <param name="bitColumn">property value of System.Boolean</param>
        /// <param name="binaryColumn">property value of System.Byte[]</param>
        /// <param name="varbinaryColumn">property value of System.Byte[]</param>
        /// <param name="imageColumn">property value of System.Byte[]</param>
        /// <param name="tinyintColumn">property value of System.Byte</param>
        /// <param name="smallintColumn">property value of System.Int16</param>
        /// <param name="intColumn">property value of System.Int32</param>
        /// <param name="bigintColumn">property value of System.Int64</param>
        /// <param name="decimalColumn">property value of System.Decimal</param>
        /// <param name="numericColumn">property value of System.Decimal</param>
        /// <param name="smallmoneyColumn">property value of System.Decimal</param>
        /// <param name="moneyColumn">property value of System.Decimal</param>
        /// <param name="floatColumn">property value of System.Single</param>
        /// <param name="realColumn">property value of System.Single</param>
        /// <param name="datetimeColumn">property value of System.DateTime</param>
        /// <param name="datetime2Column">property value of System.DateTime</param>
        /// <param name="smalldatetimeColumn">property value of System.DateTime</param>
        /// <param name="dateColumn">property value of System.DateTime</param>
        /// <param name="timeColumn">property value of System.TimeSpan</param>
        /// <param name="uniqueidentifierColumn">property value of System.Guid</param>
        public static void Insert(
            System.Int64 id
            , System.Int64 parentId
            , System.String name
            , System.Boolean isSystemBuiltIn
            , System.Guid uniqueIdentifier
            , System.DateTime createdDateTime
            , System.String charColumn
            , System.String varcharColumn
            , System.String textColumn
            , System.String ncharColumn
            , System.String nvarcharColumn
            , System.String ntextColumn
            , System.Boolean bitColumn
            , System.Byte[] binaryColumn
            , System.Byte[] varbinaryColumn
            , System.Byte[] imageColumn
            , System.Byte tinyintColumn
            , System.Int16 smallintColumn
            , System.Int32 intColumn
            , System.Int64 bigintColumn
            , System.Decimal decimalColumn
            , System.Decimal numericColumn
            , System.Decimal smallmoneyColumn
            , System.Decimal moneyColumn
            , System.Single floatColumn
            , System.Single realColumn
            , System.DateTime datetimeColumn
            , System.DateTime datetime2Column
            , System.DateTime smalldatetimeColumn
            , System.DateTime dateColumn
            , System.TimeSpan timeColumn
            , System.Guid uniqueidentifierColumn
            )
        {
            InsertEntity(new MSBuildExtensionPack.DataSourceEntities.Organization(
                id
                , parentId
                , name
                , isSystemBuiltIn
                , uniqueIdentifier
                , createdDateTime
                , charColumn
                , varcharColumn
                , textColumn
                , ncharColumn
                , nvarcharColumn
                , ntextColumn
                , bitColumn
                , binaryColumn
                , varbinaryColumn
                , imageColumn
                , tinyintColumn
                , smallintColumn
                , intColumn
                , bigintColumn
                , decimalColumn
                , numericColumn
                , smallmoneyColumn
                , moneyColumn
                , floatColumn
                , realColumn
                , datetimeColumn
                , datetime2Column
                , smalldatetimeColumn
                , dateColumn
                , timeColumn
                , uniqueidentifierColumn));
        }

        /// <summary>
        /// Updates an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="parentId">property value of System.Int64</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="isSystemBuiltIn">property value of System.Boolean</param>
        /// <param name="uniqueIdentifier">property value of System.Guid</param>
        /// <param name="createdDateTime">property value of System.DateTime</param>
        /// <param name="charColumn">property value of System.String</param>
        /// <param name="varcharColumn">property value of System.String</param>
        /// <param name="textColumn">property value of System.String</param>
        /// <param name="ncharColumn">property value of System.String</param>
        /// <param name="nvarcharColumn">property value of System.String</param>
        /// <param name="ntextColumn">property value of System.String</param>
        /// <param name="bitColumn">property value of System.Boolean</param>
        /// <param name="binaryColumn">property value of System.Byte[]</param>
        /// <param name="varbinaryColumn">property value of System.Byte[]</param>
        /// <param name="imageColumn">property value of System.Byte[]</param>
        /// <param name="tinyintColumn">property value of System.Byte</param>
        /// <param name="smallintColumn">property value of System.Int16</param>
        /// <param name="intColumn">property value of System.Int32</param>
        /// <param name="bigintColumn">property value of System.Int64</param>
        /// <param name="decimalColumn">property value of System.Decimal</param>
        /// <param name="numericColumn">property value of System.Decimal</param>
        /// <param name="smallmoneyColumn">property value of System.Decimal</param>
        /// <param name="moneyColumn">property value of System.Decimal</param>
        /// <param name="floatColumn">property value of System.Single</param>
        /// <param name="realColumn">property value of System.Single</param>
        /// <param name="datetimeColumn">property value of System.DateTime</param>
        /// <param name="datetime2Column">property value of System.DateTime</param>
        /// <param name="smalldatetimeColumn">property value of System.DateTime</param>
        /// <param name="dateColumn">property value of System.DateTime</param>
        /// <param name="timeColumn">property value of System.TimeSpan</param>
        /// <param name="uniqueidentifierColumn">property value of System.Guid</param>
        public static void Update(
            System.Int64 id
            , System.Int64 parentId
            , System.String name
            , System.Boolean isSystemBuiltIn
            , System.Guid uniqueIdentifier
            , System.DateTime createdDateTime
            , System.String charColumn
            , System.String varcharColumn
            , System.String textColumn
            , System.String ncharColumn
            , System.String nvarcharColumn
            , System.String ntextColumn
            , System.Boolean bitColumn
            , System.Byte[] binaryColumn
            , System.Byte[] varbinaryColumn
            , System.Byte[] imageColumn
            , System.Byte tinyintColumn
            , System.Int16 smallintColumn
            , System.Int32 intColumn
            , System.Int64 bigintColumn
            , System.Decimal decimalColumn
            , System.Decimal numericColumn
            , System.Decimal smallmoneyColumn
            , System.Decimal moneyColumn
            , System.Single floatColumn
            , System.Single realColumn
            , System.DateTime datetimeColumn
            , System.DateTime datetime2Column
            , System.DateTime smalldatetimeColumn
            , System.DateTime dateColumn
            , System.TimeSpan timeColumn
            , System.Guid uniqueidentifierColumn            )
        {
            UpdateEntity(new MSBuildExtensionPack.DataSourceEntities.Organization(
                id
                , parentId
                , name
                , isSystemBuiltIn
                , uniqueIdentifier
                , createdDateTime
                , charColumn
                , varcharColumn
                , textColumn
                , ncharColumn
                , nvarcharColumn
                , ntextColumn
                , bitColumn
                , binaryColumn
                , varbinaryColumn
                , imageColumn
                , tinyintColumn
                , smallintColumn
                , intColumn
                , bigintColumn
                , decimalColumn
                , numericColumn
                , smallmoneyColumn
                , moneyColumn
                , floatColumn
                , realColumn
                , datetimeColumn
                , datetime2Column
                , smalldatetimeColumn
                , dateColumn
                , timeColumn
                , uniqueidentifierColumn));
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        /// <param name="parentId">property value of System.Int64</param>
        /// <param name="name">property value of System.String</param>
        /// <param name="isSystemBuiltIn">property value of System.Boolean</param>
        /// <param name="uniqueIdentifier">property value of System.Guid</param>
        /// <param name="createdDateTime">property value of System.DateTime</param>
        /// <param name="charColumn">property value of System.String</param>
        /// <param name="varcharColumn">property value of System.String</param>
        /// <param name="textColumn">property value of System.String</param>
        /// <param name="ncharColumn">property value of System.String</param>
        /// <param name="nvarcharColumn">property value of System.String</param>
        /// <param name="ntextColumn">property value of System.String</param>
        /// <param name="bitColumn">property value of System.Boolean</param>
        /// <param name="binaryColumn">property value of System.Byte[]</param>
        /// <param name="varbinaryColumn">property value of System.Byte[]</param>
        /// <param name="imageColumn">property value of System.Byte[]</param>
        /// <param name="tinyintColumn">property value of System.Byte</param>
        /// <param name="smallintColumn">property value of System.Int16</param>
        /// <param name="intColumn">property value of System.Int32</param>
        /// <param name="bigintColumn">property value of System.Int64</param>
        /// <param name="decimalColumn">property value of System.Decimal</param>
        /// <param name="numericColumn">property value of System.Decimal</param>
        /// <param name="smallmoneyColumn">property value of System.Decimal</param>
        /// <param name="moneyColumn">property value of System.Decimal</param>
        /// <param name="floatColumn">property value of System.Single</param>
        /// <param name="realColumn">property value of System.Single</param>
        /// <param name="datetimeColumn">property value of System.DateTime</param>
        /// <param name="datetime2Column">property value of System.DateTime</param>
        /// <param name="smalldatetimeColumn">property value of System.DateTime</param>
        /// <param name="dateColumn">property value of System.DateTime</param>
        /// <param name="timeColumn">property value of System.TimeSpan</param>
        /// <param name="uniqueidentifierColumn">property value of System.Guid</param>
        public static void Delete(
            System.Int64 id
            , System.Int64 parentId
            , System.String name
            , System.Boolean isSystemBuiltIn
            , System.Guid uniqueIdentifier
            , System.DateTime createdDateTime
            , System.String charColumn
            , System.String varcharColumn
            , System.String textColumn
            , System.String ncharColumn
            , System.String nvarcharColumn
            , System.String ntextColumn
            , System.Boolean bitColumn
            , System.Byte[] binaryColumn
            , System.Byte[] varbinaryColumn
            , System.Byte[] imageColumn
            , System.Byte tinyintColumn
            , System.Int16 smallintColumn
            , System.Int32 intColumn
            , System.Int64 bigintColumn
            , System.Decimal decimalColumn
            , System.Decimal numericColumn
            , System.Decimal smallmoneyColumn
            , System.Decimal moneyColumn
            , System.Single floatColumn
            , System.Single realColumn
            , System.DateTime datetimeColumn
            , System.DateTime datetime2Column
            , System.DateTime smalldatetimeColumn
            , System.DateTime dateColumn
            , System.TimeSpan timeColumn
            , System.Guid uniqueidentifierColumn
            )
        {
            DeleteEntity(new MSBuildExtensionPack.DataSourceEntities.Organization(
                id
                , parentId
                , name
                , isSystemBuiltIn
                , uniqueIdentifier
                , createdDateTime
                , charColumn
                , varcharColumn
                , textColumn
                , ncharColumn
                , nvarcharColumn
                , ntextColumn
                , bitColumn
                , binaryColumn
                , varbinaryColumn
                , imageColumn
                , tinyintColumn
                , smallintColumn
                , intColumn
                , bigintColumn
                , decimalColumn
                , numericColumn
                , smallmoneyColumn
                , moneyColumn
                , floatColumn
                , realColumn
                , datetimeColumn
                , datetime2Column
                , smalldatetimeColumn
                , dateColumn
                , timeColumn
                , uniqueidentifierColumn));
        }

        /// <summary>
        /// delete an entity of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/> by identifier using .net value types.
        /// </summary>
        /// <param name="id">property value of System.Int64</param>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn DeleteByIdentifier(
            System.Int64 id
            )
        {
            return DeleteByIdentifierEntity(new MSBuildExtensionPack.DataSourceEntities.OrganizationIdentifier(
                id));
        }

        #endregion insert, update and delete using .Net value types

        #region batch insert, update and delete in an entity collection

        /// <summary>
        /// batch update a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchUpdate(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchUpdate(_Request);
        }

        /// <summary>
        /// batch insert a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchInsert(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchInsert(_Request);
        }

        /// <summary>
        /// batch delete a collection of <see cref=" MSBuildExtensionPack.DataSourceEntities.Organization"/>.
        /// </summary>
        /// <param name="input">The input collection.</param>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn BatchDelete(MSBuildExtensionPack.DataSourceEntities.OrganizationCollection input)
        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageBuiltIn(Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete, Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete.ToString(), Guid.NewGuid().ToString());
            _Request.Criteria = new MSBuildExtensionPack.DataSourceEntities.OrganizationCollection();
            _Request.Criteria.AddRange(input);
            return _BusinessLogicLayerInstance.BatchDelete(_Request);
        }

        #endregion batch insert, update and delete in an entity collection

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon _GetOrganizationChainedQueryCriteriaCommon(
            bool isToCompareParentId, System.Int64? parentId
            , bool isToCompareIsSystemBuiltIn, System.Boolean? isSystemBuiltIn
            , bool isToCompareCreatedDateTimeRange, bool isToCompareCreatedDateTimeRangeLow, System.DateTime? createdDateTimeRangeLow, bool isToCompareCreatedDateTimeRangeHigh, System.DateTime? createdDateTimeRangeHigh
            , bool isToCompareBitColumn, System.Boolean? bitColumn
            , bool isToCompareDatetimeColumnRange, bool isToCompareDatetimeColumnRangeLow, System.DateTime? datetimeColumnRangeLow, bool isToCompareDatetimeColumnRangeHigh, System.DateTime? datetimeColumnRangeHigh
            , bool isToCompareDatetime2ColumnRange, bool isToCompareDatetime2ColumnRangeLow, System.DateTime? datetime2ColumnRangeLow, bool isToCompareDatetime2ColumnRangeHigh, System.DateTime? datetime2ColumnRangeHigh
            , bool isToCompareSmalldatetimeColumnRange, bool isToCompareSmalldatetimeColumnRangeLow, System.DateTime? smalldatetimeColumnRangeLow, bool isToCompareSmalldatetimeColumnRangeHigh, System.DateTime? smalldatetimeColumnRangeHigh
            , bool isToCompareDateColumnRange, bool isToCompareDateColumnRangeLow, System.DateTime? dateColumnRangeLow, bool isToCompareDateColumnRangeHigh, System.DateTime? dateColumnRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareCharColumn, System.String charColumn
            , bool isToCompareVarcharColumn, System.String varcharColumn
            , bool isToCompareTextColumn, System.String textColumn
            , bool isToCompareNcharColumn, System.String ncharColumn
            , bool isToCompareNvarcharColumn, System.String nvarcharColumn
            , bool isToCompareNtextColumn, System.String ntextColumn
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon();
            criteria.Common.ParentId = new QuerySystemInt64EqualsCriteria(isToCompareParentId, parentId);
            criteria.Common.IsSystemBuiltIn = new QuerySystemBooleanEqualsCriteria(isToCompareIsSystemBuiltIn, isSystemBuiltIn);
            criteria.Common.CreatedDateTimeRange = new QuerySystemDateTimeRangeCriteria(isToCompareCreatedDateTimeRange, isToCompareCreatedDateTimeRangeLow, createdDateTimeRangeLow, isToCompareCreatedDateTimeRangeHigh, createdDateTimeRangeHigh);
            criteria.Common.BitColumn = new QuerySystemBooleanEqualsCriteria(isToCompareBitColumn, bitColumn);
            criteria.Common.DatetimeColumnRange = new QuerySystemDateTimeRangeCriteria(isToCompareDatetimeColumnRange, isToCompareDatetimeColumnRangeLow, datetimeColumnRangeLow, isToCompareDatetimeColumnRangeHigh, datetimeColumnRangeHigh);
            criteria.Common.Datetime2ColumnRange = new QuerySystemDateTimeRangeCriteria(isToCompareDatetime2ColumnRange, isToCompareDatetime2ColumnRangeLow, datetime2ColumnRangeLow, isToCompareDatetime2ColumnRangeHigh, datetime2ColumnRangeHigh);
            criteria.Common.SmalldatetimeColumnRange = new QuerySystemDateTimeRangeCriteria(isToCompareSmalldatetimeColumnRange, isToCompareSmalldatetimeColumnRangeLow, smalldatetimeColumnRangeLow, isToCompareSmalldatetimeColumnRangeHigh, smalldatetimeColumnRangeHigh);
            criteria.Common.DateColumnRange = new QuerySystemDateTimeRangeCriteria(isToCompareDateColumnRange, isToCompareDateColumnRangeLow, dateColumnRangeLow, isToCompareDateColumnRangeHigh, dateColumnRangeHigh);
            criteria.Common.Name = new QuerySystemStringContainsCriteria(isToCompareName, name);
            criteria.Common.CharColumn = new QuerySystemStringContainsCriteria(isToCompareCharColumn, charColumn);
            criteria.Common.VarcharColumn = new QuerySystemStringContainsCriteria(isToCompareVarcharColumn, varcharColumn);
            criteria.Common.TextColumn = new QuerySystemStringContainsCriteria(isToCompareTextColumn, textColumn);
            criteria.Common.NcharColumn = new QuerySystemStringContainsCriteria(isToCompareNcharColumn, ncharColumn);
            criteria.Common.NvarcharColumn = new QuerySystemStringContainsCriteria(isToCompareNvarcharColumn, nvarcharColumn);
            criteria.Common.NtextColumn = new QuerySystemStringContainsCriteria(isToCompareNtextColumn, ntextColumn);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll _GetOrganizationChainedQueryCriteriaAll(

            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll();

            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly _GetOrganizationChainedQueryCriteriaFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly();
            criteria.FKOnly.ParentId = new QuerySystemInt64EqualsCriteria(isToCompareParentId, parentId);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier _GetOrganizationChainedQueryCriteriaIdentifier(
            bool isToCompareId, System.Int64? id
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier();
            criteria.Identifier.Id = new QuerySystemInt64EqualsCriteria(isToCompareId, id);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaUniqueConstraintByUC _GetOrganizationChainedQueryCriteriaUniqueConstraintByUC(
            bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaUniqueConstraintByUC();
            criteria.UniqueConstraintByUC.UniqueIdentifier = new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifier, uniqueIdentifier);
            return criteria;
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns></returns>
        private static MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            )
        {
            var criteria = new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint();
            criteria.IdentifierAndUniqueConstraint.Id = new QuerySystemInt64EqualsCriteria(isToCompareId, id);
            criteria.IdentifierAndUniqueConstraint.UniqueIdentifier = new QuerySystemGuidEqualsCriteria(isToCompareUniqueIdentifier, uniqueIdentifier);
            return criteria;
        }

        #region Query Methods Of DefaultByCommon

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultByCommon(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByCommon(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaCommon criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultByCommon"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByCommon(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByCommon(
            bool isToCompareParentId, System.Int64? parentId
            , bool isToCompareIsSystemBuiltIn, System.Boolean? isSystemBuiltIn
            , bool isToCompareCreatedDateTimeRange, bool isToCompareCreatedDateTimeRangeLow, System.DateTime? createdDateTimeRangeLow, bool isToCompareCreatedDateTimeRangeHigh, System.DateTime? createdDateTimeRangeHigh
            , bool isToCompareBitColumn, System.Boolean? bitColumn
            , bool isToCompareDatetimeColumnRange, bool isToCompareDatetimeColumnRangeLow, System.DateTime? datetimeColumnRangeLow, bool isToCompareDatetimeColumnRangeHigh, System.DateTime? datetimeColumnRangeHigh
            , bool isToCompareDatetime2ColumnRange, bool isToCompareDatetime2ColumnRangeLow, System.DateTime? datetime2ColumnRangeLow, bool isToCompareDatetime2ColumnRangeHigh, System.DateTime? datetime2ColumnRangeHigh
            , bool isToCompareSmalldatetimeColumnRange, bool isToCompareSmalldatetimeColumnRangeLow, System.DateTime? smalldatetimeColumnRangeLow, bool isToCompareSmalldatetimeColumnRangeHigh, System.DateTime? smalldatetimeColumnRangeHigh
            , bool isToCompareDateColumnRange, bool isToCompareDateColumnRangeLow, System.DateTime? dateColumnRangeLow, bool isToCompareDateColumnRangeHigh, System.DateTime? dateColumnRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareCharColumn, System.String charColumn
            , bool isToCompareVarcharColumn, System.String varcharColumn
            , bool isToCompareTextColumn, System.String textColumn
            , bool isToCompareNcharColumn, System.String ncharColumn
            , bool isToCompareNvarcharColumn, System.String nvarcharColumn
            , bool isToCompareNtextColumn, System.String ntextColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaCommon(
                isToCompareParentId, parentId
                , isToCompareIsSystemBuiltIn, isSystemBuiltIn
                , isToCompareCreatedDateTimeRange, isToCompareCreatedDateTimeRangeLow, createdDateTimeRangeLow, isToCompareCreatedDateTimeRangeHigh, createdDateTimeRangeHigh
                , isToCompareBitColumn, bitColumn
                , isToCompareDatetimeColumnRange, isToCompareDatetimeColumnRangeLow, datetimeColumnRangeLow, isToCompareDatetimeColumnRangeHigh, datetimeColumnRangeHigh
                , isToCompareDatetime2ColumnRange, isToCompareDatetime2ColumnRangeLow, datetime2ColumnRangeLow, isToCompareDatetime2ColumnRangeHigh, datetime2ColumnRangeHigh
                , isToCompareSmalldatetimeColumnRange, isToCompareSmalldatetimeColumnRangeLow, smalldatetimeColumnRangeLow, isToCompareSmalldatetimeColumnRangeHigh, smalldatetimeColumnRangeHigh
                , isToCompareDateColumnRange, isToCompareDateColumnRangeLow, dateColumnRangeLow, isToCompareDateColumnRangeHigh, dateColumnRangeHigh
                , isToCompareName, name
                , isToCompareCharColumn, charColumn
                , isToCompareVarcharColumn, varcharColumn
                , isToCompareTextColumn, textColumn
                , isToCompareNcharColumn, ncharColumn
                , isToCompareNvarcharColumn, nvarcharColumn
                , isToCompareNtextColumn, ntextColumn
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByCommon(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByCommon", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="isToCompareIsSystemBuiltIn">will compare/filter isSystemBuiltIn property/field/column if true, otherwise false</param>
        /// <param name="isSystemBuiltIn">value to compare/filter with isSystemBuiltIn property/field/column</param>
        /// <param name="isToCompareCreatedDateTimeRange" > will compare/filter createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareCreatedDateTimeRangeLow" > will compare/filter to lower bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeLow">value of lower bound</param>
        /// <param name="isToCompareCreatedDateTimeRangeHigh">will compare/filter to upper bound of createdDateTimeRange property/field/column if true, otherwise false</param>
        /// <param name="createdDateTimeRangeHigh">upper bound</param>
        /// <param name="isToCompareBitColumn">will compare/filter bitColumn property/field/column if true, otherwise false</param>
        /// <param name="bitColumn">value to compare/filter with bitColumn property/field/column</param>
        /// <param name="isToCompareDatetimeColumnRange" > will compare/filter datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetimeColumnRangeLow" > will compare/filter to lower bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetimeColumnRangeHigh">will compare/filter to upper bound of datetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDatetime2ColumnRange" > will compare/filter datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDatetime2ColumnRangeLow" > will compare/filter to lower bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDatetime2ColumnRangeHigh">will compare/filter to upper bound of datetime2ColumnRange property/field/column if true, otherwise false</param>
        /// <param name="datetime2ColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRange" > will compare/filter smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeLow" > will compare/filter to lower bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareSmalldatetimeColumnRangeHigh">will compare/filter to upper bound of smalldatetimeColumnRange property/field/column if true, otherwise false</param>
        /// <param name="smalldatetimeColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareDateColumnRange" > will compare/filter dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="isToCompareDateColumnRangeLow" > will compare/filter to lower bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeLow">value of lower bound</param>
        /// <param name="isToCompareDateColumnRangeHigh">will compare/filter to upper bound of dateColumnRange property/field/column if true, otherwise false</param>
        /// <param name="dateColumnRangeHigh">upper bound</param>
        /// <param name="isToCompareName">will compare/filter name property/field/column if true, otherwise false</param>
        /// <param name="name" > value to compare/filter with name property/field/column</param>
        /// <param name="isToCompareCharColumn">will compare/filter charColumn property/field/column if true, otherwise false</param>
        /// <param name="charColumn" > value to compare/filter with charColumn property/field/column</param>
        /// <param name="isToCompareVarcharColumn">will compare/filter varcharColumn property/field/column if true, otherwise false</param>
        /// <param name="varcharColumn" > value to compare/filter with varcharColumn property/field/column</param>
        /// <param name="isToCompareTextColumn">will compare/filter textColumn property/field/column if true, otherwise false</param>
        /// <param name="textColumn" > value to compare/filter with textColumn property/field/column</param>
        /// <param name="isToCompareNcharColumn">will compare/filter ncharColumn property/field/column if true, otherwise false</param>
        /// <param name="ncharColumn" > value to compare/filter with ncharColumn property/field/column</param>
        /// <param name="isToCompareNvarcharColumn">will compare/filter nvarcharColumn property/field/column if true, otherwise false</param>
        /// <param name="nvarcharColumn" > value to compare/filter with nvarcharColumn property/field/column</param>
        /// <param name="isToCompareNtextColumn">will compare/filter ntextColumn property/field/column if true, otherwise false</param>
        /// <param name="ntextColumn" > value to compare/filter with ntextColumn property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByCommon(
            bool isToCompareParentId, System.Int64? parentId
            , bool isToCompareIsSystemBuiltIn, System.Boolean? isSystemBuiltIn
            , bool isToCompareCreatedDateTimeRange, bool isToCompareCreatedDateTimeRangeLow, System.DateTime? createdDateTimeRangeLow, bool isToCompareCreatedDateTimeRangeHigh, System.DateTime? createdDateTimeRangeHigh
            , bool isToCompareBitColumn, System.Boolean? bitColumn
            , bool isToCompareDatetimeColumnRange, bool isToCompareDatetimeColumnRangeLow, System.DateTime? datetimeColumnRangeLow, bool isToCompareDatetimeColumnRangeHigh, System.DateTime? datetimeColumnRangeHigh
            , bool isToCompareDatetime2ColumnRange, bool isToCompareDatetime2ColumnRangeLow, System.DateTime? datetime2ColumnRangeLow, bool isToCompareDatetime2ColumnRangeHigh, System.DateTime? datetime2ColumnRangeHigh
            , bool isToCompareSmalldatetimeColumnRange, bool isToCompareSmalldatetimeColumnRangeLow, System.DateTime? smalldatetimeColumnRangeLow, bool isToCompareSmalldatetimeColumnRangeHigh, System.DateTime? smalldatetimeColumnRangeHigh
            , bool isToCompareDateColumnRange, bool isToCompareDateColumnRangeLow, System.DateTime? dateColumnRangeLow, bool isToCompareDateColumnRangeHigh, System.DateTime? dateColumnRangeHigh
            , bool isToCompareName, System.String name
            , bool isToCompareCharColumn, System.String charColumn
            , bool isToCompareVarcharColumn, System.String varcharColumn
            , bool isToCompareTextColumn, System.String textColumn
            , bool isToCompareNcharColumn, System.String ncharColumn
            , bool isToCompareNvarcharColumn, System.String nvarcharColumn
            , bool isToCompareNtextColumn, System.String ntextColumn
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfCommon(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByCommon"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaCommon(
                isToCompareParentId, parentId
                , isToCompareIsSystemBuiltIn, isSystemBuiltIn
                , isToCompareCreatedDateTimeRange, isToCompareCreatedDateTimeRangeLow, createdDateTimeRangeLow, isToCompareCreatedDateTimeRangeHigh, createdDateTimeRangeHigh
                , isToCompareBitColumn, bitColumn
                , isToCompareDatetimeColumnRange, isToCompareDatetimeColumnRangeLow, datetimeColumnRangeLow, isToCompareDatetimeColumnRangeHigh, datetimeColumnRangeHigh
                , isToCompareDatetime2ColumnRange, isToCompareDatetime2ColumnRangeLow, datetime2ColumnRangeLow, isToCompareDatetime2ColumnRangeHigh, datetime2ColumnRangeHigh
                , isToCompareSmalldatetimeColumnRange, isToCompareSmalldatetimeColumnRangeLow, smalldatetimeColumnRangeLow, isToCompareSmalldatetimeColumnRangeHigh, smalldatetimeColumnRangeHigh
                , isToCompareDateColumnRange, isToCompareDateColumnRangeLow, dateColumnRangeLow, isToCompareDateColumnRangeHigh, dateColumnRangeHigh
                , isToCompareName, name
                , isToCompareCharColumn, charColumn
                , isToCompareVarcharColumn, varcharColumn
                , isToCompareTextColumn, textColumn
                , isToCompareNcharColumn, ncharColumn
                , isToCompareNvarcharColumn, nvarcharColumn
                , isToCompareNtextColumn, ntextColumn
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByCommon(_Request);
            return _Response;
        }

        #endregion Query Methods Of DefaultByCommon

        #region Query Methods Of NameValuePairByAll

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairByAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfNameValuePairByAll(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairByAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByAll(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairByAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairByAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairByAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairByAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByAll(_Request);
            return _Response;
        }

        #endregion Query Methods Of NameValuePairByAll

        #region Query Methods Of RssItemByAll

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemByAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemByAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfRssItemByAll(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemByAll(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfRssItemByAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfRssItemByAll"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("IdentifierInString", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemByAll(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>

        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.RssItemCollection"/></returns>
        public static Framework.RssItemCollection GetCollectionOfRssItemByAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemByAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemByAll(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfRssItemByAll", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection GetMessageOfRssItemByAll(
            int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfAll(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfRssItemByAll"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaAll(

                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageRssItemCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfRssItemByAll(_Request);
            return _Response;
        }

        #endregion Query Methods Of RssItemByAll

        #region Query Methods Of DefaultByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultByFKOnly(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByFKOnly(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaFKOnly(
                isToCompareParentId, parentId
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaFKOnly(
                isToCompareParentId, parentId
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByFKOnly(_Request);
            return _Response;
        }

        #endregion Query Methods Of DefaultByFKOnly

        #region Query Methods Of DefaultGroupedDataViewByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("ParentId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultGroupedDataViewByFKOnly(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultGroupedDataViewByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("ParentId", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewByFKOnly(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewByFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaFKOnly(
                isToCompareParentId, parentId
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView GetMessageOfDefaultGroupedDataViewByFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultGroupedDataViewByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaFKOnly(
                isToCompareParentId, parentId
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.DefaultGroupedDataView _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultGroupedDataViewByFKOnly(_Request);
            return _Response;
        }

        #endregion Query Methods Of DefaultGroupedDataViewByFKOnly

        #region Query Methods Of NameValuePairByFKOnly

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfNameValuePairByFKOnly(
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
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByFKOnly(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaFKOnly criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfNameValuePairByFKOnly"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Value", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByFKOnly(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="Framework.NameValueCollection"/></returns>
        public static Framework.NameValueCollection GetCollectionOfNameValuePairByFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaFKOnly(
                isToCompareParentId, parentId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByFKOnly(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfNameValuePairByFKOnly", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareParentId">will compare/filter parentId property/field/column if true, otherwise false</param>
        /// <param name="parentId">value to compare/filter with parentId property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection"/></returns>
        public static Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection GetMessageOfNameValuePairByFKOnly(
            bool isToCompareParentId, System.Int64? parentId
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfFKOnly(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfNameValuePairByFKOnly"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaFKOnly(
                isToCompareParentId, parentId
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageNameValuePairCollection _Response = _BusinessLogicLayerInstance.GetCollectionOfNameValuePairByFKOnly(_Request);
            return _Response;
        }

        #endregion Query Methods Of NameValuePairByFKOnly

        #region Query Methods Of EntityByIdentifier

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfEntityByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifier(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifier(_Request);
            return _Response;
        }

        #endregion Query Methods Of EntityByIdentifier

        #region Query Methods Of DefaultByIdentifier

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifier(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifier(_Request);
            return _Response;
        }

        #endregion Query Methods Of DefaultByIdentifier

        #region Query Methods Of KeyInformationByIdentifier

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection GetCollectionOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfKeyInformationByIdentifier(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationByIdentifier(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifier criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfKeyInformationByIdentifier"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifier(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection GetCollectionOfKeyInformationByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifier(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifier", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationByIdentifier(
            bool isToCompareId, System.Int64? id
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifier(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationByIdentifier"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifier(
                isToCompareId, id
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifier(_Request);
            return _Response;
        }

        #endregion Query Methods Of KeyInformationByIdentifier

        #region Query Methods Of EntityByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfEntityByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfEntityByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfEntityByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfEntityByIdentifierAndUniqueConstraint(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfEntityByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifierAndUniqueConstraint(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.OrganizationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.OrganizationCollection GetCollectionOfEntityByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfEntityByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn GetMessageOfEntityByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfEntityByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn _Response = _BusinessLogicLayerInstance.GetCollectionOfEntityByIdentifierAndUniqueConstraint(_Request);
            return _Response;
        }

        #endregion Query Methods Of EntityByIdentifierAndUniqueConstraint

        #region Query Methods Of DefaultByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfDefaultByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfDefaultByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfDefaultByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfDefaultByIdentifierAndUniqueConstraint(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfDefaultByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifierAndUniqueConstraint(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection GetCollectionOfDefaultByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfDefaultByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default GetMessageOfDefaultByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfDefaultByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.Default _Response = _BusinessLogicLayerInstance.GetCollectionOfDefaultByIdentifierAndUniqueConstraint(_Request);
            return _Response;
        }

        #endregion Query Methods Of DefaultByIdentifierAndUniqueConstraint

        #region Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Exists the of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>true if meets criteria, otherwise false</returns>
        public static bool ExistsOfKeyInformationByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "ExistsOfKeyInformationByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            Framework.CommonBLLEntities.BusinessLogicLayerResponseMessageBoolean _Response = _BusinessLogicLayerInstance.ExistsOfKeyInformationByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: ExistsOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return false;
            }
        }

        /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="queryPagingSetting"></param>
        /// <param name="queryOrderBySettingCollection"></param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection)
        {
            return GetMessageOfKeyInformationByIdentifierAndUniqueConstraint(
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
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationByIdentifierAndUniqueConstraint(
            MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint criteria
            , Framework.EntityContracts.QueryPagingSetting queryPagingSetting
            , Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
            , Framework.DataServiceTypes dataServiceType)
        {
            //log.Info(string.Format("{0}: GetMessageOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetMessageOfKeyInformationByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                );
            _Request.Criteria = criteria;
            _Request.QueryPagingSetting = queryPagingSetting;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _Request.QueryOrderBySettingCollection = new QueryOrderBySettingCollection();
                _Request.QueryOrderBySettingCollection.Add("Id", "Ascending");
            }
            else
            {
                _Request.QueryOrderBySettingCollection = queryOrderBySettingCollection;
            }
            _Request.DataServiceType = dataServiceType;

            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(_Request);
            return _Response;
        }

       /// <summary>
        /// Gets the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>the collection of type <see cref="MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection"/></returns>
        public static MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression
            )
        {
            //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Started.ToString()));
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(_Request);
            if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK)
            {
                //log.Info(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                return _Response.Message;
            }
            else
            {
                //log.Error(string.Format("{0}: GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint", Framework.LoggingOptions.UI_Process_Failed.ToString()));
                return null;
            }
        }

        /// <summary>
        /// Gets message of the collection of entity of common.
        /// </summary>
        /// <param name="isToCompareId">will compare/filter id property/field/column if true, otherwise false</param>
        /// <param name="id">value to compare/filter with id property/field/column</param>
        /// <param name="isToCompareUniqueIdentifier">will compare/filter uniqueIdentifier property/field/column if true, otherwise false</param>
        /// <param name="uniqueIdentifier">value to compare/filter with uniqueIdentifier property/field/column</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="queryOrderByExpression">The query order by expression.</param>
        /// <returns>business layer built-in message <see cref="MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation"/></returns>
        public static MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation GetMessageOfKeyInformationByIdentifierAndUniqueConstraint(
            bool isToCompareId, System.Int64? id
            , bool isToCompareUniqueIdentifier, System.Guid? uniqueIdentifier
            , int currentIndex
            , int pageSize
            , string queryOrderByExpression        )

        {
            MSBuildExtensionPack.WcfContracts.IOrganizationService _BusinessLogicLayerInstance = MSBuildExtensionPack.WcfContracts.WcfServiceResolver.ResolveWcfServiceOrganization();
            var _Request = new MSBuildExtensionPack.CommonBLLEntities.OrganizationRequestMessageUserDefinedOfIdentifierAndUniqueConstraint(
                Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search
                , "GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint"
                , Guid.NewGuid().ToString()
                , currentIndex
                , pageSize
                , queryOrderByExpression
                );
            _Request.Criteria = _GetOrganizationChainedQueryCriteriaIdentifierAndUniqueConstraint(
                isToCompareId, id
                , isToCompareUniqueIdentifier, uniqueIdentifier
                );
            MSBuildExtensionPack.CommonBLLEntities.OrganizationResponseMessageBuiltIn.KeyInformation _Response = _BusinessLogicLayerInstance.GetCollectionOfKeyInformationByIdentifierAndUniqueConstraint(_Request);
            return _Response;
        }

        #endregion Query Methods Of KeyInformationByIdentifierAndUniqueConstraint

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLL
{
    public class OrganizationDataStreamService
        : Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.OrganizationCollection, MSBuildExtensionPack.DataSourceEntities.Organization>
    {
        public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ParentId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IsSystemBuiltIn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CreatedDateTime";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "VarcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TextColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NvarcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NtextColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BitColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BinaryColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "VarbinaryColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ImageColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TinyintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmallintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IntColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BigintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DecimalColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NumericColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmallmoneyColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "MoneyColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "FloatColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "RealColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DatetimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Datetime2Column";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmalldatetimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DateColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueidentifierColumn";

        }

        public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.Organization dataItem, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ParentId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IsSystemBuiltIn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CreatedDateTime;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.VarcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TextColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NvarcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NtextColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BitColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BinaryColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.VarbinaryColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ImageColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TinyintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmallintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IntColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BigintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DecimalColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NumericColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmallmoneyColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.MoneyColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.FloatColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.RealColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DatetimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Datetime2Column;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmalldatetimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DateColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueidentifierColumn;

        }

        public class Default
            : Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.Organization.Default>
        {
            public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2_UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ParentId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IsSystemBuiltIn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CreatedDateTime";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "VarcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TextColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NvarcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NtextColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BitColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BinaryColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "VarbinaryColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ImageColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TinyintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmallintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IntColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BigintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DecimalColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NumericColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmallmoneyColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "MoneyColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "FloatColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "RealColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DatetimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Datetime2Column";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmalldatetimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DateColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueidentifierColumn";

            }

            public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.Organization.Default dataItem, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2_UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ParentId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IsSystemBuiltIn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CreatedDateTime;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.VarcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TextColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NvarcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NtextColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BitColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BinaryColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.VarbinaryColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ImageColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TinyintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmallintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IntColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BigintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DecimalColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NumericColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmallmoneyColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.MoneyColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.FloatColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.RealColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DatetimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Datetime2Column;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmalldatetimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DateColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueidentifierColumn;

            }
        }

        public class DefaultGroupedDataView
            : Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataViewCollection, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView>
        {
            public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ParentId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CountPerFK";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            }

            public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultGroupedDataView dataItem, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ParentId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CountPerFK;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            }
        }

        public class DefaultWithPath
            : Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPathCollection, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath>
        {
            public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "RecursivePath__";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ParentId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IsSystemBuiltIn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CreatedDateTime";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "VarcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TextColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NvarcharColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NtextColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BitColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BinaryColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "VarbinaryColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "ImageColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TinyintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmallintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IntColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BigintColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DecimalColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "NumericColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmallmoneyColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "MoneyColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "FloatColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "RealColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DatetimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Datetime2Column";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "SmalldatetimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "DateColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "TimeColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueidentifierColumn";

            }

            public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.Organization.DefaultWithPath dataItem, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.RecursivePath__;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ParentId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IsSystemBuiltIn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CreatedDateTime;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.VarcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TextColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NvarcharColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NtextColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BitColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BinaryColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.VarbinaryColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.ImageColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TinyintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmallintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IntColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BigintColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DecimalColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.NumericColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmallmoneyColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.MoneyColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.FloatColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.RealColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DatetimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Datetime2Column;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.SmalldatetimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.DateColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.TimeColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueidentifierColumn;

            }
        }

        public class KeyInformation
            : Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformationCollection, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation>
        {
            public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "IsSystemBuiltIn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BitColumn";

            }

            public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation dataItem, int row)
            {
                char cell = 'A';

                string cellKey;
                cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.IsSystemBuiltIn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BitColumn;

            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildExtensionPack.CommonBLL
{
    public class BuildLogDataStreamService 
		: Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.BuildLogCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog>
    {
        public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildEventCodeId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Message";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "EventTime";


        }

        public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.BuildLog dataItem, int row)
        {
            char cell = 'A';

            string cellKey;
            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildEventCodeId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Message;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.EventTime;


        }


		public class Default 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Build_1_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Solution_1Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Solution_1_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_1_UniqueidentifierColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_1_UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_1Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_1_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2_UniqueidentifierColumn";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2_UniqueIdentifier";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildEventCode_1_Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildEventCodeId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Message";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "EventTime";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Build_1_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Solution_1Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Solution_1_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_1_UniqueidentifierColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_1_UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_1Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_1_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2_UniqueidentifierColumn;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2_UniqueIdentifier;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildEventCode_1_Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildEventCodeId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Message;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.EventTime;


			}
		}



		public class DefaultGroupedDataView 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataViewCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildEventCodeId";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "CountPerFK";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Name";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Solution_1Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_1Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Organization_2Id";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.BuildLog.DefaultGroupedDataView dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildEventCodeId;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.CountPerFK;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Name;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Solution_1Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_1Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Organization_2Id;


			}
		}



		public class KeyInformation 
			: Framework.Services.DataStreamServiceProviderBase<MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformationCollection, MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation>
		{
			public override void WriteHeaderLineToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "Id";

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = "BuildEventCodeId";


			}

			public override void WriteDataItemToClosedXmlWorkSheet(ClosedXML.Excel.IXLWorksheet worksheet, MSBuildExtensionPack.DataSourceEntities.BuildLog.KeyInformation dataItem, int row)
			{
				char cell = 'A';

				string cellKey;
	            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.Id;

            cellKey = Framework.Services.ClosedXmlHelper.GetCellKey(row, cell ++);
            worksheet.Cell(cellKey).Value = dataItem.BuildEventCodeId;


			}
		}



    }
}
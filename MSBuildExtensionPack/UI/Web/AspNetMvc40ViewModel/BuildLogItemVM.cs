using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class BuildLogItemVM : Framework.ViewModels.ViewModelItemBase<MSBuildExtensionPack.DataSourceEntities.BuildLogIdentifier, MSBuildExtensionPack.DataSourceEntities.BuildLog.Default>
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

        public static BuildLogItemVM Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int64 valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            BuildLogItemVM vm = new BuildLogItemVM();

            try
            {
                log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildExtensionPack.CommonBLLEntities.BuildLogResponseMessageBuiltIn.Default _Response =
                    MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int64), valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    vm.Item = _Response.Message[0];
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                    log.Info(string.Format("{0}: {1}", uiAction, Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                }
                else
                {
                    vm.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    vm.StatusMessageOfResult = _Response.ServerErrorMessage;
                    vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                    log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));
                }
            }
            catch (Exception ex)
            {
                vm.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                vm.StatusMessageOfResult = ex.Message;
                vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), vm.StatusOfResult, vm.StatusMessageOfResult));
            }

            return vm;
        }

        public static BuildLogItemVM CreateNewViewModel(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            BuildLogItemVM vm = new BuildLogItemVM();
            vm.ContentData.Title = Framework.Resources.UIStringResource.AddNewAlternativeText;
            vm.ContentData.Summary = MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.AddNew_BuildLog;

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }
	}
}


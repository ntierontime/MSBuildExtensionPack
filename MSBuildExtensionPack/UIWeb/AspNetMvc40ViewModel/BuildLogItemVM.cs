using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class BuildLogItemVM : MSBuildExtensionPack.ViewModelData.BuildLogItemVM
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

                public List<SelectListItem> SelectListOfMSBuildExtensionPack_Organization { get; set; }
                public List<SelectListItem> SelectListOfMSBuildExtensionPack_BuildEventCode { get; set; }

        public void Load(bool isToCompareId, System.Int64? id
            , Framework.UIAction uiAction)
        {
            try
            {
                log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

                var _Response =
                    MSBuildExtensionPack.CommonBLLIoC.IoCBuildLog.GetMessageOfDefaultOfByIdentifier(isToCompareId, id, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    this.Item = _Response.Message[0];
                    this.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                    log.Info(string.Format("{0}: {1}", uiAction, Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    this.LoadExtraData(uiAction);
                }
                else
                {
                    this.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    this.StatusMessageOfResult = _Response.ServerErrorMessage;
                    this.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                    log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), this.StatusOfResult, this.StatusMessageOfResult));
                }
            }
            catch (Exception ex)
            {
                this.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                this.StatusMessageOfResult = ex.Message;
                this.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), this.StatusOfResult, this.StatusMessageOfResult));
            }
        }

        public static BuildLogItemVM CreateNewViewModel(MSBuildExtensionPack.DataSourceEntities.BuildLog.Default entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            BuildLogItemVM vm = new BuildLogItemVM();
            vm.ContentData.Title = Framework.Resx.UIStringResource.AddNew;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog.AddNew_BuildLog;
            vm.LoadExtraData(uiAction);

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(BuildLogItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }

        public void LoadExtraData(Framework.UIAction uiAction)
        {
            if (uiAction != Framework.UIAction.ViewDetails)
            {
                this.NameValueCollectionOfMSBuildExtensionPack_Organization = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
                this.SelectListOfMSBuildExtensionPack_Organization = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Organization);

                this.NameValueCollectionOfMSBuildExtensionPack_BuildEventCode = MSBuildExtensionPack.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
                this.SelectListOfMSBuildExtensionPack_BuildEventCode = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_BuildEventCode);

            }
        }
    }
}


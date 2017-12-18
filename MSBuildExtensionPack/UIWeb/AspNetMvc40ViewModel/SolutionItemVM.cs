using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40ViewModel
{
    public partial class SolutionItemVM : MSBuildExtensionPack.ViewModelData.SolutionItemVM
    {
        #region log4net

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion log4net

                public List<SelectListItem> SelectListOfMSBuildExtensionPack_Organization { get; set; }

        public void Load(bool isToCompareIdByIdentifierOftOfByIdentifier, System.Int32? valueToCompareIdByIdentifierOftOfByIdentifier
            , Framework.UIAction uiAction)
        {
            try
            {
                log.Info(string.Format("{0}: Details", Framework.LoggingOptions.UI_Process_Started.ToString()));

                MSBuildExtensionPack.CommonBLLEntities.SolutionResponseMessageBuiltIn.Default _Response =
                    MSBuildExtensionPack.CommonBLLIoC.IoCSolution.GetMessageOfDefaultOfByIdentifier(isToCompareIdByIdentifierOftOfByIdentifier && valueToCompareIdByIdentifierOftOfByIdentifier != default(System.Int32), valueToCompareIdByIdentifierOftOfByIdentifier, -1, -1, null);

                if (_Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageOK || _Response.BusinessLogicLayerResponseStatus == Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady)
                {
                    this.Item = _Response.Message[0];
                    this.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);
                    log.Info(string.Format("{0}: {1}", uiAction, Framework.LoggingOptions.UI_Process_Succeeded.ToString()));
                    this.LoadExtraData(uiAction);
                }
                else
                {
                    this.StatusOfResult = _Response.BusinessLogicLayerResponseStatus;
                    this.StatusMessageOfResult = _Response.ServerErrorMessage;
                    this.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                    log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), this.StatusOfResult, this.StatusMessageOfResult));
                }
            }
            catch (Exception ex)
            {
                this.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.MessageErrorDetected;
                this.StatusMessageOfResult = ex.Message;
                this.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Failed);
                log.Error(string.Format("{0}: {1}, {2}, {3}", uiAction, Framework.LoggingOptions.UI_Process_Failed.ToString(), this.StatusOfResult, this.StatusMessageOfResult));
            }
        }

        public static SolutionItemVM CreateNewViewModel(MSBuildExtensionPack.DataSourceEntities.Solution.Default entity)
        {
            Framework.UIAction uiAction = Framework.UIAction.Create;
            SolutionItemVM vm = new SolutionItemVM();
            vm.ContentData.Title = Framework.Resx.UIStringResource.AddNew;
            vm.ContentData.Summary = MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.AddNew_Solution;
            vm.LoadExtraData(uiAction);

            vm.Item = entity;
            vm.UIActionStatusMessage = new Framework.UIActionStatusMessage(typeof(SolutionItemVM).FullName, uiAction.ToString(), uiAction, Framework.UIActionStatus.Launch);

            return vm;
        }

        public void LoadExtraData(Framework.UIAction uiAction)
        {
            if (uiAction != Framework.UIAction.ViewDetails)
            {
                this.NameValueCollectionOfMSBuildExtensionPack_Organization = MSBuildExtensionPack.CommonBLLIoC.IoCOrganization.GetCollectionOfNameValuePairOfAll(new MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaAll(), new Framework.EntityContracts.QueryPagingSetting(), null);
                this.SelectListOfMSBuildExtensionPack_Organization = Framework.Mvc.MvcHelper.BuildListOfSelectListItem(this.NameValueCollectionOfMSBuildExtensionPack_Organization);

            }
        }
    }
}

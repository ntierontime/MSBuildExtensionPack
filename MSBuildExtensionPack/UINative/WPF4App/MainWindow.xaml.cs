using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.WPF4App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private bool _shutdown;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.Cleanup();

            InitializeNavigationSettingCollectionInMainViewModel();

            Messenger.Default.Register<Framework.UIActionStatusMessage>(
                this,
                message =>
                {
                    if (MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Exists(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus))
                    {
                        var navigationSetting = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.FirstOrDefault(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus);
                        if (navigationSetting != null)
                        {
                            if (navigationSetting.UIAction == Framework.UIAction.Search && navigationSetting.UIActionStatus == Framework.UIActionStatus.Starting)
                            {
                                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.IsBusy = true;
                            }
                            else
                            {
                                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.IsBusy = false;
                            }

                            if (navigationSetting.NextUIAction == Framework.UIAction.GoBack)
                            {
                                _mainFrame.GoBack();
                            }
                            else if (navigationSetting.NextUIAction == Framework.UIAction.Navigate)
                            {
                                _mainFrame.Navigate(new Uri(navigationSetting.TargetUrl, UriKind.Relative));
                            }
                        }
                    }
                });
        }

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
            #region Workspaces with MasterTypeFullName

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.WPCommonOfBuild));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPsomethingOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPsomethingOfBuildVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/WPsomethingOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.WPsomethingOfBuild));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.WPCommonOfBuildEventCode));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.WPCommonOfBuildLog));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/WPCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.WPCommonOfOrganization));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.WPCommonOfSolution));

            #endregion Workspaces with MasterTypeFullName

            #region Create, Update and Delete, Details of MSBuildExtensionPack.Build

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.WPCommonOfBuild));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.WPCommonOfBuild));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.WPCommonOfBuild));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Build

            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.WPCommonOfBuildEventCode));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.WPCommonOfBuildEventCode));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.WPCommonOfBuildEventCode));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.WPCommonOfBuildLog));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.WPCommonOfBuildLog));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.WPCommonOfBuildLog));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            #region Create, Update and Delete, Details of MSBuildExtensionPack.Organization

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Organization/WPCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.WPCommonOfOrganization));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Organization/WPCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.WPCommonOfOrganization));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Organization/WPCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.WPCommonOfOrganization));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Organization/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Organization.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Organization

            #region Create, Update and Delete, Details of MSBuildExtensionPack.Solution

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.WPCommonOfSolution));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.WPCommonOfSolution));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.WPCommonOfSolution));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Solution

        }

        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel) return;
            e.Cancel = !_shutdown && MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.QuitConfirmationEnabled;
            if (_shutdown) return;

            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = Framework.Resx.UIStringResource.Quit,
                NegativeButtonText = Framework.Resx.UIStringResource.Cancel,
                AnimateShow = true,
                AnimateHide = false
            };

            var result = await this.ShowMessageAsync(Framework.Resx.UIStringResource.QuitApplication,
                Framework.Resx.UIStringResource.QuitApplicationMessage,
                MessageDialogStyle.AffirmativeAndNegative, mySettings);

            _shutdown = result == MessageDialogResult.Affirmative;

            if (_shutdown)
            {
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.Cleanup();
                Application.Current.Shutdown();
            }
        }
    }
}


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
            Closing += (s, e) => MSBuildExtensionPack.ViewModels.ViewModelLocator.Cleanup();

            // The MVVM Light Messenger In-Depth: http://msdn.microsoft.com/en-us/magazine/dn745866.aspx

			InitializeMainMenuTree();

            InitializeNavigationSettingCollectionInMainViewModel();

            Messenger.Default.Register<Framework.UIActionStatusMessage>(
                this,
                message =>
                {
                    if (MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Exists(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus))
                    {
                        var navigationSetting = MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.FirstOrDefault(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus);
                        if (navigationSetting != null)
                        {
                            if (navigationSetting.UIAction == Framework.UIAction.Search && navigationSetting.UIActionStatus == Framework.UIActionStatus.Starting)
                            {
                                MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.IsBusy = true;
                            }
                            else
                            {
                                MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.IsBusy = false;
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


        private static void InitializeMainMenuTree()
        {

			// 1.1 MSBuildExtensionPack.Build
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Build", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Build, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Build, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Build, null, null, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.2 MSBuildExtensionPack.BuildEventCode
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.BuildEventCode", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildEventCode, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildEventCode, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_BuildEventCode, null, null, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.3 MSBuildExtensionPack.BuildLog
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.BuildLog", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildLog, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildLog, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_BuildLog, null, null, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.4 MSBuildExtensionPack.Solution
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Solution", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Solution, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Solution, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Solution, null, null, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


        }

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
			#region Workspaces with MasterTypeFullName


            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuild));


            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildEventCode));


            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildLog));


            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfSolution));



			#endregion Workspaces with MasterTypeFullName


            #region Create, Update and Delete, Details of MSBuildExtensionPack.Build

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuild));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuild));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuild));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Details));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Details));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Edit));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Build.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Build



            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildEventCode));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildEventCode));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildEventCode));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Details));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Details));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Edit));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildEventCode.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode



            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildLog));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildLog));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfBuildLog));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Details));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Details));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Edit));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.BuildLog.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog



            #region Create, Update and Delete, Details of MSBuildExtensionPack.Solution

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfSolution));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfSolution));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.WPCommonOfSolution));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Details));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Create));

            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Details));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Edit));
            MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildExtensionPack.WPF4App.Pages.Solution.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Solution



		}

        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel) return;
            e.Cancel = !_shutdown && MSBuildExtensionPack.ViewModels.ViewModelLocator.MainStatic.QuitConfirmationEnabled;
            if (_shutdown) return;

            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = Framework.Resources.UIStringResource.Quit,
                NegativeButtonText = Framework.Resources.UIStringResource.CancelAlternativeText,
                AnimateShow = true,
                AnimateHide = false
            };

            var result = await this.ShowMessageAsync(Framework.Resources.UIStringResource.QuitApplication,
                Framework.Resources.UIStringResource.QuitApplicationMessage,
                MessageDialogStyle.AffirmativeAndNegative, mySettings);

            _shutdown = result == MessageDialogResult.Affirmative;

            if (_shutdown)
            {
                MSBuildExtensionPack.ViewModels.ViewModelLocator.Cleanup();
                Application.Current.Shutdown();
            }
        }
    }
}


using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Grid App template is documented at http://go.microsoft.com/fwlink/?LinkId=234226

namespace MSBuildExtensionPack.WinStoreApp
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton Application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
			
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer, Framework.CommonBLLEntities.BusinessLogicLayerContextContainerCommon>();

            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildExtensionPack.WcfContracts.IBusinessLogicLayerFactoryAsyn, MSBuildExtensionPack.WcfClientBLL.WcfClientFactoryAsyn>();

            Framework.CommonBLLEntities.BusinessLogicLayerMemberShip _BusinessLogicLayerMemberShip = new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip();
            Framework.CommonBLLEntities.SessionVariablesCommon.BusinessLogicLayerContext = new Framework.CommonBLLEntities.BusinessLogicLayerContext(_BusinessLogicLayerMemberShip);
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();
                //Associate the frame with a Framework.Xaml.SuspensionManager key                                
                Framework.Xaml.SuspensionManager.RegisterFrame(rootFrame, "AppFrame");

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Restore the saved session state only when appropriate
                    try
                    {
                        await Framework.Xaml.SuspensionManager.RestoreAsync();
                    }
                    catch (Framework.Xaml.SuspensionManagerException)
                    {
                        //Something went wrong restoring state.
                        //Assume there is no state and continue
                    }
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }
            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(MSBuildExtensionPack.WinStoreApp.GroupedItemsPage), "AllGroups"))
                {
                    throw new Exception("Failed to create initial page");
                }
            }
            // Ensure the current window is active
            Window.Current.Activate();

            // The MVVM Light Messenger In-Depth: http://msdn.microsoft.com/en-us/magazine/dn745866.aspx

			InitializeMainMenuTree();

            InitializeNavigationSettingCollectionInMainViewModel();

            Messenger.Default.Register<Framework.UIActionStatusMessage>(
                this,
                message =>
                {
                    if (MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Count(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus) > 0)
                    {
                        var navigationSetting = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.FirstOrDefault(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus);
                        if (navigationSetting != null)
                        {
                            if (navigationSetting.NextUIAction == Framework.UIAction.GoBack)
                            {
                                rootFrame.GoBack();
                            }
                            else if (navigationSetting.NextUIAction == Framework.UIAction.Navigate)
                            {
                                rootFrame.Navigate(navigationSetting.TargetPageType);
                            }
                        }
                    }
                });
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await Framework.Xaml.SuspensionManager.SaveAsync();
            deferral.Complete();
        }


        private static void InitializeMainMenuTree()
        {
// 1.1 MSBuildExtensionPack.Build
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Build", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Build, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Build, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Build, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
// 1.2 MSBuildExtensionPack.BuildEventCode
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.BuildEventCode", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildEventCode, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildEventCode, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_BuildEventCode, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
// 1.3 MSBuildExtensionPack.BuildLog
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.BuildLog", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildLog, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildLog, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_BuildLog, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
// 1.4 MSBuildExtensionPack.Solution
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Solution", MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Solution, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Solution, MSBuildExtensionPack.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Solution, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);

        }

        #region InitializeNavigationSettingCollectionInMainViewModel()

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
            #region Workspaces with MasterTypeFullName
MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuild));
MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildEventCode));
MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildLog));
MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfSolution));

            #endregion Workspaces with MasterTypeFullName
#region Create, Update and Delete, Details of MSBuildExtensionPack.Build

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuild));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuild));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuild));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Build.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Build.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Build.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Build.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Build
#region Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildEventCode));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildEventCode));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildEventCode));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildEventCode.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildEventCode.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildEventCode.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode
#region Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildLog));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildLog));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfBuildLog));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildLog.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildLog.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildLog.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.BuildLog.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog
#region Create, Update and Delete, Details of MSBuildExtensionPack.Solution

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfSolution));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfSolution));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.WPCommonOfSolution));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Solution.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Solution.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Solution.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildExtensionPack.WinStoreApp.Pages.Solution.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Solution

        }

        #endregion InitializeNavigationSettingCollectionInMainViewModel()
    }
}
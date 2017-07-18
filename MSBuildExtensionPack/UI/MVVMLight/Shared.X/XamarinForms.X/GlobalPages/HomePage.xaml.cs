using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms.GlobalPages {
	public partial class HomePage : ContentPage {
		public HomePage() {
			InitializeComponent();
			Closing += (s, e) => MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.Cleanup();

			// The MVVM Light Messenger In-Depth: http://msdn.microsoft.com/en-us/magazine/dn745866.aspx

			InitializeMainMenuTree();

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

        private static void InitializeMainMenuTree()
        {

			// 1.1 MSBuildExtensionPack.Build
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Build", MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Build, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Build, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Build, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.2 MSBuildExtensionPack.BuildEventCode
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.BuildEventCode", MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildEventCode, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildEventCode, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_BuildEventCode, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.3 MSBuildExtensionPack.BuildLog
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.BuildLog", MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildLog, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_BuildLog, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_BuildLog, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.4 MSBuildExtensionPack.Organization
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Organization", MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Organization, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Organization, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Organization, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


			// 1.5 MSBuildExtensionPack.Solution
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildExtensionPack.Solution", MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Solution, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Common_of_MSBuildExtensionPack_Solution, MSBuildExtensionPack.Resx.UIStringResourcePerApp.Description_Of_Common_of_MSBuildExtensionPack_Solution, null, null, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.Search, Framework.UIActionStatus.Launch);


        }

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
			#region Workspaces with MasterTypeFullName


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonOfBuild));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonOfBuildEventCode));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonOfBuildLog));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonOfOrganization));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonOfSolution));



			#endregion Workspaces with MasterTypeFullName


            #region Create, Update and Delete, Details of MSBuildExtensionPack.Build

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

			// TODO: removed 5 lines

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Create));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Build



            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

			// TODO: removed 5 lines

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Create));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode



            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

			// TODO: removed 5 lines

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Create));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog



            #region Create, Update and Delete, Details of MSBuildExtensionPack.Organization

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

			// TODO: removed 5 lines

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Create));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Organization



            #region Create, Update and Delete, Details of MSBuildExtensionPack.Solution

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

			// TODO: removed 5 lines

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Create));


            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.ViewDetails,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Solution



		}

	}
}


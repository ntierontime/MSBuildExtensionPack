using System;
using System.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms.Pages {
    public partial class HomePage : ContentPage {
        public HomePage() {
            InitializeComponent();

            // The MVVM Light Messenger In-Depth: http://msdn.microsoft.com/en-us/magazine/dn745866.aspx

            InitializeNavigationSettingCollectionInMainViewModel();

            Messenger.Default.Register<Framework.UIActionStatusMessage>(
                this,
                message =>
                {
                    var dispatcherHelper = Framework.Xaml.IDispatcherHelperWrapperService.GetDispatcherHelper();

                    dispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (message.UIAction == Framework.UIAction.Home)
                        {
                            App.NavigationPage.Navigation.PopToRootAsync();
                        }
                        else if (message.UIAction == Framework.UIAction.GoBack)
                        {
                            App.NavigationPage.Navigation.PopAsync();
                        }
                        else if (MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Exists(t => t.SourceTypeFullName == message.SourceTypeFullName && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus))
                        {
                            var navigationSetting = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.FirstOrDefault(t => t.SourceTypeFullName == message.SourceTypeFullName && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus);
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

                                if (navigationSetting.NextUIAction == Framework.UIAction.Navigate)
                                {
                                    var page = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.GetPageInstanceSingleton(navigationSetting.TargetPageType);

                                    App.NavigationPage.Navigation.PushAsync((Page)page);
                                }
                                else if (navigationSetting.NextUIAction == Framework.UIAction.GoBack)
                                {
                                    App.NavigationPage.Navigation.PopAsync();
                                }
                            }
                        }
                    });
                });
        }

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
            // 1. Common Workspace

            // MSBuildExtensionPack.Build.TabContainer
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/WPTabbedCommonOfBuild.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.WPTabbedCommonOfBuild));

            // MSBuildExtensionPack.BuildEventCode.TabContainer
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPTabbedCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.WPTabbedCommonOfBuildEventCode));

            // MSBuildExtensionPack.BuildLog.TabContainer
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/WPTabbedCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.WPTabbedCommonOfBuildLog));

            // MSBuildExtensionPack.Organization.TabContainer
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/WPTabbedCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.WPTabbedCommonOfOrganization));

            // MSBuildExtensionPack.Solution.TabContainer
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/WPTabbedCommonOfSolution.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.WPTabbedCommonOfSolution));

            #region Create, Update and Delete, Details of MSBuildExtensionPack.Build

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/WPTabbedCommonOfBuild.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.WPTabbedCommonOfBuild));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/WPTabbedCommonOfBuild.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.WPTabbedCommonOfBuild));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Create));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Build.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Build

            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPTabbedCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.WPTabbedCommonOfBuildEventCode));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/WPTabbedCommonOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.WPTabbedCommonOfBuildEventCode));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Create));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            #region Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/WPTabbedCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.WPTabbedCommonOfBuildLog));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/WPTabbedCommonOfBuildLog.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.WPTabbedCommonOfBuildLog));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Create));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildLog.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildLog

            #region Create, Update and Delete, Details of MSBuildExtensionPack.Organization

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Organization/WPTabbedCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.WPTabbedCommonOfOrganization));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Organization/WPTabbedCommonOfOrganization.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.WPTabbedCommonOfOrganization));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Create));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Organization/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Organization.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Organization

            #region Create, Update and Delete, Details of MSBuildExtensionPack.Solution

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/WPTabbedCommonOfSolution.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.WPTabbedCommonOfSolution));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/WPTabbedCommonOfSolution.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.WPTabbedCommonOfSolution));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Create));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Details));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.Solution.Delete));

            #endregion Create, Update and Delete, Details of MSBuildExtensionPack.Solution

        }
    }
}


using System;
using System.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms.GlobalPages {
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
                                    //_mainFrame.GoBack();
                                }
                                else if (navigationSetting.NextUIAction == Framework.UIAction.Navigate)
                                {
                                    var page = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.GetPageInstanceSingleton(navigationSetting.TargetPageType);

                                    App.NavigationPage.Navigation.PopAsync();
                                    App.NavigationPage.Navigation.PushAsync((ContentPage)page);
                                    App.MenuIsPresented = false;
                                }
                            }
                        }
                    });
                });
        }

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
            // 1. Common Workspace

            // MSBuildExtensionPack.Build.Search
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonSearchViewOfBuild.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonSearchViewOfBuild));

            // MSBuildExtensionPack.Build.Result
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM.ViewName_Static, Framework.UIAction.Result,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonResultViewOfBuild.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonResultViewOfBuild));

            // MSBuildExtensionPack.BuildEventCode.Search
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonSearchViewOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonSearchViewOfBuildEventCode));

            // MSBuildExtensionPack.BuildEventCode.Result
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM.ViewName_Static, Framework.UIAction.Result,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonResultViewOfBuildEventCode.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonResultViewOfBuildEventCode));

            // MSBuildExtensionPack.BuildLog.Search
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonSearchViewOfBuildLog.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonSearchViewOfBuildLog));

            // MSBuildExtensionPack.BuildLog.Result
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM.ViewName_Static, Framework.UIAction.Result,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonResultViewOfBuildLog.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonResultViewOfBuildLog));

            // MSBuildExtensionPack.Organization.Search
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonSearchViewOfOrganization.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonSearchViewOfOrganization));

            // MSBuildExtensionPack.Organization.Result
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM.ViewName_Static, Framework.UIAction.Result,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonResultViewOfOrganization.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonResultViewOfOrganization));

            // MSBuildExtensionPack.Solution.Search
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonSearchViewOfSolution.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonSearchViewOfSolution));

            // MSBuildExtensionPack.Solution.Result
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM.ViewName_Static, Framework.UIAction.Result,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonResultViewOfSolution.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.WPCommonResultViewOfSolution));

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

            //#region Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Details));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            // TODO: removed 5 lines

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Create));

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Edit));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.EntityName_Static, MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode.Delete));

            //#endregion Create, Update and Delete, Details of MSBuildExtensionPack.BuildEventCode

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


/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MSBuildExtensionPack.MVVMLightViewModels"
                                   x:Key="Locator" />
  </Application.Resources>

  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  OR (WPF only):

  xmlns:vm="clr-namespace:MSBuildExtensionPack.MVVMLightViewModels"
  DataContext="{Binding Source={x:Static vm:ViewModelLocatorTemplate.ViewModelNameStatic}}"
*/

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// Use the <strong>mvvmlocatorproperty</strong> snippet to add ViewModels
    /// to this locator.
    /// </para>
    /// <para>
    /// In Silverlight and WPF, place the ViewModelLocatorTemplate in the App.xaml resources:
    /// </para>
    /// <code>
    /// &lt;Application.Resources&gt;
    ///     &lt;vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MSBuildExtensionPack.MVVMLightViewModels"
    ///                                  x:Key="Locator" /&gt;
    /// &lt;/Application.Resources&gt;
    /// </code>
    /// <para>
    /// Then use:
    /// </para>
    /// <code>
    /// DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
    /// </code>
    /// <para>
    /// You can also use Blend to do all this with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// <para>
    /// In <strong>*WPF only*</strong> (and if databinding in Blend is not relevant), you can delete
    /// the Main property and bind to the ViewModelNameStatic property instead:
    /// </para>
    /// <code>
    /// xmlns:vm="clr-namespace:MSBuildExtensionPack.MVVMLightViewModels"
    /// DataContext="{Binding Source={x:Static vm:ViewModelLocatorTemplate.ViewModelNameStatic}}"
    /// </code>
    /// </summary>
    public class ViewModelLocator
    {
        public static string WebApiRootUrl { get; set; }

        #region constructors

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view models
            ////}
            ////else
            ////{
            ////    // Create run time view models
            ////}

            CreateMain();
        }

        #endregion constructors

        #region MSBuildExtensionPack.MVVMLightViewModels.MainViewModel

        private static MSBuildExtensionPack.MVVMLightViewModels.MainViewModel _main;

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        public static MSBuildExtensionPack.MVVMLightViewModels.MainViewModel MainStatic
        {
            get
            {
                if (_main == null)
                {
                    CreateMain();
                }

                return _main;
            }
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MSBuildExtensionPack.MVVMLightViewModels.MainViewModel Main
        {
            get
            {
                return MainStatic;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the Main property.
        /// </summary>
        public static void ClearMain()
        {
            _main.Cleanup();
            _main = null;
        }

        /// <summary>
        /// Provides a deterministic way to create the Main property.
        /// </summary>
        public static void CreateMain()
        {
            if (_main == null)
            {
                _main = new MSBuildExtensionPack.MVVMLightViewModels.MainViewModel();
            }
        }

        #endregion MSBuildExtensionPack.MVVMLightViewModels.MainViewModel

        #region MVVMViewModel #1.1: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM

        private static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM;
        public static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM

        #region MVVMViewModel #1.5: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM;
        public static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM

        #region MVVMViewModel #1.9: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM

        private static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM;
        public static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM

        #region MVVMViewModel #1.13: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM

        private static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM;
        public static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM

        #region MVVMViewModel #1.17: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM

        private static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM;
        public static MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM = new MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM

        #region MVVMViewModel #2.1: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild

        private static MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild;
        public static MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild = new MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild

        #region MVVMViewModel #2.2: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode

        private static MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode;
        public static MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode = new MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode

        #region MVVMViewModel #2.3: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog

        private static MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog;
        public static MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog = new MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog

        #region MVVMViewModel #2.4: MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization

        private static MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization;
        public static MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization = new MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization

        #region MVVMViewModel #2.5: MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution

        private static MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution;
        public static MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution = new MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution

        #region MVVMViewModel #3.1: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild

        private static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild;
        public static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild = new MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild

        #region MVVMViewModel #3.2: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode

        private static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode;
        public static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode = new MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode

        #region MVVMViewModel #3.3: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog

        private static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog;
        public static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog = new MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog

        #region MVVMViewModel #3.4: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization

        private static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization;
        public static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization = new MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization

        #region MVVMViewModel #3.5: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution

        private static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution;
        public static MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution == null)
                {
                    CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution();
                }

                return m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution;
            }
        }

        public MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution
        {
            get
            {
                return MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution != null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution.Cleanup();
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution()
        {
            if (m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution == null)
            {
                m_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution = new MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {

            // #1.1: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildVM
            Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM();

            // #1.5: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildEventCodeVM
            Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM();

            // #1.9: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfBuildLogVM
            Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM();

            // #1.13: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfOrganizationVM
            Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM();

            // #1.17: MSBuildExtensionPack.MVVMLightViewModels.WPCommonOfSolutionVM
            Clear_MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM();

            // #2.1: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuild
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild();

            // #2.2: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildEventCode
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode();

            // #2.3: MSBuildExtensionPack.MVVMLightViewModels.ItemVMBuildLog
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog();

            // #2.4: MSBuildExtensionPack.MVVMLightViewModels.ItemVMOrganization
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization();

            // #2.5: MSBuildExtensionPack.MVVMLightViewModels.ItemVMSolution
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution();

            // #3.1: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuild
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild();

            // #3.2: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildEventCode
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildEventCode();

            // #3.3: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMBuildLog
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog();

            // #3.4: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMOrganization
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMOrganization();

            // #3.5: MSBuildExtensionPack.MVVMLightViewModels.ExtendedVMSolution
            Clear_MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMSolution();

            // #4. ClearMain -- CleanUp
            ClearMain();
        }
    }
}


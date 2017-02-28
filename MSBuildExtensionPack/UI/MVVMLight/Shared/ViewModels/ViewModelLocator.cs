/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MSBuildExtensionPack.ViewModels"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
  
  OR (WPF only):
  
  xmlns:vm="clr-namespace:MSBuildExtensionPack.ViewModels"
  DataContext="{Binding Source={x:Static vm:ViewModelLocatorTemplate.ViewModelNameStatic}}"
*/

namespace MSBuildExtensionPack.ViewModels
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
    ///     &lt;vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MSBuildExtensionPack.ViewModels"
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
    /// xmlns:vm="clr-namespace:MSBuildExtensionPack.ViewModels"
    /// DataContext="{Binding Source={x:Static vm:ViewModelLocatorTemplate.ViewModelNameStatic}}"
    /// </code>
    /// </summary>
    public class ViewModelLocator
    {
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

        #region MSBuildExtensionPack.ViewModels.MainViewModel

        private static MSBuildExtensionPack.ViewModels.MainViewModel _main;

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        public static MSBuildExtensionPack.ViewModels.MainViewModel MainStatic
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
        public MSBuildExtensionPack.ViewModels.MainViewModel Main
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
                _main = new MSBuildExtensionPack.ViewModels.MainViewModel();
            }
        }

        #endregion MSBuildExtensionPack.ViewModels.MainViewModel



        #region MVVMViewModel #1.1: MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM

        private static MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM;
        public static MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_WPCommonOfBuildVM();
                }

                return m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM;
            }
        }

        public MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM != null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM.Cleanup();
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM == null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM = new MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM




        #region MVVMViewModel #1.2: MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM;
        public static MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM();
                }

                return m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM;
            }
        }

        public MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM != null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM.Cleanup();
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM == null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM = new MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM




        #region MVVMViewModel #1.3: MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM;
        public static MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM();
                }

                return m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM;
            }
        }

        public MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM != null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM.Cleanup();
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM == null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM = new MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM




        #region MVVMViewModel #1.4: MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM

        private static MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM;
        public static MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM();
                }

                return m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM;
            }
        }

        public MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM != null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM.Cleanup();
                m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM == null)
            {
                m_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM = new MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM






        #region MVVMViewModel #2.1: MSBuildExtensionPack.ViewModels.ItemVMBuild

        private static MSBuildExtensionPack.ViewModels.ItemVMBuild m_MSBuildExtensionPack_ViewModels_ItemVMBuild;
        public static MSBuildExtensionPack.ViewModels.ItemVMBuild MSBuildExtensionPack_ViewModels_ItemVMBuild_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ItemVMBuild == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ItemVMBuild();
                }

                return m_MSBuildExtensionPack_ViewModels_ItemVMBuild;
            }
        }

        public MSBuildExtensionPack.ViewModels.ItemVMBuild MSBuildExtensionPack_ViewModels_ItemVMBuild
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ItemVMBuild_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ItemVMBuild property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ItemVMBuild()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMBuild != null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMBuild.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ItemVMBuild = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ItemVMBuild property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ItemVMBuild()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMBuild == null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMBuild = new MSBuildExtensionPack.ViewModels.ItemVMBuild();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ItemVMBuild




        #region MVVMViewModel #2.2: MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode

        private static MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode;
        public static MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ItemVMBuildEventCode();
                }

                return m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode;
            }
        }

        public MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode != null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ItemVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode == null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode = new MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode




        #region MVVMViewModel #2.3: MSBuildExtensionPack.ViewModels.ItemVMBuildLog

        private static MSBuildExtensionPack.ViewModels.ItemVMBuildLog m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog;
        public static MSBuildExtensionPack.ViewModels.ItemVMBuildLog MSBuildExtensionPack_ViewModels_ItemVMBuildLog_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ItemVMBuildLog();
                }

                return m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog;
            }
        }

        public MSBuildExtensionPack.ViewModels.ItemVMBuildLog MSBuildExtensionPack_ViewModels_ItemVMBuildLog
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ItemVMBuildLog_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ItemVMBuildLog property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ItemVMBuildLog()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog != null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ItemVMBuildLog property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ItemVMBuildLog()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog == null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMBuildLog = new MSBuildExtensionPack.ViewModels.ItemVMBuildLog();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ItemVMBuildLog




        #region MVVMViewModel #2.4: MSBuildExtensionPack.ViewModels.ItemVMSolution

        private static MSBuildExtensionPack.ViewModels.ItemVMSolution m_MSBuildExtensionPack_ViewModels_ItemVMSolution;
        public static MSBuildExtensionPack.ViewModels.ItemVMSolution MSBuildExtensionPack_ViewModels_ItemVMSolution_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ItemVMSolution == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ItemVMSolution();
                }

                return m_MSBuildExtensionPack_ViewModels_ItemVMSolution;
            }
        }

        public MSBuildExtensionPack.ViewModels.ItemVMSolution MSBuildExtensionPack_ViewModels_ItemVMSolution
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ItemVMSolution_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ItemVMSolution property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ItemVMSolution()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMSolution != null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMSolution.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ItemVMSolution = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ItemVMSolution property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ItemVMSolution()
        {
            if (m_MSBuildExtensionPack_ViewModels_ItemVMSolution == null)
            {
                m_MSBuildExtensionPack_ViewModels_ItemVMSolution = new MSBuildExtensionPack.ViewModels.ItemVMSolution();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ItemVMSolution






        #region MVVMViewModel #3.1: MSBuildExtensionPack.ViewModels.ExtendedVMBuild

        private static MSBuildExtensionPack.ViewModels.ExtendedVMBuild m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild;
        public static MSBuildExtensionPack.ViewModels.ExtendedVMBuild MSBuildExtensionPack_ViewModels_ExtendedVMBuild_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ExtendedVMBuild();
                }

                return m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild;
            }
        }

        public MSBuildExtensionPack.ViewModels.ExtendedVMBuild MSBuildExtensionPack_ViewModels_ExtendedVMBuild
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ExtendedVMBuild_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ExtendedVMBuild property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ExtendedVMBuild()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild != null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ExtendedVMBuild property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ExtendedVMBuild()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild == null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuild = new MSBuildExtensionPack.ViewModels.ExtendedVMBuild();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ExtendedVMBuild




        #region MVVMViewModel #3.2: MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode

        private static MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode;
        public static MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode();
                }

                return m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode;
            }
        }

        public MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode != null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode == null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode = new MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode




        #region MVVMViewModel #3.3: MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog

        private static MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog;
        public static MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ExtendedVMBuildLog();
                }

                return m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog;
            }
        }

        public MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog != null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ExtendedVMBuildLog()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog == null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog = new MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog




        #region MVVMViewModel #3.4: MSBuildExtensionPack.ViewModels.ExtendedVMSolution

        private static MSBuildExtensionPack.ViewModels.ExtendedVMSolution m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution;
        public static MSBuildExtensionPack.ViewModels.ExtendedVMSolution MSBuildExtensionPack_ViewModels_ExtendedVMSolution_Static
        {
            get
            {
                if (m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution == null)
                {
                    CreateMSBuildExtensionPack_ViewModels_ExtendedVMSolution();
                }

                return m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution;
            }
        }

        public MSBuildExtensionPack.ViewModels.ExtendedVMSolution MSBuildExtensionPack_ViewModels_ExtendedVMSolution
        {
            get
            {
                return MSBuildExtensionPack_ViewModels_ExtendedVMSolution_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildExtensionPack_ViewModels_ExtendedVMSolution property.
        /// </summary>
        public static void Clear_MSBuildExtensionPack_ViewModels_ExtendedVMSolution()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution != null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution.Cleanup();
                m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildExtensionPack_ViewModels_ExtendedVMSolution property.
        /// </summary>
        public static void CreateMSBuildExtensionPack_ViewModels_ExtendedVMSolution()
        {
            if (m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution == null)
            {
                m_MSBuildExtensionPack_ViewModels_ExtendedVMSolution = new MSBuildExtensionPack.ViewModels.ExtendedVMSolution();
            }
        }

        #endregion MVVMViewModel: MSBuildExtensionPack.ViewModels.ExtendedVMSolution




        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {


			// #1.1: MSBuildExtensionPack.ViewModels.WPCommonOfBuildVM
			Clear_MSBuildExtensionPack_ViewModels_WPCommonOfBuildVM();


			// #1.2: MSBuildExtensionPack.ViewModels.WPCommonOfBuildEventCodeVM
			Clear_MSBuildExtensionPack_ViewModels_WPCommonOfBuildEventCodeVM();


			// #1.3: MSBuildExtensionPack.ViewModels.WPCommonOfBuildLogVM
			Clear_MSBuildExtensionPack_ViewModels_WPCommonOfBuildLogVM();


			// #1.4: MSBuildExtensionPack.ViewModels.WPCommonOfSolutionVM
			Clear_MSBuildExtensionPack_ViewModels_WPCommonOfSolutionVM();




			// #2.1: MSBuildExtensionPack.ViewModels.ItemVMBuild
            Clear_MSBuildExtensionPack_ViewModels_ItemVMBuild();


			// #2.2: MSBuildExtensionPack.ViewModels.ItemVMBuildEventCode
            Clear_MSBuildExtensionPack_ViewModels_ItemVMBuildEventCode();


			// #2.3: MSBuildExtensionPack.ViewModels.ItemVMBuildLog
            Clear_MSBuildExtensionPack_ViewModels_ItemVMBuildLog();


			// #2.4: MSBuildExtensionPack.ViewModels.ItemVMSolution
            Clear_MSBuildExtensionPack_ViewModels_ItemVMSolution();




			// #3.1: MSBuildExtensionPack.ViewModels.ExtendedVMBuild
            Clear_MSBuildExtensionPack_ViewModels_ExtendedVMBuild();


			// #3.2: MSBuildExtensionPack.ViewModels.ExtendedVMBuildEventCode
            Clear_MSBuildExtensionPack_ViewModels_ExtendedVMBuildEventCode();


			// #3.3: MSBuildExtensionPack.ViewModels.ExtendedVMBuildLog
            Clear_MSBuildExtensionPack_ViewModels_ExtendedVMBuildLog();


			// #3.4: MSBuildExtensionPack.ViewModels.ExtendedVMSolution
            Clear_MSBuildExtensionPack_ViewModels_ExtendedVMSolution();



			// #4. ClearMain -- CleanUp
            ClearMain();
        }
    }
}


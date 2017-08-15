namespace MSBuildExtensionPack.MVVMLightViewModels
{
    /// <summary>
    /// http://netprogrammingodyssey.wordpress.com/2011/01/10/localizing-in-silverlight/
    /// </summary>
    public class LocalizedStrings
    {
        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedStrings"/> class.
        /// </summary>
        public LocalizedStrings()
        {
        }

        #endregion constructor

        #region UIComponentResourceFile_String per solution

        private static Framework.Resx.UIStringResource m_Framework_Resx_UIStringResource = Framework.Resx.ResourceFileFactory.GetUIStringResourceInstance();

        public Framework.Resx.UIStringResource Framework_Resx_UIStringResource { get { return m_Framework_Resx_UIStringResource; } }

        #endregion UIComponentResourceFile_String per solution

        #region UIComponentResourceFile_String_PerApplication per solution

        private static MSBuildExtensionPack.Resx.UIStringResourcePerApp m_MSBuildExtensionPack_Resx_UIStringResourcePerApp = MSBuildExtensionPack.Resx.ResourceFileFactory.GetUIStringResourcePerAppInstance();

        public MSBuildExtensionPack.Resx.UIStringResourcePerApp MSBuildExtensionPack_Resx_UIStringResourcePerApp { get { return m_MSBuildExtensionPack_Resx_UIStringResourcePerApp; } }

        #endregion UIComponentResourceFile_String_PerApplication per solution

        #region UIComponentResourceFile_String per entity

        private static MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuild = MSBuildExtensionPack.Resx.ResourceFileFactory.GetUIStringResourcePerEntityBuild();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild.
        /// </value>
        public MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuild { get { return m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuild; } }

        private static MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuildEventCode = MSBuildExtensionPack.Resx.ResourceFileFactory.GetUIStringResourcePerEntityBuildEventCode();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode.
        /// </value>
        public MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuildEventCode { get { return m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuildEventCode; } }

        private static MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuildLog = MSBuildExtensionPack.Resx.ResourceFileFactory.GetUIStringResourcePerEntityBuildLog();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog.
        /// </value>
        public MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuildLog { get { return m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityBuildLog; } }

        private static MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityOrganization = MSBuildExtensionPack.Resx.ResourceFileFactory.GetUIStringResourcePerEntityOrganization();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.
        /// </value>
        public MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization MSBuildExtensionPack_Resx_UIStringResourcePerEntityOrganization { get { return m_MSBuildExtensionPack_Resx_UIStringResourcePerEntityOrganization; } }

        private static MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution m_MSBuildExtensionPack_Resx_UIStringResourcePerEntitySolution = MSBuildExtensionPack.Resx.ResourceFileFactory.GetUIStringResourcePerEntitySolution();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.
        /// </value>
        public MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution MSBuildExtensionPack_Resx_UIStringResourcePerEntitySolution { get { return m_MSBuildExtensionPack_Resx_UIStringResourcePerEntitySolution; } }

        #endregion UIComponentResourceFile_String per entity
    }
}


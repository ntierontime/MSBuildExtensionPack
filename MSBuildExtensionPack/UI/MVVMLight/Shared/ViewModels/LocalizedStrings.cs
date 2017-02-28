namespace MSBuildExtensionPack.ViewModels
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

        private static Framework.Resources.UIStringResource m_Framework_Resources_UIStringResource = Framework.Resources.ResourceFileFactory.GetUIStringResourceInstance();

        public Framework.Resources.UIStringResource Framework_Resources_UIStringResource { get { return m_Framework_Resources_UIStringResource; } }

        #endregion UIComponentResourceFile_String per solution

        #region UIComponentResourceFile_String_PerApplication per solution

        private static MSBuildExtensionPack.Resources.UIStringResourcePerApp m_MSBuildExtensionPack_Resources_UIStringResourcePerApp = MSBuildExtensionPack.Resources.ResourceFileFactory.GetUIStringResourcePerAppInstance();

        public MSBuildExtensionPack.Resources.UIStringResourcePerApp MSBuildExtensionPack_Resources_UIStringResourcePerApp { get { return m_MSBuildExtensionPack_Resources_UIStringResourcePerApp; } }

        #endregion UIComponentResourceFile_String_PerApplication per solution

        #region UIComponentResourceFile_String per entity

        private static MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild m_MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuild = MSBuildExtensionPack.Resources.ResourceFileFactory.GetUIStringResourcePerEntityBuild();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.
        /// </value>
        public MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuild { get { return m_MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuild; } }

        private static MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode m_MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuildEventCode = MSBuildExtensionPack.Resources.ResourceFileFactory.GetUIStringResourcePerEntityBuildEventCode();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.
        /// </value>
        public MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuildEventCode { get { return m_MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuildEventCode; } }

        private static MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog m_MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuildLog = MSBuildExtensionPack.Resources.ResourceFileFactory.GetUIStringResourcePerEntityBuildLog();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.
        /// </value>
        public MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuildLog { get { return m_MSBuildExtensionPack_Resources_UIStringResourcePerEntityBuildLog; } }

        private static MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution m_MSBuildExtensionPack_Resources_UIStringResourcePerEntitySolution = MSBuildExtensionPack.Resources.ResourceFileFactory.GetUIStringResourcePerEntitySolution();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.
        /// </value>
        public MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution MSBuildExtensionPack_Resources_UIStringResourcePerEntitySolution { get { return m_MSBuildExtensionPack_Resources_UIStringResourcePerEntitySolution; } }


        #endregion UIComponentResourceFile_String per entity
    }
}



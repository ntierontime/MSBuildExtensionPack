namespace MSBuildExtensionPack.ViewModelData
{
    public class OrderByLists
    {

        #region 1.1. MSBuildExtensionPack.Build.WPCommonOfBuild

        public static Framework.NameValueCollection WPCommonOfBuildVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Solution_1_Name~ASC", "Solution_1_Name A-Z");
                list.Add("Solution_1_Name~DESC", "Solution_1_Name Z-A");
            return list;
        }

        #endregion 1.1. MSBuildExtensionPack.Build.WPCommonOfBuild

        #region 2.1. MSBuildExtensionPack.BuildEventCode.WPCommonOfBuildEventCode

        public static Framework.NameValueCollection WPCommonOfBuildEventCodeVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("EventCode~ASC", "EventCode A-Z");
                list.Add("EventCode~DESC", "EventCode Z-A");
            return list;
        }

        #endregion 2.1. MSBuildExtensionPack.BuildEventCode.WPCommonOfBuildEventCode

        #region 3.1. MSBuildExtensionPack.BuildLog.WPCommonOfBuildLog

        public static Framework.NameValueCollection WPCommonOfBuildLogVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Build_1_Name~ASC", "Build_1_Name A-Z");
                list.Add("Build_1_Name~DESC", "Build_1_Name Z-A");
            return list;
        }

        #endregion 3.1. MSBuildExtensionPack.BuildLog.WPCommonOfBuildLog

        #region 4.1. MSBuildExtensionPack.Organization.WPCommonOfOrganization

        public static Framework.NameValueCollection WPCommonOfOrganizationVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Organization_2_Name~ASC", "Organization_2_Name A-Z");
                list.Add("Organization_2_Name~DESC", "Organization_2_Name Z-A");
            return list;
        }

        #endregion 4.1. MSBuildExtensionPack.Organization.WPCommonOfOrganization

        #region 5.1. MSBuildExtensionPack.Solution.WPCommonOfSolution

        public static Framework.NameValueCollection WPCommonOfSolutionVM_GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("Organization_1_Name~ASC", "Organization_1_Name A-Z");
                list.Add("Organization_1_Name~DESC", "Organization_1_Name Z-A");
            return list;
        }

        #endregion 5.1. MSBuildExtensionPack.Solution.WPCommonOfSolution

    }
}


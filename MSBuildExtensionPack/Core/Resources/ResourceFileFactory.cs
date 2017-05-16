using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.Resources
{
    public static class ResourceFileFactory
    {
        public static MSBuildExtensionPack.Resources.UIStringResourcePerApp GetUIStringResourcePerAppInstance()
        {
            return new MSBuildExtensionPack.Resources.UIStringResourcePerApp();
        }


        public static MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild GetUIStringResourcePerEntityBuild()
        {
            return new MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild();
        }


        public static MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode GetUIStringResourcePerEntityBuildEventCode()
        {
            return new MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode();
        }


        public static MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog GetUIStringResourcePerEntityBuildLog()
        {
            return new MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog();
        }


        public static MSBuildExtensionPack.Resources.UIStringResourcePerEntityOrganization GetUIStringResourcePerEntityOrganization()
        {
            return new MSBuildExtensionPack.Resources.UIStringResourcePerEntityOrganization();
        }


        public static MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution GetUIStringResourcePerEntitySolution()
        {
            return new MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution();
        }


    }
}


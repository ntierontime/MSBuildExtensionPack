using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSBuildExtensionPack.Resx
{
    public static class ResourceFileFactory
    {
        public static MSBuildExtensionPack.Resx.UIStringResourcePerApp GetUIStringResourcePerAppInstance()
        {
            return new MSBuildExtensionPack.Resx.UIStringResourcePerApp();
        }

        public static MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild GetUIStringResourcePerEntityBuild()
        {
            return new MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild();
        }

        public static MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode GetUIStringResourcePerEntityBuildEventCode()
        {
            return new MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode();
        }

        public static MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog GetUIStringResourcePerEntityBuildLog()
        {
            return new MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog();
        }

        public static MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization GetUIStringResourcePerEntityOrganization()
        {
            return new MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization();
        }

        public static MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution GetUIStringResourcePerEntitySolution()
        {
            return new MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution();
        }

    }
}


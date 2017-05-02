using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    // You exclude the 'Extension' suffix when using in Xaml markup
    [ContentProperty ("Text")]
	public class TranslateExtension : IMarkupExtension
	{
        public const string ResourceId_UIStringResource = "Framework.Resources.UIStringResource";
        public const string ResourceId_UIStringResourcePerApp = "MSBuildExtensionPack.Resources.UIStringResourcePerApp";
        public const string ResourceId_UIStringResourcePerEntityBuild = "MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild";
        public const string ResourceId_UIStringResourcePerEntityBuildEventCode = "MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode";
        public const string ResourceId_UIStringResourcePerEntityBuildLog = "MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog";
        public const string ResourceId_UIStringResourcePerEntitySolution = "MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution";

        readonly CultureInfo ci = null;

		public TranslateExtension() {
            if (Device.RuntimePlatform.ToLower() == Platforms.iOS.ToString().ToLower() || Device.RuntimePlatform.ToLower() == Platforms.Android.ToString().ToLower())
            {
                ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
		}

		public string ResourceId { get; set; }
        public string Text { get; set; }

        public object ProvideValue (IServiceProvider serviceProvider)
		{
			if (Text == null)
				return "";

			ResourceManager temp = GetResourceManager(ResourceId);

            if (temp != null)
            {
                string translation;
                translation = temp.GetString(Text, ci);

                //if (ci == null)
                //{
                //    translation = temp.GetString(Text);
                //}
                //else
                //{
                //    translation = temp.GetString(Text, ci);
                //}

                if (translation == null)
                {
#if DEBUG
                    throw new ArgumentException(
                        String.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId, ci.Name),
                        "Text");
#else
				translation = Text; // HACK: returns the key, which GETS DISPLAYED TO THE USER
#endif
                }
                return translation;
            }
            else
            {
                return this.Text;
            }
		}

        public ResourceManager GetResourceManager(string resourceId)
        {
            if(ResourceId == ResourceId_UIStringResource)
            {
                return new ResourceManager(resourceId, typeof(Framework.Resources.ResourceFileFactory).GetTypeInfo().Assembly);
            }
            else
            {
                try
                {
                    return new ResourceManager(resourceId, typeof(MSBuildExtensionPack.Resources.ResourceFileFactory).GetTypeInfo().Assembly);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}

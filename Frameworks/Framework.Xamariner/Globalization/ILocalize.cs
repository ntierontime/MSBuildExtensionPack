using System;
using System.Globalization;

namespace Framework.Xamariner.Globalization
{
    /// <summary>
    /// Implementations of this interface MUST convert iOS and Android
    /// platform-specific locales to a value supported in .NET because
    /// ONLY valid .NET cultures can have their RESX resources loaded and used.
    /// </summary>
    /// <remarks>
    /// Lists of valid .NET cultures can be found here:
    ///   https://github.com/xamarin/xamarin-forms-samples/tree/master/UsingResxLocalization
    ///   http://www.localeplanet.com/dotnet/
    ///   http://www.csharp-examples.net/culture-names/
    /// You should always test all the locales implemented in your application.
    /// Sample apps built using the Xamarin.Forms framework.
    /// 
    /// License
    /// The Apache License 2.0 applies to all samples in this repository.
    /// Copyright 2011 Xamarin Inc
    /// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
    /// http://www.apache.org/licenses/LICENSE-2.0
    /// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
    /// </remarks>
    public interface ILocalize
    {
		///	<summary>
		/// This method must evaluate platform-specific locale settings
		/// and convert them (when necessary) to a valid .NET locale.
		/// </summary>
		CultureInfo GetCurrentCultureInfo ();

		/// <summary>
		/// CurrentCulture and CurrentUICulture must be set in the platform project, 
		/// because the Thread object can't be accessed in a PCL.
		/// </summary>
		void SetLocale (CultureInfo ci);
	}

	/// <summary>
	/// Helper class for splitting locales like
	///   iOS: ms_MY, gsw_CH
	///   Android: in-ID
	/// into parts so we can create a .NET culture (or fallback culture)
	/// </summary>
	public class PlatformCulture 
	{
		public PlatformCulture (string platformCultureString)
		{
			if (String.IsNullOrEmpty(platformCultureString)) 
				throw new ArgumentException("Expected culture identifier", "platformCultureString"); // in C# 6 use nameof(platformCultureString)

			PlatformString = platformCultureString.Replace("_", "-"); // .NET expects dash, not underscore
			var dashIndex = PlatformString.IndexOf("-", StringComparison.Ordinal);
			if (dashIndex > 0)
			{
				var parts = PlatformString.Split('-');
				LanguageCode = parts[0];
				LocaleCode = parts[1];
			}
			else
			{ 
				LanguageCode = PlatformString;
				LocaleCode = "";
			}
		}
		public string PlatformString { get; private set; }
		public string LanguageCode { get; private set; }
		public string LocaleCode { get; private set; }
		public override string ToString()
		{
			return PlatformString;
		}
	}

    public enum Platforms
    {
        //
        // Summary:
        //     (Unused) Indicates that Forms is running on an undefined platform.
        Other = 0,
        //
        // Summary:
        //     Indicates that Forms is running on an Apple iOS OS.
        iOS = 1,
        //
        // Summary:
        //     Indicates that Forms is running on a Google Android OS.
        Android = 2,
        //
        // Summary:
        //     Indicates that Forms is running on a Microsoft WinPhone OS.
        WinPhone = 3,
        //
        // Summary:
        //     Indicates that forms is running on the Windows platform.
        Windows = 4
    }
}


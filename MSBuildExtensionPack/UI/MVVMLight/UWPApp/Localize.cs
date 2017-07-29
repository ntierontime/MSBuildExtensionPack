﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(MSBuildExtensionPack.UWPApp.Localize))]

namespace MSBuildExtensionPack.UWPApp
{
    public class Localize : Framework.Xamariner.ILocalize
    {
        public void SetLocale(CultureInfo ci) { }
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            return CultureInfo.CurrentUICulture;
        }
    }
}

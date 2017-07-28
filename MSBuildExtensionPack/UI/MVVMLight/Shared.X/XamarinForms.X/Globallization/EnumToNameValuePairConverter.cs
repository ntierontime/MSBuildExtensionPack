using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MSBuildExtensionPack.XamarinForms
{
    public sealed class EnumToNameValuePairConverter : IValueConverter
    {
        const string format = "{0}_{2}";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            { return null; }
            var prefix = parameter == null ? targetType.Name : parameter.ToString();
            return new Framework.NameValuePair(value.ToString(), Framework.Resx.UIStringResource.ResourceManager.GetString(string.Format(format, prefix, null, value.ToString())));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            try
            {
                var originalValue = (Framework.NameValuePair)value;
                return Enum.Parse(targetType, originalValue.Value);
            }
            catch
            {
                throw new ArgumentException(null, "value");
            }
        }
    }
}

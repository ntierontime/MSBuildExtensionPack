//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Markup;

//namespace Framework.Xamariner
//{
//    public sealed class EnumerateToNameValuePairExtension : MarkupExtension
//    {
//        const string format = "{0}_{1}_{2}";

//        public Type Type { get; set; }
//        public string ResourcePrefix { get; set; }

//        //public EnumerateToNameValuePairExtension(Type enumType)
//        //{
//        //    Type = type;
//        //}

//        //public EnumerateToNameValuePairExtension(Type type, string resourcePrefix)
//        //{
//        //    Type = type;
//        //    ResourcePrefix = resourcePrefix;
//        //}

//        public override object ProvideValue(IServiceProvider serviceProvider)
//        {

//            string[] names = Enum.GetNames(Type);
//            var results = new Framework.NameValueCollection();
//            var prefix = string.IsNullOrWhiteSpace(ResourcePrefix) ? Type.Name : ResourcePrefix;

//            foreach (var name in names)
//            {
//                results.Add(name, Framework.Resx.UIStringResource.ResourceManager.GetString(string.Format(format, prefix, null, name)));
//            }

//            return results.ToArray();
//        }
//    }
//}

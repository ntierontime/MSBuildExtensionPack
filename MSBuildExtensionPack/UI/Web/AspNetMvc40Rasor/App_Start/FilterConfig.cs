using System.Web;
using System.Web.Mvc;

namespace MSBuildExtensionPack.AspNetMvc40Rasor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
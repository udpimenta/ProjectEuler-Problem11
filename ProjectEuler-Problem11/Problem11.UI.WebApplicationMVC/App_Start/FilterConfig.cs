using System.Web;
using System.Web.Mvc;

namespace Problem11.UI.WebApplicationMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

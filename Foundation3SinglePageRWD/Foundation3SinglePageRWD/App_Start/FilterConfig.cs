using System.Web;
using System.Web.Mvc;

namespace Foundation3SinglePageRWD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
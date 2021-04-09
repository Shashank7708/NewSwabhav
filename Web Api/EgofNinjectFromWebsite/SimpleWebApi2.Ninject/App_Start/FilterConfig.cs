using System.Web;
using System.Web.Mvc;

namespace SimpleWebApi2.Ninject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

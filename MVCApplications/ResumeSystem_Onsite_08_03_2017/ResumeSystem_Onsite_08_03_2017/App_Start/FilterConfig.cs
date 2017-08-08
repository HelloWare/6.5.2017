using System.Web;
using System.Web.Mvc;

namespace ResumeSystem_Onsite_08_03_2017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

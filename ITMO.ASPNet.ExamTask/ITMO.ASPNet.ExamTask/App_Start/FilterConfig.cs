using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPNet.ExamTask
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

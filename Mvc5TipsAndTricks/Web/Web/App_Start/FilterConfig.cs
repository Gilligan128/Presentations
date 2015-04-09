using System.Web;
using System.Web.Mvc;
using WebDemo.Infrastructure.Validation;

namespace WebDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ValidateModelStateAttribute());
        }
    }
}

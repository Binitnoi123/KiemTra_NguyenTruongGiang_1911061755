using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenTruongGiang_1911061755
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

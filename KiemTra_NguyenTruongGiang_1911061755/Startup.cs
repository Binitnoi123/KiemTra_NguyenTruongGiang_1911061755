using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiemTra_NguyenTruongGiang_1911061755.Startup))]
namespace KiemTra_NguyenTruongGiang_1911061755
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

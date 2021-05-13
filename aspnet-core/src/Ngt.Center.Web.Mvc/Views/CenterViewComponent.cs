using Abp.AspNetCore.Mvc.ViewComponents;

namespace Ngt.Center.Web.Views
{
    public abstract class CenterViewComponent : AbpViewComponent
    {
        protected CenterViewComponent()
        {
            LocalizationSourceName = CenterConsts.LocalizationSourceName;
        }
    }
}
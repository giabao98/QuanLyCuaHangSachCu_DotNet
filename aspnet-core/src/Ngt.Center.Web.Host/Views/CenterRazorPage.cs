using Abp.AspNetCore.Mvc.Views;

namespace Ngt.Center.Web.Views
{
    public abstract class CenterRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CenterRazorPage()
        {
            LocalizationSourceName = CenterConsts.LocalizationSourceName;
        }
    }
}

using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Ngt.Center.Web.Public.Views
{
    public abstract class CenterRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CenterRazorPage()
        {
            LocalizationSourceName = CenterConsts.LocalizationSourceName;
        }
    }
}

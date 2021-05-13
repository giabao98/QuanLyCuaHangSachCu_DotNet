using System;
using Ngt.Center.Core;
using Ngt.Center.Core.Dependency;
using Ngt.Center.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ngt.Center.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}
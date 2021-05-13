using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ngt.Center
{
    [DependsOn(typeof(CenterXamarinSharedModule))]
    public class CenterXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterXamarinAndroidModule).GetAssembly());
        }
    }
}
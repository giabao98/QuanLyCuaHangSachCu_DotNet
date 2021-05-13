using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ngt.Center
{
    [DependsOn(typeof(CenterCoreSharedModule))]
    public class CenterApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterApplicationSharedModule).GetAssembly());
        }
    }
}
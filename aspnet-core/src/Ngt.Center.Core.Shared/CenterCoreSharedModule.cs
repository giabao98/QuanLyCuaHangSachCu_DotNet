using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ngt.Center
{
    public class CenterCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterCoreSharedModule).GetAssembly());
        }
    }
}
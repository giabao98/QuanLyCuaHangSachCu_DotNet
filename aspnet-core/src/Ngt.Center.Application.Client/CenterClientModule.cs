using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ngt.Center
{
    public class CenterClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterClientModule).GetAssembly());
        }
    }
}

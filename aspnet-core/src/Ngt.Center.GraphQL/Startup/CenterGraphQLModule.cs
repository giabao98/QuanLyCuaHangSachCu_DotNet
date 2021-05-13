using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ngt.Center.Startup
{
    [DependsOn(typeof(CenterCoreModule))]
    public class CenterGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}
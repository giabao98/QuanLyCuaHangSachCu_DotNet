using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Ngt.Center.Configure;
using Ngt.Center.Startup;
using Ngt.Center.Test.Base;

namespace Ngt.Center.GraphQL.Tests
{
    [DependsOn(
        typeof(CenterGraphQLModule),
        typeof(CenterTestBaseModule))]
    public class CenterGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterGraphQLTestModule).GetAssembly());
        }
    }
}
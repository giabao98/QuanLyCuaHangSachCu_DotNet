﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ngt.Center
{
    [DependsOn(typeof(CenterClientModule), typeof(AbpAutoMapperModule))]
    public class CenterXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CenterXamarinSharedModule).GetAssembly());
        }
    }
}
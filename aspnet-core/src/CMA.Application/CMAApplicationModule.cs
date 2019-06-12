using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CMA.Authorization;

namespace CMA
{
    [DependsOn(
        typeof(CMACoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CMAApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CMAAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CMAApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

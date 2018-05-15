using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InnovationSoft.Olh.Authorization;

namespace InnovationSoft.Olh
{
    [DependsOn(
        typeof(OlhCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OlhApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OlhAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OlhApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Project.web.Authorization;

namespace Project.web
{
    [DependsOn(
        typeof(webCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class webApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<webAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(webApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

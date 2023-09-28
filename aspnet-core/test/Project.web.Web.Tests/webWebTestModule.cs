using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Project.web.EntityFrameworkCore;
using Project.web.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Project.web.Web.Tests
{
    [DependsOn(
        typeof(webWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class webWebTestModule : AbpModule
    {
        public webWebTestModule(webEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(webWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(webWebMvcModule).Assembly);
        }
    }
}
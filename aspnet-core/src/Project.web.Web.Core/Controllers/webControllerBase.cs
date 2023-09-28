using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Project.web.Controllers
{
    public abstract class webControllerBase: AbpController
    {
        protected webControllerBase()
        {
            LocalizationSourceName = webConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

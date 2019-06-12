using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CMA.Controllers
{
    public abstract class CMAControllerBase: AbpController
    {
        protected CMAControllerBase()
        {
            LocalizationSourceName = CMAConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

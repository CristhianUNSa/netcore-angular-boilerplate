using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InnovationSoft.Olh.Controllers
{
    public abstract class OlhControllerBase: AbpController
    {
        protected OlhControllerBase()
        {
            LocalizationSourceName = OlhConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

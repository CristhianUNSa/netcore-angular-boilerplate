using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using InnovationSoft.Olh.Authorization;
using InnovationSoft.Olh.Authorization.Roles;
using InnovationSoft.Olh.Authorization.Users;
using InnovationSoft.Olh.Editions;
using InnovationSoft.Olh.MultiTenancy;

namespace InnovationSoft.Olh.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}

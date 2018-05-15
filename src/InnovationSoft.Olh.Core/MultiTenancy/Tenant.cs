using Abp.MultiTenancy;
using InnovationSoft.Olh.Authorization.Users;

namespace InnovationSoft.Olh.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

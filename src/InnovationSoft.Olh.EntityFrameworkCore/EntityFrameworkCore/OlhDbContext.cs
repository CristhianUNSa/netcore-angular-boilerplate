using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InnovationSoft.Olh.Authorization.Roles;
using InnovationSoft.Olh.Authorization.Users;
using InnovationSoft.Olh.MultiTenancy;

namespace InnovationSoft.Olh.EntityFrameworkCore
{
    public class OlhDbContext : AbpZeroDbContext<Tenant, Role, User, OlhDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OlhDbContext(DbContextOptions<OlhDbContext> options)
            : base(options)
        {
        }
    }
}

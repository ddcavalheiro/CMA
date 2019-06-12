using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CMA.Authorization.Roles;
using CMA.Authorization.Users;
using CMA.MultiTenancy;

namespace CMA.EntityFrameworkCore
{
    public class CMADbContext : AbpZeroDbContext<Tenant, Role, User, CMADbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CMADbContext(DbContextOptions<CMADbContext> options)
            : base(options)
        {
        }
    }
}

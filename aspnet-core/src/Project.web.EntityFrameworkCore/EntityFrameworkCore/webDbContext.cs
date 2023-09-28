using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Project.web.Authorization.Roles;
using Project.web.Authorization.Users;
using Project.web.MultiTenancy;

namespace Project.web.EntityFrameworkCore
{
    public class webDbContext : AbpZeroDbContext<Tenant, Role, User, webDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Todo.Todo> Todo { get; set; }


        public webDbContext(DbContextOptions<webDbContext> options)
            : base(options)
        {
        }
    }
}

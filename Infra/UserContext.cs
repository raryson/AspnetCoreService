using AspnetCoreService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreService.Infra
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options){}

        public DbSet<User> Users { get;set; }
    }
}
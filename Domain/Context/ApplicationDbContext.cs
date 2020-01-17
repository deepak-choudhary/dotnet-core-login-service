using Microsoft.EntityFrameworkCore;
using LoginService.Model;
namespace LoginService.Domain.Context{
    public class ApplicationDbContext:DbContext{
        public ApplicationDbContext(DbContextOptions options)
        :base(options)
        {
            
        }
        public DbSet<MemberShip> User{get;set;}
    }
}
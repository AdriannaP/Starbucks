using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Starbucks.Areas.Identity.Data;
using Starbucks.Models;

namespace Starbucks
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<StarbuksUser> StarbuksUsers { get; set; }

    }
}

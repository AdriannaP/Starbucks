using Microsoft.EntityFrameworkCore;
using Starbucks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starbucks
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Coffee> Coffee { get; set; }


    }
}

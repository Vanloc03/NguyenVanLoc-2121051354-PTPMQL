using Microsoft.EntityFrameworkCore;
using DemoMVC.Models.Entities;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenVanLoc> NguyenVanLoc { get; set; } = default!;
    }
}

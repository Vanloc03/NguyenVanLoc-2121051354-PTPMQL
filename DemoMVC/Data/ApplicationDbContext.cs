using Microsoft.EntityFrameworkCore;
using DemoMVC.Models.Entities;
using DemoMVC.Models;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenVanLoc> NguyenVanLoc { get; set; } = default!;
        public DbSet<DemoMVC.Models.Entities.Student> Student { get; set; } = default!;
        public DbSet<DemoMVC.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DemoMVC.Models.DaiLy> DaiLy { get; set; } = default!;
        public DbSet<DemoMVC.Models.person> person { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DaiLy> DaiLy { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; }
    }
}
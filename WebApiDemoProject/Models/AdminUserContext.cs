using Microsoft.EntityFrameworkCore;

namespace WebApiDemoProject.Models
{
    public class AdminUserContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2KEA18U\SQLEXPRESS;Database=AdminUserApi;Trusted_Connection=true;TrustServerCertificate=true;");

        }
        public DbSet<AdminUser>AdminUsers { get; set; }

    }
}

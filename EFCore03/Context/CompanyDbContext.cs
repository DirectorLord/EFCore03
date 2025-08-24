using EFCore03.Medals;
using Microsoft.EntityFrameworkCore;


namespace EFCore03.Context;

internal class CompanyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server= .; Database = NorthWind; Trusted_Connection = true; TrustServerCertificate = true;");
    }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }
}

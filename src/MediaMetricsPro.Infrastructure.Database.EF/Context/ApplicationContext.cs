using MediaMetricsPro.Domain.Register;
using Microsoft.EntityFrameworkCore;

namespace MediaMetricsPro.Infrastructure.Database.EF.Context;

public class ApplicationContext : DbContext
{
    public DbSet<Seller> Sellers { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }
}

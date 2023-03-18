using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Factories;

public class SqlServerDbContextFactory : IDbContextFactory<AdminAppDbContext>
{
    private readonly bool _seedDemoData;
    private readonly DbContextOptionsBuilder<AdminAppDbContext> _contextOptionsBuilder = new();

    public SqlServerDbContextFactory(string connectionString, bool seedDemoData = true)
    {
        _seedDemoData = seedDemoData;
        _contextOptionsBuilder.UseSqlServer(connectionString);
    }

    public AdminAppDbContext CreateDbContext() => new(_contextOptionsBuilder.Options, _seedDemoData);
}
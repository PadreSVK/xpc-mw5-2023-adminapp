using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Factories;

// todo-cleancode why is this factory called SqlServerDbContextFactory when it create npgsql?
public class SqlServerDbContextFactory : IDbContextFactory<AdminAppDbContext>
{
    private readonly bool _seedDemoData;
    private readonly DbContextOptionsBuilder<AdminAppDbContext> _contextOptionsBuilder = new();

    // todo-maintability why is here seedDemoData? => AdminAppDbContext
    public SqlServerDbContextFactory(string connectionString, bool seedDemoData = true)
    {
        _seedDemoData = seedDemoData;
        _contextOptionsBuilder.UseNpgsql(connectionString);
        //_contextOptionsBuilder.UseSqlServer(connectionString);
    }

    public AdminAppDbContext CreateDbContext() => new(_contextOptionsBuilder.Options, _seedDemoData);
}
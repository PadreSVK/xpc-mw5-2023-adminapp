using AdminApp.BLL.Options;
using AdminApp.DAL;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.BLL;

interface IDbMigrator
{
    public void Migrate();
    public Task MigrateAsync(CancellationToken cancellationToken);
}

public class NoneDbMigrator : IDbMigrator
{
    public void Migrate() { }
    public Task MigrateAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}

public class SqlServerDbMigrator : IDbMigrator
{
    private readonly IDbContextFactory<AdminAppDbContext> _dbContextFactory;
    private readonly SqlServerOptions _sqlServerOptions;

    public SqlServerDbMigrator(IDbContextFactory<AdminAppDbContext> dbContextFactory, DALOptions dalOptions)
    {
        _dbContextFactory = dbContextFactory;
        _sqlServerOptions = dalOptions.SqlServer ?? throw new ArgumentNullException(nameof(dalOptions), $@"{nameof(DALOptions.SqlServer)} are not set");
    }

    public void Migrate() => MigrateAsync(CancellationToken.None).GetAwaiter().GetResult();

    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        await using AdminAppDbContext dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        
        await dbContext.Database.EnsureCreatedAsync(cancellationToken);
    }
}

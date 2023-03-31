using AdminApp.App.Options;
using AdminApp.DAL;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.App;

interface IDbMigrator
{
    public void Migrate();
    public Task MigrateAsync(CancellationToken cancellationToken);
}

public class PostgreSqlDbMigrator : IDbMigrator
{
    private readonly IDbContextFactory<AdminAppDbContext> _dbContextFactory;
    private readonly PostgreSqlOptions _postgreSqlOptions;

    public PostgreSqlDbMigrator(IDbContextFactory<AdminAppDbContext> dbContextFactory, DALOptions dalOptions)
    {
        _dbContextFactory = dbContextFactory;
        _postgreSqlOptions = dalOptions.PostgreSqlServer ?? throw new ArgumentNullException(nameof(dalOptions), $@"{nameof(DALOptions.PostgreSqlServer)} are not set");
    }

    public void Migrate() => MigrateAsync(CancellationToken.None).GetAwaiter().GetResult();

    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        await using AdminAppDbContext dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        
        await dbContext.Database.EnsureCreatedAsync(cancellationToken);
    }
}

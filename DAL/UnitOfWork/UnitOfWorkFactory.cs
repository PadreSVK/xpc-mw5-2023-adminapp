using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.UnitOfWork;

public class UnitOfWorkFactory : IUnitOfWorkFactory
{
    private readonly IDbContextFactory<AdminAppDbContext> _dbContextFactory;

    public UnitOfWorkFactory(IDbContextFactory<AdminAppDbContext> dbContextFactory) =>
        _dbContextFactory = dbContextFactory;

    public IUnitOfWork Create() => new UnitOfWork(_dbContextFactory.CreateDbContext());
}
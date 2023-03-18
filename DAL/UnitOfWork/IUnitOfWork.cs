using AdminApp.DAL.Entities;
using AdminApp.DAL.Mappers;
using AdminApp.DAL.Repositories;


namespace AdminApp.DAL.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    IRepository<TEntity> GetRepository<TEntity, TEntityMapper>()
        where TEntity : class, IEntity
        where TEntityMapper : IEntityMapper<TEntity>, new();

    Task CommitAsync();
}
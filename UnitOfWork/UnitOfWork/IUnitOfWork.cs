using Microsoft.EntityFrameworkCore;

namespace Faliush.ContactManager.Infrastructure.UnitOfWork;

public interface IUnitOfWork<out TContext> : IUnitOfWork where TContext : DbContext
{
    TContext DbContext { get; }
}

public interface IUnitOfWork : IDisposable 
{
    IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

    int SaveChanges();

    Task<int> SaveChangesAsync();

    SaveChangesResult LastSaveChangeResult { get; }
}


using System.Data.Entity;

namespace CoreEntityFramework
{
    /// <summary>
    /// IDbContext interface.
    /// </summary>
    public interface IDbContext : IUnitOfWork
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
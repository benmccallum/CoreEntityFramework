using System;
using System.Threading.Tasks;

namespace CoreEntityFramework
{
    /// <summary>
    /// IUnitOfWork interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
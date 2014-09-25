using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CoreEntityFramework.Entities;

namespace CoreEntityFramework
{
    /// <summary>
    /// DbContext base.
    /// </summary>
    public class DbContext : System.Data.Entity.DbContext, IDbContext
    {
        /// <summary>
        /// Constructs a new context instance using the given string as the name or connection string for the database to which a connection will be made
        /// </summary>
        /// <param name="nameOrConnectionString">Either the database name or a connection string.</param>
        public DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            
        }

        /// <summary>
        /// Sets the auditing type fields on the DB entities on create and modification.
        /// </summary>
        private void AuditEntries()
        {
            var utcNow = DateTime.UtcNow;
            foreach (var entry in ChangeTracker.Entries<DbEntity>().Where(e => e.State != EntityState.Unchanged))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreatedUtc = utcNow;
                }
                entry.Entity.DateLastModifiedUtc = utcNow;
            }
        }

        public override int SaveChanges()
        {
            AuditEntries();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            AuditEntries();
            return base.SaveChangesAsync();
        }
    }
}

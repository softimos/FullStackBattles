using Microsoft.EntityFrameworkCore;
using Softimos.FullStackBattles.DTO;
using System;

namespace Softimos.FullStackBattles.DAL.Repositories
{
    /// <summary>
    /// Base class for CRUD repository.
    /// Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <seealso cref="System.IDisposable" />
    public abstract class SqlEntityFrameworkRepositoryBase<TEntity, TDbContext> :
        IDisposable where TEntity : class, IInt32Identity
        where TDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEntityFrameworkRepositoryBase{TEntity, TDbContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="ArgumentNullException">context - Parameter {nameof(context)} is null.</exception>
        public SqlEntityFrameworkRepositoryBase(TDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), $"Parameter {nameof(context)} is null.");
            }

            _Context = context;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            ((IDisposable)_Context).Dispose();
        }

        /// <summary>
        /// The context
        /// </summary>
        private TDbContext _Context;

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        protected TDbContext Context
        {
            get
            {
                return _Context;
            }
        }

        /// <summary>
        /// Verifies if the item is added or attached to database set.
        /// </summary>
        /// <param name="dbSet">The database set.</param>
        /// <param name="item">The item.</param>
        protected void VerifyItemIsAddedOrAttachedToDbSet(DbSet<TEntity> dbSet, TEntity item)
        {
            if (item == null)
            {
                return;
            }
            else
            {
                if (item.Id == 0)
                {
                    dbSet.Add(item);
                }
                else
                {
                    var entry = _Context.Entry<TEntity>(item);

                    if (entry.State == EntityState.Detached)
                    {
                        dbSet.Attach(item);
                    }

                    entry.State = EntityState.Modified;
                }
            }
        }
    }
}

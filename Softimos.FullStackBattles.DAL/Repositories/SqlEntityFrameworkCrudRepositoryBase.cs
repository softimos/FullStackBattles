using Microsoft.EntityFrameworkCore;
using Softimos.FullStackBattles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softimos.FullStackBattles.DAL.Repositories
{
    /// <summary>
    /// Base class for EF Core repository having implemented CRUD operations. 
    /// Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <seealso cref="Softimos.FullStackBattles.DAL.SqlEntityFrameworkRepositoryBase{TEntity, TDbContext}" />
    /// <seealso cref="Softimos.FullStackBattles.DAL.IRepository{TEntity}" />
    public abstract class SqlEntityFrameworkCrudRepositoryBase<TEntity, TDbContext> :
        SqlEntityFrameworkRepositoryBase<TEntity, TDbContext>, IRepository<TEntity>
        where TEntity : class, IInt32Identity
        where TDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEntityFrameworkCrudRepositoryBase{TEntity, TDbContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SqlEntityFrameworkCrudRepositoryBase(TDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets the entity database set.
        /// </summary>
        /// <value>
        /// The entity database set.
        /// </value>
        protected abstract DbSet<TEntity> EntityDbSet
        {
            get;
        }

        /// <summary>
        /// Gets all elements of an entity TEntity.
        /// </summary>
        /// <returns>
        /// Enumerable collection of elements of type TEntity.
        /// </returns>
        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await EntityDbSet.ToListAsync();
        }

        /// <summary>
        /// Gets the element by providing its identifier value.
        /// </summary>
        /// <param name="id">The identifier value in the database.</param>
        /// <returns>
        /// Element of type TEntity.
        /// </returns>
        public virtual async Task<TEntity> GetById(int id)
        {
            return await EntityDbSet.Where(t => t.Id == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Gets a subset of elements of an entity TEntity.
        /// </summary>
        /// <param name="pageNumber">Zero-based page index value.</param>
        /// <returns>
        /// Enumerable collection of elements of type TEntity.
        /// </returns>
        public virtual async Task<IEnumerable<TEntity>> GetPage(int pageNumber)
        {
            return await EntityDbSet
                .Skip(pageNumber * Constants.ItemsPerPage)
                .Take(Constants.ItemsPerPage)
                .ToListAsync();
        }

        /// <summary>
        /// Gets a random element of an entity TEntity.
        /// Due to the small amount of data the implementation prioritized minimal number of request to the database
        /// and not the optimal ordering of the items.
        /// </summary>
        /// <returns>
        /// Element of type TEntity.
        /// </returns>
        public virtual async Task<TEntity> GetRandom()
        {
            return await EntityDbSet
                .OrderBy(c => Guid.NewGuid())
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Saves the specified model to be saved.
        /// </summary>
        /// <param name="modelToBeSaved">The model to be saved.</param>
        /// <exception cref="ArgumentNullException">modelToBeSaved - Parameter {nameof(modelToBeSaved)} is null.</exception>
        public virtual async Task Save(TEntity modelToBeSaved)
        {
            if (modelToBeSaved == null)
            {
                throw new ArgumentNullException(nameof(modelToBeSaved), $"Parameter {nameof(modelToBeSaved)} is null.");
            }

            VerifyItemIsAddedOrAttachedToDbSet(EntityDbSet, modelToBeSaved);

            await Context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes the specified model to be deleted.
        /// </summary>
        /// <param name="modelToBeDeleted">The model to be deleted.</param>
        /// <exception cref="ArgumentNullException">modelToBeDeleted - Parameter {nameof(modelToBeDeleted)} is null.</exception>
        public virtual async Task Delete(TEntity modelToBeDeleted)
        {
            if (modelToBeDeleted == null)
            {
                throw new ArgumentNullException(nameof(modelToBeDeleted), $"Parameter {nameof(modelToBeDeleted)} is null.");
            }

            var entry = Context.Entry(modelToBeDeleted);

            if (entry.State == EntityState.Detached)
            {
                EntityDbSet.Attach(modelToBeDeleted);
            }

            EntityDbSet.Remove(modelToBeDeleted);

            await Context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates the specified element in the database.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="newModel">The new model.</param>
        /// <returns></returns>
        public virtual async Task<bool> Update(int id, TEntity newModel)
        {
            newModel.Id = id;
            Context.Entry(EntityDbSet.FirstOrDefault(x => x.Id == id)).CurrentValues.SetValues(newModel);
            int result = await Context.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// Counts the number of items of an entity in a database.
        /// </summary>
        /// <returns>
        /// Number of items.
        /// </returns>
        public virtual async Task<int> Count()
        {
            return await EntityDbSet.CountAsync();
        }
    }
}

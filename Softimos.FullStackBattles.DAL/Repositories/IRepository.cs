using System.Collections.Generic;
using System.Threading.Tasks;
using Softimos.FullStackBattles.DTO;

namespace Softimos.FullStackBattles.DAL.Repositories
{
    /// <summary>
    /// Interface for repositories to force implementation of all desired methods.
    /// Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/
    /// </summary>
    /// <typeparam name="TEntity">Repository data model type.</typeparam>
    public interface IRepository<TEntity> where TEntity : IInt32Identity
    {
        /// <summary>
        /// Gets all elements of an entity TEntity.
        /// </summary>
        /// <returns>Enumerable collection of elements of type TEntity.</returns>
        Task<IEnumerable<TEntity>> GetAll();

        /// <summary>
        /// Gets the element by providing its identifier value.
        /// </summary>
        /// <param name="id">The identifier value in the database.</param>
        /// <returns>Element of type TEntity.</returns>
        Task<TEntity> GetById(int id);

        /// <summary>
        /// Gets a subset of elements of an entity TEntity.
        /// </summary>
        /// <param name="pageNumber">Zero-based page index value.</param>
        /// <returns>Enumerable collection  of elements of type TEntity.</returns>
        Task<IEnumerable<TEntity>> GetPage(int pageNumber);

        /// <summary>
        /// Gets a random element of an entity TEntity.
        /// </summary>
        /// <returns>Element of type TEntity.</returns>
        Task<TEntity> GetRandom();

        /// <summary>
        /// Adds the specified element to the database.
        /// </summary>
        /// <param name="entityToBeSaved">The entity to be saved of type TEntity.</param>
        Task Save(TEntity entityToBeSaved);

        /// <summary>
        /// Deletes the specified element from the database.
        /// </summary>
        /// <param name="entityToBeDeleted">The entity to be deleted of type TEntity.</param>
        Task Delete(TEntity entityToBeDeleted);

        /// <summary>
        /// Updates the specified element in the database.
        /// </summary>
        /// <param name="id">The identifier value in the database.</param>
        /// <param name="entityToBeUpdated">The entity of type TEntity to be updated.</param>
        /// <returns>Boolean value indicating whether the update operation was successful.</returns>
        Task<bool> Update(int id, TEntity entityToBeUpdated);

        /// <summary>
        /// Counts the number of items of an entity in a database.
        /// </summary>
        /// <returns>Number of items.</returns>
        Task<int> Count();
    }
}

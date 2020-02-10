using Microsoft.EntityFrameworkCore;
using Softimos.FullStackBattles.Database;
using Softimos.FullStackBattles.DTO;

namespace Softimos.FullStackBattles.DAL.Repositories
{
    /// <summary>
    /// Repository of the starship entity.
    /// </summary>
    /// <seealso cref="Softimos.FullStackBattles.DAL.SqlEntityFrameworkCrudRepositoryBase{Softimos.FullStackBattles.DTO.Starship, Softimos.FullStackBattles.Database.CustomDatabaseContext}" />
    /// <seealso cref="Softimos.FullStackBattles.DAL.IRepository{Softimos.FullStackBattles.DTO.Starship}" />
    public class StarshipRepository :
        SqlEntityFrameworkCrudRepositoryBase<Starship, CustomDatabaseContext>, IRepository<Starship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StarshipRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public StarshipRepository(
            CustomDatabaseContext context) :
            base(context)
        {

        }

        /// <summary>
        /// Gets the entity database set.
        /// </summary>
        /// <value>
        /// The entity database set.
        /// </value>
        protected override DbSet<Starship> EntityDbSet
        {
            get
            {
                return Context.Starships;
            }
        }
    }
}

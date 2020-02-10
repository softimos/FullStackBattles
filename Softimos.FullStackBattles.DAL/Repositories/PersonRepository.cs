using Microsoft.EntityFrameworkCore;
using Softimos.FullStackBattles.Database;
using Softimos.FullStackBattles.DTO;

namespace Softimos.FullStackBattles.DAL.Repositories
{
    /// <summary>
    /// Repository of the person entity.
    /// </summary>
    /// <seealso cref="Softimos.FullStackBattles.DAL.SqlEntityFrameworkCrudRepositoryBase{Softimos.FullStackBattles.DTO.Person, Softimos.FullStackBattles.Database.CustomDatabaseContext}" />
    /// <seealso cref="Softimos.FullStackBattles.DAL.IRepository{Softimos.FullStackBattles.DTO.Person}" />
    public class PersonRepository :
        SqlEntityFrameworkCrudRepositoryBase<Person, CustomDatabaseContext>, IRepository<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public PersonRepository(
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
        protected override DbSet<Person> EntityDbSet
        {
            get
            {
                return Context.People;
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softimos.FullStackBattles.DAL.Repositories;
using Softimos.FullStackBattles.DTO;

namespace Softimos.FullStackBattles.WebApi.Controllers
{
    /// <summary>
    /// Controller for people resources
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Produces("application/json")]
    [Route("/api/v1/people")]
    public class PeopleController : ResourceControllerBase<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleController"/> class.
        /// </summary>
        /// <param name="personRepository">The person repository.</param>
        /// <param name="logger">The logger.</param>
        public PeopleController(IRepository<Person> personRepository, ILogger<ResourceControllerBase<Person>> logger)
            : base(personRepository, logger) { }
    }
}

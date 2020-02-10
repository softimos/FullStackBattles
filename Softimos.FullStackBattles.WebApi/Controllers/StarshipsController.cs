using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softimos.FullStackBattles.DAL.Repositories;
using Softimos.FullStackBattles.DTO;

namespace Softimos.FullStackBattles.WebApi.Controllers
{
    /// <summary>
    /// Controller for starships resources
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Produces("application/json")]
    [Route("/api/v1/starships")]
    public class StarshipsController : ResourceControllerBase<Starship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StarshipsController"/> class.
        /// </summary>
        /// <param name="starshipRepository">The starship repository.</param>
        /// <param name="logger">The logger.</param>
        public StarshipsController(IRepository<Starship> starshipRepository, ILogger<ResourceControllerBase<Starship>> logger)
            : base(starshipRepository, logger) { }
    }
}

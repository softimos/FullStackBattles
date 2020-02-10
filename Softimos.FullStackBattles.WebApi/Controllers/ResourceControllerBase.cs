using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softimos.FullStackBattles.DAL.Repositories;
using Softimos.FullStackBattles.DTO;

namespace Softimos.FullStackBattles.WebApi.Controllers
{
    /// <summary>
    /// Base Controller for resource entities
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Produces("application/json")]
    public abstract class ResourceControllerBase<T> : ControllerBase where T : IInt32Identity, new()
    {
        /// <summary>
        /// The logger
        /// </summary>
        protected readonly ILogger<ResourceControllerBase<T>> logger;

        /// <summary>
        /// The entity repository
        /// </summary>
        protected IRepository<T> entityRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceControllerBase{T}"/> class.
        /// </summary>
        /// <param name="entityRepository">The entity repository.</param>
        /// <param name="logger">The logger.</param>
        /// <exception cref="ArgumentNullException">entityRepository</exception>
        protected ResourceControllerBase(IRepository<T> entityRepository, ILogger<ResourceControllerBase<T>> logger)
        {
            if (entityRepository == null)
            {
                throw new ArgumentNullException(nameof(entityRepository), $"{nameof(entityRepository)} is null.");
            }

            this.entityRepository = entityRepository;
            this.logger = logger;
        }

        /// <summary>
        /// Gets all elements from the database.
        /// </summary>
        /// <returns>Enumerable collection of elements of entity type</returns>
        /// <response code="200">Returns the list</response>
        /// <response code="400">If an error occurs</response>   
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            try
            {
                IEnumerable<T> entity = await entityRepository.GetAll();
                return Ok(entity);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Gets the element from the database by providing its identifier value.
        /// </summary>
        /// <param name="id">The identifier value in the database.</param>
        /// <returns>Element of entity type.</returns>
        /// <response code="200">Returns the item</response>
        /// <response code="400">If an error occurs</response>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest($"Parameter '{nameof(id)}' should be greater than zero.");
            }

            try
            {
                IInt32Identity entity = await entityRepository.GetById(id);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Gets a subset of elements from the database.
        /// </summary>
        /// <param name="pageNumber">Zero-based page index value.</param>
        /// <returns>Enumerable collection of elements of entity type</returns>
        /// <response code="200">Returns the list</response>
        /// <response code="400">If an error occurs</response> 
        [HttpGet]
        [Route("page/{pageNumber}")]
        public async Task<IActionResult> GetPage(int pageNumber)
        {
            if (pageNumber < 0)
            {
                return BadRequest($"Parameter '{nameof(pageNumber)}' should be a non-negative value.");
            }

            try
            {
                IEnumerable<T> entity = await entityRepository.GetPage(pageNumber);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Gets a random element from the database.
        /// </summary>
        /// <returns>Element of entity type.</returns>
        /// <response code="200">Returns the item</response>
        /// <response code="400">If an error occurs</response>   
        [HttpGet]
        [Route("random")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> GetRandom()
        {
            try
            {
                IInt32Identity entity = await entityRepository.GetRandom();
                return Ok(entity);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Adds the specified element to the database.
        /// </summary>
        /// <param name="model">Entity model.</param>
        /// <returns>ActionResult indicating whether the operation was successful.</returns>
        /// <response code="200">Indicates that the operation was successful</response>
        /// <response code="400">If an error occurs</response>   
        [HttpPost]
        public async Task<IActionResult> Create(T model)
        {
            try
            {
                await entityRepository.Save(model);
                return Ok();
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Deletes the specified element from the database.
        /// </summary>
        /// <param name="id">The identifier value in the database.</param>
        /// <returns>ActionResult indicating whether the operation was successful.</returns>
        /// <response code="200">Indicates that the operation was successful</response>
        /// <response code="400">If an error occurs</response>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest($"Parameter '{nameof(id)}' should be greater than zero.");
            }

            try
            {
                IInt32Identity entity = await entityRepository.GetById(id);

                if (entity == null)
                {
                    return BadRequest($"Item with Id = '{id}' does not exist.");
                }

                T toBeDeleted = new T() { Id = id };
                await entityRepository.Delete(toBeDeleted);
                return Ok();
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Updates the specified element in the database.
        /// </summary>
        /// <param name="id">The identifier value in the database.</param>
        /// <param name="newModel">entity entity.</param>
        /// <returns>ActionResult indicating whether the operation was successful.</returns>
        /// <response code="200">Indicates that the operation was successful</response>
        /// <response code="204">Indicates that no entities were updated</response>
        /// <response code="400">If an error occurs</response>   
        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, T newModel)
        {
            try
            {
                IInt32Identity entity = await entityRepository.GetById(id);

                if (entity == null)
                {
                    return BadRequest($"Item with Id = '{id}' does not exist.");
                }

                bool isUpdateSuccessful = await entityRepository.Update(id, newModel);
                if (isUpdateSuccessful)
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent, "No entities updated.");
                }
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Counts the number of items of an entity in a database.
        /// </summary>
        /// <returns>Number of items.</returns>
        /// <response code="200">Returns the count</response>
        /// <response code="400">If an error occurs</response>   
        [HttpGet]
        [Route("count")]
        public async Task<IActionResult> GetCount()
        {
            try
            {
                int elementCount = await entityRepository.Count();
                return Ok(elementCount);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MTIT.Storekeeper.Models;
using MTIT.Storekeeper.Services;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MTIT.Storekeeper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorekeeperController : ControllerBase
    {
        private readonly IStorekeeperService _storekeeperService;

        public StorekeeperController(IStorekeeperService storekeeperService)
        {
            _storekeeperService = storekeeperService ?? throw new ArgumentNullException(nameof(storekeeperService));
        }


        // GET: api/<StorekeeperController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_storekeeperService.GetStorekeepers());
        }

        // GET api/<StorekeeperController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _storekeeperService.GetStorekeeper(id) != null ? Ok(_storekeeperService.GetStorekeeper(id)) : NoContent();
        }

        // POST api/<StorekeeperController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Storekeeper storekeeper)
        {
            return Ok(_storekeeperService.AddStorekeeper(storekeeper));
        }

        // PUT api/<StorekeeperController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Storekeeper storekeeper)
        {
            return Ok(_storekeeperService.UpdateStorekeeper(storekeeper));
        }

        // DELETE api/<StorekeeperController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _storekeeperService.DeleteStorekeeper(id);

            return result.HasValue & result == true ? Ok($"storekeeper with ID:{id} got deleted successfully.")
            : BadRequest($"Unable to delete the storekeeper with ID:{id}.");

        }
    }
}

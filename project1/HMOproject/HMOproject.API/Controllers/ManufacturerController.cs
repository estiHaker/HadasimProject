using HMOproject.Core.Entities;
using HMOproject.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMOproject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;
        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService; 
        }
        // GET: api/<ManufacturerController>
        [HttpGet]
        public async Task<List<Manufacturer>> Get()
        {
            return await _manufacturerService.GetManufacturersAsync();
        }

        // GET api/<ManufacturerController>/5
        [HttpGet("{id}")]
        public async Task<Manufacturer> Get(int id)
        {
            return await _manufacturerService.GetManufacturerByIdAsync(id);
        }

        // POST api/<ManufacturerController>
        [HttpPost]
        public async Task Post([FromBody] Manufacturer manufacturer)
        {
            await _manufacturerService.AddManufacturerAsync(manufacturer);
        }

        // PUT api/<ManufacturerController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Manufacturer manufacturer)
        {
            await _manufacturerService.UpdateManufacturerAsync(id, manufacturer);
        }

        // DELETE api/<ManufacturerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manufacturerService.DeleteManufacturerAsync(id);
        }
    }
}

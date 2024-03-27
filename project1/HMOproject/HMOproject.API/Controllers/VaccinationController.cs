using HMOproject.Core.Entities;
using HMOproject.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMOproject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        private readonly IVaccinationService _vaccinationService;
        public VaccinationController(IVaccinationService vaccinationService)
        {
            _vaccinationService = vaccinationService;
        }
        // GET: api/<VaccinationController>
        [HttpGet]
        public async Task<List<Vaccination>> Get()
        {
            return await _vaccinationService.GetVaccinationsAsync();
        }

        // GET api/<VaccinationController>/5
        [HttpGet("{id}")]
        public async Task<Vaccination> Get(int id)
        {
            return await _vaccinationService.GetVaccinationByIdAsync(id);
        }

        // POST api/<VaccinationController>
        [HttpPost]
        public async Task Post([FromBody] Vaccination vaccination)
        {
            await _vaccinationService.AddVaccinationAsync(vaccination);
        }

        // PUT api/<VaccinationController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Vaccination vaccination)
        {
            await _vaccinationService.UpdateVaccinationAsync(id, vaccination);
        }

        // DELETE api/<VaccinationController>/5
        [HttpDelete("{id}")]
        public  void Delete(int id)
        {
             _vaccinationService.DeleteVaccination(id);
        }

        // [HttpDelete()]
        //public async void deleteAllByIdMember(int codeMem)
        //{
        //    await _vaccinationService.DeleteAllVaccinationAsync(codeMem);
        //}
    }
}

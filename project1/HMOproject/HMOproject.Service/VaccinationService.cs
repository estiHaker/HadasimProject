using HMOproject.Core.Entities;
using HMOproject.Core.Repositories;
using HMOproject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Service
{
    public class VaccinationService:IVaccinationService
    {
        private readonly IVaccinationRepository _vaccinationRepository;
        public VaccinationService(IVaccinationRepository vaccinationRepository)
        {
            _vaccinationRepository = vaccinationRepository;
        }
        public async Task<List<Vaccination>> GetVaccinationsAsync()
        {
            return await _vaccinationRepository.GetAllVaccinationsAsync();
        }
        public async Task<Vaccination> GetVaccinationByIdAsync(int id)
        {
            return await _vaccinationRepository.GetVaccinationByIdAsync(id);
        }

        public async Task AddVaccinationAsync(Vaccination vaccination)
        {
            if(Validation.addVac(vaccination)) 
                await _vaccinationRepository.AddVaccinationAsync(vaccination);
        } 
        public async Task UpdateVaccinationAsync(int id, Vaccination vaccination)
        {
            await _vaccinationRepository.UpdateVaccinationAsync(id, vaccination);
        }
        public  void DeleteVaccination(int id)
        {
             _vaccinationRepository.DeleteVaccination(id);
        }

        public  void DeleteAllVaccination(int codeMem)
        {
             _vaccinationRepository.DeleteAllVaccination(codeMem);
        }


    }
}

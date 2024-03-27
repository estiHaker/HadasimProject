using HMOproject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Services
{
    public interface IVaccinationService
    {
        Task<List<Vaccination>> GetVaccinationsAsync();
        Task<Vaccination> GetVaccinationByIdAsync(int id);
        Task AddVaccinationAsync(Vaccination vaccination);
        void DeleteVaccination(int id);
        Task UpdateVaccinationAsync(int id, Vaccination vaccination);
        void DeleteAllVaccination(int codeMem);
    }
}

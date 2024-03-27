using HMOproject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Repositories
{
    public interface IVaccinationRepository
    {
        //get all vaccination
        Task<List<Vaccination>> GetAllVaccinationsAsync();
        //get vaccination by id
        Task<Vaccination> GetVaccinationByIdAsync(int id);
        //add vaccination
        Task<Vaccination> AddVaccinationAsync(Vaccination vaccination);
        //delete vaccination by id
        void DeleteVaccination(int id);
        //update vaccination
        Task UpdateVaccinationAsync(int id, Vaccination vaccination);

        void DeleteAllVaccination(int codeMem);
    }
}

using HMOproject.Core.Entities;
using HMOproject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Data.Repositories
{
    public class VaccinationRepository: IVaccinationRepository
    {
        private readonly DataContext _context;
        public VaccinationRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Vaccination>> GetAllVaccinationsAsync()
        {
            return await _context.VaccinationList.Include(u=>u.Manufacturer).Include(u=> u.Members).ToListAsync(); 
        }
        public async Task<Vaccination> GetVaccinationByIdAsync(int id)
        {
            return await _context.VaccinationList.FirstAsync(x => x.Id == id);   
        }
        public async Task<Vaccination> AddVaccinationAsync(Vaccination vaccination)
        {
            int Count = 0;
            foreach (Vaccination vac in _context.VaccinationList)
            {
                if (vac.CodeMem == vaccination.CodeMem)
                            Count++;
            }
            if (Count < 4)
            {
                foreach(Members members in _context.MembersList)
                {
                    if (vaccination.CodeMem == members.CodeMem)
                        members.countVac = members.countVac + 1;
                        _context.MembersList.Update(members);
                }
                _context.VaccinationList.AddAsync(vaccination);
                // _context.CoronaDetailsList.g
                await _context.SaveChangesAsync();
                return vaccination;
            }
            return null;
        }
        public async Task UpdateVaccinationAsync(int id, Vaccination vaccination)
        {
            Vaccination v = GetVaccinationByIdAsync(id).Result;
            v.DateOfVaccination=vaccination.DateOfVaccination;
            v.Manufacturer.CodeMan=vaccination.Manufacturer.CodeMan;
            v.Manufacturer.Name=vaccination.Manufacturer.Name;
            await _context.SaveChangesAsync();
        }

        public  void DeleteVaccination(int id)
        {
            Vaccination v = GetVaccinationByIdAsync(id).Result;
            _context.VaccinationList.Remove(v);
             _context.SaveChangesAsync();
        }

        public  void DeleteAllVaccination(int codeMem) 
        {
            foreach (Vaccination vac in _context.VaccinationList)
            {
                if (vac.CodeMem == codeMem)
                {
                    _context.VaccinationList.Remove(vac);
                    
                }
            }
             _context.SaveChangesAsync();
        }
    }
}

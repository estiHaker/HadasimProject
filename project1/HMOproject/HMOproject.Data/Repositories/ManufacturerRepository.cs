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
    public class ManufacturerRepository: IManufacturerRepository
    {
        private readonly DataContext _context;
        public ManufacturerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Manufacturer>> GetAllManufacturersAsync()
        {
            return await  _context.ManufacturerList.ToListAsync();
        }
        public async Task<Manufacturer> GetManufacturerByIdAsync(int id)
        {
           return _context.ManufacturerList.FirstOrDefault(x => x.CodeMan == id);
           // return await _context.ManufacturerList.FindAsync()
        }
        public async Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer)
        {
            _context.ManufacturerList.AddAsync(manufacturer);
            await _context.SaveChangesAsync();
            return manufacturer;
        }
        public async Task UpdateManufacturerAsync(int id, Manufacturer manufacturer)
        {
            Manufacturer m=GetManufacturerByIdAsync(id).Result;
            m.Name = manufacturer.Name;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteManufacturerAsync(int id)
        {
            Manufacturer m = GetManufacturerByIdAsync(id).Result;
            _context.ManufacturerList.Remove(m);
            await _context.SaveChangesAsync();
        }
    }
}

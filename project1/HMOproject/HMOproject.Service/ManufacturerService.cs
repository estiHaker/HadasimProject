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
    public class ManufacturerService: IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }
        public async Task<List<Manufacturer>> GetManufacturersAsync()
        {
            return await _manufacturerRepository.GetAllManufacturersAsync();
        }
        public async Task<Manufacturer> GetManufacturerByIdAsync(int id)
        {
            return await _manufacturerRepository.GetManufacturerByIdAsync(id);
        }
        public async Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer)
        {
            return await _manufacturerRepository.AddManufacturerAsync(manufacturer);
        }
        public async Task UpdateManufacturerAsync(int id, Manufacturer manufacturer)
        {
            await _manufacturerRepository.UpdateManufacturerAsync(id, manufacturer);
        }
        public async Task DeleteManufacturerAsync(int id)
        {
            await _manufacturerRepository.DeleteManufacturerAsync(id);
        }
    }
}

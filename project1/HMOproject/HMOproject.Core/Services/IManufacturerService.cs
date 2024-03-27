using HMOproject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Services
{
    public interface IManufacturerService
    {
        Task<List<Manufacturer>> GetManufacturersAsync();
        Task<Manufacturer> GetManufacturerByIdAsync(int id);
        Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer);
        Task UpdateManufacturerAsync(int id, Manufacturer manufacturer);
        Task DeleteManufacturerAsync(int id);
    }
}

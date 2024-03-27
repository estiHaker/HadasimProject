using HMOproject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Repositories
{
   public interface IManufacturerRepository
    {
        //get all manufacturers
        Task<List<Manufacturer>> GetAllManufacturersAsync();
        //get manufacturer by id
        Task<Manufacturer> GetManufacturerByIdAsync(int id);
        //add member
        Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer);
        //update manufacturer
        Task UpdateManufacturerAsync(int id, Manufacturer manufacturer);
        //delete manufacturer by id
        Task DeleteManufacturerAsync(int id);


    }
}

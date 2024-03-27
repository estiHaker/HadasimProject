using HMOproject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Members> MembersList { get; set; }
        public DbSet<Manufacturer> ManufacturerList { get; set; }
        public DbSet<Vaccination> VaccinationList { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=HMO_new4");
        }
    }
}

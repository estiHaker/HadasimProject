using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Entities
{
    public class Vaccination
    {
        public int Id { get; set; }
        public DateTime DateOfVaccination {get;set; }

        public Manufacturer? Manufacturer {get;set; }
        public int CodeMan { get;set; }

      //  public CoronaDetails CoronaDetails;
        public Members? Members {  get; set; } 
        public int CodeMem { get;set; }
    }
}

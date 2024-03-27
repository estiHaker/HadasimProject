using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Entities
{
    public class Members
    {
        [Key]
        public int CodeMem {  get; set; }
        public string Name { get; set; }
        public string LastName {  get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime Dob {  get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        //  public int CoronaId { get; set; }
        //  public CoronaDetails CoronaDetails { get; set; }
        public DateTime? Ill { get; set; }
        public DateTime? Recovery {  get; set; }
        public List<Vaccination>? Vaccination { get; set; }
        public int countVac { get; set; } = 0;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Core.Entities
{
    public class Manufacturer
    {
        [Key]
        public int CodeMan { get; set; }
        public string Name { get; set; }



    }
}
